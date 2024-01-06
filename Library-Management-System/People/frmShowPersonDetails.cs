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

namespace LibraryManagementSystem.People
{
    public partial class frmShowPersonDetails : Form
    {
        private int? _PersonID = null;

        public frmShowPersonDetails(int? personID)
        {
            InitializeComponent();
            _PersonID = personID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowPersonDetails_Load(object sender, EventArgs e)
        {
            if (!clsPerson.IsPersonExist(_PersonID))
            {
                MessageBox.Show($"No person with ID = {_PersonID} was found in the system !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ucPersonCard1.LoadPersonData(_PersonID);
        }

    }
}
