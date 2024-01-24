using Library_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Genres.UserControls
{
    public partial class ucGenreCard : UserControl
    {
        private int? _GenreID = null;

        private clsGenre _Genre = null;

        public int? GenreID => _GenreID;

        public clsGenre Genre => _Genre;

        public ucGenreCard()
        {
            InitializeComponent();
        }

        public void ResetGenreData()
        {
            _GenreID = null;

            lblGenreID.Text = "[????]";
            lblGenreName.Text = "[????]";
            lblDescription.Text = "[????]";
        }

        public void LoadGenreData(int? genreData)
        {
            _Genre = clsGenre.Find(genreData);

            if (_Genre == null)
            {
                MessageBox.Show($"No genre with ID = {genreData} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetGenreData();
                return;
            }

            _GenreID = _Genre.GenreID;

            lblGenreID.Text = _GenreID.ToString();
            lblGenreName.Text = _Genre.GenreName;
            lblDescription.Text = string.IsNullOrEmpty(_Genre.Description) ? "No description available !" : _Genre.Description;
        }

    }
}
