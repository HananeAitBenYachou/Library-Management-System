using Library_BusinessLayer;
using LibraryManagementSystem.GlobalClasses;
using LibraryManagementSystem.People.UserControls;
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
    public partial class frmAddUpdateReservation : Form
    {
        private enum enMode { AddNew = 1, Update = 2 };

        private enMode _Mode = enMode.AddNew;

        private int? _MemberID = null;

        private int? _BookCopyID = null;

        private clsReservation _Reservation = null;

        private int? _ReservationID = null;

        public frmAddUpdateReservation(int? MemberID = null)
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            _MemberID = MemberID;       
        }

        public frmAddUpdateReservation(int? reservationID, int? MemberID = null)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _ReservationID = reservationID;
        }

        private void _ResetDefaultValues()
        {
            ucMemberCardWithFilter1.MemberFound += HandleMemberFound;

            ucBookCardWithFilter1.BookFound += HandleBookFound;

            dtpReservationDate.MinDate = DateTime.Now;
            dtpReservationDate.Value = DateTime.Now;

            lblReservationID.Text = "[????]";

            if (_Mode == enMode.AddNew)
            {
                _Reservation = new clsReservation();
                lblTitle.Text = "Add New Reservation";
                ucBookCardWithFilter1.FilterFocus();

                if (_MemberID.HasValue)
                    ucMemberCardWithFilter1.LoadMemberData(_MemberID);
            }

            else
            {
                lblTitle.Text = "Update Reservation";
            }
         
            btnToSecondPage.Enabled = _Mode == enMode.Update;
            btnToLastPage.Enabled = _Mode == enMode.Update || _MemberID.HasValue;

            tpMemberInfo.Enabled = btnToSecondPage.Enabled;
            tpReservationInfo.Enabled = btnToLastPage.Enabled;

            btnSave.Enabled = btnToSecondPage.Enabled && btnToLastPage.Enabled;
        }

        private void _LoadReservationData()
        {
            _Reservation = clsReservation.Find(_ReservationID);

            if (_Reservation == null)
            {
                MessageBox.Show($"No Reservation with ID = {_ReservationID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnClose.PerformClick();
                return;
            }

            _MemberID = _Reservation.MemberID;
            _BookCopyID = _Reservation.BookCopyID;

            ucMemberCardWithFilter1.LoadMemberData(_MemberID);
            ucBookCardWithFilter1.LoadBookData(_Reservation.BookCopyInfo.BookID);

            lblReservationID.Text = _ReservationID.ToString();

            dtpReservationDate.MinDate = _Reservation.ReservationDate.Value;
            dtpReservationDate.Value = _Reservation.ReservationDate.Value;
        }

        private void _SaveReservationData()
        {
            _Reservation.BookCopyID = _BookCopyID;
            _Reservation.MemberID = ucMemberCardWithFilter1.MemberID;
            _Reservation.ReservationDate = dtpReservationDate.Value;

            if (_Reservation.Save())
            {
                MessageBox.Show("Reservation data saved successfully !", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblReservationID.Text = _Reservation.ReservationID.ToString();

                _Mode = enMode.Update;
                lblTitle.Text = "Update Reservation";
                ucMemberCardWithFilter1.FilterEnabled = false;
                ucBookCardWithFilter1.FilterEnabled = false;
            }

            else
            {
                MessageBox.Show("Reservation data is not saved successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void frmAddUpdateReservation_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
            {
                _LoadReservationData();
            }
        }

        private void HandleMemberFound(object sender, int? memberID)
        {
            if (memberID.HasValue)
            {
                btnToLastPage.Enabled = true;
                _MemberID = memberID;
            }
        }

        private void HandleBookFound(object sender, int? bookID)
        {
            if (bookID.HasValue)
            {
                btnToSecondPage.Enabled = true;
                _BookCopyID = ucBookCardWithFilter1.Book.GetBorrowedBookCopy();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _SaveReservationData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnToSecondPage_Click(object sender, EventArgs e)
        {
            if (!ucBookCardWithFilter1.BookID.HasValue)
            {
                MessageBox.Show("Please select a book first !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucBookCardWithFilter1.FilterFocus();
                return;
            }

            if (!_BookCopyID.HasValue)
            {
                MessageBox.Show("There are no borrowed copies of the selected book available for reservation !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucBookCardWithFilter1.FilterFocus();
                return;
            }

            else
            {
                tpMemberInfo.Enabled = true;
                tcReservationInfo.SelectedTab = tpMemberInfo;
                if (!_MemberID.HasValue)
                    ucMemberCardWithFilter1.FilterFocus();
            }
        }

        private void btnToLastPage_Click(object sender, EventArgs e)
        {
            if (!_MemberID.HasValue)
            {
                MessageBox.Show("Please select a member first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucMemberCardWithFilter1.FilterFocus();
                return;
            }

            else
            {
                btnSave.Enabled = true;
                tpReservationInfo.Enabled = true;
                tcReservationInfo.SelectedTab = tpReservationInfo;
            }
        }

    }
}
