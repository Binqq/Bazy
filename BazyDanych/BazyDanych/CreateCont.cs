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
    public partial class CreateCont : Form
    {
        string data;
        MySqlConnection cnn;
        public CreateCont(MySqlConnection connect, string data)
        {
            this.cnn = connect;
            this.data = data;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
