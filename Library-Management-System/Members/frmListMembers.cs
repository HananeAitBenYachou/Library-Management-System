﻿using Library_BusinessLayer;
using LibraryManagementSystem.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem.Members
{
    public partial class frmListMembers : Form
    {
        private DataView _MembersDataView;

        public frmListMembers()
        {
            InitializeComponent();
        }

        private void _RefreshMembersList()
        {
            _MembersDataView = clsMember.GetAllMembers().DefaultView;
            dgvMembersList.DataSource = _MembersDataView;
            cbFilterByOptions.SelectedIndex = 0;
        }

        private void _FilterMembersList()
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                _MembersDataView.RowFilter = null;
                return;
            }

            if (cbFilterByOptions.Text == "Person ID" || cbFilterByOptions.Text == "Member ID")
            {
                _MembersDataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, txtFilterValue.Text.Trim());
            }

            else
            {
                _MembersDataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text.Trim());
            }
        }

        private void frmListMembers_Load(object sender, EventArgs e)
        {
            _RefreshMembersList();
        }

        private void dgvMembersList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvMembersList.Columns)
            {
                column.Width = 150;
            }
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterByOptions.Text == "Gender")
            {
                txtFilterValue.Visible = false;
                cbGender.Visible = true;
                cbGender.SelectedIndex = 0;
            }

            else
            {
                txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
                txtFilterValue.ResetText();
                txtFilterValue.Focus();
                cbGender.Visible = false;
                txtFilterValue_TextChanged(null, null);
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterMembersList();
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbGender.Text)
            {
                case "All":
                    _MembersDataView.RowFilter = null;
                    return;
                default:
                    _MembersDataView.RowFilter = 
                        string.Format("[{0}] = '{1}'", cbFilterByOptions.Text, cbGender.Text);
                    break;
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text == "Person ID" || cbFilterByOptions.Text == "Member ID")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            frmAddUpdateMember frm = new frmAddUpdateMember();
            frm.ShowDialog();
            _RefreshMembersList();
        }

        private void AddMembertoolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddMember.PerformClick();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowMemberDetails frm = new frmShowMemberDetails((int)dgvMembersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this member ?", "Confrim",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int MemberID = (int)dgvMembersList.CurrentRow.Cells[0].Value;

            if (!clsMember.IsMemberExist(MemberID))
            {
                MessageBox.Show($"No member with ID = {MemberID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsMember.DeleteMember(MemberID))
            {
                MessageBox.Show("Member has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
                MessageBox.Show("Member is not deleted due to data connected to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateMember frm = new frmAddUpdateMember((int)dgvMembersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshMembersList();
        }

        private void changePasswordtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeMemberPassword frm = new frmChangeMemberPassword((int)dgvMembersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

    }
}