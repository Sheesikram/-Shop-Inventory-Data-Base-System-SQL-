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
    public partial class account : sample
    {
        OracleConnection con;
        public account()
        {
            InitializeComponent();
        }

        private void account_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521 / XE; USER ID = 21L-5430_project; PASSWORD = 123";
            con = new OracleConnection(conStr);
            textBox1.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void updateGrid()
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = " SELECT * FROM account";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();//display
            DataTable empDT = new DataTable();//get data from datatable
            empDT.Load(empDR);
            dataGridView2.DataSource = empDT;

            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            updateGrid();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = " SELECT sum(expense) FROM account";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();//display
            if (empDR.Read())
            {
                textBox4.Text = empDR.GetDecimal(0).ToString(); // get the value of the first column as a decimal and convert it to a string
            }
            else
            {
                textBox4.Text = ""; // no rows returned, set the textbox to empty
            }
            OracleCommand getEmp = con.CreateCommand();
            getEmp.CommandText = " SELECT sum(revenue) FROM account";
            getEmp.CommandType = CommandType.Text;
            OracleDataReader empD = getEmp.ExecuteReader();//display
            if (empD.Read())
            {
                textBox1.Text = empD.GetDecimal(0).ToString(); // get the value of the first column as a decimal and convert it to a string
            }
            else
            {
                textBox1.Text = ""; // no rows returned, set the textbox to empty
            }
            OracleCommand getEms = con.CreateCommand();
            getEms.CommandText = " SELECT sum(profit) FROM account";
            getEms.CommandType = CommandType.Text;
            OracleDataReader emp = getEms.ExecuteReader();//display
            if (emp.Read())
            {
                textBox5.Text = emp.GetDecimal(0).ToString(); // get the value of the first column as a decimal and convert it to a string
            }
            else
            {
                textBox5.Text = ""; // no rows returned, set the textbox to empty
            }

            con.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            main_screen obj = new main_screen();
            main.showWindow(obj, this, mdi.ActiveForm);
        }
    }
}
