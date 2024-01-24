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

namespace LibraryManagementSystem.Authors
{
    public partial class frmShowAuthorDetails : Form
    {
        private int? _AuthorID = null;

        public frmShowAuthorDetails(int? authorID)
        {
            InitializeComponent();
            _AuthorID = authorID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowAuthorDetails_Load(object sender, EventArgs e)
        {
            if (!clsAuthor.IsAuthorExist(_AuthorID))
            {
                MessageBox.Show($"No author with ID = {_AuthorID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ucAuthorCard1.LoadAuthorData(_AuthorID);
        }

    }
}
