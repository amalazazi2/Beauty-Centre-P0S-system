using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Project_1
{
    public partial class LOGIN_WINDOW : Form
    {
        public LOGIN_WINDOW()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OleDbConnection CN = new OleDbConnection();
            CN.ConnectionString = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Amal\Documents\Beauty center0.accdb;";
            CN.Open();
            OleDbCommand CMD = new OleDbCommand();
            CMD.Connection = CN;
            CMD.CommandText = "select * from Table1 where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'";
            OleDbDataReader Reader = CMD.ExecuteReader();
            int count = 0;
            while (Reader.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                this.Hide();
                Form1 add = new Form1();
                add.Show();
            }

            else
            {
                MessageBox.Show("Username and password is not correct");

            }
            CN.Close();

            
        }

        private void LOGIN_WINDOW_Load(object sender, EventArgs e)
        {

        }
    }
}
