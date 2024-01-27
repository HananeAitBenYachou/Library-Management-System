using Library_BusinessLayer;
using LibraryManagementSystem.Members;
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
    public partial class frmListBooks : Form
    {
        private DataView _BooksDataView;

        public frmListBooks()
        {
            InitializeComponent();
        }

        private async void _FillGenresInComboBoxAsync()
        {
            await Task.Run(() =>
            {
                foreach (DataRow row in clsGenre.GetAllGenres().Rows)
                {
                    cbGenre.Invoke((Action)(() => cbGenre.Items.Add((string)row["Genre Name"])));
                }

            });                 
        }

        private void _RefreshBooksList()
        {
            _BooksDataView = clsBook.GetAllBooks().DefaultView;
            dgvBooksList.DataSource = _BooksDataView;
            cbFilterByOptions.SelectedIndex = 0;
        }

        private void _FilterBooksList()
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                _BooksDataView.RowFilter = null;
                return;
            }

            if (cbFilterByOptions.Text == "Book ID" || cbFilterByOptions.Text == "Quantity")
            {
                _BooksDataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, txtFilterValue.Text.Trim());
            }

            else
            {
                _BooksDataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text.Trim());
            }
        }

        private void frmListBooks_Load(object sender, EventArgs e)
        {
            _FillGenresInComboBoxAsync();

            _RefreshBooksList();
        }

        private void dgvBooksList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvBooksList.Columns)
            {
                column.Width = 150;
            }

            dgvBooksList.Columns["Title"].Width = 200;
            dgvBooksList.Columns[dgvBooksList.ColumnCount-1].Width = 500;
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterByOptions.Text == "Genre")
            {
                txtFilterValue.Visible = false;
                cbGenre.Visible = true;
                cbGenre.SelectedIndex = 0;
            }

            else
            {
                txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
                txtFilterValue.ResetText();
                txtFilterValue.Focus();
                cbGenre.Visible = false;
                txtFilterValue_TextChanged(null, null);
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterBooksList();
        }

        private void cbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbGenre.Text)
            {
                case "All":
                    _BooksDataView.RowFilter = null;
                    return;
                default:
                    _BooksDataView.RowFilter =
                        string.Format("[{0}] = '{1}'", cbFilterByOptions.Text, cbGenre.Text);
                    break;
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text == "Book ID" || cbFilterByOptions.Text == "Quantity")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            frmAddUpdateBook frm = new frmAddUpdateBook();
            frm.ShowDialog();
            _RefreshBooksList();
        }

        private void AddBooktoolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddBook.PerformClick();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowBookDetails frm = new frmShowBookDetails((int)dgvBooksList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this book ?", "Confrim",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int BookID = (int)dgvBooksList.CurrentRow.Cells[0].Value;

            if (!clsBook.IsBookExist(BookID))
            {
                MessageBox.Show($"No book with ID = {BookID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsBook.DeleteBook(BookID))
            {
                MessageBox.Show("Book has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshBooksList();
            }

            else
                MessageBox.Show("Book is not deleted due to data connected to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateBook frm = new frmAddUpdateBook((int)dgvBooksList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshBooksList();
        }

        private void addNewCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to add new copy of this book ?", "Confirm",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            clsBook book = clsBook.Find((int)dgvBooksList.CurrentRow.Cells[0].Value);

            if (!clsBook.IsBookExist(book.BookID))
            {
                MessageBox.Show($"No book with ID = {book.BookID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int? copyID = book.AddCopy();

            if (copyID.HasValue)
            {
                MessageBox.Show($"A new copy of this book has been added successfully with copyID : {copyID}", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshBooksList();
            }

            else
                MessageBox.Show("Error occured during this operation", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void showBookCopiesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowBookCopies frm = new frmShowBookCopies((int)dgvBooksList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshBooksList();
        }

    }
}
