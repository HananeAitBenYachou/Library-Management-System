using Guna.UI2.WinForms;
using Library_BusinessLayer;
using Library_Utility;
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

namespace LibraryManagementSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Please enter your email address !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Please enter your password !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, null);
            }
        }

        private void _ResetDefaultValues()
        {
            txtPassword.ResetText();
            txtEmail.ResetText();
            txtEmail.Select();
        }

        private bool _SignInAsUser(int? personID)
        {
            clsGlobal.CurrentUser = clsUser.FindByPersonID(personID);

            if(!clsGlobal.CurrentUser.IsActive.Value)
            {
                MessageBox.Show("Your account is not active ! Please contact the admin", "Inactive Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            this.Hide();
            frmMain main = new frmMain(this);
            main.Show();

            return true;
        }

        private bool _SignInAsMember(int? personID)
        {
            clsGlobal.CurrentMember = clsMember.FindByPersonID(personID);

            this.Hide();
            frmMemberMain main = new frmMemberMain(this);
            main.Show();

            return true;
        }

        private bool _SignIn()
        {
            clsPerson person = clsPerson.Find(txtEmail.Text.Trim(), clsCryptoUtility.ComputeHash(txtPassword.Text.Trim()));

            if(person == null)
            {
                MessageBox.Show($"Invalid Email or Password ! please try again.", "Wrong Credintials",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (person.PersonType == clsPerson.enPersonType.User)
            {
                if (!_SignInAsUser(person.PersonID))
                    return false;
            }
                        
            else
                _SignInAsMember(person.PersonID);


            if (ckbRememberMe.Checked)
                clsGlobal.StorePersonCredentials(txtEmail.Text.Trim(), txtPassword.Text.Trim());
            else
            {
                clsGlobal.StorePersonCredentials(string.Empty, string.Empty);
                txtEmail.ResetText();
                txtPassword.ResetText();
            }

            return true;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Please fill out all required fields !", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_SignIn())
                _ResetDefaultValues();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string Email = "", Password = ""; 

            if(clsGlobal.GetStoredPersonCredentials(ref Email,ref Password))
            {
                txtPassword.Text = Password;
                txtEmail.Text = Email;
                ckbRememberMe.Checked = true;
            }

            else
            {
                _ResetDefaultValues();
                ckbRememberMe.Checked = false;
            }
        }
    }
}
