using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project_DB
{
    class main
    {public static DialogResult check_try(string msg,string heading,bool type)
        {if(type==true)
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon
                    .Information);
            }
        else
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon
                    .Error);
            }
            

        }

        public static void showWindow(Form openwin, Form closewin, Form mdi)
        {
            closewin.Close();
            openwin.MdiParent = mdi;
            openwin.WindowState = FormWindowState.Maximized;
            openwin.Show();

        }
        public static void showWindow(Form openwin, Form mdi)
        {
            //closewin.Close();
            openwin.MdiParent = mdi;
            openwin.WindowState = FormWindowState.Maximized;
            openwin.Show();

        }
    }
}
