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

namespace LibraryManagementSystem.Fines
{
    public partial class ucFineDetails : UserControl
    {
        private int? _FineID = null;

        private clsFine _Fine = null;

        public int? FineID => _FineID;

        public clsFine Fine => _Fine;

        public ucFineDetails()
        {
            InitializeComponent();
        }

        public void ResetFineData()
        {
            _FineID = null;

            llbShowBorrowingInfo.Visible = false;

            lblFineID.Text = "[????]";
            lblBorrowingID.Text = "[????]";
            lblMemberLibCardNo.Text = "[????]";
            lblLateDaysNo.Text = "[????]";
            lblFineAmount.Text = "[????]";
            lblPaymentStatus.Text = "[????]";
        }

        public void LoadFineDetails(int? fineID)
        {
            _Fine = clsFine.Find(fineID);

            if (_Fine == null)
            {
                MessageBox.Show($"No fine with ID = {fineID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetFineData();
                return;
            }

            _FineID = _Fine.FineID;

            lblFineID.Text = _Fine.FineID.ToString();
            lblBorrowingID.Text = _Fine.BorrowingRecordID.ToString();
            lblMemberLibCardNo.Text = _Fine.MemberInfo.LibraryCardNumber;
            lblLateDaysNo.Text = _Fine.NumberOfLateDays.ToString() + " Days"; 
            lblFineAmount.Text = _Fine.FineAmount.ToString();
            lblPaymentStatus.Text = _Fine.PaymentStatus.Value ? "Paid" : "Not paid yet";

            llbShowBorrowingInfo.Visible = true;
        }

        private void llbShowBorrowingInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowBorrowingDetails frm = new frmShowBorrowingDetails(_Fine.BorrowingRecordID);
            frm.ShowDialog();
        }
    }
}
