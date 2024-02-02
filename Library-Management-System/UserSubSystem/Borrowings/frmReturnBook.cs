using Library_BusinessLayer;
using LibraryManagementSystem.Books.UserControls;
using LibraryManagementSystem.GlobalClasses;
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
    public partial class frmReturnBook : Form
    {
        public int? _BookCopyID = null;

        public frmReturnBook(int? bookCopyID)
        {
            InitializeComponent();
            _BookCopyID = bookCopyID;
            clsGlobal.CurrentUser = clsUser.Find(6);
        }

        public frmReturnBook()
        {
            InitializeComponent();
            clsGlobal.CurrentUser = clsUser.Find(6);

        }

        private void HandleBookCopyFound(object sender, int? bookCopyID)
        {
            if(!bookCopyID.HasValue)
            {
                MessageBox.Show("Please select a bookcopy to return !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucBookCopyCardWithFilter1.FilterFocus();
                btnReturn.Enabled = false;
                return;
            }

            else if(ucBookCopyCardWithFilter1.BookCopy.AvailabilityStatus.Value)
            {
                MessageBox.Show("This bookcopy is not borrowed , choose another one !", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucBookCopyCardWithFilter1.FilterFocus();
                btnReturn.Enabled = false;
                return;
            }

            lblBorrowingID.Text = ucBookCopyCardWithFilter1.BookCopy.BorrowingInfo.BorrowingRecordID.ToString();
            lblMemberLibCardNo.Text = ucBookCopyCardWithFilter1.BookCopy.BorrowingInfo.MemberInfo.LibraryCardNumber.ToString();
            lblBorrowingDueDate.Text = ucBookCopyCardWithFilter1.BookCopy.BorrowingInfo.DueDate.Value.ToShortDateString();
            lblReturnedByUser.Text = clsGlobal.CurrentUser.UserName;

            btnReturn.Enabled = true;
        }

        private void frmReturnBook_Load(object sender, EventArgs e)
        {           
            lblActualReturnDate.Text = DateTime.Now.ToShortDateString();    
            ucBookCopyCardWithFilter1.BookCopyFound += HandleBookCopyFound;

            if (_BookCopyID.HasValue)
                ucBookCopyCardWithFilter1.LoadBookCopyData(_BookCopyID);       
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to return this borrowed bookcopy ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            double? FineFees = 0;

            if(!ucBookCopyCardWithFilter1.BookCopy.ReturnBorrowedBookCopy(ref FineFees))
            {
                MessageBox.Show("Error : Failed to return this borrowed bookcopy ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Borrowed bookcopy returned successfully ", "Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            ucBookCopyCardWithFilter1.FilterEnabled = false;
            lblFineFees.Text = FineFees > 0 ? FineFees.ToString() : "No Fine";
            btnReturn.Enabled = false;
        }

    }
}
