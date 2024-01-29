using Library_BusinessLayer;
using LibraryManagementSystem.Borrowings_Returns;
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

namespace LibraryManagementSystem.MemberSubSystem
{
    public partial class frmListMemberBorrowings : Form
    {
        private DataView _BorrowingsDataView;

        public frmListMemberBorrowings()
        {
            InitializeComponent();
        }

        private void _RefreshBorrowingsList()
        {
            _BorrowingsDataView = clsBorrowingRecord.GetMemberBorrowingRecords(clsGlobal.CurrentMember.MemberID).DefaultView;
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

        private void frmListMemberBorrowings_Load(object sender, EventArgs e)
        {
            _RefreshBorrowingsList();
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
            frmBorrowBook frm = new frmBorrowBook(clsGlobal.CurrentMember.MemberID);
            frm.ShowDialog();
            _RefreshBorrowingsList();
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

        private void cbBorrowedCopyStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _BorrowingsDataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, cbBorrowedCopyStatus.Text);
        }

    }
}
