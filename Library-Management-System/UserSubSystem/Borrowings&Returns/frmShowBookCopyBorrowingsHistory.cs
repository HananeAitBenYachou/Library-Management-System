using Library_BusinessLayer;
using LibraryManagementSystem.Books.UserControls;
using LibraryManagementSystem.Borrowings_Returns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Books.BookCopies
{
    public partial class frmShowBookCopyBorrowingsHistory : Form
    {
        private int? _BookCopyID = null;

        public frmShowBookCopyBorrowingsHistory(int? bookcopyID)
        {
            InitializeComponent();
            _BookCopyID = bookcopyID;
        }

        private void frmShowBookCopies_Load(object sender, EventArgs e)
        {
            if (!clsBookCopy.IsBookCopyExist(_BookCopyID))
            {
                MessageBox.Show($"No bookcopy with ID = {_BookCopyID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ucBookCopyCard1.LoadBookCopyData(_BookCopyID);
            dgvBorrowingsList.DataSource = clsBorrowingRecord.GetBookCopyBorrowingRecords(_BookCopyID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowBorrowingDetails frm = new frmShowBorrowingDetails((int)dgvBorrowingsList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
      
    }
}
