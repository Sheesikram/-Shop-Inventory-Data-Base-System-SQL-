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
    public partial class category : sample3
    {
        bool flag = false;
        int pid;
        OracleConnection con;
        public category()
        {
            InitializeComponent();
        }

        private void category_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521 / XE; USER ID = 21L-5430_project; PASSWORD = 123";
            con = new OracleConnection(conStr);
            updateGrid();
            cid.Enabled = false;
            name.Enabled = false;
        }
        private void updateGrid()
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = " SELECT* FROM category";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();//display
            DataTable empDT = new DataTable();//get data from datatable
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }

        public override void button1_Click(object sender, EventArgs e)
        {
            cid.Clear();
            name.Clear();
            name.Enabled = true;
        }

        public override void button2_Click(object sender, EventArgs e)
        {
            flag = true;
            name.Enabled = true;
            cid.Enabled = true;
        }

        public override void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "DELETE FROM category WHERE cid = :cid";

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
          
            name.Clear();
            cid.Clear(); 
            name.Enabled = false;
        }

        public override void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag == false)////insert
                {
                    con.Open();
                    OracleCommand insertEmp = con.CreateCommand();
                    insertEmp.CommandText = " INSERT INTO category (name)VALUES('" + name.Text + "')";
                    insertEmp.CommandType = CommandType.Text;
                    int rows = insertEmp.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show(" Data Inserted Successfully! ");
                    }
                    con.Close();
                    updateGrid();

                  
                    name.Clear();
                    cid.Clear();
                    name.Enabled = false;
                   
                }
                else///update
                {
                    con.Open();

                    string sql = "UPDATE category SET cid = :cid ,name = :name WHERE cid = :cid";

                    // create an OracleCommand object with the SQL statement and connection
                    OracleCommand cmd = new OracleCommand(sql, con);

                    // add parameter values from the textboxes
                    cmd.Parameters.Add(":cid", OracleDbType.Int32).Value = Convert.ToInt32(cid.Text);
                    cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = name.Text;

                    // execute
                    int rows = cmd.ExecuteNonQuery();

                    con.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show(" Data Updated Successfully! ");
                    }


                    con.Close();
                    updateGrid();
                    
                    name.Clear();
                    cid.Clear();


                    name.Enabled = false;
                    flag = false;
                }
            }
            catch
            {

            }
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
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
         

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            rack obj5 = new rack();
            main.showWindow(obj5, this, mdi.ActiveForm);

        }
    }
}
