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
        string data;
        MySqlConnection cnn;
        public FormBank(MySqlConnection connect, string data)
        {
            this.cnn = connect;
            this.data = data;
            InitializeComponent();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
           
                data = null;
                cnn.Close();
                this.Close();
            

        }

        private void buttonBalance_Click(object sender, EventArgs e)
        {
            cnn.Close();
           
            cnn.Open();
          string  query2 = "SELECT Balacne FROM accounts   JOIN customers ON Customer_id=customers.Customers_id AND customers.Login='" + data + "'";
            using (MySqlCommand cmdSel = new MySqlCommand(query2, cnn))
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter rdr = new MySqlDataAdapter(cmdSel);
                rdr.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
            }
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            cnn.Close();

            cnn.Open();
            string query2 = "SELECT Transaction_id as 'Id transakcji', Data_Type as 'Data', Login as 'Login' , Employee_id as 'numer pracownika'  FROM transactions   JOIN accounts ON transactions.Account_id=accounts.Account_id JOIN customers ON accounts.Customer_id=customers.Customers_id AND customers.Login = '"+data+"'";
            using (MySqlCommand cmdSel = new MySqlCommand(query2, cnn))
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter rdr = new MySqlDataAdapter(cmdSel);
                rdr.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
            }
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {

        }
    }
}
