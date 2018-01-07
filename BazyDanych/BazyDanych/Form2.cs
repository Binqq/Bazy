﻿using System;
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
    }
}
