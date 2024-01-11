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

namespace LibraryManagementSystem.People.UserControls
{
    public partial class ucPersonCard : UserControl
    {
        private int? _PersonID = null;

        private clsPerson _Person = null;

        public int? PersonID => _PersonID;

        public clsPerson Person => _Person;

        public ucPersonCard()
        {
            InitializeComponent();
        }

        public void ResetPersonData()
        {
            _PersonID = null;

            lblPersonID.Text = "[????]";
            lblFullName.Text = "[????]";
            lblEmail.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblPhoneNo.Text = "[????]";
            lblAddress.Text = "[????]";
            lblGender.Text = "[????]";
            lblBirthDate.Text = "[????]";
            lblCountry.Text = "[????]";

        }

        private void _LoadPersonData()
        {
            llbEditPersonInfo.Enabled = true;

            _PersonID = _Person.PersonID;

            lblPersonID.Text = _PersonID.ToString();
            lblFullName.Text = _Person.FullName;
            lblEmail.Text = _Person.Email;
            lblNationalNo.Text = _Person.NationalNo;
            lblPhoneNo.Text = _Person.Phone;
            lblAddress.Text = _Person.Address;
            lblGender.Text = (_Person.Gender == 'M') ? "Male" : "Female";
            lblBirthDate.Text = _Person.BirthDate.Value.ToShortDateString();
            lblCountry.Text = _Person.CountryInfo.CountryName;

            pbPersonImage.ImageLocation = _Person.PersonalImagePath ?? null;
        }

        public void LoadPersonData(int? PersonID)
        {
            _Person = clsPerson.Find(PersonID);

            if (_Person == null)
            {
                MessageBox.Show($"No person with ID = {PersonID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetPersonData();
                return;
            }

            _LoadPersonData();
        }

        public void LoadPersonData(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);

            if (_Person == null)
            {
                MessageBox.Show($"No person with NationalNo = {NationalNo} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetPersonData();
                return;
            }

            _LoadPersonData();
        }

        private void llbEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson form = new frmAddUpdatePerson(_PersonID);
            form.ShowDialog();
            LoadPersonData(_PersonID);

        }

    }
}
