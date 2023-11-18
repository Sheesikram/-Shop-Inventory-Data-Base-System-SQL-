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
    public partial class login_page:sample

    { 
        OracleConnection con;
        public login_page()
        {
            InitializeComponent();
        }

        private void login_page_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (user.Text == "" || pass.Text == "")
            {
                MessageBox.Show("fields are not filled correctly");
                // main.check_try("fields are not filled correctly", "stop", false);
            }
            else
            {

                main_screen m = new main_screen();
                main.showWindow(m, this, mdi.ActiveForm);

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_page_Load_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fasih.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("fields are not filled");
                //main.check_try("fields are not filled correctly", "stop", false);
            }
            else
            {
                string hello = fasih.Text;
                int hello1 = Convert.ToInt32(textBox1.Text);
                if(hello=="fasih")
                {
                    if (hello1 == 123)
                    {
                        main_screen m = new main_screen();
                        main.showWindow(m, this, mdi.ActiveForm);
                    }
                    else
                    {
                        MessageBox.Show("INVALID password");
                    }
                }
                else
                {
                    MessageBox.Show("INVALID USERNAME");
                }
                // con.Open();
                // OracleCommand getEmps = con.CreateCommand();
                // getEmps.CommandText = "SELECT per_unit_price FROM product WHERE user_id = :userid and pass=passw";
                // getEmps.Parameters.Add("userId", OracleDbType.Int32).Value = hello;
                // getEmps.Parameters.Add("userId", OracleDbType.Int32).Value = hello1;
                // OracleDataReader empDR = getEmps.ExecuteReader();
                // if (empDR.Read())
                // {
                //     perprice.Text = empDR.GetDecimal(0).ToString(); // get the value of the first column as a decimal and convert it to a string
                // }
                // else
                // {
                //     perprice.Text = ""; // no rows returned, set the textbox to empty
                // }

              

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void fasih_TextChanged(object sender, EventArgs e)
        {

        }

        private void saqib_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
