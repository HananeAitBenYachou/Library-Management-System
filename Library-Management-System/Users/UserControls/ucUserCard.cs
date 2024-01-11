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

namespace LibraryManagementSystem.Users.UserControls
{
    public partial class ucUserCard : UserControl
    {
        private int? _UserID = null;

        private clsUser _User = null;

        public int? UserID => _UserID;

        public clsUser User => _User;

        public ucUserCard()
        {
            InitializeComponent();
        }

        public void ResetUserData()
        {
            _UserID = null;

            lblUserID.Text = "[????]";
            lblUserName.Text = "[????]";
            lblIsActive.Text = "[????]";
            lblPermissions.Text = "[????]";

            ucPersonCard1.ResetPersonData();
        }

        public void LoadUserData(int? userID)
        {
            _User = clsUser.Find(userID);

            if (_User == null)
            {
                MessageBox.Show($"No user with ID = {userID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetUserData();
                return;
            }

            _UserID = _User.UserID;

            lblUserID.Text = _User.UserID.ToString();
            lblUserName.Text = _User.UserName;
            lblIsActive.Text = _User.IsActive.Value ? "YES" : "NO";
            lblPermissions.Text = _User.Permissions.ToString();

            ucPersonCard1.LoadPersonData(_User.PersonID);
        }

    }
}
