using Library_BusinessLayer;
using LibraryManagementSystem.Genres.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Fines
{
    public partial class frmShowFineDetails : Form
    {
        private int? _FineID = null;

        public frmShowFineDetails(int? fineID)
        {
            InitializeComponent();
            _FineID = fineID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowFineDetails_Load(object sender, EventArgs e)
        {
            if (!clsFine.IsFineExist(_FineID))
            {
                MessageBox.Show($"No fine with ID = {_FineID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ucFineDetails1.LoadFineDetails(_FineID);
        }
    }
}
