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
    public partial class frmShowReservationDetails : Form
    {
        private int? _ReservationID = null;

        public frmShowReservationDetails(int? reservationID)
        {
            InitializeComponent();
            _ReservationID = reservationID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowReservationDetails_Load(object sender, EventArgs e)
        {
            if (!clsReservation.IsReservationExist(_ReservationID))
            {
                MessageBox.Show($"No reservation with ID = {_ReservationID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ucReservationDetails1.LoadReservationDetails(_ReservationID);
        }
    }
}
