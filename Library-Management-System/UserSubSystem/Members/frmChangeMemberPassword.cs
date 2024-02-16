using Library_BusinessLayer;
using Library_Utility;
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
    public partial class frmChangeMemberPassword : Form
    {
        private int? _MemberID = null;

        private clsMember _Member = null;

        public frmChangeMemberPassword(int? memberID)
        {
            InitializeComponent();
            _MemberID = memberID;
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "This field is required , cannot be left blank !");
                return;
            }

            if (clsCryptoUtility.ComputeHash(txtCurrentPassword.Text.Trim()) != _Member.PersonInfo.Password)
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

        private bool _UpdateMemberPassword()
        {
            return _Member.UpdateMemberPassword(clsCryptoUtility.ComputeHash(txtNewPassword.Text.Trim()));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_UpdateMemberPassword())
            {
                MessageBox.Show("Member Password changed successfully !", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Error: Member Password was not changed successfully !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _Member = clsMember.Find(_MemberID);

            if (_Member == null)
            {
                MessageBox.Show($"No member with ID = {_MemberID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ucMemberCard1.LoadMemberData(_MemberID);
        }

    }
}
