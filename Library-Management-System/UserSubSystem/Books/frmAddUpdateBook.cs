using Guna.UI2.WinForms;
using Library_BusinessLayer;
using Library_Utility;
using LibraryManagementSystem.Authors;
using LibraryManagementSystem.Genres;
using LibraryManagementSystem.GlobalClasses;
using LibraryManagementSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace LibraryManagementSystem.Books
{
    public partial class frmAddUpdateBook : Form
    {
        private enum enMode { AddNew = 1, Update = 2 };

        private enMode _Mode = enMode.AddNew;

        private int? _BookID = null;

        private clsBook _Book = null;

        public event EventHandler<int?> BookAdded;

        protected virtual void OnBookAdded(int? bookID)
        {
            BookAdded?.Invoke(this, bookID);
        }

        public frmAddUpdateBook()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdateBook(int? bookID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _BookID = bookID;
        }

        private void _FillGenresInComboBox()
        {
            foreach (DataRow row in clsGenre.GetAllGenres().Rows)
            {
                cbGenres.Items.Add((string)row["Genre Name"]);        
            }

        }

        private void _FillAuthorsInComboBox()
        {
            foreach (DataRow row in clsAuthor.GetAllAuthors().Rows)
            {
                cbAuthors.Items.Add((string)row["Name"]);
            }
        }

        private void _ResetDefaultValues()
        {
            _FillGenresInComboBox();
            _FillAuthorsInComboBox();

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Book";
                _Book = new clsBook();
            }

            else
            {
                lblTitle.Text = "Update Book";
            }

            lblBookID.Text = "[????]";
            txtTitle.ResetText();
            txtISBN.ResetText();
            txtAdditionalDetails.ResetText();
            dtpPublicationDate.Value = DateTime.Now;

            cbAuthors.SelectedIndex = 0;
            cbGenres.SelectedIndex = 0;

        }

        private void _LoadBookData()
        {
            _Book = clsBook.Find(_BookID);

            if (_Book == null)
            {
                MessageBox.Show($"No book with ID = {_BookID} was found in the system !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            lblBookID.Text = _Book.BookID.ToString();
            pbBookImage.ImageLocation = _Book.BookImagePath ?? null;
            txtTitle.Text = _Book.Title;
            txtISBN.Text = _Book.ISBN;
            txtAdditionalDetails.PlaceholderText = string.IsNullOrEmpty(_Book.AdditionalDetails) ? "No Additional Details" : "";
            txtAdditionalDetails.Text = _Book.AdditionalDetails ?? "";
            dtpPublicationDate.Value = _Book.PublicationDate.Value;

            cbAuthors.SelectedIndex = cbAuthors.FindString(_Book.AuthorInfo.FullName);
            cbGenres.SelectedIndex = cbGenres.FindString(_Book.GenreInfo.GenreName);

            llbRemoveImage.Visible = pbBookImage.Image != null;
        }

        private bool _SaveBookData()
        {
            if (!_IsBookImageHandledSuccessfully())
                return false;

            _Book.Title = txtTitle.Text.Trim();
            _Book.ISBN = txtISBN.Text.Trim();
            _Book.AdditionalDetails = txtAdditionalDetails.Text.Trim();
            _Book.GenreID = clsGenre.Find(cbGenres.Text).GenreID;
            _Book.AuthorID = clsAuthor.Find(cbAuthors.Text).AuthorID;
            _Book.BookImagePath = pbBookImage.ImageLocation ?? null;
            if(dtpPublicationDate.Value == DateTime.Now)
            {
                _Book.PublicationDate = null;
            }
            else
            {
                _Book.PublicationDate = dtpPublicationDate.Value;
            }

            if (_Book.Save())
            {
                MessageBox.Show("Book data saved successfully !", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _Mode = enMode.Update;
                lblBookID.Text = _Book.BookID.ToString();
                lblTitle.Text = "Update Book";

                return true;
            }

            else
            {
                MessageBox.Show("Book data is not saved successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool _IsBookImageHandledSuccessfully()
        {
            if (pbBookImage.ImageLocation != _Book.BookImagePath)
            {
                if (_Book.BookImagePath != null)
                {
                    try
                    {
                        File.Delete(_Book.BookImagePath);

                    }
                    catch (Exception ex)
                    {
                        clsErrorLogger.LogError(ex);
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }

                if (pbBookImage.ImageLocation != null)
                {
                    string sourceFile = pbBookImage.ImageLocation;
                    string destinationFolder = @"C:\Library-Books-Images";

                    try
                    {
                        clsUtility.CopyImageToProjectImagesFolder(destinationFolder, ref sourceFile);
                        pbBookImage.ImageLocation = sourceFile;
                    }

                    catch (Exception ex)
                    {
                        clsErrorLogger.LogError(ex);
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }

            return true;
        }

        private void frmAddEditBook_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                 _LoadBookData();

        }

        private void llbUploadImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbBookImage.ImageLocation = openFileDialog1.FileName;
                llbRemoveImage.Visible = true;
            }
        }

        private void llbRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbBookImage.ImageLocation = null;

            pbBookImage.Image = Resources.book__2_;
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError((Guna2TextBox)sender, "This field is required , cannot be left blank !");
            }

            else if (clsBook.IsBookExistByTitle(txtTitle.Text) && txtTitle.Text != _Book.Title)
            {
                e.Cancel = true;
                errorProvider1.SetError((Guna2TextBox)sender, "This Title already exists !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError((Guna2TextBox)sender, null);
            }
        }

        private void txtISBN_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtISBN.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError((Guna2TextBox)sender, "This field is required , cannot be left blank !");
            }

            else if (clsBook.IsBookExistByISBN(txtISBN.Text) && txtISBN.Text != _Book.ISBN)
            {
                e.Cancel = true;
                errorProvider1.SetError((Guna2TextBox)sender, "This ISBN already exists !");
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
            if (_SaveBookData())
                OnBookAdded(_Book.BookID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitle_TextChanged(object sender, EventArgs e)
        {
            this.Text = lblTitle.Text;
        }

        private void btnAddNewGenre_Click(object sender, EventArgs e)
        {
            frmAddUpdateGenre frm = new frmAddUpdateGenre();
            frm.GenreAdded += HandleNewGenreAdded;
            frm.ShowDialog();
        }

        private void btnAddNewAuthor_Click(object sender, EventArgs e)
        {
            frmAddUpdateAuthor frm = new frmAddUpdateAuthor();
            frm.AuthorAdded += HandleNewAuthorAdded;
            frm.ShowDialog();
        }

        private void HandleNewGenreAdded(object sender, frmAddUpdateGenre.GenreAddedEventArgs e)
        {
            if(e.GenreID.HasValue)
            {
                cbGenres.Items.Add(e.GenreName);
                cbGenres.Text = e.GenreName;
            }
        }

        private void HandleNewAuthorAdded(object sender, frmAddUpdateAuthor.AuthorAddedEventArgs e)
        {
            if (e.AuthorID.HasValue)
            {
                cbAuthors.Items.Add(e.AuthorFullName);
                cbAuthors.Text = e.AuthorFullName;
            }
        }

    }
}
