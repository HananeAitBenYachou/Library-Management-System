using Library_BusinessLayer;
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

namespace LibraryManagementSystem.Reservations
{
    public partial class frmListReservations : Form
    {
        private DataView _ReservationsDataView;

        public frmListReservations()
        {
            InitializeComponent();
        }

        private void _RefreshReservationsList()
        {
            _ReservationsDataView = clsReservation.GetAllReservations().DefaultView;
            dgvReservationsList.DataSource = _ReservationsDataView;
            cbFilterByOptions.SelectedIndex = 0;
        }

        private void _FilterReservationsList()
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                _ReservationsDataView.RowFilter = null;
                return;
            }

            if (cbFilterByOptions.Text == "Copy ID" || cbFilterByOptions.Text == "Reservation ID")
            {
                _ReservationsDataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, txtFilterValue.Text.Trim());
            }

            else
            {
                _ReservationsDataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text.Trim());
            }
        }

        private void frmListReservations_Load(object sender, EventArgs e)
        {
            _RefreshReservationsList();
        }

        private void dgvReservationsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvReservationsList.Columns)
            {
                column.Width = 200;
            }
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
            txtFilterValue.ResetText();
            txtFilterValue.Focus();
            txtFilterValue_TextChanged(null, null);
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterReservationsList();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text == "Copy ID" || cbFilterByOptions.Text == "Reservation ID")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            frmAddUpdateReservation frm = new frmAddUpdateReservation();
            frm.ShowDialog();
            _RefreshReservationsList();
        }

        private void AddReservationtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddReservation.PerformClick();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowReservationDetails frm = new frmShowReservationDetails((int)dgvReservationsList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this reservation record ?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int reservationID = (int)dgvReservationsList.CurrentRow.Cells[0].Value;

            if (!clsReservation.IsReservationExist(reservationID))
            {
                MessageBox.Show($"No reservation with ID = {reservationID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsReservation.DeleteReservation(reservationID))
            {
                MessageBox.Show("Reservation record has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshReservationsList();
            }

            else
                MessageBox.Show("Reservation record is not deleted due to data connected to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateReservation frm = new frmAddUpdateReservation((int)dgvReservationsList.CurrentRow.Cells[0].Value,null);
            frm.ShowDialog();
            _RefreshReservationsList();
        }
    }
}
