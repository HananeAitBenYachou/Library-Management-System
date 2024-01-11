using Guna.UI2.WinForms;
using Library_BusinessLayer;
using Library_Utility;
using LibraryManagementSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace LibraryManagementSystem.Authors
{
    public partial class frmAddUpdateAuthor : Form
    {
        public class AuthorAddedEventArgs
        {
            public int? AuthorID { get; }

            public string AuthorFullName { get; }

            public AuthorAddedEventArgs(int? authorID, string authorFullName)
            {
                this.AuthorID = authorID;
                this.AuthorFullName = authorFullName;
            }
        }

        private enum enMode { AddNew = 1, Update = 2 };
        
        private enMode _Mode = enMode.AddNew;

        private int? _AuthorID = null;

        private clsAuthor _Author = null;

        public event EventHandler<AuthorAddedEventArgs> AuthorAdded;

        protected virtual void OnAuthorAdded(int? authorID, string authorName)
        {
            AuthorAdded?.Invoke(this,new AuthorAddedEventArgs(authorID,authorName));
        }

        public frmAddUpdateAuthor()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdateAuthor(int? personID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _AuthorID = personID;
        }

        private void _ResetDefaultValues()
        {
            _FillCountriesInComboBox();

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Author";
                _Author = new clsAuthor();
            }

            else
            {
                lblTitle.Text = "Update Author";
            }

            lblAuthorID.Text = "[????]";
            txtFullName.ResetText();
            txtBiography.ResetText();               
        }

        private void _LoadAuthorData()
        {
            _Author = clsAuthor.Find(_AuthorID);

            if (_Author == null)
            {
                MessageBox.Show($"No author with ID = {_AuthorID} was found in the system !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            lblAuthorID.Text = _Author.AuthorID.ToString();
            txtFullName.Text = _Author.FullName;
            txtBiography.PlaceholderText = string.IsNullOrEmpty(_Author.Biography) ? "No biography available" : "";
            txtBiography.Text = _Author.Biography ?? "";
       
            cbCountries.SelectedIndex = cbCountries.FindString(_Author.CountryInfo.CountryName); 
        }

        private bool _SaveAuthorData()
        {
            _Author.FullName = txtFullName.Text.Trim();
            _Author.NationalityCountryID = clsCountry.Find(cbCountries.Text).CountryID;
            _Author.Biography = string.IsNullOrEmpty(txtBiography.Text.Trim()) ? null : txtBiography.Text.Trim();

            if (_Author.Save())
            {
                MessageBox.Show("Author data saved successfully !", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _Mode = enMode.Update;
                lblAuthorID.Text = _Author.AuthorID.ToString();
                lblTitle.Text = "Update Author";

                return true;
            }

            else
            {
                MessageBox.Show("Author data is not saved successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void frmAddEditAuthor_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadAuthorData();
        }

        private void _FillCountriesInComboBox()
        {
            foreach (DataRow row in clsCountry.GetAllCountries().Rows)
            {
                cbCountries.Items.Add(row["CountryName"]);
            }

            cbCountries.SelectedIndex = cbCountries.FindString("Morocco");
        }

        private void txtFullName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError((Guna2TextBox)sender, "This field is required , cannot be left blank !");
            }

            else if (clsAuthor.IsAuthorExist(txtFullName.Text.Trim()) && txtFullName.Text.Trim() != _Author.FullName)
            {
                e.Cancel = true;
                errorProvider1.SetError((Guna2TextBox)sender, "This author already exists !");
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

            if (_SaveAuthorData())
                OnAuthorAdded(_Author.AuthorID,_Author.FullName);
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
