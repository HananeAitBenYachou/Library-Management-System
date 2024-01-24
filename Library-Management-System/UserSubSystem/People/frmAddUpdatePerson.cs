using Guna.UI2.WinForms;
using Library_BusinessLayer;
using Library_Utility;
using LibraryManagementSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibraryManagementSystem.People
{
    public partial class frmAddUpdatePerson : Form
    {
        private enum enMode { AddNew = 1, Update = 2};

        private enMode _Mode = enMode.AddNew;

        private int? _PersonID = null;

        private clsPerson _Person = null;

        public event EventHandler<int?> PersonAdded;

        public bool _PasswordEditEnabled = true;

        public bool PasswordEditEnabled
        {
            get
            {
                return _PasswordEditEnabled;
            }

            set
            {
                txtPassword.Visible = value;
                iconPassword.Visible = value;
                lblPassword.Visible = value;
            }
        }

        protected virtual void OnPersonAdded(int? personID)
        {
            PersonAdded?.Invoke(this, personID);
        }

        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdatePerson(int? personID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _PersonID = personID;
        }

        private void _ResetDefaultValues()
        {
            _FillCountriesInComboBox();
            
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                PasswordEditEnabled = true;
                _Person = new clsPerson();
            }

            else
            {
                PasswordEditEnabled = false;
                lblTitle.Text = "Update Person";
            }

            lblPersonID.Text = "[????]";
            txtFirstName.ResetText();
            txtLastName.ResetText();
            txtEmail.ResetText();
            txtNationalNo.ResetText();
            txtPhoneNo.ResetText();
            txtAddress.ResetText();
            txtPassword.ResetText();

            dtpBirthDate.MaxDate = DateTime.Now.AddYears(-18);
            dtpBirthDate.MinDate = DateTime.Now.AddYears(-85);

            rbMale.Checked = true;
        }

        private void _LoadPersonData()
        {
            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show($"No person with ID = {_PersonID} was found in the system !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            lblPersonID.Text = _Person.PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtLastName.Text = _Person.LastName;
            txtEmail.Text = _Person.Email;
            txtNationalNo.Text = _Person.NationalNo;
            txtPhoneNo.Text = _Person.Phone;
            txtAddress.Text = _Person.Address;
            txtPassword.Text = _Person.Password;

            if (_Person.Gender == 'M')
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            dtpBirthDate.Value = _Person.BirthDate.Value;

            cbCountries.SelectedIndex = cbCountries.FindString(_Person.CountryInfo.CountryName);

            pbPersonImage.ImageLocation = _Person.PersonalImagePath ?? null;

            llbRemoveImage.Visible = pbPersonImage.Image != null;

        }

        private bool _SavePersonData()
        {
            if (!_IsPersonImageHandledSuccessfully())
                return false;

            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.Phone = txtPhoneNo.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();          
            _Person.Gender = rbMale.Checked ? 'M' : 'F';
            _Person.BirthDate = dtpBirthDate.Value;
            _Person.NationalityCountryID = clsCountry.Find(cbCountries.Text).CountryID;
            _Person.PersonalImagePath = pbPersonImage.ImageLocation ?? null;
            _Person.Password = PasswordEditEnabled ? txtPassword.Text.Trim() : _Person.Password;

            if (_Person.Save())
            {
                MessageBox.Show("Person data saved successfully !", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _Mode = enMode.Update;
                lblPersonID.Text = _Person.PersonID.ToString();
                lblTitle.Text = "Update Person";

                return true;
            }

            else
            {
                MessageBox.Show("Person data is not saved successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool _IsPersonImageHandledSuccessfully()
        {
            if (pbPersonImage.ImageLocation != _Person.PersonalImagePath)
            {
                if(_Person.PersonalImagePath!= null)
                {
                    try
                    {
                        File.Delete(_Person.PersonalImagePath);

                    }
                    catch(Exception ex)
                    {
                        clsErrorLogger.LogError(ex);
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }

                if(pbPersonImage.ImageLocation != null)
                {
                    string sourceFile = pbPersonImage.ImageLocation;
                    string destinationFolder = @"C:\Library-People-Images";

                    try
                    {
                        clsUtility.CopyImageToProjectImagesFolder(destinationFolder,ref sourceFile);
                        pbPersonImage.ImageLocation = sourceFile;
                    }

                    catch (Exception ex)
                    {
                        clsErrorLogger.LogError(ex);
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }

            return true;
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadPersonData();
        }

        private void _FillCountriesInComboBox()
        {
            foreach (DataRow row in clsCountry.GetAllCountries().Rows)
            {
                cbCountries.Items.Add(row["CountryName"]);
            }

            cbCountries.SelectedIndex = cbCountries.FindString("Morocco");
        }

        private void llbUploadImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbPersonImage.ImageLocation = openFileDialog1.FileName;
                llbRemoveImage.Visible = true;
            }
        }

        private void llbRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;

            pbPersonImage.Image = rbMale.Checked ? Resources.man : Resources.woman;
        }

        private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtNationalNo.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError((Guna2TextBox)sender, "This field is required , cannot be left blank !");
            }

            else if(clsPerson.IsPersonExistByNationalNo(txtNationalNo.Text) && txtNationalNo.Text != _Person.NationalNo)
            {
                e.Cancel = true;
                errorProvider1.SetError((Guna2TextBox)sender, "This NationalNo already exists !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError((Guna2TextBox)sender, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError((Guna2TextBox)sender, "This field is required , cannot be left blank !");
            }

            else if (clsPerson.IsPersonExistByEmail(txtEmail.Text) && txtEmail.Text != _Person.Email)
            {
                e.Cancel = true;
                errorProvider1.SetError((Guna2TextBox)sender, "This NationalNo already exists !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError((Guna2TextBox)sender, null);
            }
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox tempTextBox = (Guna2TextBox)sender;

            if (string.IsNullOrEmpty(tempTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tempTextBox, "This field is required , cannot be left blank !");
            }
         
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tempTextBox, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(_SavePersonData())
                OnPersonAdded(_Person.PersonID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitle_TextChanged(object sender, EventArgs e)
        {
            this.Text = lblTitle.Text;
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.man;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.woman;
        }

    }
}
