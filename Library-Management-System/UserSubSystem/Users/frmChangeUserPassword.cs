using Library_BusinessLayer;
using Library_Utility;
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
    public partial class frmChangeUserPassword : Form
    {
        private int? _UserID = null;

        private clsUser _User = null;

        public frmChangeUserPassword(int? userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "This field is required , cannot be left blank !");
                return;
            }

            if (clsCryptoUtility.ComputeHash(txtCurrentPassword.Text.Trim()) != _User.PersonInfo.Password)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "The password you entered is incorrect !");
                return;
            }

            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            }
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "This field is required , cannot be left blank !");
                return;
            }

            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "This field is required , cannot be left blank !");
                return;
            }

            else if (txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "The passwords do not match !");
                return;
            }

            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private bool _UpdateUserPassword()
        {
            return _User.UpdateUserPassword(clsCryptoUtility.ComputeHash(txtNewPassword.Text.Trim()));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(_UpdateUserPassword())
            {
                MessageBox.Show("User Password changed successfully !", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Error: User Password was not changed successfully !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _User = clsUser.Find(_UserID); 

            if (_User == null)
            {
                MessageBox.Show($"No user with ID = {_UserID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ucUserCard1.LoadUserData(_UserID);
        }

    }
}
