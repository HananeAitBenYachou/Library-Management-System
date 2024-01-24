using Library_BusinessLayer;
using LibraryManagementSystem.Books;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Authors
{
    public partial class frmListAuthors : Form
    {
        private DataView _AuthorsDataView;

        public frmListAuthors()
        {
            InitializeComponent();
        }

        private async void _FillCountriesInComboBoxAsync()
        {
            await Task.Run(() =>
            {
                foreach (DataRow row in clsCountry.GetAllCountries().Rows)
                {
                    cbCountries.Invoke((Action)(() => cbCountries.Items.Add((string)row["CountryName"])));
                }

            });
        }

        private void _RefreshAuthorsList()
        {
            _AuthorsDataView = clsAuthor.GetAllAuthors().DefaultView;
            dgvAuthorsList.DataSource = _AuthorsDataView;
            cbFilterByOptions.SelectedIndex = 0;
        }

        private void _FilterAuthorsList()
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                _AuthorsDataView.RowFilter = null;
                return;
            }

            if (cbFilterByOptions.Text == "Author ID")
            {
                _AuthorsDataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, txtFilterValue.Text.Trim());
            }

            else
            {
                _AuthorsDataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text.Trim());
            }
        }

        private void frmListAuthors_Load(object sender, EventArgs e)
        {
            _FillCountriesInComboBoxAsync();

            _RefreshAuthorsList();
        }

        private void dgvAuthorsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvAuthorsList.Columns)
            {
                column.Width = 250;
            }

            dgvAuthorsList.Columns[dgvAuthorsList.ColumnCount - 1].Width = 500;
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterByOptions.Text == "Nationality")
            {
                txtFilterValue.Visible = false;
                cbCountries.Visible = true;
                cbCountries.SelectedIndex = 0;
            }

            else
            {
                txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
                txtFilterValue.ResetText();
                txtFilterValue.Focus();
                cbCountries.Visible = false;
                txtFilterValue_TextChanged(null, null);
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterAuthorsList();
        }

        private void cbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            _AuthorsDataView.RowFilter =
                       string.Format("[{0}] = '{1}'", cbFilterByOptions.Text, cbCountries.Text);
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text == "Author ID")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            frmAddUpdateAuthor frm = new frmAddUpdateAuthor();
            frm.ShowDialog();
            _RefreshAuthorsList();
        }

        private void AddAuthortoolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddAuthor.PerformClick();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowAuthorDetails frm = new frmShowAuthorDetails((int)dgvAuthorsList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this author ?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int authorID = (int)dgvAuthorsList.CurrentRow.Cells[0].Value;

            if (!clsAuthor.IsAuthorExist(authorID))
            {
                MessageBox.Show($"No author with ID = {authorID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsAuthor.DeleteAuthor(authorID))
            {
                MessageBox.Show("Author has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshAuthorsList();
            }

            else
                MessageBox.Show("Author is not deleted due to data connected to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateAuthor frm = new frmAddUpdateAuthor((int)dgvAuthorsList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshAuthorsList();
        }

    }
}
