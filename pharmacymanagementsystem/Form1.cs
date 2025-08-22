using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace pharmacymanagementsystem
{
    public partial class Form1: Form
    {

        function fn = new function();
                
        String query;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Handle root user if DB is empty
            query = "SELECT * FROM users";
            ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                if (username == "root" && password == "root")
                {
                    Administrator admin = new Administrator();
                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                // Query to find user with username and password
                query = $"SELECT * FROM users WHERE username = '{username}' AND pass = '{password}'";
                ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    // FIX: Get the correct column index for Role (assuming it's at index 3)
                    string role = ds.Tables[0].Rows[0]["userRole"].ToString().ToLower();

                    if (role == "adminstrator")
                    {
                        Administrator admin = new Administrator();
                        admin.Show();
                        this.Hide();
                    }
                    else if (role == "pharmacist")
                    {
                        pharmacist pharm = new pharmacist();
                        pharm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Role not recognized.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }


























        /* if(txtUsername.Text=="Areeba" && txtPassword.Text == "pass")
          {
              Administrator am = new Administrator();
              am.Show();
              this.Hide();
          }
          else
          {
              MessageBox.Show("Wrong username OR password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }*/
    }
    }

