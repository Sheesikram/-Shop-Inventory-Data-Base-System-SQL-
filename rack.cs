using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project_DB
{
    public partial class rack : sample
    {
        public rack()
        {
            InitializeComponent();
        }

        private void rack_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            main_screen obj = new main_screen();
            main.showWindow(obj, this, mdi.ActiveForm);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            sample2 obj2 = new sample2();
            main.showWindow(obj2, this, mdi.ActiveForm);
        }

        private void label4_Click(object sender, EventArgs e)
        {
        //    //main_screen obj = new main_screen();
        //    //main.showWindow(obj, this, mdi.ActiveForm);

        
        }

        private void manage_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            lvl obj4 = new lvl();
            main.showWindow(obj4, this, mdi.ActiveForm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            category obj3 = new category();
            main.showWindow(obj3, this, mdi.ActiveForm);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reorder_pints obj4 =new  reorder_pints();
            main.showWindow(obj4, this, mdi.ActiveForm);
        }

        private void button7_Click(object sender, EventArgs e)
        {
           lvl obj4 = new lvl();
            main.showWindow(obj4, this, mdi.ActiveForm);
        }
    }
}
