namespace Project_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addNewProducts_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.productNumber_TextBox = new System.Windows.Forms.TextBox();
            this.productName_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productPrice_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quantity_TextBox = new System.Windows.Forms.TextBox();
            this.clear_Button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.beauty_center0DataSet1 = new Project_1.Beauty_center0DataSet1();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.beauty_center0DataSet = new Project_1.Beauty_center0DataSet();
            this.productsTableAdapter1 = new Project_1.Beauty_center0DataSetTableAdapters.ProductsTableAdapter();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beauty_centerDataSet = new Project_1.Beauty_centerDataSet();
            this.productsTableAdapter = new Project_1.Beauty_centerDataSetTableAdapters.ProductsTableAdapter();
            this.productsTableAdapter2 = new Project_1.Beauty_center0DataSet1TableAdapters.ProductsTableAdapter();
            this.bill_Button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.close_Button = new System.Windows.Forms.Button();
            this.sum_Button = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.beauty_centerDataSet3 = new Project_1.Beauty_centerDataSet3();
            this.beautycenterDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addToBill_Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.total_TextBox = new System.Windows.Forms.TextBox();
            this.Paid = new System.Windows.Forms.TextBox();
            this.Reminder = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beauty_center0DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beauty_center0DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beauty_centerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beauty_centerDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautycenterDataSet3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewProducts_Button
            // 
            this.addNewProducts_Button.BackColor = System.Drawing.Color.DodgerBlue;
            this.addNewProducts_Button.Location = new System.Drawing.Point(526, 573);
            this.addNewProducts_Button.Name = "addNewProducts_Button";
            this.addNewProducts_Button.Size = new System.Drawing.Size(162, 39);
            this.addNewProducts_Button.TabIndex = 0;
            this.addNewProducts_Button.Text = "Add new products";
            this.addNewProducts_Button.UseVisualStyleBackColor = false;
            this.addNewProducts_Button.Click += new System.EventHandler(this.addNewProduct_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(94, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product no:";
            // 
            // productNumber_TextBox
            // 
            this.productNumber_TextBox.Location = new System.Drawing.Point(207, 47);
            this.productNumber_TextBox.Name = "productNumber_TextBox";
            this.productNumber_TextBox.Size = new System.Drawing.Size(132, 20);
            this.productNumber_TextBox.TabIndex = 2;
            this.productNumber_TextBox.TextChanged += new System.EventHandler(this.productNumber_TextBox_TextChanged);
            // 
            // productName_TextBox
            // 
            this.productName_TextBox.Location = new System.Drawing.Point(207, 166);
            this.productName_TextBox.Multiline = true;
            this.productName_TextBox.Name = "productName_TextBox";
            this.productName_TextBox.ReadOnly = true;
            this.productName_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.productName_TextBox.Size = new System.Drawing.Size(132, 30);
            this.productName_TextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(94, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(94, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product Price:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // productPrice_TextBox
            // 
            this.productPrice_TextBox.Location = new System.Drawing.Point(207, 238);
            this.productPrice_TextBox.Name = "productPrice_TextBox";
            this.productPrice_TextBox.ReadOnly = true;
            this.productPrice_TextBox.Size = new System.Drawing.Size(132, 20);
            this.productPrice_TextBox.TabIndex = 6;
            this.productPrice_TextBox.TextChanged += new System.EventHandler(this.productPrice_TextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(94, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "The amount:";
            // 
            // quantity_TextBox
            // 
            this.quantity_TextBox.Location = new System.Drawing.Point(207, 110);
            this.quantity_TextBox.Name = "quantity_TextBox";
            this.quantity_TextBox.Size = new System.Drawing.Size(132, 20);
            this.quantity_TextBox.TabIndex = 8;
            this.quantity_TextBox.TextChanged += new System.EventHandler(this.quantity_TextBox_TextChanged);
            // 
            // clear_Button
            // 
            this.clear_Button.Location = new System.Drawing.Point(242, 564);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(117, 23);
            this.clear_Button.TabIndex = 11;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(867, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 524);
            this.listBox1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productnoDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.productpriceDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(414, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 524);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // productnoDataGridViewTextBoxColumn
            // 
            this.productnoDataGridViewTextBoxColumn.DataPropertyName = "Productno";
            this.productnoDataGridViewTextBoxColumn.HeaderText = "Productno";
            this.productnoDataGridViewTextBoxColumn.Name = "productnoDataGridViewTextBoxColumn";
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "Productname";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "Productname";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            // 
            // productpriceDataGridViewTextBoxColumn
            // 
            this.productpriceDataGridViewTextBoxColumn.DataPropertyName = "Productprice";
            this.productpriceDataGridViewTextBoxColumn.HeaderText = "Productprice";
            this.productpriceDataGridViewTextBoxColumn.Name = "productpriceDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // productsBindingSource2
            // 
            this.productsBindingSource2.DataMember = "Products";
            this.productsBindingSource2.DataSource = this.beauty_center0DataSet1;
            // 
            // beauty_center0DataSet1
            // 
            this.beauty_center0DataSet1.DataSetName = "Beauty_center0DataSet1";
            this.beauty_center0DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.beauty_center0DataSet;
            // 
            // beauty_center0DataSet
            // 
            this.beauty_center0DataSet.DataSetName = "Beauty_center0DataSet";
            this.beauty_center0DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.beauty_centerDataSet;
            // 
            // beauty_centerDataSet
            // 
            this.beauty_centerDataSet.DataSetName = "Beauty_centerDataSet";
            this.beauty_centerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter2
            // 
            this.productsTableAdapter2.ClearBeforeFill = true;
            // 
            // bill_Button
            // 
            this.bill_Button.Location = new System.Drawing.Point(173, 509);
            this.bill_Button.Name = "bill_Button";
            this.bill_Button.Size = new System.Drawing.Size(75, 23);
            this.bill_Button.TabIndex = 15;
            this.bill_Button.Text = "Bill";
            this.bill_Button.UseVisualStyleBackColor = true;
            this.bill_Button.Click += new System.EventHandler(this.bill_Button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(120, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total :";
            // 
            // close_Button
            // 
            this.close_Button.Location = new System.Drawing.Point(115, 564);
            this.close_Button.Name = "close_Button";
            this.close_Button.Size = new System.Drawing.Size(75, 23);
            this.close_Button.TabIndex = 17;
            this.close_Button.Text = "Close";
            this.close_Button.UseVisualStyleBackColor = true;
            this.close_Button.Click += new System.EventHandler(this.close_Button_Click);
            // 
            // sum_Button
            // 
            this.sum_Button.Location = new System.Drawing.Point(112, 456);
            this.sum_Button.Name = "sum_Button";
            this.sum_Button.Size = new System.Drawing.Size(75, 23);
            this.sum_Button.TabIndex = 18;
            this.sum_Button.Text = "sum";
            this.sum_Button.UseVisualStyleBackColor = true;
            this.sum_Button.Click += new System.EventHandler(this.sum_Button_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(1116, 43);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 524);
            this.listBox2.TabIndex = 19;
            // 
            // beauty_centerDataSet3
            // 
            this.beauty_centerDataSet3.DataSetName = "Beauty_centerDataSet3";
            this.beauty_centerDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // beautycenterDataSet3BindingSource
            // 
            this.beautycenterDataSet3BindingSource.DataSource = this.beauty_centerDataSet3;
            this.beautycenterDataSet3BindingSource.Position = 0;
            // 
            // addToBill_Button
            // 
            this.addToBill_Button.Location = new System.Drawing.Point(229, 456);
            this.addToBill_Button.Margin = new System.Windows.Forms.Padding(2);
            this.addToBill_Button.Name = "addToBill_Button";
            this.addToBill_Button.Size = new System.Drawing.Size(130, 27);
            this.addToBill_Button.TabIndex = 20;
            this.addToBill_Button.Text = "Add to Bill";
            this.addToBill_Button.UseVisualStyleBackColor = true;
            this.addToBill_Button.Click += new System.EventHandler(this.addToBill_Button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(120, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Paid :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(112, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Reminder:";
            // 
            // total_TextBox
            // 
            this.total_TextBox.Location = new System.Drawing.Point(207, 291);
            this.total_TextBox.Name = "total_TextBox";
            this.total_TextBox.Size = new System.Drawing.Size(132, 20);
            this.total_TextBox.TabIndex = 9;
            this.total_TextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Paid
            // 
            this.Paid.Location = new System.Drawing.Point(207, 350);
            this.Paid.Name = "Paid";
            this.Paid.Size = new System.Drawing.Size(132, 20);
            this.Paid.TabIndex = 24;
            this.Paid.TextChanged += new System.EventHandler(this.Paid_TextChanged_1);
            // 
            // Reminder
            // 
            this.Reminder.Location = new System.Drawing.Point(207, 391);
            this.Reminder.Name = "Reminder";
            this.Reminder.Size = new System.Drawing.Size(132, 20);
            this.Reminder.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1245, 625);
            this.Controls.Add(this.Reminder);
            this.Controls.Add(this.Paid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addToBill_Button);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.sum_Button);
            this.Controls.Add(this.close_Button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bill_Button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.total_TextBox);
            this.Controls.Add(this.quantity_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.productPrice_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productName_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productNumber_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addNewProducts_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beauty_center0DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beauty_center0DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beauty_centerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beauty_centerDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautycenterDataSet3BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewProducts_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productNumber_TextBox;
        private System.Windows.Forms.TextBox productName_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productPrice_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quantity_TextBox;
        private System.Windows.Forms.Button clear_Button;
        private Beauty_centerDataSet beauty_centerDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private Beauty_centerDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Beauty_center0DataSet beauty_center0DataSet;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private Beauty_center0DataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private Beauty_center0DataSet1 beauty_center0DataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource2;
        private Beauty_center0DataSet1TableAdapters.ProductsTableAdapter productsTableAdapter2;
        private System.Windows.Forms.Button bill_Button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button close_Button;
        private System.Windows.Forms.Button sum_Button;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private Beauty_centerDataSet3 beauty_centerDataSet3;
        private System.Windows.Forms.BindingSource beautycenterDataSet3BindingSource;
        private System.Windows.Forms.Button addToBill_Button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox total_TextBox;
        private System.Windows.Forms.TextBox Paid;
        private System.Windows.Forms.TextBox Reminder;
    }
}

