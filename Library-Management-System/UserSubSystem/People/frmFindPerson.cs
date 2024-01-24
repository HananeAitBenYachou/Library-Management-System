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
    public partial class frmFindPerson : Form
    {
        public event EventHandler<int?> PersonFound;

        protected virtual void OnPersonFound()
        {
            PersonFound?.Invoke(this, ucPersonCardWithFilter1.PersonID);
        }

        public frmFindPerson()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            OnPersonFound();
            this.Close();
        }

        private void frmFindPerson_Load(object sender, EventArgs e)
        {
            ucPersonCardWithFilter1.FilterEnabled = true;
        }

    }
}
