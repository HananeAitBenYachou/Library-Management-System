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
    public partial class frmShowMemberReservationsHistory : Form
    {
        private int? _MemberID = null;

        public frmShowMemberReservationsHistory(int? memberID)
        {
            InitializeComponent();
            _MemberID = memberID;
        }

        private void frmShowMemberReservationsHistory_Load(object sender, EventArgs e)
        {
            if (!clsMember.IsMemberExist(_MemberID))
            {
                MessageBox.Show($"No member with ID = {_MemberID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ucMemberCard1.LoadMemberData(_MemberID);
            dgvMemberReservationsList.DataSource = clsReservation.GetMemberReservations(_MemberID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMemberReservationList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvMemberReservationsList.Columns)
            {
                column.Width = 200;
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowReservationDetails frm = new frmShowReservationDetails((int)dgvMemberReservationsList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
