using Library_BusinessLayer;
using LibraryManagementSystem.Books.UserControls;
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
    public partial class frmShowBorrowingDetails : Form
    {
        private int? _BorrowingID = null;

        public frmShowBorrowingDetails(int? borrowingID)
        {
            InitializeComponent();
            _BorrowingID = borrowingID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowBorrowingDetails_Load(object sender, EventArgs e)
        {
            if (!clsBorrowingRecord.IsBorrowingRecordExist(_BorrowingID))
            {
                MessageBox.Show($"No borrowing with ID = {_BorrowingID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ucBorrowingDetails1.LoadBorrowingDetails(_BorrowingID);
        }
    }
}
