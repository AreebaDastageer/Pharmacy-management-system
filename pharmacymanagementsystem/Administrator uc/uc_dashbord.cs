using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacymanagementsystem.Administrator_uc
{
    public partial class uc_dashbord: UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public uc_dashbord()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void uc_dashbord_Load(object sender, EventArgs e)
        {
            query = "select count(userRole) from users where userRole = 'Adminstrator'";
            ds = fn.getData(query);
            setlabel(ds, Adminlabel);

            query = "select  count(userRole) from users where userRole = 'pharmacist'";
            ds = fn.getData(query);
            setlabel(ds, Pharmlabel);
        }

        private void setlabel(DataSet ds,Label lbl)
        {
            if (ds.Tables[0].Rows.Count!= 0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();

            }
            else
            {
                lbl.Text = "0";
            }
        }

        private void Pharmlabel_Click(object sender, EventArgs e)
        {

        }

        private void btnsync_Click(object sender, EventArgs e)
        {
            uc_dashbord_Load(this, null);
        }
    }
}
