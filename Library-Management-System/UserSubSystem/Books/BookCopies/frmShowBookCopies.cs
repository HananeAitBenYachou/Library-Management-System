using Library_BusinessLayer;
using LibraryManagementSystem.Books.BookCopies;
using LibraryManagementSystem.Members.UserControls;
using LibraryManagementSystem.Reservations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Books
{
    public partial class frmShowBookCopies : Form
    {
        private int? _BookID = null;

        public frmShowBookCopies(int? bookID)
        {
            InitializeComponent();
            _BookID = bookID;
        }

        private void frmShowBookCopies_Load(object sender, EventArgs e)
        {
            if (!clsBook.IsBookExist(_BookID))
            {
                MessageBox.Show($"No book with ID = {_BookID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ucBookCard1.LoadBookData(_BookID);
            dgvBookCopiesList.DataSource = clsBookCopy.GetAllBookCopies(_BookID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowBookCopyDetails frm = new frmShowBookCopyDetails((int)dgvBookCopiesList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void dgvBookCopiesList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach(DataGridViewColumn column in dgvBookCopiesList.Columns)
            {
                column.Width = 300;
            }
        }

        private void showCopyBorrowingsHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowBookCopyBorrowingsHistory frm = new frmShowBookCopyBorrowingsHistory((int)dgvBookCopiesList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void showCopyReservationsHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowBookCopyReservationsHistory frm = new frmShowBookCopyReservationsHistory((int)dgvBookCopiesList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
