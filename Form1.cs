using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Project_1
{
    public partial class Form1 : Form
    {
        Boolean firstrun = true;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void addNewProduct_Button_Click(object sender, EventArgs e)
        
        {
            this.Hide();
            Form2 add = new Form2();
            add.Show();
        }

        private void productNumber_TextBox_TextChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
            {
                cell = selectedCell;
                break;
            }

            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                if (productNumber_TextBox.Text == row.Cells[0].Value.ToString()) return;
            }

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.ClearSelection();

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells[0].Value.ToString().Equals(productNumber_TextBox.Text))
                {
                    item.Selected = true;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            total_TextBox.Text = "";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beauty_center0DataSet1.Products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter2.Fill(this.beauty_center0DataSet1.Products);

            OleDbConnection cnn = new OleDbConnection();
            cnn.ConnectionString = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\Beauty center.accdb;";

            cnn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cnn;
            string query = "select * from Products";
            cmd.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            cnn.Close();    


            // TODO: This line of code loads data into the 'beauty_center0DataSet.Products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter1.Fill(this.beauty_center0DataSet.Products);
            
            dataGridView1.ClearSelection();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (firstrun)
            {
                firstrun = false;
                return;
            }

            productName_TextBox.Clear();
            productPrice_TextBox.Clear();
            quantity_TextBox.Clear();
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                productNumber_TextBox.Text = row.Cells[0].Value.ToString();
                productName_TextBox.Text = row.Cells[1].Value.ToString();
                productPrice_TextBox.Text = row.Cells[2].Value.ToString();
               

            
            }
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bill_Button_Click(object sender, EventArgs e)
        { 
            string Path = @"D:/Bill.txt";
            File.Create(Path).Close();
            FileStream str;
            str = new FileStream(Path, FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(str);
            foreach (var item in listBox1.Items)
            {
                sw.WriteLine(item.ToString());
            }
            sw.Close();
            str.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void quantity_TextBox_TextChanged(object sender, EventArgs e)
        {
            if(quantity_TextBox.Text != "" && productPrice_TextBox.Text != "")
            {
                double total = Convert.ToDouble(quantity_TextBox.Text) * Convert.ToDouble(productPrice_TextBox.Text);
                productPrice_TextBox.Text = total.ToString();
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void productPrice_TextBox_TextChanged(object sender, EventArgs e)
        {
            //listBox2.Items.Add(productPrice_TextBox.Text);

        }

        private void close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sum_Button_Click(object sender, EventArgs e)
        {
            int i = 0, result = 0;
            while (i < listBox2.Items.Count)
            {
                result += Convert.ToInt32(listBox2.Items[i]);
                i++;
            }
            total_TextBox.Text = Convert.ToString(result);
            string totalEntry = total_TextBox.Text;
            listBox1.Items.Add("THE TOTAL:"+totalEntry);
        }

        private void addToBill_Button_Click(object sender, EventArgs e)
        {
            string detailEntry = productName_TextBox.Text + ": " + productPrice_TextBox.Text;
            string billEntry = productPrice_TextBox.Text;
            string totalEntry = total_TextBox.Text;
            listBox1.Items.Add(detailEntry);
            listBox2.Items.Add(billEntry);
            

        }

      

        private void Paid_TextChanged_1(object sender, EventArgs e)
        {
            double n1, n2, result;
            n1 = Convert.ToDouble(total_TextBox.Text);
            n2 = Convert.ToDouble(Paid.Text);
            result = n2 - n1;
           Reminder.Text = result.ToString();

        }

        private void label8_Click(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

       
    }
}
