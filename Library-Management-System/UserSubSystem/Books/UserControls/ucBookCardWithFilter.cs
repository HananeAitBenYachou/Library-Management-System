using Library_BusinessLayer;
using LibraryManagementSystem.People.UserControls;
using LibraryManagementSystem.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Books.UserControls
{
    public partial class ucBookCardWithFilter : UserControl
    {
        public event EventHandler<int?> BookFound;

        protected virtual void OnBookFound(int? bookID)
        {
            BookFound?.Invoke(this, bookID);
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

        public int? BookID => ucBookCard1.BookID;

        public clsBook Book => ucBookCard1.Book;

        public ucBookCardWithFilter()
        {
            InitializeComponent();
        }

        public void LoadBookData(int? bookID)
        {
            FilterEnabled = false;
            txtFilterValue.Text = bookID.ToString();
            _FindBook();
        }

        public void ResetBookData()
        {
            cbFilterByOptions.SelectedIndex = 0;
            FilterFocus();
            ucBookCard1.ResetBookData();
        }

        private void _FindBook()
        {
            switch (cbFilterByOptions.Text)
            {
                case "Book ID":
                    ucBookCard1.LoadBookData(int.Parse(txtFilterValue.Text.Trim()));
                    break;
                case "ISBN":
                    ucBookCard1.LoadBookData(txtFilterValue.Text.Trim());
                    break;
            }
        }

        private void ucBookCardWithFilter_Load(object sender, EventArgs e)
        {
            FilterFocus();
        }

        private void btnSearchForBook_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Please enter the Book's BookID/ISBN you want to search for !", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _FindBook();

            if (FilterEnabled && BookID.HasValue)
                OnBookFound(ucBookCard1.BookID);
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            frmAddUpdateBook frm = new frmAddUpdateBook();
            frm.BookAdded += _HandleNewBookAdded;
            frm.ShowDialog();
        }

        private void _HandleNewBookAdded(object sender, int? bookID)
        {
            cbFilterByOptions.SelectedIndex = 0;
            txtFilterValue.Text = bookID.ToString();
            btnSearchForBook.PerformClick();
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
            if (cbFilterByOptions.Text == "Book ID")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        public void FilterFocus()
        {
            txtFilterValue.ResetText();
            txtFilterValue.Select();
        }

    }
}
