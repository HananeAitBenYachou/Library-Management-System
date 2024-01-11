using Library_BusinessLayer;
using LibraryManagementSystem.People.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Books
{
    public partial class frmShowBookDetails : Form
    {
        private int? _BookID = null;

        public frmShowBookDetails(int? bookID)
        {
            InitializeComponent();
            _BookID = bookID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowBookDetails_Load(object sender, EventArgs e)
        {
            if (!clsBook.IsBookExist(_BookID))
            {
                MessageBox.Show($"No book with ID = {_BookID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ucBookCard1.LoadBookData(_BookID);
        }

    }
}
