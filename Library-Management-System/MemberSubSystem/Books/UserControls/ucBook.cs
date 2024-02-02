using Library_BusinessLayer;
using LibraryManagementSystem.Books;
using LibraryManagementSystem.Books.UserControls;
using LibraryManagementSystem.GlobalClasses;
using LibraryManagementSystem.Members.UserControls;
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

namespace LibraryManagementSystem.MemberSubSystem.Books.UserControls
{
    public partial class ucBook : UserControl
    {
        private clsBook _Book = null;

        private int? _BookID = null;

        public clsBook Book
        {
            get
            {
                return _Book;
            }
        }

        public int? BookID
        {
            get
            {
                return _BookID;
            }
        }

        public ucBook()
        {
            InitializeComponent();
        }

        private void _ResetDefaultValues()
        {
            lblBookTitle.Text = "[????]";
            lblAuthorName.Text = "[????]";
            pbBookImage.Image = Resources.book1;

            btnBorrowBook.Enabled = false;
            btnViewBookDetails.Enabled = false;          
        }

        private void _SetUserControlAppearance()
        {
            btnBorrowBook.Visible = clsGlobal.LoginMode == clsGlobal.enLoginMode.Member;
            btnViewBookDetails.Enabled = clsGlobal.LoginMode == clsGlobal.enLoginMode.Member;
            this.Size = clsGlobal.LoginMode == clsGlobal.enLoginMode.Member
                ? new Size(316, 328) : new Size(316, 259);
        }

        public void LoadBookDetails(int? bookID)
        {
            _SetUserControlAppearance(); 

            _Book = clsBook.Find(bookID);

            if (_Book == null)
            {
                MessageBox.Show($"No book with ID = {bookID} was found in the system !", "Not Found !", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetDefaultValues();
                return;
            }

            _BookID = bookID;

            btnBorrowBook.Enabled = true;
            btnViewBookDetails.Enabled = true;

            lblBookTitle.Text = _Book.Title;
            lblAuthorName.Text = _Book.AuthorInfo.FullName;

            pbBookImage.ImageLocation = _Book.BookImagePath ?? null;
        }

        private void _BorrowBook()
        {
            clsBorrowingRecord Borrowing = new clsBorrowingRecord();

            Borrowing.BookCopyID = _Book.GetAvailableBookCopy();
            Borrowing.MemberID = clsGlobal.CurrentMember.MemberID;
            Borrowing.BorrowingDate = DateTime.Now;
            Borrowing.DueDate = DateTime.Now.AddDays(clsSettings.DefaultBorrowDays.Value);

            if (Borrowing.Save())
            {
                MessageBox.Show($"You have successfully borrowed book with ID {_BookID}!", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Sorry , an error occured during this operation !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnViewBookDetails_Click(object sender, EventArgs e)
        {
            frmShowBookDetails frm = new frmShowBookDetails(_BookID);
            frm.ShowDialog();
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            if(_Book.IsMemberHasActiveBorrowingForBook(clsGlobal.CurrentMember.MemberID))
            {
                MessageBox.Show("Sorry, you cannot borrow this book. You have already borrowed a copy of this book that has not been returned yet.", 
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _BorrowBook();
        }

    }
}
