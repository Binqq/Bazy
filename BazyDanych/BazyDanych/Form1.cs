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
    public partial class Form1 : Form
    {
        private bool Porownaj(string string1, string string2)
        {
            return String.Compare(string1, string2, true, System.Globalization.CultureInfo.InvariantCulture) == 0 ? true : false;
        }
        private void PrintRows(DataSet dataSet)
        {
            // For each table in the DataSet, print the row values.
            foreach (DataTable table in dataSet.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn column in table.Columns)
                    {
                        MessageBox.Show(row[column].ToString());
                    }
                }
            }
        }
        public Form1()
        {

            InitializeComponent();

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string login;
            string password;
            login = textBoxLogin.Text;
            password = textBoxPassword.Text;
            string connetionString = null;

            MySqlConnection cnn;
            connetionString = "server=localhost;database=bank;uid=root;pwd=Bd123456789#";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();
            try
            {

                string query = "SELECT Login, Passwords FROM customers WHERE Login Like " + login + " AND Passwords LIKE '" + password + "'";
                MySqlDataAdapter rdr = new MySqlDataAdapter(query, cnn);
                rdr.SelectCommand = new MySqlCommand(query, cnn);
                DataSet data = new DataSet();
                rdr.Fill(data);
                if (data != null)
                {
                    MessageBox.Show("Zalogowano poprawnie");

                    (new FormBank()).ShowDialog();



                }

                cnn.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}

