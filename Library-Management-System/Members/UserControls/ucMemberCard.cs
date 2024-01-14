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

namespace LibraryManagementSystem.Members.UserControls
{
    public partial class ucMemberCard : UserControl
    {
        private int? _MemberID = null;

        private clsMember _Member = null;

        public int? MemberID => _MemberID;

        public clsMember Member => _Member;

        public ucMemberCard()
        {
            InitializeComponent();
        }

        public void ResetMemberData()
        {
            _MemberID = null;

            lblMemberID.Text = "[????]";
            lblLibraryCardNo.Text = "[????]";

            ucPersonCard1.ResetPersonData();
        }

        private void _LoadMemberData()
        {
            _MemberID = _Member.MemberID;

            lblMemberID.Text = _Member.MemberID.ToString();
            lblLibraryCardNo.Text = _Member.LibraryCardNumber;

            ucPersonCard1.LoadPersonData(_Member.PersonID);
        }

        public void LoadMemberData(int? memberID)
        {
            _Member = clsMember.Find(memberID);

            if (_Member == null)
            {
                MessageBox.Show($"No member with ID = {memberID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetMemberData();
                return;
            }

            _LoadMemberData(); 
        }

        public void LoadMemberDataByPersonID(int? personID)
        {
            _Member = clsMember.FindByPersonID(personID);

            if (_Member == null)
            {
                MessageBox.Show($"No member with PersonID = {personID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetMemberData();
                return;
            }

            _LoadMemberData();
        }

        public void LoadMemberData(string LibraryCardNo)
        {
            _Member = clsMember.Find(LibraryCardNo);

            if (_Member == null)
            {
                MessageBox.Show($"No member with LibraryCardNo = {LibraryCardNo} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetMemberData();
                return;
            }

            _LoadMemberData();
        }

    }
}
