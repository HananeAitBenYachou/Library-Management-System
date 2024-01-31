﻿using Guna.UI2.WinForms;
using LibraryManagementSystem.MemberSubSystem;
using LibraryManagementSystem.MemberSubSystem.Books;
using LibraryManagementSystem.MemberSubSystem.Fines;
using LibraryManagementSystem.MemberSubSystem.Reservations;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmMemberMain : Form
    {
        private Form _LoginForm = null;

        private Guna2Button _CurrentActiveButton = new Guna2Button();

        public frmMemberMain(Form loginForm)
        {
            InitializeComponent();
            _LoginForm = loginForm;
        }

        private void _ShowForm(Guna2Button activeBtn, Form frm)
        {
            if (_CurrentActiveButton != null)
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

        private void btnBooks_Click(object sender, EventArgs e)
        {
            _ShowForm((Guna2Button)sender, new frmListBooks());
        }

        private void btnBorrowings_Click(object sender, EventArgs e)
        {
            _ShowForm((Guna2Button)sender, new frmListMemberBorrowings());
        }

        private void btnFines_Click(object sender, EventArgs e)
        {
            _ShowForm((Guna2Button)sender, new frmListMemberFines());
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            _ShowForm((Guna2Button)sender, new frmListMemberReservations());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            _LoginForm.Show();
            this.Close();
        }

        private void frmMemberMain_Load(object sender, EventArgs e)
        {
            btnBooks.PerformClick();
        }
    }
}