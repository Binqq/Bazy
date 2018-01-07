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
        string data;
        MySqlConnection cnn;
        public Employee(MySqlConnection connection, string data)
        {
            this.data = data;
            cnn = connection;
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCredit_Click(object sender, EventArgs e)
        {
            new Credit(cnn,data).ShowDialog();
        }

        private void buttonNewConto_Click(object sender, EventArgs e)
        {

        }

        private void buttonCloseConto_Click(object sender, EventArgs e)
        {
            new DelConto(cnn, data).ShowDialog();
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {

        }

        private void buttonPay_In_Out_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreditBack_Click(object sender, EventArgs e)
        {
           
        }

       

        private void panelNewConto_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void buttonLogOut_Click_1(object sender, EventArgs e)
        {
            data = null;
            cnn.Close();
            this.Close();
        }
    }
}
