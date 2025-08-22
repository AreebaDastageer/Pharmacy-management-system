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
    public partial class pharmacist: Form
    {
        public pharmacist()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uc_p_UpdateMedicine1.Visible = true;
            uc_p_UpdateMedicine1.BringToFront();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
           fm.Show();
            this.Hide();
        }

        private void btndashbord_Click(object sender, EventArgs e)
        {
            uc_p_dashbord1.Visible= true;
            uc_p_dashbord1.BringToFront();
        }

        private void pharmacist_Load(object sender, EventArgs e)
        {
            uc_p_dashbord1.Visible = false;
            uc_p_ViewUser1.Visible = false;
            uc_p_addmedicine1.Visible = false;
            uc_p_UpdateMedicine1.Visible = false;
            btndashbord.PerformClick();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uc_p_addmedicine1.Visible= true;
            uc_p_addmedicine1.BringToFront();
        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            uc_p_ViewUser1.Visible = true;
            uc_p_ViewUser1.BringToFront();
        }
    }
}
