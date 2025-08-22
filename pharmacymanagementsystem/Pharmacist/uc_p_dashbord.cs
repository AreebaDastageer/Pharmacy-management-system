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
    public partial class uc_p_dashbord: UserControl
    {

        function fn = new function();
        String query;
        DataSet ds;
        Int64  count;
        public uc_p_dashbord()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void uc_p_dashbord_Load(object sender, EventArgs e)
        {
            LoadChart();
        }

        public void LoadChart()
        {
           /* query = "select count(mname) from medic where eDate >= getdate()";
    
            ds = fn.getData(query);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Valid medicine"].Points.AddXY("Medicine validity chart", count);*/
        }
    }
}
