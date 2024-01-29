using Library_BusinessLayer;
using LibraryManagementSystem.Genres;
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
    public partial class frmListBorrowings : Form
    {
        private DataView _BorrowingsDataView;

        public frmListBorrowings()
        {
            InitializeComponent();
        }

        private void _RefreshBorrowingsist()
        {
            _BorrowingsDataView = clsBorrowingRecord.GetAllBorrowingRecords().DefaultView;
            dgvBorrowingsList.DataSource = _BorrowingsDataView;
            cbFilterByOptions.SelectedIndex = 0;
        }

        private void _FilterBorrowingsList()
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                _BorrowingsDataView.RowFilter = null;
                return;
            }

            if (cbFilterByOptions.Text == "Borrowed Copy ID" || cbFilterByOptions.Text == "Borrowing ID")
            {
                _BorrowingsDataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, txtFilterValue.Text.Trim());
            }

            else
            {
                _BorrowingsDataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text.Trim());
            }
        }

        private void frmListBorrowings_Load(object sender, EventArgs e)
        {
            _RefreshBorrowingsist();
        }

        private void dgvBorrowingsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvBorrowingsList.Columns)
            {
                column.Width = 150;
            }
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterByOptions.Text == "Book Copy Status")
            {
                txtFilterValue.Visible = false;
                cbBorrowedCopyStatus.Visible = true;
                cbBorrowedCopyStatus.SelectedIndex = 0;
            }

            else
            {
                txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
                txtFilterValue.ResetText();
                txtFilterValue.Focus();
                cbBorrowedCopyStatus.Visible = false;
                txtFilterValue_TextChanged(null, null);
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterBorrowingsList();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text == "Borrowed Copy ID" || cbFilterByOptions.Text == "Borrowing ID")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btnAddBorrowing_Click(object sender, EventArgs e)
        {
            frmBorrowBook frm = new frmBorrowBook();
            frm.ShowDialog();
            _RefreshBorrowingsist();
        }

        private void AddBorrowingtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddBorrowing.PerformClick();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowBorrowingDetails frm = new frmShowBorrowingDetails((int)dgvBorrowingsList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this borrowing record ?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int borrowingID = (int)dgvBorrowingsList.CurrentRow.Cells[0].Value;

            if (!clsBorrowingRecord.IsBorrowingRecordExist(borrowingID))
            {
                MessageBox.Show($"No borrowing with ID = {borrowingID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsBorrowingRecord.DeleteBorrowingRecord(borrowingID))
            {
                MessageBox.Show("Borrowing record has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshBorrowingsist();
            }

            else
                MessageBox.Show("Borrowing record is not deleted due to data connected to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReturnBook frm = new frmReturnBook((int)dgvBorrowingsList.CurrentRow.Cells["Borrowed Copy ID"].Value);
            frm.ShowDialog();
            _RefreshBorrowingsist();
        }

        private void cbBorrowedCopyStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _BorrowingsDataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, cbBorrowedCopyStatus.Text);
        }

        private void cmsBorrowings_Opening(object sender, CancelEventArgs e)
        {
            clsBookCopy bookCopy = clsBookCopy.Find((int)dgvBorrowingsList.CurrentRow.Cells["Borrowed Copy ID"].Value);
            returnBookToolStripMenuItem.Enabled = !bookCopy.AvailabilityStatus.Value;
        }
    }
}
