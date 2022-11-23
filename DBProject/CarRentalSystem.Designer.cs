namespace DBProject
{
    partial class CarRentalSystem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.carList = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.make = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daily_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyPriceField = new System.Windows.Forms.TextBox();
            this.makeLabel = new System.Windows.Forms.Label();
            this.dailyPriceLabel = new System.Windows.Forms.Label();
            this.makeField = new System.Windows.Forms.TextBox();
            this.colorField = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.modelField = new System.Windows.Forms.TextBox();
            this.yearField = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.customers = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rentedCars = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rentalInfo = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.rentalOrderIdLabel = new System.Windows.Forms.Label();
            this.rentalOrderIdField = new System.Windows.Forms.TextBox();
            this.totalPriceField = new System.Windows.Forms.TextBox();
            this.rentStartLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.rentStartField = new System.Windows.Forms.TextBox();
            this.rentEndField = new System.Windows.Forms.TextBox();
            this.rentEndLabel = new System.Windows.Forms.Label();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rent_start_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rent_end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.carList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.rentedCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.rentalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 553);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Made By: Cristian Zapata && Alejandro Romero-Lopez";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.carList);
            this.tabControl1.Controls.Add(this.customers);
            this.tabControl1.Controls.Add(this.rentedCars);
            this.tabControl1.Controls.Add(this.rentalInfo);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(961, 538);
            this.tabControl1.TabIndex = 12;
            // 
            // carList
            // 
            this.carList.Controls.Add(this.dataGridView1);
            this.carList.Controls.Add(this.dailyPriceField);
            this.carList.Controls.Add(this.makeLabel);
            this.carList.Controls.Add(this.dailyPriceLabel);
            this.carList.Controls.Add(this.makeField);
            this.carList.Controls.Add(this.colorField);
            this.carList.Controls.Add(this.modelLabel);
            this.carList.Controls.Add(this.colorLabel);
            this.carList.Controls.Add(this.modelField);
            this.carList.Controls.Add(this.yearField);
            this.carList.Controls.Add(this.yearLabel);
            this.carList.Location = new System.Drawing.Point(4, 24);
            this.carList.Name = "carList";
            this.carList.Padding = new System.Windows.Forms.Padding(3);
            this.carList.Size = new System.Drawing.Size(953, 510);
            this.carList.TabIndex = 0;
            this.carList.Text = "Car List";
            this.carList.UseVisualStyleBackColor = true;
            this.carList.Click += new System.EventHandler(this.carList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.make,
            this.model,
            this.year,
            this.color,
            this.daily_price});
            this.dataGridView1.Location = new System.Drawing.Point(6, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(941, 336);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // make
            // 
            this.make.HeaderText = "Make";
            this.make.Name = "make";
            this.make.Width = 180;
            // 
            // model
            // 
            this.model.HeaderText = "Model";
            this.model.Name = "model";
            this.model.Width = 180;
            // 
            // year
            // 
            this.year.HeaderText = "Year";
            this.year.Name = "year";
            this.year.Width = 180;
            // 
            // color
            // 
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.Width = 180;
            // 
            // daily_price
            // 
            this.daily_price.HeaderText = "Daily Price";
            this.daily_price.Name = "daily_price";
            this.daily_price.Width = 180;
            // 
            // dailyPriceField
            // 
            this.dailyPriceField.AcceptsTab = true;
            this.dailyPriceField.BackColor = System.Drawing.SystemColors.Window;
            this.dailyPriceField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dailyPriceField.Location = new System.Drawing.Point(703, 73);
            this.dailyPriceField.Name = "dailyPriceField";
            this.dailyPriceField.Size = new System.Drawing.Size(119, 23);
            this.dailyPriceField.TabIndex = 22;
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.makeLabel.Location = new System.Drawing.Point(93, 50);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(47, 20);
            this.makeLabel.TabIndex = 13;
            this.makeLabel.Text = "Make";
            this.makeLabel.Click += new System.EventHandler(this.Make_Click_1);
            // 
            // dailyPriceLabel
            // 
            this.dailyPriceLabel.AutoSize = true;
            this.dailyPriceLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dailyPriceLabel.Location = new System.Drawing.Point(703, 50);
            this.dailyPriceLabel.Name = "dailyPriceLabel";
            this.dailyPriceLabel.Size = new System.Drawing.Size(82, 20);
            this.dailyPriceLabel.TabIndex = 21;
            this.dailyPriceLabel.Text = "Daily Price";
            // 
            // makeField
            // 
            this.makeField.AcceptsTab = true;
            this.makeField.BackColor = System.Drawing.SystemColors.Window;
            this.makeField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.makeField.Location = new System.Drawing.Point(93, 73);
            this.makeField.Name = "makeField";
            this.makeField.Size = new System.Drawing.Size(119, 23);
            this.makeField.TabIndex = 14;
            // 
            // colorField
            // 
            this.colorField.AcceptsTab = true;
            this.colorField.BackColor = System.Drawing.SystemColors.Window;
            this.colorField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorField.Location = new System.Drawing.Point(556, 73);
            this.colorField.Name = "colorField";
            this.colorField.Size = new System.Drawing.Size(119, 23);
            this.colorField.TabIndex = 20;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.modelLabel.Location = new System.Drawing.Point(245, 50);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(53, 20);
            this.modelLabel.TabIndex = 15;
            this.modelLabel.Text = "Model";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.colorLabel.Location = new System.Drawing.Point(556, 50);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(46, 20);
            this.colorLabel.TabIndex = 19;
            this.colorLabel.Text = "Color";
            // 
            // modelField
            // 
            this.modelField.AcceptsTab = true;
            this.modelField.BackColor = System.Drawing.SystemColors.Window;
            this.modelField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modelField.Location = new System.Drawing.Point(245, 73);
            this.modelField.Name = "modelField";
            this.modelField.Size = new System.Drawing.Size(119, 23);
            this.modelField.TabIndex = 16;
            // 
            // yearField
            // 
            this.yearField.AcceptsTab = true;
            this.yearField.BackColor = System.Drawing.SystemColors.Window;
            this.yearField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearField.Location = new System.Drawing.Point(400, 73);
            this.yearField.Name = "yearField";
            this.yearField.Size = new System.Drawing.Size(119, 23);
            this.yearField.TabIndex = 18;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yearLabel.Location = new System.Drawing.Point(400, 50);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(39, 20);
            this.yearLabel.TabIndex = 17;
            this.yearLabel.Text = "Year";
            // 
            // customers
            // 
            this.customers.Controls.Add(this.dataGridView4);
            this.customers.Controls.Add(this.textBox16);
            this.customers.Controls.Add(this.label7);
            this.customers.Controls.Add(this.label8);
            this.customers.Controls.Add(this.textBox17);
            this.customers.Controls.Add(this.textBox18);
            this.customers.Controls.Add(this.label9);
            this.customers.Controls.Add(this.label10);
            this.customers.Controls.Add(this.textBox19);
            this.customers.Controls.Add(this.textBox20);
            this.customers.Controls.Add(this.label11);
            this.customers.Location = new System.Drawing.Point(4, 24);
            this.customers.Name = "customers";
            this.customers.Padding = new System.Windows.Forms.Padding(3);
            this.customers.Size = new System.Drawing.Size(953, 510);
            this.customers.TabIndex = 1;
            this.customers.Text = "Customers";
            this.customers.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 124);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 25;
            this.dataGridView4.Size = new System.Drawing.Size(941, 336);
            this.dataGridView4.TabIndex = 23;
            // 
            // textBox16
            // 
            this.textBox16.AcceptsTab = true;
            this.textBox16.BackColor = System.Drawing.SystemColors.Window;
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox16.Location = new System.Drawing.Point(703, 73);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(119, 23);
            this.textBox16.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(93, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(703, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Daily Price";
            // 
            // textBox17
            // 
            this.textBox17.AcceptsTab = true;
            this.textBox17.BackColor = System.Drawing.SystemColors.Window;
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox17.Location = new System.Drawing.Point(93, 73);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(119, 23);
            this.textBox17.TabIndex = 14;
            // 
            // textBox18
            // 
            this.textBox18.AcceptsTab = true;
            this.textBox18.BackColor = System.Drawing.SystemColors.Window;
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox18.Location = new System.Drawing.Point(556, 73);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(119, 23);
            this.textBox18.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(245, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(556, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "label10";
            // 
            // textBox19
            // 
            this.textBox19.AcceptsTab = true;
            this.textBox19.BackColor = System.Drawing.SystemColors.Window;
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox19.Location = new System.Drawing.Point(245, 73);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(119, 23);
            this.textBox19.TabIndex = 16;
            // 
            // textBox20
            // 
            this.textBox20.AcceptsTab = true;
            this.textBox20.BackColor = System.Drawing.SystemColors.Window;
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox20.Location = new System.Drawing.Point(400, 73);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(119, 23);
            this.textBox20.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(400, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "label11";
            // 
            // rentedCars
            // 
            this.rentedCars.Controls.Add(this.dataGridView3);
            this.rentedCars.Controls.Add(this.textBox11);
            this.rentedCars.Controls.Add(this.label1);
            this.rentedCars.Controls.Add(this.label3);
            this.rentedCars.Controls.Add(this.textBox12);
            this.rentedCars.Controls.Add(this.textBox13);
            this.rentedCars.Controls.Add(this.label4);
            this.rentedCars.Controls.Add(this.label5);
            this.rentedCars.Controls.Add(this.textBox14);
            this.rentedCars.Controls.Add(this.textBox15);
            this.rentedCars.Controls.Add(this.label6);
            this.rentedCars.Location = new System.Drawing.Point(4, 24);
            this.rentedCars.Name = "rentedCars";
            this.rentedCars.Size = new System.Drawing.Size(953, 510);
            this.rentedCars.TabIndex = 2;
            this.rentedCars.Text = "Rented Cars";
            this.rentedCars.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 124);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(941, 336);
            this.dataGridView3.TabIndex = 23;
            // 
            // textBox11
            // 
            this.textBox11.AcceptsTab = true;
            this.textBox11.BackColor = System.Drawing.SystemColors.Window;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox11.Location = new System.Drawing.Point(703, 73);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(119, 23);
            this.textBox11.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(703, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Daily Price";
            // 
            // textBox12
            // 
            this.textBox12.AcceptsTab = true;
            this.textBox12.BackColor = System.Drawing.SystemColors.Window;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Location = new System.Drawing.Point(93, 73);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(119, 23);
            this.textBox12.TabIndex = 14;
            // 
            // textBox13
            // 
            this.textBox13.AcceptsTab = true;
            this.textBox13.BackColor = System.Drawing.SystemColors.Window;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.Location = new System.Drawing.Point(556, 73);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(119, 23);
            this.textBox13.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(245, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(556, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "label5";
            // 
            // textBox14
            // 
            this.textBox14.AcceptsTab = true;
            this.textBox14.BackColor = System.Drawing.SystemColors.Window;
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox14.Location = new System.Drawing.Point(245, 73);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(119, 23);
            this.textBox14.TabIndex = 16;
            // 
            // textBox15
            // 
            this.textBox15.AcceptsTab = true;
            this.textBox15.BackColor = System.Drawing.SystemColors.Window;
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox15.Location = new System.Drawing.Point(400, 73);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(119, 23);
            this.textBox15.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(400, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "label6";
            // 
            // rentalInfo
            // 
            this.rentalInfo.Controls.Add(this.dataGridView2);
            this.rentalInfo.Controls.Add(this.rentalOrderIdLabel);
            this.rentalInfo.Controls.Add(this.rentalOrderIdField);
            this.rentalInfo.Controls.Add(this.totalPriceField);
            this.rentalInfo.Controls.Add(this.rentStartLabel);
            this.rentalInfo.Controls.Add(this.totalPriceLabel);
            this.rentalInfo.Controls.Add(this.rentStartField);
            this.rentalInfo.Controls.Add(this.rentEndField);
            this.rentalInfo.Controls.Add(this.rentEndLabel);
            this.rentalInfo.Location = new System.Drawing.Point(4, 24);
            this.rentalInfo.Name = "rentalInfo";
            this.rentalInfo.Size = new System.Drawing.Size(953, 510);
            this.rentalInfo.TabIndex = 3;
            this.rentalInfo.Text = "Rental Info";
            this.rentalInfo.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_id,
            this.rent_start_date,
            this.rent_end_date,
            this.total_price});
            this.dataGridView2.Location = new System.Drawing.Point(6, 124);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(941, 336);
            this.dataGridView2.TabIndex = 23;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // rentalOrderIdLabel
            // 
            this.rentalOrderIdLabel.AutoSize = true;
            this.rentalOrderIdLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rentalOrderIdLabel.Location = new System.Drawing.Point(93, 50);
            this.rentalOrderIdLabel.Name = "rentalOrderIdLabel";
            this.rentalOrderIdLabel.Size = new System.Drawing.Size(69, 20);
            this.rentalOrderIdLabel.TabIndex = 13;
            this.rentalOrderIdLabel.Text = "Order ID";
            this.rentalOrderIdLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // rentalOrderIdField
            // 
            this.rentalOrderIdField.AcceptsTab = true;
            this.rentalOrderIdField.BackColor = System.Drawing.SystemColors.Window;
            this.rentalOrderIdField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rentalOrderIdField.Location = new System.Drawing.Point(93, 73);
            this.rentalOrderIdField.Name = "rentalOrderIdField";
            this.rentalOrderIdField.Size = new System.Drawing.Size(119, 23);
            this.rentalOrderIdField.TabIndex = 14;
            this.rentalOrderIdField.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // totalPriceField
            // 
            this.totalPriceField.AcceptsTab = true;
            this.totalPriceField.BackColor = System.Drawing.SystemColors.Window;
            this.totalPriceField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceField.Location = new System.Drawing.Point(556, 73);
            this.totalPriceField.Name = "totalPriceField";
            this.totalPriceField.Size = new System.Drawing.Size(119, 23);
            this.totalPriceField.TabIndex = 20;
            this.totalPriceField.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // rentStartLabel
            // 
            this.rentStartLabel.AutoSize = true;
            this.rentStartLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rentStartLabel.Location = new System.Drawing.Point(245, 50);
            this.rentStartLabel.Name = "rentStartLabel";
            this.rentStartLabel.Size = new System.Drawing.Size(117, 20);
            this.rentStartLabel.TabIndex = 15;
            this.rentStartLabel.Text = "Rent Start Date";
            this.rentStartLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalPriceLabel.Location = new System.Drawing.Point(556, 50);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(82, 20);
            this.totalPriceLabel.TabIndex = 19;
            this.totalPriceLabel.Text = "Total Price";
            this.totalPriceLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // rentStartField
            // 
            this.rentStartField.AcceptsTab = true;
            this.rentStartField.BackColor = System.Drawing.SystemColors.Window;
            this.rentStartField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rentStartField.Location = new System.Drawing.Point(245, 73);
            this.rentStartField.Name = "rentStartField";
            this.rentStartField.Size = new System.Drawing.Size(119, 23);
            this.rentStartField.TabIndex = 16;
            this.rentStartField.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // rentEndField
            // 
            this.rentEndField.AcceptsTab = true;
            this.rentEndField.BackColor = System.Drawing.SystemColors.Window;
            this.rentEndField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rentEndField.Location = new System.Drawing.Point(400, 73);
            this.rentEndField.Name = "rentEndField";
            this.rentEndField.Size = new System.Drawing.Size(119, 23);
            this.rentEndField.TabIndex = 18;
            this.rentEndField.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // rentEndLabel
            // 
            this.rentEndLabel.AutoSize = true;
            this.rentEndLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rentEndLabel.Location = new System.Drawing.Point(400, 50);
            this.rentEndLabel.Name = "rentEndLabel";
            this.rentEndLabel.Size = new System.Drawing.Size(109, 20);
            this.rentEndLabel.TabIndex = 17;
            this.rentEndLabel.Text = "Rent End Date";
            this.rentEndLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // order_id
            // 
            this.order_id.HeaderText = "Order ID";
            this.order_id.Name = "order_id";
            this.order_id.Width = 225;
            // 
            // rent_start_date
            // 
            this.rent_start_date.HeaderText = "Rent Start Date";
            this.rent_start_date.Name = "rent_start_date";
            this.rent_start_date.Width = 225;
            // 
            // rent_end_date
            // 
            this.rent_end_date.HeaderText = "Rent End Date";
            this.rent_end_date.Name = "rent_end_date";
            this.rent_end_date.Width = 225;
            // 
            // total_price
            // 
            this.total_price.HeaderText = "Total Price";
            this.total_price.Name = "total_price";
            this.total_price.Width = 225;
            // 
            // CarRentalSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 575);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Name = "CarRentalSystem";
            this.Text = "Car Rental System";
            this.Load += new System.EventHandler(this.CarList_Load);
            this.tabControl1.ResumeLayout(false);
            this.carList.ResumeLayout(false);
            this.carList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.customers.ResumeLayout(false);
            this.customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.rentedCars.ResumeLayout(false);
            this.rentedCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.rentalInfo.ResumeLayout(false);
            this.rentalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private TabControl tabControl1;
        private TabPage carList;
        private TabPage customers;
        private TabPage rentedCars;
        private TabPage rentalInfo;
        private DataGridView dataGridView2;
        private Label rentalOrderIdLabel;
        private TextBox rentalOrderIdField;
        private TextBox totalPriceField;
        private Label rentStartLabel;
        private Label totalPriceLabel;
        private TextBox rentStartField;
        private TextBox rentEndField;
        private Label rentEndLabel;
        private DataGridView dataGridView1;
        private TextBox dailyPriceField;
        private Label makeLabel;
        private Label dailyPriceLabel;
        private TextBox makeField;
        private TextBox colorField;
        private Label modelLabel;
        private Label colorLabel;
        private TextBox modelField;
        private TextBox yearField;
        private Label yearLabel;
        private DataGridView dataGridView4;
        private TextBox textBox16;
        private Label label7;
        private Label label8;
        private TextBox textBox17;
        private TextBox textBox18;
        private Label label9;
        private Label label10;
        private TextBox textBox19;
        private TextBox textBox20;
        private Label label11;
        private DataGridView dataGridView3;
        private TextBox textBox11;
        private Label label1;
        private Label label3;
        private TextBox textBox12;
        private TextBox textBox13;
        private Label label4;
        private Label label5;
        private TextBox textBox14;
        private TextBox textBox15;
        private Label label6;
        private DataGridViewTextBoxColumn make;
        private DataGridViewTextBoxColumn model;
        private DataGridViewTextBoxColumn year;
        private DataGridViewTextBoxColumn color;
        private DataGridViewTextBoxColumn daily_price;
        private DataGridViewTextBoxColumn order_id;
        private DataGridViewTextBoxColumn rent_start_date;
        private DataGridViewTextBoxColumn rent_end_date;
        private DataGridViewTextBoxColumn total_price;
    }
}