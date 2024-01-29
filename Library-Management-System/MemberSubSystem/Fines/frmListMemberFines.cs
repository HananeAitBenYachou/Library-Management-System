using Library_BusinessLayer;
using LibraryManagementSystem.Fines;
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

namespace LibraryManagementSystem.MemberSubSystem.Fines
{
    public partial class frmListMemberFines : Form
    {
        private DataView _FinesDataView;

        public frmListMemberFines()
        {
            InitializeComponent();
        }

        private void _RefreshFinesList()
        {
            _FinesDataView = clsFine.GetMemberFines(clsGlobal.CurrentMember.MemberID).DefaultView;
            dgvFinesList.DataSource = _FinesDataView;
            cbFilterByOptions.SelectedIndex = 0;
        }

        private void _FilterFinesList()
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                _FinesDataView.RowFilter = null;
                return;
            }

            _FinesDataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, txtFilterValue.Text.Trim());
        }

        private void frmListFines_Load(object sender, EventArgs e)
        {
            _RefreshFinesList();
        }

        private void dgvFinesList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvFinesList.Columns)
            {
                column.Width = 200;
            }
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterByOptions.Text == "Payment Status")
            {
                txtFilterValue.Visible = false;
                cbPaymentStatus.Visible = true;
                cbPaymentStatus.SelectedIndex = 0;
            }

            else
            {
                txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
                txtFilterValue.ResetText();
                txtFilterValue.Focus();
                cbPaymentStatus.Visible = false;
                txtFilterValue_TextChanged(null, null);
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterFinesList();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowFineDetails frm = new frmShowFineDetails((int)dgvFinesList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void payFineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to pay this fine record ?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int fineID = (int)dgvFinesList.CurrentRow.Cells[0].Value;

            if (!clsFine.IsFineExist(fineID))
            {
                MessageBox.Show($"No fine with ID = {fineID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsFine.Find(fineID).Pay())
            {
                MessageBox.Show("Fine record has been paid successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshFinesList();
            }

            else
                MessageBox.Show("Fine record is not paid due to data connected to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbPaymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FinesDataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, cbPaymentStatus.Text);
        }

    }
}
