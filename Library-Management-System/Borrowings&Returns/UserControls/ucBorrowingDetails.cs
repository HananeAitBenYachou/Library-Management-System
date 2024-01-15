using Library_BusinessLayer;
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

        public int? BorrowingRecordID => _BorrowingRecordID;

        public clsBorrowingRecord Borrowing => _Borrowing;

        public ucBorrowingDetails()
        {
            InitializeComponent();
        }

        public void ResetBorrowingData()
        {
            _BorrowingRecordID = null;

            lblBorrowingID.Text = "[????]";
            lblMemberLibCardNo.Text = "[????]";
            lblTitle.Text = "[????]";
            lblBookCopyID.Text = "[????]";
            lblIsBookReturned.Text = "[????]";
            lblBorrowingDate.Text = "[????]";
            lblReturnDate.Text = "[????]";
            lblDueDate.Text = "[????]";
            lblCreatedByUser.Text = "[????]";
            lblUpdatedByUser.Text = "[????]";
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

            clsBookCopy borrowedCopy = clsBookCopy.Find(_Borrowing.BookCopyID);

            lblBorrowingID.Text = _Borrowing.BorrowingRecordID.ToString();
            lblMemberLibCardNo.Text = _Borrowing.MemberInfo.LibraryCardNumber;
            lblTitle.Text = borrowedCopy.BookInfo.Title;
            lblBookCopyID.Text = borrowedCopy.BookCopyID.ToString();
            lblIsBookReturned.Text = borrowedCopy.AvailabilityStatus.Value ? "YES" : "NO";
            lblBorrowingDate.Text = _Borrowing.BorrowingDate.Value.ToShortDateString();
            lblReturnDate.Text = _Borrowing.BorrowingDate.Value.ToShortDateString() ?? "Not returned yet !";
            lblDueDate.Text = _Borrowing.DueDate.Value.ToShortDateString();
            lblCreatedByUser.Text = _Borrowing.CreatedByUserInfo.UserName;
            lblUpdatedByUser.Text = _Borrowing.UpdatedByUserInfo.UserName;
        }

    }
}
