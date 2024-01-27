using Guna.UI2.WinForms;
using Library_BusinessLayer;
using LibraryManagementSystem.GlobalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;
using static Library_BusinessLayer.clsUser;

namespace LibraryManagementSystem.Users
{
    public partial class frmAddUpdateUser : Form
    {
        private enum enMode { AddNew = 1, Update = 2 };

        private enMode _Mode = enMode.AddNew;

        private int? _PersonID = null;

        private int? _UserID = null;

        private clsUser _User = null;

        public frmAddUpdateUser(int? userID)
        {
            InitializeComponent();
            _UserID = userID;
            _Mode = enMode.Update;
        }

        public frmAddUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        private void _ResetPermissionsGroupBox()
        {
            tsAll.Checked = false;

            tsManageUsers.Checked = false;
            tsManageMembers.Checked = false;
            tsManageBooks.Checked = false;
            tsManageBorrowings.Checked = false;
            tsManageReturns.Checked = false;
            tsManageFines.Checked = false;
        }

        private void _ResetDefaultValues()
        {
            ucPersonCardWithFilter1.ResetPersonData();
            ucPersonCardWithFilter1.PersonFound += HandlePersonFound;

            lblUserID.Text = "[????]";
            txtUserName.ResetText();
            chbIsActive.Checked = true;
            _ResetPermissionsGroupBox();

            if (_Mode == enMode.AddNew)
            {
                _User = new clsUser();
                lblTitle.Text = "Add New User";
                ucPersonCardWithFilter1.FilterFocus();
            }

            else
            {
                lblTitle.Text = "Update User";
                ucPersonCardWithFilter1.FilterEnabled = false;
            }

            btnNext.Enabled = _Mode == enMode.Update;
            tpAccountInfo.Enabled = btnNext.Enabled;
            btnSave.Enabled = btnNext.Enabled;
        }

        private bool _CheckPermissionToggleSwitch(Guna2ToggleSwitch ts , clsUser.enPermissions permissions)
        {
            if(_User.CheckAccessPermissions(permissions))
            {
                ts.Checked = true;
                return true;
            }

            return false;
        }

        private void _LoadUserPermissions()
        {
            if (_CheckPermissionToggleSwitch(tsAll, clsUser.enPermissions.eAll))
                return;

            clsUser.enPermissions permissions;

            foreach (Guna2ToggleSwitch ts in pnlPermissions.Controls)
            {
                if(ts != tsAll)
                {
                    permissions = (clsUser.enPermissions)Enum.Parse(typeof(clsUser.enPermissions), ts.Tag.ToString());
                    _CheckPermissionToggleSwitch(ts, permissions);
                }             
            }
        }

        private void _LoadUserData()
        {
            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                MessageBox.Show($"No user with ID = {_UserID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnClose.PerformClick();
                return;
            }

            _PersonID = _User.PersonID;
            ucPersonCardWithFilter1.LoadPersonData(_PersonID);
            lblUserID.Text = _UserID.ToString();
            txtUserName.Text = _User.UserName;
            chbIsActive.Checked = _User.IsActive.Value;

            gbPermissions.Enabled = clsGlobal.CurrentUser.UserID != _User.UserID;

            _LoadUserPermissions();       
        }

        private short? _SetUserPermissions()
        {
            if (tsAll.Checked)
                return -1;

            short? userPermissions = 0;
   
            foreach (Guna2ToggleSwitch ts in pnlPermissions.Controls)
            {
                if (ts.Checked)
                    userPermissions += short.Parse(ts.Tag.ToString());
            }

            return userPermissions;

        }

        private void _SaveUserData()
        {

            _User.Permissions = _SetUserPermissions();
            _User.UserName = txtUserName.Text.Trim();
            _User.IsActive = chbIsActive.Checked;
            _User.PersonID = ucPersonCardWithFilter1.PersonID;

            if (_User.Save())
            {
                MessageBox.Show("User data saved successfully !", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
                lblTitle.Text = "Update User";
                lblUserID.Text = _User.UserID.ToString();
                ucPersonCardWithFilter1.FilterEnabled = false;
            }

            else
            {
                MessageBox.Show("User data is not saved successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
            {
                _LoadUserData();
            }
        }

        private void HandlePersonFound(object sender, int? PersonID)
        {
            if(PersonID.HasValue)
            {
                btnNext.Enabled = true;
                _PersonID = PersonID;
            }
     
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "This field is required , cannot be left blank !");
                return;
            }

            if (_User.UserName != txtUserName.Text.Trim() && clsUser.IsUserExist(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "This username already exists!");
                return;
            }

            else
            {
                errorProvider1.SetError(txtUserName, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _SaveUserData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(!_PersonID.HasValue)
            {
                MessageBox.Show("Please select a person first !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucPersonCardWithFilter1.Focus();
                return;
            }

            else if (ucPersonCardWithFilter1.PersonID != _User.PersonID && clsUser.IsUserExistByPersonID(ucPersonCardWithFilter1.PersonID))
            {
                MessageBox.Show("The person you have choosen is already linked with another user !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucPersonCardWithFilter1.Focus();
                return;
            }

            else
            {
                btnSave.Enabled = true;
                tpAccountInfo.Enabled = true;
                tcUserInfo.SelectedTab = tpAccountInfo;
            }
        }

        private void lblTitle_TextChanged(object sender, EventArgs e)
        {
            this.Text = lblTitle.Text;
        }

        private void tsAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Guna2ToggleSwitch ts in pnlPermissions.Controls)
            {
                if(ts != tsAll)
                    ts.Checked = !tsAll.Checked;
            }
        }

    }
}
