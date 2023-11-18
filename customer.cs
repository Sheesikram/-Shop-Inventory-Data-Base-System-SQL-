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
    public partial class customer : sample3
    {
        bool flag = false;
        int pid;
        OracleConnection con;
        public customer()
        {
            InitializeComponent();
        }

        private void customer_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521 / XE; USER ID = 21L-5430_project; PASSWORD = 123";
            con = new OracleConnection(conStr);
           updateGrid();
            cid.Enabled = false;
            name.Enabled = false;
            phone_no.Enabled = false;
            address.Enabled = false;

        }
        private void updateGrid()
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = " SELECT* FROM customer";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();//display
            DataTable empDT = new DataTable();//get data from datatable
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        public override void button1_Click(object sender, EventArgs e)
        {

            cid.Clear();
            name.Clear();
            phone_no.Clear();
            address.Clear();


            cid.Enabled = true;
            name.Enabled = true;
            phone_no.Enabled = true;
            address.Enabled=true;


        }

        public override void button2_Click(object sender, EventArgs e)
        {
            flag = true;
            cid.Enabled = true;
            name.Enabled = true;
            phone_no.Enabled = true;
            address.Enabled = true;
           
          

        }

        public override void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "DELETE FROM customer WHERE customer_id = :cid";

            // create an OracleCommand object with the SQL statement and connection
            OracleCommand cmd = new OracleCommand(sql, con);

            // add parameter values from the textbox
            cmd.Parameters.Add(":cid", OracleDbType.Int32).Value = Convert.ToInt32(cid.Text);

            // execute the SQL statement
            int rows = cmd.ExecuteNonQuery();

            // close the database connection
            con.Close();
            MessageBox.Show("Record deleted successfully");
            updateGrid();
            cid.Clear();
            name.Clear();
            phone_no.Clear();
            address.Clear();

            cid.Enabled = false;
            name.Enabled = false;
            phone_no.Enabled = false;
            address.Enabled = false;


        }

        public override void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag == false)////insert
                {
                    con.Open();
                   OracleCommand insertEmp = con.CreateCommand();
                    insertEmp.CommandText = " INSERT INTO customer VALUES('" + cid.Text + "','" + name.Text + "','" + phone_no.Text + "','" +address.Text + "')";
                    insertEmp.CommandType = CommandType.Text;
                    int rows = insertEmp.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show(" Data Inserted Successfully! ");
                    }
                    con.Close();
                     updateGrid();

                    cid.Clear();
                    name.Clear();
                    phone_no.Clear();
                    address.Clear();


                    cid.Enabled = false;
                    name.Enabled = false;
                    phone_no.Enabled = false;
                    address.Enabled = false;
                }
                else///update
                {
                    con.Open();

                    string sql = "UPDATE customer SET customer_id = :cid ,name = :name,  phone_no= :phone_no,  address = :address WHERE customer_id = :cid";

                    // create an OracleCommand object with the SQL statement and connection
                    OracleCommand cmd = new OracleCommand(sql, con);

                    // add parameter values from the textboxes
                    cmd.Parameters.Add(":cid", OracleDbType.Int32).Value = Convert.ToInt32(cid.Text);
                    cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = name.Text;
                    cmd.Parameters.Add(":phone_no", OracleDbType.Int32).Value = phone_no.Text;
                    cmd.Parameters.Add(":address", OracleDbType.Varchar2).Value = address.Text;
                 
                    // execute
                    int rows = cmd.ExecuteNonQuery();

                    con.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show(" Data Updated Successfully! ");
                    }


                    con.Close();
                    updateGrid();
                    cid.Clear();
                    name.Clear();
                    phone_no.Clear();
                    address.Clear();
                    cid.Enabled = false;
                    name.Enabled = false;
                    phone_no.Enabled = false;
                    address.Enabled = false;
                    flag = false;
                }
            }
            catch
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];///getting pid from where
                pid = Convert.ToInt32(row.Cells[0].Value.ToString());
                cid.Text = row.Cells[0].Value.ToString();
                name.Text = row.Cells[1].Value.ToString();
                phone_no.Text = row.Cells[2].Value.ToString();
                address.Text = row.Cells[3].Value.ToString();               
               
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

             main_screen  obj3 = new main_screen();
            main.showWindow(obj3, this, mdi.ActiveForm);
        }
    }
}
