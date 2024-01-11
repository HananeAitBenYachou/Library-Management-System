using Guna.UI2.WinForms;
using Library_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Genres
{
    public partial class frmAddUpdateGenre : Form
    {
        public class GenreAddedEventArgs
        {
            public int? GenreID { get; }

            public string GenreName { get; }

            public GenreAddedEventArgs(int? genreID, string genreName)
            {
                this.GenreID = genreID;
                this.GenreName = genreName;
            }
        }

        private enum enMode { AddNew = 1, Update = 2 };

        private enMode _Mode = enMode.AddNew;

        private int? _GenreID = null;

        private clsGenre _Genre = null;

        public event EventHandler<GenreAddedEventArgs> GenreAdded;

        protected virtual void OnGenreAdded(int? genreID, string genreName)
        {
            GenreAdded?.Invoke(this, new GenreAddedEventArgs(genreID,genreName));
        }

        public frmAddUpdateGenre()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdateGenre(int? genreID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _GenreID = genreID;
        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Genre";
                _Genre = new clsGenre();
            }

            else
            {
                lblTitle.Text = "Update Genre";
            }

            lblGenreID.Text = "[????]";
            txtGenreName.ResetText();
            txtDescription.ResetText();
        }

        private void _LoadGenreData()
        {
            _Genre = clsGenre.Find(_GenreID);

            if (_Genre == null)
            {
                MessageBox.Show($"No genre with ID = {_GenreID} was found in the system !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            lblGenreID.Text = _Genre.GenreID.ToString();
            txtGenreName.Text = _Genre.GenreName;
            txtDescription.PlaceholderText = string.IsNullOrEmpty(_Genre.Description) ? "No description available" : "";
            txtDescription.Text = _Genre.Description ?? "";
        }

        private bool _SaveGenreData()
        {
            _Genre.GenreName = txtGenreName.Text.Trim();
            _Genre.Description = string.IsNullOrEmpty(txtDescription.Text.Trim()) ? null : txtDescription.Text.Trim();

            if (_Genre.Save())
            {
                MessageBox.Show("Genre data saved successfully !", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _Mode = enMode.Update;
                lblGenreID.Text = _Genre.GenreID.ToString();
                lblTitle.Text = "Update Genre";

                return true;
            }

            else
            {
                MessageBox.Show("Genre data is not saved successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void frmAddEditGenre_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadGenreData();

        }

        private void txtGenreName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtGenreName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError((Guna2TextBox)sender, "This field is required , cannot be left blank !");
            }

            else if (clsGenre.IsGenreExist(txtGenreName.Text.Trim()) && txtGenreName.Text.Trim() != _Genre.GenreName)
            {
                e.Cancel = true;
                errorProvider1.SetError((Guna2TextBox)sender, "This genre already exists !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError((Guna2TextBox)sender, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_SaveGenreData())
                OnGenreAdded(_Genre.GenreID,_Genre.GenreName);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitle_TextChanged(object sender, EventArgs e)
        {
            this.Text = lblTitle.Text;
        }

    }
}
