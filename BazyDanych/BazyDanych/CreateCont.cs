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
       string connetionString1 = "server=localhost;database=bank;uid=root;pwd=Bd123456789#";
        public CreateCont(MySqlConnection connect, string data)
        {
            this.cnn = connect;
            this.data = data;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name, Surname, Adres, Password, Login, Branch;
            double Phone, Mobile, PESEL;
            int type;
            Name = textBoxName.Text;
            Surname = textBoxSurname.Text;
            PESEL = Convert.ToDouble(textBoxPesel.Text);
            Adres = textBoxAddress.Text;
            Password = textBoxPassword.Text;
            Login = textBoxLogin.Text;
            Branch = textBoxBranch.Text;
            Phone = Convert.ToDouble(textBoxTel.Text);
            Mobile = Convert.ToDouble(textBoxMobile.Text);
            if (checkBoxCompanyAccount.Checked == true)
            {
                type = 1;
            }
            else
                type =1;
            string query;
            query = "INSERT INTO person VALUES('" + PESEL + "','" + Name + "','" + Surname + "','" + Adres + "','" + Phone + "','" + Mobile + "');";
            MySqlConnection cnn1 = new MySqlConnection(connetionString1);
            MySqlCommand cmd = new MySqlCommand(query, cnn1);
            cnn1.Open();
            MySqlDataReader rdr=null;
            rdr = cmd.ExecuteReader();
            cnn1.Close();


            string query1;
          
            query1 = "INSERT INTO customers (Customers_Type,Passwords,Login,Person_id) VALUES('" + type + "','" + Password + "','" + Login + "','"+PESEL+"');";
         
            MySqlCommand cmd1 = new MySqlCommand(query1, cnn1);
            MySqlDataReader rdr1=null;
            cnn1.Open();
            rdr1 = cmd1.ExecuteReader();
            cnn1.Close();

            string query2;
            //TODO Zmienić na tak jak wyżej 
            query2 = "INSERT INTO accounts VALUES('" + null + "','" + Branch + "','" + 1 + "','" + 0 + "','" + null + "','" + null + "','" + null + "')";
            MySqlCommand cmd2 = new MySqlCommand(query2, cnn1);
            MySqlDataReader rdr2 = null;
            cnn1.Open();
            rdr2= cmd2.ExecuteReader();
            cnn1.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
