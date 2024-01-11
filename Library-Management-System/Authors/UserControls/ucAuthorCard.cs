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

namespace LibraryManagementSystem.Authors.UserControls
{
    public partial class ucAuthorCard : UserControl
    {
        private int? _AuthorID = null;

        private clsAuthor _Author = null;

        public int? AuthorID => _AuthorID;

        public clsAuthor Author => _Author;

        public ucAuthorCard()
        {
            InitializeComponent();
        }

        public void ResetAuthorData()
        {
            _AuthorID = null;

            lblAuthorID.Text = "[????]";
            lblFullName.Text = "[????]";
            lblBiography.Text = "[????]";     
            lblCountry.Text = "[????]";
        }

        public void LoadAuthorData(int? authorData)
        {
            _Author = clsAuthor.Find(authorData);

            if (_Author == null)
            {
                MessageBox.Show($"No author with ID = {authorData} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetAuthorData();
                return;
            }

            _AuthorID = _Author.AuthorID;

            lblAuthorID.Text = _AuthorID.ToString();
            lblFullName.Text = _Author.FullName;
            lblBiography.Text = string.IsNullOrEmpty(_Author.Biography) ? "No biography available !" : _Author.Biography;
            lblCountry.Text = _Author.CountryInfo.CountryName;
        }
    }
}
