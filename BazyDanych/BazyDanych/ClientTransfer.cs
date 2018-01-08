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
    public partial class ClientTransfer : Form
    {
        string data;
        MySqlConnection cnn;
        public ClientTransfer(MySqlConnection connection, string data)
        {
            this.data = data;
            cnn = connection;
            InitializeComponent();
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            string Name, Surname;
            double PESEL;
            float Cash;
            int Account_id;
            Name = textBoxName.Text;
            Surname = textBoxSurname.Text;
            PESEL = Convert.ToDouble(Pesel.Text);
            Cash = float.Parse(textBoxCash.Text);
            Account_id = Convert.ToInt32(textBoxAccountNumber.Text);


            string query;
            query = "UPDATE accounts SET Balance= Balance + '" + Cash + "' WHERE Account_id = '" + Account_id + "'";
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader rdr = null;
            rdr = cmd.ExecuteReader();
            cnn.Close();

            string query1, query2;
            query2 = "SELECT Account_id FROM accounts b  JOIN customers ON b.Customer_id=customers.Customers_id AND customers.Person_id='" + PESEL + "')";
            cnn.Open();
            MySqlCommand cmd1 = new MySqlCommand(query2, cnn);
            MySqlDataReader rdr1 = null;
            rdr1 = cmd1.ExecuteReader();
            int accountID;
            if (rdr1.Read())
                accountID = rdr1.GetInt16(0);
            else
            {
                accountID = 0;
                MessageBox.Show("Brak numeru konta");
            }
            cnn.Close();

            query1 = "UPDATE accounts SET Balance= Balance - '" + Cash + "' WHERE Account_id= '" + accountID + "'";
            cnn.Open();
            MySqlCommand cmd2 = new MySqlCommand(query1, cnn);
            MySqlDataReader rdr2 = null;
            rdr2 = cmd2.ExecuteReader();
            cnn.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
