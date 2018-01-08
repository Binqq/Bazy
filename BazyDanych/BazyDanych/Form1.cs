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
            try
            {
                cnn.Open();
            }catch
            {
                MessageBox.Show("Spróbuj później", "Error");
            }
            ///try
//{
                string query;
                if (checkBoxEmployees.Checked)
                {
                    query = "SELECT Login FROM employees WHERE Login Like '" + login + "' AND Passwords LIKE '" + password + "'";
                    MySqlCommand cmd = new MySqlCommand(query, cnn);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        if (rdr.Read() == false)
                        {
                            MessageBox.Show("Zalogowano poprawnie");
                            string loginTmp = rdr.GetString(0);
                            this.Visible = false;
                            (new Employee(cnn, loginTmp)).ShowDialog();
                            this.Visible = true;
                           
                        }


                    }
                    else
                        MessageBox.Show("Błędne hasło lub login", "Error");



                    cnn.Close();
                } else
                {
                    query = "SELECT Login FROM customers WHERE Login Like '" + login + "' AND Passwords LIKE '" + password + "'";
                    MySqlCommand cmd = new MySqlCommand(query, cnn);
                    MySqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        if (rdr.Read() == false)
                        {
                            MessageBox.Show("Zalogowano poprawnie");
                            string loginTmp = rdr.GetString(0);
                            this.Visible = false;
                            (new FormBank(cnn, loginTmp)).ShowDialog();
                            this.Visible = true;
                        }


                    }
                    else
                        MessageBox.Show("Błędne hasło lub login", "Error");



                    cnn.Close();
                }

               
            //}catch(Exception exs)
            //{
          //      MessageBox.Show("Błąd");
          //  }
            
            }
    }
}

