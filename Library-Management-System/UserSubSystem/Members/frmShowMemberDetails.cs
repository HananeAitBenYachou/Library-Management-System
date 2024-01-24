using Library_BusinessLayer;
using LibraryManagementSystem.Users.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Members
{
    public partial class frmShowMemberDetails : Form
    {
        private int? _MemberID = null;

        public frmShowMemberDetails(int? memberID)
        {
            InitializeComponent();
            _MemberID = memberID;
        }

        private void frmShowMemberDetails_Load(object sender, EventArgs e)
        {
            if (!clsMember.IsMemberExist(_MemberID))
            {
                MessageBox.Show($"No member with ID = {_MemberID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ucMemberCard1.LoadMemberData(_MemberID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
