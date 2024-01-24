using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmMemberMain : Form
    {
        private Form _LoginForm; 
        public frmMemberMain(Form loginForm)
        {
            InitializeComponent();
            _LoginForm = loginForm;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            _LoginForm.Show();
            this.Close();
        }
    }
}
