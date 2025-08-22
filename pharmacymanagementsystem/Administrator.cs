using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacymanagementsystem
{
    public partial class Administrator: Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            uc_dashbord1.Visible = true;
            uc_dashbord1.BringToFront();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            uc_dashbord1.Visible = false;
            uc_adduser1.Visible = false;
            btnDashbord.PerformClick();


        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            uc_adduser1.Visible = true;
            uc_adduser1.BringToFront();
        }
    }
}
