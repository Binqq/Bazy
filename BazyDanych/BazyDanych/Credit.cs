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
    public partial class Credit : Form
    {
        string data;
        MySqlConnection cnn;
        string connetionString1 = "server=localhost;database=bank;uid=root;pwd=Bd123456789#";
        public Credit(MySqlConnection connection, string data)
        {
            this.data = data;
            cnn = connection;
            InitializeComponent();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void buttonGrantALoan_Click(object sender, EventArgs e)
        {
            string Name, Surname;
            double PESEL;
            int Month;
            float Cash;
            Name = textBoxName.Text;
            Surname = textBoxSurname.Text;
            PESEL = Convert.ToDouble(textBoxPesel.Text);
            Month = Convert.ToInt32(textBoxDuration.Text);
            Cash = float.Parse(textBoxCash.Text);
            float Rate = Cash / Month;
            DateTime date1 = DateTime.Today;

            string query1, query2, query3,query,que;
            query = "SELECT Account_id FROM accounts JOIN customers ON accounts.Customer_id = customers.Customers_id AND Customer_id = '"+PESEL+"'";
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader rdr = null;
           
            rdr = cmd.ExecuteReader();
            int accountID;
            if (rdr.Read())
                accountID = rdr.GetInt16(0);
            else
            {
                accountID = 0;
                MessageBox.Show("Brak numeru konta");
                    
                    }
            cnn.Close();
            query3 = "SELECT Employees_id FROM employees WHERE Login='" + data + "'";
            cnn.Open();
            MySqlCommand cmd1 = new MySqlCommand(query3, cnn);
            MySqlDataReader rdr1 = null;
            rdr1 = cmd1.ExecuteReader();
            int employeeID;
            if (rdr1.Read())
                employeeID = rdr1.GetInt16(0);
            else
            {
                employeeID = 0;
                MessageBox.Show("Brak numeru konta");
            }
            cnn.Close();
            query1 ="INSERT INTO loans (DurationByMonth,Interest_rate,Start_Date,Account_id) VALUES('"+Month+"','"+Rate+"','"+date1+"','"+ accountID+ "')";         
            MySqlCommand command = new MySqlCommand(query1, cnn);
            MySqlDataReader rdr2 = null;
            cnn.Open();
            rdr2 = command.ExecuteReader();
            cnn.Close();

            que = "SELECT Loan_id FROM loans WHERE Login='" + accountID + "'";
            cnn.Open();
            MySqlCommand cmd2 = new MySqlCommand(que, cnn);
            MySqlDataReader rdr3 = null;
            rdr3 = cmd2.ExecuteReader();
            int loanID;
            if(rdr3.Read())
                loanID= rdr3.GetInt16(0);
            else
            {
               loanID = 0;
                MessageBox.Show("Brak kredytu");
            }
            cnn.Close();

            query2 ="INSERT INTO  transaction (Data_Type,Account_id,Transaction_Type_id,Employee_id,Loan_ID) VALUES('"+date1+"','"+accountID+"','4','"+employeeID+"','"+loanID+"')" ;
            MySqlCommand command1 = new MySqlCommand(query2, cnn);
            MySqlDataReader rdr4= null;
            cnn.Open();
         
            rdr4= command1.ExecuteReader();
            cnn.Close();
        }

    
    }
}
