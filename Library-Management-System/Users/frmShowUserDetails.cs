using Library_BusinessLayer;
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

namespace LibraryManagementSystem.Users
{
    public partial class frmShowUserDetails : Form
    {
        private int? _UserID = null;

        public frmShowUserDetails(int? userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        private void frmShowUserDetails_Load(object sender, EventArgs e)
        {
            if (!clsUser.IsUserExist(_UserID))
            {
                MessageBox.Show($"No user with ID = {_UserID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ucUserCard1.LoadUserData(_UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
