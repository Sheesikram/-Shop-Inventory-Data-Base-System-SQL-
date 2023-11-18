using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace final_project_DB
{
    public partial class lvl : sample
    {
        OracleConnection con;
        public lvl()
        {
            InitializeComponent();
        }

        private void lvl_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521 / XE; USER ID = 21L-5430_project; PASSWORD = 123";
            con = new OracleConnection(conStr);
            updateGrid();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void updateGrid()
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = " select p.product_id,p.product_name,c.name as category,p.category as cid,p.quantity as stock_avilable,p.BARCODE from product p,category c where p.category = c.cid ";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();//display
            DataTable empDT = new DataTable();//get data from datatable
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rack obj = new rack();
            main.showWindow(obj, this, mdi.ActiveForm);
        }
    }
}
