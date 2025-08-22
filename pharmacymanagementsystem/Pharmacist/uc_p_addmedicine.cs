using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacymanagementsystem.Pharmacist
{
    public partial class uc_p_addmedicine: UserControl
    {
        function fn = new function();
        String query;
        public uc_p_addmedicine()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMedID.Text != "" && guna2TextBox1.Text != "" && txtMedNo.Text != "" && txtQuantity.Text != "" && txtExpireDate.Text != "")
            {
                String mid = txtMedID.Text;
                String mname = guna2TextBox1.Text;
                String mnumber = txtMedNo.Text;       
                String mDate = txtManufacturingDate.Text;
                String eDate = txtPricePerUnit.Text;
               Int64 quantity = Int64.Parse(txtQuantity.Text);
                Int64 perunit = Int64.Parse(txtExpireDate.Text);
                
                   query = "insert into medic (mid,mname,mnumber,mDate,eDate,quantity,perunit) values ('"+mid+"' , '"+mname+"' , '"+mnumber+"' , '"+mDate+"' , '"+eDate+"' , "+quantity+" , "+perunit+")";
                fn.setData(query, "Medicine added to the database");

            }
            else
            {
                MessageBox.Show("Enter all data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtMedID.Clear();
            guna2TextBox1.Clear();
            txtMedNo.Clear();
            txtManufacturingDate.ResetText();
            txtPricePerUnit.ResetText();
            txtQuantity.Clear();
            txtExpireDate.Clear();




        }
    }
}
