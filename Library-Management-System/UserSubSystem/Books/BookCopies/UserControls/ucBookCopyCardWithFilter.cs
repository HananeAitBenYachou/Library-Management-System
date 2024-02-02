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
    public partial class ucBookCopyCardWithFilter : UserControl
    {
        public event EventHandler<int?> BookCopyFound;

        protected virtual void OnBookCopyFound(int? bookcopyID)
        {
            BookCopyFound?.Invoke(this, bookcopyID);
        }

        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }

            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;

                if (!_FilterEnabled)
                    txtFilterValue.Validating -= txtFilterValue_Validating;
            }
        }

        public int? BookCopyID => ucBookCopyCard1.BookCopyID;

        public clsBookCopy BookCopy => ucBookCopyCard1.BookCopy;

        public ucBookCopyCardWithFilter()
        {
            InitializeComponent();
        }

        public void LoadBookCopyData(int? bookcopyID)
        {
            txtFilterValue.Text = bookcopyID.ToString();
            FilterEnabled = false;
            _FindBookCopy();
        }

        public void ResetBookCopyData()
        {
            FilterFocus();
            ucBookCopyCard1.ResetBookCopyData();
        }

        private void _FindBookCopy()
        {
            ucBookCopyCard1.LoadBookCopyData(int.Parse(txtFilterValue.Text.Trim()));

            if (BookCopyID.HasValue)
                OnBookCopyFound(ucBookCopyCard1.BookCopyID);
        }

        private void ucBookCopyCardWithFilter_Load(object sender, EventArgs e)
        {
            FilterFocus();
        }

        private void btnSearchForBookCopy_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Please enter the CopyID you want to search for !", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _FindBookCopy();
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This field is required , cannot be left blank !");
                return;
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFilterValue, null);
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        public void FilterFocus()
        {
            txtFilterValue.ResetText();
            txtFilterValue.Select();
        }
    }
}
