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
    public partial class uc_p_ViewUser: UserControl
    {
        function fn = new function();
        String query;
        public uc_p_ViewUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void uc_p_ViewUser_Load(object sender, EventArgs e)
        {
            query = "select * from medic";
            DataSet ds = fn.getData(query);
            guna2DataGridView4.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from medic where mname like'" + txtSearch.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView4.DataSource = ds.Tables[0];
        }

        private void setDataGridView()
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView4.DataSource = ds.Tables[0];
        }
        String medicineID;
        private void guna2DataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineID = guna2DataGridView4.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) ;
            {
                query = "Delete from medic where mid = '" + medicineID + "'";
                fn.setData(query, "Medicine record deleted");
                uc_p_ViewUser_Load(this,null);
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            uc_p_ViewUser_Load(this, null);
        }
    }
}
