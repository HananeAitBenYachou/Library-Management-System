using Guna.UI2.WinForms;
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
using static Library_BusinessLayer.clsUser;

namespace LibraryManagementSystem.Members
{
    public partial class frmAddUpdateMember : Form
    {
        private enum enMode { AddNew = 1, Update = 2 };

        private enMode _Mode = enMode.AddNew;

        private int? _PersonID = null;

        private int? _MemberID = null;

        private clsMember _Member = null;

        public event EventHandler<int?> MemberAdded;

        protected virtual void OnMemberAdded(int? memberID)
        {
            MemberAdded?.Invoke(this, memberID);
        }

        public frmAddUpdateMember(int? memberID)
        {
            InitializeComponent();
            _MemberID = memberID;
            _Mode = enMode.Update;
        }

        public frmAddUpdateMember()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        private void _ResetDefaultValues()
        {
            ucPersonCardWithFilter1.ResetPersonData();
            ucPersonCardWithFilter1.PersonFound += HandlePersonFound;

            lblMemberD.Text = "[????]";
            txtLibraryCardNo.ResetText();
       
            if (_Mode == enMode.AddNew)
            {
                _Member = new clsMember();
                lblTitle.Text = "Add New Member";
                ucPersonCardWithFilter1.FilterFocus();
            }

            else
            {
                lblTitle.Text = "Update Member";
                ucPersonCardWithFilter1.FilterEnabled = false;
            }

            btnNext.Enabled = _Mode == enMode.Update;
            tpMembershipInfo.Enabled = btnNext.Enabled;
            btnSave.Enabled = btnNext.Enabled;
        }

        private void _LoadMemberData()
        {
            _Member = clsMember.Find(_MemberID);

            if (_Member == null)
            {
                MessageBox.Show($"No member with ID = {_MemberID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnClose.PerformClick();
                return;
            }

            _PersonID = _Member.PersonID;
            ucPersonCardWithFilter1.LoadPersonData(_PersonID);
            lblMemberD.Text = _MemberID.ToString();
            txtLibraryCardNo.Text = _Member.LibraryCardNumber;

        }

        private bool _SaveMemberData()
        {
            _Member.LibraryCardNumber = txtLibraryCardNo.Text.Trim();
            _Member.PersonID = ucPersonCardWithFilter1.PersonID;

            if (_Member.Save())
            {
                MessageBox.Show("Member data saved successfully !", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
                lblTitle.Text = "Member User";
                lblMemberD.Text = _Member.MemberID.ToString();
                ucPersonCardWithFilter1.FilterEnabled = false;

                return true;
            }

            else
            {
                MessageBox.Show("Member data is not saved successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void frmAddUpdateMember_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
            {
                _LoadMemberData();
            }
        }

        private void HandlePersonFound(object sender, int? PersonID)
        {
            if (PersonID.HasValue)
            {
                btnNext.Enabled = true;
                _PersonID = PersonID;
            }

        }

        private void txtLibraryCardNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLibraryCardNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLibraryCardNo, "This field is required , cannot be left blank !");
                return;
            }

            if (_Member.LibraryCardNumber != txtLibraryCardNo.Text.Trim() && clsMember.IsMemberExist(txtLibraryCardNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLibraryCardNo, "This LibrayCardNo already exists!");
                return;
            }

            else
            {
                errorProvider1.SetError(txtLibraryCardNo, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_SaveMemberData())
                OnMemberAdded(_Member.MemberID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!_PersonID.HasValue)
            {
                MessageBox.Show("Please select a person first !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucPersonCardWithFilter1.Focus();
                return;
            }

            else if (ucPersonCardWithFilter1.PersonID != _Member.PersonID && clsMember.IsMemberExistByPersonID(ucPersonCardWithFilter1.PersonID))
            {
                MessageBox.Show("The person you have choosen is already linked with another member !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucPersonCardWithFilter1.Focus();
                return;
            }

            else
            {
                btnSave.Enabled = true;
                tpMembershipInfo.Enabled = true;
                tcMemberInfo.SelectedTab = tpMembershipInfo;
            }
        }

        private void lblTitle_TextChanged(object sender, EventArgs e)
        {
            this.Text = lblTitle.Text;
        }

        private void txtLibraryCardNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }


    }
}
