using Library_BusinessLayer;
using LibraryManagementSystem.Books.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Books.BookCopies
{
    public partial class frmShowBookCopyDetails : Form
    {
        private int? _BookCopyID = null;

        public frmShowBookCopyDetails(int? bookcopyID)
        {
            InitializeComponent();
            _BookCopyID = bookcopyID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowBookCopyDetails_Load(object sender, EventArgs e)
        {
            if (!clsBook.IsBookExist(_BookCopyID))
            {
                MessageBox.Show($"No bookcopy with ID = {_BookCopyID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ucBookCopyCard1.LoadBookCopyData(_BookCopyID);
        }
    }
}
