using Library_BusinessLayer;
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

namespace LibraryManagementSystem.MemberSubSystem.Books
{
    public partial class frmListBooks : Form
    {
        public frmListBooks()
        {
            InitializeComponent();
            Parallel.Invoke(_RefreshBooksList);
        }

        private void _RefreshBooksList()
        {
            foreach (DataRow row in
                clsBook.GetAllAvailbleBooksForMember(clsGlobal.CurrentMember.MemberID).Rows)
            {
                ucBook bookControl = new ucBook();
           
                bookControl.LoadBookDetails((int?)row["BookID"]);

                bookControl.Margin = new Padding(40,0,40,0);

                flowLayoutPanel1.Controls.Add(bookControl);
            }         
        }

    }
}
