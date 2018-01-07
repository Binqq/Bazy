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
        public Credit(MySqlConnection connection, string data)
        {
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
            query = "SELECT Account_id FROM accounts JOIN customers ON Customer_id = Customers_id AND Login LIKE '"+data+"`";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader rdr = null;
            rdr = cmd.ExecuteReader();
            int accountID = rdr.GetInt16(0);


            query3 = "SELECT Employees_id FROM employees WHERE Login=`" + data + "`";
            MySqlCommand cmd1 = new MySqlCommand(query3, cnn);
            MySqlDataReader rdr1 = null;
            rdr1 = cmd1.ExecuteReader();
            int employeeID = rdr.GetInt16(0);

            query1 ="INSERT INTO loans VALUES(`"+null+"',`"+Month+"`,`"+Rate+"`,`"+date1+"`,`"+ accountID+ "`)";
            MySqlCommand command = new MySqlCommand(query1, cnn);
            command.ExecuteNonQuery();

            que = "SELECT Loan_id FROM loans WHERE Login=`" + accountID + "`";
            MySqlCommand cmd2 = new MySqlCommand(que, cnn);
            MySqlDataReader rdr2 = null;
            rdr2 = cmd1.ExecuteReader();
            int loanID = rdr.GetInt16(0);


            query2 ="INSERT INTO  transaction VALUES(`"+null+"`,`"+date1+"`,`"+accountID+"`,`4`,`"+employeeID+"`,`"+loanID+"`)" ;
            MySqlCommand command1 = new MySqlCommand(query2, cnn);
            command1.ExecuteNonQuery();

        }

    
    }
}
