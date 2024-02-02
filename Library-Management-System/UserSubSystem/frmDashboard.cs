using Library_BusinessLayer;
using LibraryManagementSystem.Books;
using LibraryManagementSystem.GlobalClasses;
using LibraryManagementSystem.MemberSubSystem.Books.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LibraryManagementSystem.UserSubSystem
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void _LoadChartData()
        {
            Series serie = chart1.Series["BooksStatus"];

            serie.Points[0].SetValueY(clsBook.GetBooksCountPerStatus(clsBook.enBookStatus.Borrowed));
            serie.Points[1].SetValueY(clsBook.GetBooksCountPerStatus(clsBook.enBookStatus.Available));

            serie.Points[0].Color = ColorTranslator.FromHtml("#2d6e64");
            serie.Points[1].Color = ColorTranslator.FromHtml("#f7bf90");

        }

        private void _LoadBooksList()
        {
            foreach (DataRow row in clsBook.GetAllBooks().Rows)
            {
                ucBook bookControl = new ucBook();

                bookControl.LoadBookDetails((int?)row["Book ID"]);

                flowLayoutPanel1.Controls.Add(bookControl);
            }
        }

        private void _LoadDashboardData()
        {
            lblGreeting.Text = $"Welcome Back {clsGlobal.CurrentUser.UserName} !";

            lblUsersCount.Text = clsUser.GetUsersCount().ToString();
            lblMembersCount.Text = clsMember.GetMembersCount().ToString();
            lblBorrowingsCount.Text = clsBorrowingRecord.GetBorrowingsCount().ToString();
            lblReturnsCount.Text = clsBorrowingRecord.GetReturnsCount().ToString();
            lblBooksCount.Text = clsBook.GetBooksCount().ToString();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            _LoadChartData();
            _LoadDashboardData();
            Parallel.Invoke(_LoadBooksList);
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            frmAddUpdateBook frm = new frmAddUpdateBook();
            frm.ShowDialog();
        }
    }
}
