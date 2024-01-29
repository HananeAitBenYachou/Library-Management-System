using Library_BusinessLayer;
using LibraryManagementSystem.Books.BookCopies;
using LibraryManagementSystem.Members;
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

namespace LibraryManagementSystem.Borrowings_Returns
{
    public partial class ucBorrowingDetails : UserControl
    {
        private int? _BorrowingRecordID = null;

        private clsBorrowingRecord _Borrowing = null;

        public clsBookCopy _BorrowedCopy = null;

        public int? BorrowingRecordID => _BorrowingRecordID;

        public clsBorrowingRecord Borrowing => _Borrowing;

        public ucBorrowingDetails()
        {
            InitializeComponent();
        }

        public void ResetBorrowingData()
        {
            _BorrowingRecordID = null;

            llbShowBookCopyInfo.Visible = true;
            llbShowMemberInfo.Visible = true;

            lblBorrowingID.Text = "[????]";
            lblMemberLibCardNo.Text = "[????]";
            lblTitle.Text = "[????]";
            lblBookCopyID.Text = "[????]";
            lblIsBookReturned.Text = "[????]";
            lblBorrowingDate.Text = "[????]";
            lblReturnDate.Text = "[????]";
            lblDueDate.Text = "[????]";

        }

        public void LoadBorrowingDetails(int? borrowingID)
        {
            _Borrowing = clsBorrowingRecord.Find(borrowingID);

            if (_Borrowing == null)
            {
                MessageBox.Show($"No borrowing with ID = {borrowingID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetBorrowingData();
                return;
            }

            _BorrowingRecordID = _Borrowing.BorrowingRecordID;

            llbShowBookCopyInfo.Visible = true;
            llbShowMemberInfo.Visible = true;

            _BorrowedCopy = clsBookCopy.Find(_Borrowing.BookCopyID);

            lblBorrowingID.Text = _Borrowing.BorrowingRecordID.ToString();
            lblMemberLibCardNo.Text = _Borrowing.MemberInfo.LibraryCardNumber;
            lblTitle.Text = _BorrowedCopy.BookInfo.Title;
            lblBookCopyID.Text = _BorrowedCopy.BookCopyID.ToString();
            lblIsBookReturned.Text = _BorrowedCopy.AvailabilityStatus.Value ? "YES" : "NO";
            lblBorrowingDate.Text = _Borrowing.BorrowingDate.Value.ToShortDateString();
            lblReturnDate.Text = _Borrowing.BorrowingDate.Value.ToShortDateString() ?? "Not returned yet !";
            lblDueDate.Text = _Borrowing.DueDate.Value.ToShortDateString();
        }

        private void llbShowBookCopyInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowBookCopyDetails frm = new frmShowBookCopyDetails(_BorrowedCopy.BookCopyID);
            frm.ShowDialog();
        }

        private void llbShowMemberInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowMemberDetails frm = new frmShowMemberDetails(_Borrowing.MemberID);
            frm.ShowDialog();
        }
    
    }
}
