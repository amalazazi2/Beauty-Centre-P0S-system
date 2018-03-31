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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection cnn = new OleDbConnection();
            cnn.ConnectionString = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\Beauty center.accdb;";
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Productno", textBox1.Text);
            cmd.Parameters.AddWithValue("@Productname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Productprice", textBox3.Text);
            cmd.Parameters.AddWithValue("@Amount", textBox4.Text);
            cmd.CommandText = "insert into Products (Productno,Productname,Productprice,Amount) values(@Productno,@Productname,@Productprice,@Amount)";
            cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Added successfully");
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult d = MessageBox.Show("confirm", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == System.Windows.Forms.DialogResult.Yes)
            {
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\Beauty center.accdb;";
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                OleDbCommand cmd2 = new OleDbCommand();
                cmd2.Connection = cnn;
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.AddWithValue("@Productno", textBox1.Text);
                cmd2.CommandText = "delete from Products where Productno=@Productno";
                cmd2.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Deleted");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection cnn = new OleDbConnection();
            cnn.ConnectionString = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\Beauty center.accdb;";
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            OleDbCommand cmd1 = new OleDbCommand();
            cmd1.Connection = cnn;
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.AddWithValue("@Productno", textBox1.Text);
            cmd1.Parameters.AddWithValue("@Productprice", textBox3.Text);
            cmd1.Parameters.AddWithValue("@Amount", textBox4.Text);
            cmd1.CommandText = "update Products set Productno=@Productno,Productprice=@Productprice,Amount=@Amount where Productno=@Productno";
            cmd1.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Updated");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 add =new Form1();
            add.Show();
        }

        
    }
}
