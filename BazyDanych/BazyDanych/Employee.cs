using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BazyDanych
{
    public partial class Employee : Form
    {
        public Employee(MySqlConnection connection, string data)
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }
    }
}
