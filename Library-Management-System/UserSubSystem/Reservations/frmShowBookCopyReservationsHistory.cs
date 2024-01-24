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
    public partial class frmShowBookCopyReservationsHistory : Form
    {
        private int? _BookCopyID = null;

        public frmShowBookCopyReservationsHistory(int? bookcopyID)
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
            dgvReservationsList.DataSource = clsReservation.GetBookCopyReservations(_BookCopyID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowReservationDetails frm = new frmShowReservationDetails((int)dgvReservationsList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

    }
}
