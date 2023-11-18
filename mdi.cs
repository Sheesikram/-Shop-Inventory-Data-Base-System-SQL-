using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Types;
using Oracle.ManagedDataAccess.Client;
namespace final_project_DB
{
    public partial class mdi : Form
    {
        OracleConnection con;
        public mdi()
        {
            InitializeComponent();
        }

        private void mdi_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521 / XE; USER ID = 21L-5430_project; PASSWORD = 123";
            con = new OracleConnection(conStr);
           //updateGrid();
            login_page log = new login_page();
            main.showWindow(log, this);
        }
    }
}
