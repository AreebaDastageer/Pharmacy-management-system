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
    public partial class uc_adduser: UserControl
    {

        function fn = new function();
        String query;
        public uc_adduser()
        {
            InitializeComponent();
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            String role = gunaComboBox1.Text;
            String name = txtname.Text;
            String dob = txtDOB.Text;
            Int64 mobile = Int64.Parse(txtmobileno.Text);
            String email = txtemail.Text;
            String username = txtusername.Text;
            String pass = txtpassword.Text;
            try
            {
                query= "insert into users (userRole,name,dob,mobile,email,username,pass) values ('"+role+"', '"+name+"', '"+dob+"', '"+mobile+"', '"+email+"', '"+username+"', '"+pass+"')";
                fn.setData (query, "Sign up successful.");
            }
            catch(Exception)
            {
                MessageBox.Show("Username already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {

        }
        
        public void clearAll()
        {
            txtname.Clear();
            txtDOB.ResetText();
            txtmobileno.Clear();
            txtemail.Clear();
            txtusername.Clear();
            txtpassword.Clear();
            gunaComboBox1.SelectedIndex = -1;



        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username = '" + txtusername.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.ImageLocation = "@D:\\Areeba\\icons\\yes.png";
            }
            else
            {
                pictureBox1.ImageLocation = "@D:\\Areeba\\icons\\no.png";
            }
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
