using Library_BusinessLayer;
using LibraryManagementSystem.People;
using LibraryManagementSystem.People.UserControls;
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

namespace LibraryManagementSystem.Books.UserControls
{
    public partial class ucBookCard : UserControl
    {
        private int? _BookID = null;

        private clsBook _Book = null;

        public int? BookID => _BookID;

        public clsBook Book => _Book;

        public ucBookCard()
        {
            InitializeComponent();
        }

        public void ResetBookData()
        {
            _BookID = null;

            lblBookID.Text = "[????]";
            lblTitle.Text = "[????]";
            lblIsbn.Text = "[????]";
            lblGenre.Text = "[????]";
            lblAuthor.Text = "[????]";
            lblDetails.Text = "[????]";
            lblPublicationDate.Text = "[????]";
            lblCreatedByUser.Text = "[????]";

            pbBookImage.Image = Resources.book1;
        }

        private void _LoadBookData()
        {
            llbEditBookInfo.Enabled = true;

            _BookID = _Book.BookID;

            lblBookID.Text = _BookID.ToString();
            lblTitle.Text = _Book.Title;
            lblIsbn.Text = _Book.ISBN;
            lblGenre.Text = _Book.GenreInfo.GenreName;
            lblAuthor.Text = _Book.AuthorInfo.FullName;
            lblDetails.Text = _Book.AdditionalDetails ?? "No Additional Details";
            lblPublicationDate.Text = _Book.PublicationDate.Value.ToShortDateString();
            lblCreatedByUser.Text = _Book.UserInfo.UserName;

            pbBookImage.ImageLocation = _Book.BookImagePath ?? null;
        }

        public void LoadBookData(int? bookID)
        {
            _Book = clsBook.Find(bookID);

            if (_Book == null)
            {
                MessageBox.Show($"No book with ID = {bookID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetBookData();
                return;
            }

            _LoadBookData();

        }

        public void LoadBookData(string ISBN)
        {
            _Book = clsBook.Find(ISBN);

            if (_Book == null)
            {
                MessageBox.Show($"No book with ID = {ISBN} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetBookData();
                return;
            }

            _LoadBookData();
        }

        private void llbEditBookInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdateBook form = new frmAddUpdateBook(_BookID);
            form.ShowDialog();
            LoadBookData(_BookID);

        }
    }
}
