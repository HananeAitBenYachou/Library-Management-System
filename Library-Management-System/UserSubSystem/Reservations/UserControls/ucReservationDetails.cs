using Library_BusinessLayer;
using LibraryManagementSystem.Books.BookCopies;
using LibraryManagementSystem.Members;
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
    public partial class ucReservationDetails : UserControl
    {
        private int? _ReservationID = null;

        private clsReservation _Reservation = null;

        public int? ReservationID => _ReservationID;

        public clsReservation Reservation => _Reservation;

        public ucReservationDetails()
        {
            InitializeComponent();
        }

        public void ResetReservationData()
        {
            _Reservation = null;

            llbShowBookCopyInfo.Visible = true;
            llbShowMemberInfo.Visible = true;

            lblReservationID.Text = "[????]";
            lblMemberLibCardNo.Text = "[????]";
            lblTitle.Text = "[????]";
            lblBookCopyID.Text = "[????]";
            lblReservationDate.Text = "[????]";
            lblCreatedByUser.Text = "[????]";
        }

        public void LoadReservationDetails(int? reservationID)
        {
            _Reservation = clsReservation.Find(reservationID);

            if (_Reservation == null)
            {
                MessageBox.Show($"No reservation with ID = {reservationID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetReservationData();
                return;
            }

            _ReservationID = _Reservation.ReservationID;

            llbShowBookCopyInfo.Visible = true;
            llbShowMemberInfo.Visible = true;

            lblReservationID.Text = _Reservation.ReservationID.ToString();
            lblMemberLibCardNo.Text = _Reservation.MemberInfo.LibraryCardNumber;
            lblTitle.Text = _Reservation.BookCopyInfo.BookInfo.Title;
            lblBookCopyID.Text = _Reservation.BookCopyID.ToString();
            lblReservationDate.Text = _Reservation.ReservationDate.Value.ToShortDateString();
        }

        private void llbShowBookCopyInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowBookCopyDetails frm = new frmShowBookCopyDetails(_Reservation.BookCopyID);
            frm.ShowDialog();
        }

        private void llbShowMemberInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowMemberDetails frm = new frmShowMemberDetails(_Reservation.MemberID);
            frm.ShowDialog();
        }
    }
}
