using Guna.UI2.WinForms;
using LibraryManagementSystem.Authors;
using LibraryManagementSystem.Books;
using LibraryManagementSystem.Borrowings_Returns;
using LibraryManagementSystem.Fines;
using LibraryManagementSystem.Genres;
using LibraryManagementSystem.Members;
using LibraryManagementSystem.Reservations;
using LibraryManagementSystem.Users;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmMain : Form
    {
        private Guna2Button _CurrentActiveButton = new Guna2Button(); 

        public frmMain()
        {
            InitializeComponent();
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

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            _ShowForm((Guna2Button)sender ,new frmListUsers());
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
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
            _ShowForm((Guna2Button)sender, new frmListMembers());
        }

        private void btnBorrowings_Click(object sender, EventArgs e)
        {
            _ShowForm((Guna2Button)sender, new frmListBorrowings());

        }

        private void btnFines_Click(object sender, EventArgs e)
        {
            _ShowForm((Guna2Button)sender, new frmListFines());

        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            _ShowForm((Guna2Button)sender, new frmListReservations());
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {

        }
    }
}
