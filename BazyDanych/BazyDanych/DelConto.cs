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
    public partial class DelConto : Form
    {
        string data;
        MySqlConnection cnn;
        public DelConto(MySqlConnection connection, string data)
        {
            cnn = connection;
            this.data = data;
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

            this.Close();

        }
}
}
