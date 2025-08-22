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
    public partial class uc_p_UpdateMedicine: UserControl
    {
        function fn = new function();
        String query;
        public uc_p_UpdateMedicine()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtmedId.Text!="")
            {
                query="select * from medic where mid='"+txtmedId.Text+"'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count!=0){
                    txtmedName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtmedNo.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtMD.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtED.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtAQ.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtPP.Text = ds.Tables[0].Rows[0][6].ToString();

                }
                else
                {
                    MessageBox.Show("No medicine with ID: " + txtmedId.Text + "exitst. ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                clearAll();
            }
                
        }

        private void clearAll()
        {
            txtmedName.Clear();
            txtmedNo.Clear();
            txtMD.ResetText();
            txtED.ResetText();
            txtAQ.ResetText();
            txtPP.Clear();
            txtmedId.Clear();
            if (guna2TextBox6.Text != "0")
            {
                guna2TextBox6.Text = "0";
            }
            else
            {
                guna2TextBox6.Text = "0";
            }
        }

        private void txtmedName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRT_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        Int64 totalQuantity;
        private void btnUP_Click(object sender, EventArgs e)
        {
        String mname = txtmedId.Text;
        String mnumber = txtmedNo.Text;
            String mDate = txtMD.Text;
            String eDate = txtED.Text;
            Int64 quantity = Int64.Parse(txtAQ.Text);
            Int64 addQuantity = Int64.Parse(guna2TextBox6.Text);
            Int64 unitprice = Int64.Parse(guna2TextBox6.Text);

            totalQuantity = quantity + addQuantity;

            query = "update medic set mname='" + mname + "',mnumber='" + mnumber + "',mDate='" + mDate + "',eDate='" + eDate + "', quantity=" + totalQuantity + ",perunit=" + unitprice + " where mid ='"+txtmedId.Text+"'";
            fn.setData(query, "Medicine Details updated");


        }
    }
}
