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

namespace LibraryManagementSystem.Books.BookCopies
{
    public partial class ucBookCopyCard : UserControl
    {
        private int? _BookCopyID = null;

        private clsBookCopy _BookCopy = null;

        public int? BookCopyID => _BookCopyID;

        public clsBookCopy BookCopy => _BookCopy;

        public ucBookCopyCard()
        {
            InitializeComponent();
        }

        public void ResetBookCopyData()
        {
            _BookCopyID = null;

            lblBookCopyID.Text = "[????]";
            lblStatus.Text = "[????]";

            ucBookCard1.ResetBookData();
        }

        public void LoadBookCopyData(int? bookCopyID)
        {
            _BookCopy = clsBookCopy.Find(bookCopyID);

            if (_BookCopy == null)
            {
                MessageBox.Show($"No book copy with copyID = {bookCopyID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetBookCopyData();
                return;
            }

            _BookCopyID = _BookCopy.BookCopyID;

            lblBookCopyID.Text = _BookCopy.BookCopyID.ToString();
            lblStatus.Text = _BookCopy.AvailabilityStatusText;

            ucBookCard1.LoadBookData(_BookCopy.BookID);
        }

    }
}
