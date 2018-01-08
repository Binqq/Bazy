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
    public partial class Transf : Form
    {
        string data;
        MySqlConnection cnn;
        public Transf(MySqlConnection connection, string data)
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
            query = "UPDATE accounts SET Balance= Balance + '"+Cash+"' WHERE Account_id = '"+Account_id+"'";
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader rdr = null;
            rdr = cmd.ExecuteReader();
            cnn.Close();

            string query1;
            //TODO  poprawić zapytanie
            query1 = "UPDATE accounts SET Balance= Balance - '" + Cash + "' JOIN customers ON accounts.Customer_id=customers.Customers_id  AND customers.Person_id= '"+PESEL+"'";
            cnn.Open();
            MySqlCommand cmd1 = new MySqlCommand(query1, cnn);
            MySqlDataReader rdr1 = null;
            rdr1 = cmd1.ExecuteReader();
            cnn.Close();

        }
    }
}
