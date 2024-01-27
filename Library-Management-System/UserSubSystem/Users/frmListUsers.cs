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

namespace LibraryManagementSystem.Users
{
    public partial class frmListUsers : Form
    {
        private DataView _UsersDataView;

        public frmListUsers()
        {
            InitializeComponent();
        }

        private void _RefreshUsersList()
        {
            _UsersDataView = clsUser.GetAllUsers().DefaultView;
            dgvUsersList.DataSource = _UsersDataView;
            cbFilterByOptions.SelectedIndex = 0;
        }

        private void _FilterUsersList()
        {
            if(string.IsNullOrEmpty(txtFilterValue.Text))
            {
                _UsersDataView.RowFilter = null;
                return;
            }

            if(cbFilterByOptions.Text == "Person ID"||  cbFilterByOptions.Text == "User ID")
            {
                _UsersDataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, txtFilterValue.Text.Trim());
            }

            else 
            {
                _UsersDataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text.Trim());
            }
        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
            _RefreshUsersList();
        }

        private void dgvUsersList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach(DataGridViewColumn column in dgvUsersList.Columns) 
            {
                column.Width = 210;
            }
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterByOptions.Text == "Is Active")
            {
                txtFilterValue.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.SelectedIndex = 0;
            }

            else
            {
                txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
                txtFilterValue.ResetText();
                txtFilterValue.Focus();
                cbIsActive.Visible = false;
                txtFilterValue_TextChanged(null, null);
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {           
            _FilterUsersList();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool status = false; 

            switch(cbIsActive.Text)
            {
                case "All":
                    _UsersDataView.RowFilter = null;
                    return;
                case "Yes":
                    status = true;
                    break;
                case "No":
                    status = false;
                    break;
            }

            _UsersDataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, status);
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterByOptions.Text == "Person ID" || cbFilterByOptions.Text == "User ID")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
            _RefreshUsersList();
        }

        private void AddUsertoolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddUser.PerformClick();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {        
            frmShowUserDetails frm = new frmShowUserDetails((int)dgvUsersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this user ?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int userID = (int)dgvUsersList.CurrentRow.Cells[0].Value;

            if (!clsUser.IsUserExist(userID))
            {
                MessageBox.Show($"No user with ID = {userID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsUser.DeleteUser(userID))
            {
                MessageBox.Show("User has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshUsersList();
            }

            else
                MessageBox.Show("User is not deleted due to data connected to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser((int)dgvUsersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshUsersList();
        }

        private void changePasswordtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeUserPassword frm = new frmChangeUserPassword((int)dgvUsersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void cmsUsers_Opening(object sender, CancelEventArgs e)
        {
            deleteToolStripMenuItem.Enabled = (clsGlobal.CurrentUser.UserID != (int)dgvUsersList.CurrentRow.Cells[0].Value);
        }
    }
}
