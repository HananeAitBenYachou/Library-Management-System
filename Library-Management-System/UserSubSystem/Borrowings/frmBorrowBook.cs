using Guna.UI2.WinForms;
using Library_BusinessLayer;
using LibraryManagementSystem.GlobalClasses;
using LibraryManagementSystem.People.UserControls;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LibraryManagementSystem.Borrowings_Returns
{
    public partial class frmBorrowBook : Form
    {
        private int? _MemberID = null;

        private int? _BookCopyID = null;

        private clsBorrowingRecord _Borrowing = null;

        public frmBorrowBook()
        {
            InitializeComponent();
        }

        public frmBorrowBook(int? MemberID)
        {
            InitializeComponent();
            _MemberID = MemberID;
            ucMemberCardWithFilter1.LoadMemberData(MemberID);
        }

        private void _ResetDefaultValues()
        {
           ucMemberCardWithFilter1.MemberFound += HandleMemberFound;

            ucBookCardWithFilter1.BookFound += HandleBookFound;

            dtpBorrowingDate.MinDate = DateTime.Now;
            dtpBorrowingDate.MaxDate = DateTime.Now.AddDays(1);

            lblBorrowingID.Text = "[????]";
            dtpBorrowingDate.Value = DateTime.Now;
            dtpDueDate.Value = DateTime.Now.AddDays(clsSettings.DefaultBorrowDays.Value);

            _Borrowing = new clsBorrowingRecord();
            ucBookCardWithFilter1.FilterFocus();

            btnToSecondPage.Enabled = false;
            btnToLastPage.Enabled = (_MemberID.HasValue);

            tpMemberInfo.Enabled = (_MemberID.HasValue);

            btnSave.Enabled = btnToSecondPage.Enabled && btnToLastPage.Enabled;
        }

        private void _SaveBorrowingData()
        {
            _Borrowing.BookCopyID = _BookCopyID;
            _Borrowing.MemberID = ucMemberCardWithFilter1.MemberID;
            _Borrowing.BorrowingDate = dtpBorrowingDate.Value;
            _Borrowing.DueDate = dtpDueDate.Value;
           
            if (_Borrowing.Save())
            {
                MessageBox.Show("Borrowing data saved successfully !", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblBorrowingID.Text = _Borrowing.BorrowingRecordID.ToString();

                ucMemberCardWithFilter1.FilterEnabled = false;
                ucBookCardWithFilter1.FilterEnabled = false;
            }

            else
            {
                MessageBox.Show("Borrowing data is not saved successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void frmBorrowBook_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
        }

        private void HandleMemberFound(object sender, int? memberID)
        {
            if (memberID.HasValue)
            {
                btnToLastPage.Enabled = true;
                _MemberID = memberID;
            }
        }

        private void HandleBookFound(object sender, int? bookID)
        {
            if (bookID.HasValue)
            {
                btnToSecondPage.Enabled = true;              
                _BookCopyID = ucBookCardWithFilter1.Book.GetAvailableBookCopy();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _SaveBorrowingData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnToSecondPage_Click(object sender, EventArgs e)
        {
            if (!ucBookCardWithFilter1.BookID.HasValue)
            {
                MessageBox.Show("Please select a book first !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucBookCardWithFilter1.FilterFocus();
                return;
            }

            if (!_BookCopyID.HasValue)
            {
                MessageBox.Show("Sorry, there are no copies of the selected book available for borrowing !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucBookCardWithFilter1.FilterFocus();
                return;
            }

            else
            {
                tpMemberInfo.Enabled = true;
                tcBorrowingInfo.SelectedTab = tpMemberInfo;
                if(!_MemberID.HasValue)
                    ucMemberCardWithFilter1.FilterFocus();
            }

        }

        private void btnToLastPage_Click(object sender, EventArgs e)
        {
            if (!_MemberID.HasValue)
            {
                MessageBox.Show("Please select a member to lend the book to first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucMemberCardWithFilter1.FilterFocus();
                return;
            }

            else
            {
                btnSave.Enabled = true;
                tpBorrowingInfo.Enabled = true;
                tcBorrowingInfo.SelectedTab = tpBorrowingInfo;
            }
        }

    }
}
