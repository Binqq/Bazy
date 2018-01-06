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
    public partial class FormBank : Form
    {
        MySqlConnection connection;
        string data;

        public FormBank(MySqlConnection connection, string data)
        {
            InitializeComponent();
            this.connection = connection;
          
            
        }

        private void FormBank_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            data = null;
            connection.Close();
            this.Close();
        }
    }
}
