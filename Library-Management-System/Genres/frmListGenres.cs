using Library_BusinessLayer;
using LibraryManagementSystem.Authors;
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

namespace LibraryManagementSystem.Genres
{
    public partial class frmListGenres : Form
    {
        private DataView _GenresDataView;

        public frmListGenres()
        {
            InitializeComponent();
        }

        private void _RefreshGenresList()
        {
            _GenresDataView = clsGenre.GetAllGenres().DefaultView;
            dgvGenresList.DataSource = _GenresDataView;
            cbFilterByOptions.SelectedIndex = 0;
        }

        private void _FilterGenresList()
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text))
            {
                _GenresDataView.RowFilter = null;
                return;
            }

            if (cbFilterByOptions.Text == "Genre ID")
            {
                _GenresDataView.RowFilter = string.Format("[{0}] = {1}", cbFilterByOptions.Text, txtFilterValue.Text.Trim());
            }

            else
            {
                _GenresDataView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", cbFilterByOptions.Text, txtFilterValue.Text.Trim());
            }
        }

        private void frmListGenres_Load(object sender, EventArgs e)
        {
            _RefreshGenresList();
        }

        private void dgvGenresList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvGenresList.Columns)
            {
                column.Width = 300;
            }

            dgvGenresList.Columns[dgvGenresList.ColumnCount - 1].Width = 600;
        }

        private void cbFilterByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterByOptions.Text != "None");
            txtFilterValue.ResetText();
            txtFilterValue.Focus();
            txtFilterValue_TextChanged(null, null);
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _FilterGenresList();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterByOptions.Text == "Genre ID")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            frmAddUpdateGenre frm = new frmAddUpdateGenre();
            frm.ShowDialog();
            _RefreshGenresList();
        }

        private void AddGenretoolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddGenre.PerformClick();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowGenreDetails frm = new frmShowGenreDetails((int)dgvGenresList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this genre ?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int genreID = (int)dgvGenresList.CurrentRow.Cells[0].Value;

            if (!clsGenre.IsGenreExist(genreID))
            {
                MessageBox.Show($"No genre with ID = {genreID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsGenre.DeleteGenre(genreID))
            {
                MessageBox.Show("Genre has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshGenresList();
            }

            else
                MessageBox.Show("Genre is not deleted due to data connected to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateGenre frm = new frmAddUpdateGenre((int)dgvGenresList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshGenresList();
        }

    }
}
