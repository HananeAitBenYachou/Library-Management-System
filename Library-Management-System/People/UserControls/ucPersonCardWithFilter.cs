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
    public partial class ucPersonCardWithFilter : UserControl
    {
        public event EventHandler<int?> PersonFound;

        protected virtual void OnPersonFound(int? PersonID)
        {
            PersonFound?.Invoke(this,PersonID);
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

                if(!_FilterEnabled)
                    txtFilterValue.Validating -= txtFilterValue_Validating;
            }
        }

        public int? PersonID => ucPersonCard1.PersonID;

        public clsPerson Person => ucPersonCard1.Person;

        public ucPersonCardWithFilter()
        {
            InitializeComponent();
        }

        public void LoadPersonData(int? personID)
        {
            FilterEnabled = false;
            txtFilterValue.Text = personID.ToString();
            _FindPerson();
        }

        public void ResetPersonData()
        {
            cbFilterByOptions.SelectedIndex = 0;
            FilterFocus();
            ucPersonCard1.ResetPersonData();
        }

        private void _FindPerson()
        {
            switch (cbFilterByOptions.Text)
            {
                case "Person ID":
                    ucPersonCard1.LoadPersonData(int.Parse(txtFilterValue.Text.Trim()));
                    break;
                case "National No":
                    ucPersonCard1.LoadPersonData(txtFilterValue.Text.Trim());
                    break;
            }  
        }

        private void ucPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            FilterFocus();
        }

        private void btnSearchForPerson_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Please enter the Person's PersonID/NationalNo you want to search for !", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _FindPerson();

            if (FilterEnabled && PersonID.HasValue)
                OnPersonFound(ucPersonCard1.PersonID);
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.PersonAdded += _HandleNewPersonAdded;
            frm.ShowDialog();
        }

        private void _HandleNewPersonAdded(object sender, int? PersonID)
        {
            cbFilterByOptions.SelectedIndex = 0;
            txtFilterValue.Text = PersonID.ToString();
            btnSearchForPerson.PerformClick();
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
            if(cbFilterByOptions.Text == "Person ID")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        public void FilterFocus()
        {
            txtFilterValue.ResetText();
            txtFilterValue.Select();
        }

    }
}
