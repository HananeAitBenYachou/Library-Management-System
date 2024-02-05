using Library_BusinessLayer;
using LibraryManagementSystem.Books.UserControls;
using LibraryManagementSystem.Books;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Members.UserControls
{
    public partial class ucMemberCardWithFilter : UserControl
    {
        public event EventHandler<int?> MemberFound;

        protected virtual void OnMemberFound(int? memberID)
        {
            MemberFound?.Invoke(this, memberID);
        }

        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }

            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;

                if (!_FilterEnabled)
                    txtFilterValue.Validating -= txtFilterValue_Validating;
            }
        }

        public int? MemberID => ucMemberCard1.MemberID;

        public clsMember Member => ucMemberCard1.Member;

        public ucMemberCardWithFilter()
        {
            InitializeComponent();
        }

        public void LoadMemberData(int? memberID)
        {
            FilterEnabled = false;
            txtFilterValue.Text = memberID.ToString();
            _FindMember();
        }

        public void ResetMemberData()
        {
            cbFilterByOptions.SelectedIndex = 0;
            FilterFocus();
            ucMemberCard1.ResetMemberData();
        }

        private void _FindMember()
        {
            switch (cbFilterByOptions.Text)
            {
                case "Member ID":
                    ucMemberCard1.LoadMemberData(int.Parse(txtFilterValue.Text.Trim()));
                    break;

                case "Person ID":
                    ucMemberCard1.LoadMemberDataByPersonID(int.Parse(txtFilterValue.Text.Trim()));
                    break;

                case "LibraryCard No":
                    ucMemberCard1.LoadMemberData(txtFilterValue.Text.Trim());
                    break;
            }

            if (MemberID.HasValue)
                OnMemberFound(ucMemberCard1.MemberID);
        }

        private void ucMemberCardWithFilter_Load(object sender, EventArgs e)
        {
        }

        private void btnSearchForMember_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Please enter the Member's MemberID/LibraryCardNo/PersonID you want to search for !", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _FindMember();
        }

        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            frmAddUpdateMember frm = new frmAddUpdateMember();
            frm.MemberAdded += _HandleNewMemberAdded;
            frm.ShowDialog();
        }

        private void _HandleNewMemberAdded(object sender, int? memberID)
        {
            cbFilterByOptions.SelectedIndex = 0;
            txtFilterValue.Text = memberID.ToString();
            btnSearchForMember.PerformClick();
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This field is required , cannot be left blank !");
                return;
            }

            else
            {
                errorProvider1.SetError(txtFilterValue, null);
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text == "Member ID" || cbFilterByOptions.Text == "Person ID")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        public void FilterFocus()
        {
            txtFilterValue.ResetText();
            txtFilterValue.Select();
        }

    }
}
