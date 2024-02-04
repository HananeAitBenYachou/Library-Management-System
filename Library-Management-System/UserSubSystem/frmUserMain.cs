using Guna.UI2.WinForms;
using Library_BusinessLayer;
using LibraryManagementSystem.Authors;
using LibraryManagementSystem.Books;
using LibraryManagementSystem.Borrowings_Returns;
using LibraryManagementSystem.Fines;
using LibraryManagementSystem.Genres;
using LibraryManagementSystem.GlobalClasses;
using LibraryManagementSystem.Members;
using LibraryManagementSystem.Reservations;
using LibraryManagementSystem.Users;
using LibraryManagementSystem.UserSubSystem;
using LibraryManagementSystem.UserSubSystem.Global;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmMain : Form
    {
        private Form _LoginForm = null;

        private Guna2Button _CurrentActiveButton = new Guna2Button(); 

        public frmMain(Form loginForm)
        {
            InitializeComponent();
            _LoginForm = loginForm;
        }
        
        private bool _CheckUserPermissions(clsUser.enPermissions permission)
        {
            if (!clsGlobal.CurrentUser.CheckAccessPermissions(permission))
            {
                frmAccessDenied frm = new frmAccessDenied();
                frm.ShowDialog();
                return false;
            }

            return true;
        }

        private void _ShowForm(Guna2Button activeBtn , Form frm)
        {
            if(_CurrentActiveButton != null)           
                _CurrentActiveButton.Checked = false;
            
            _CurrentActiveButton = activeBtn;
            _CurrentActiveButton.Checked = true;
 
            frm.BackColor = pnlContainer.BackColor;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;

            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(frm);

            frm.Show();
        }

        private void _LoadLoggedInUserInfo()
        {
            lblUserRole.Text = clsGlobal.CurrentUser.UserRole.ToString();
            lblUserFullName.Text = clsGlobal.CurrentUser.PersonInfo.FullName;

            if (clsGlobal.CurrentUser.PersonInfo.PersonalImagePath != null)
                pbUserImage.ImageLocation = clsGlobal.CurrentUser.PersonInfo.PersonalImagePath;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _LoadLoggedInUserInfo();
            btnDashboard.PerformClick();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if(_CheckUserPermissions(clsUser.enPermissions.enManageUsers))
                _ShowForm((Guna2Button)sender ,new frmListUsers());
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            if (_CheckUserPermissions(clsUser.enPermissions.enManageBooks))
                _ShowForm((Guna2Button)sender, new frmListBooks());
        }

        private void btnGenres_Click(object sender, EventArgs e)
        {
            _ShowForm((Guna2Button)sender, new frmListGenres());
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            _ShowForm((Guna2Button)sender, new frmListAuthors());
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            if (_CheckUserPermissions(clsUser.enPermissions.enManageMemebers))
                _ShowForm((Guna2Button)sender, new frmListMembers());
        }

        private void btnBorrowings_Click(object sender, EventArgs e)
        {
            if (_CheckUserPermissions(clsUser.enPermissions.enManageBooksBorrowings))
                _ShowForm((Guna2Button)sender, new frmListBorrowings());
        }

        private void btnFines_Click(object sender, EventArgs e)
        {
            if (_CheckUserPermissions(clsUser.enPermissions.enManageFines))
                _ShowForm((Guna2Button)sender, new frmListFines());
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            if (_CheckUserPermissions(clsUser.enPermissions.enManageBooksReservations))
                _ShowForm((Guna2Button)sender, new frmListReservations());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            _ShowForm((Guna2Button)sender, new frmDashboard());

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            _LoginForm.Show();
            this.Close();
        }

        private void btnShowUserProfile_Click(object sender, EventArgs e)
        {
            frmShowUserDetails frm = new frmShowUserDetails(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }
    }
}
