using Library_BusinessLayer;
using LibraryManagementSystem.Authors.UserControls;
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
    public partial class frmShowGenreDetails : Form
    {
        private int? _GenreID = null;

        public frmShowGenreDetails(int? genreID)
        {
            InitializeComponent();
            _GenreID = genreID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowGenreDetails_Load(object sender, EventArgs e)
        {
            if (!clsGenre.IsGenreExist(_GenreID))
            {
                MessageBox.Show($"No genre with ID = {_GenreID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ucGenreCard1.LoadGenreData(_GenreID);
        }

    }
}
