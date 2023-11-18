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
    public partial class main_screen : sample

    {
        public main_screen()
        {
            InitializeComponent();
        }

        private void main_screen_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rack r = new rack();
            main.showWindow(r, this, mdi.ActiveForm);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            customer obj3 = new customer();
            main.showWindow(obj3, this, mdi.ActiveForm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vendor obj7 = new vendor();
            main.showWindow(obj7, this, mdi.ActiveForm);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sales obj = new sales();
            main.showWindow(obj, this, mdi.ActiveForm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            account obj = new account();
            main.showWindow(obj, this, mdi.ActiveForm);

        }
    }
}
