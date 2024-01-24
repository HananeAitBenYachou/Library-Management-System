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
    public partial class frmShowMemberFinesHistory : Form
    {
        private int? _MemberID = null;

        public frmShowMemberFinesHistory(int? memberID)
        {
            InitializeComponent();
            _MemberID = memberID;
        }

        private void frmShowMemberFinesHistory_Load(object sender, EventArgs e)
        {
            if (!clsMember.IsMemberExist(_MemberID))
            {
                MessageBox.Show($"No member with ID = {_MemberID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ucMemberCard1.LoadMemberData(_MemberID);
            dgvMemberFinesList.DataSource = clsFine.GetMemberFines(_MemberID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMemberFinesList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvMemberFinesList.Columns)
            {
                column.Width = 200;
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowFineDetails frm = new frmShowFineDetails((int)dgvMemberFinesList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
