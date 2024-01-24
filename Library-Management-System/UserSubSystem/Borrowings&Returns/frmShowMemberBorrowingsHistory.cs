using Library_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Borrowings_Returns
{
    public partial class frmShowMemberBorrowingsHistory : Form
    {
        private int? _MemberID = null;

        public frmShowMemberBorrowingsHistory(int? memberID)
        {
            InitializeComponent();
            _MemberID = memberID;
        }

        private void frmShowMemberBorrowingsHistory_Load(object sender, EventArgs e)
        {
            if (!clsMember.IsMemberExist(_MemberID))
            {
                MessageBox.Show($"No member with ID = {_MemberID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ucMemberCard1.LoadMemberData(_MemberID);
            dgvMemberBorrowingsList.DataSource = clsBorrowingRecord.GetMemberBorrowingRecords(_MemberID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMemberBorrowingsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvMemberBorrowingsList.Columns)
            {
                column.Width = 200;
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowBorrowingDetails frm = new frmShowBorrowingDetails((int)dgvMemberBorrowingsList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
