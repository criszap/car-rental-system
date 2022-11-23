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
            this.customers = new System.Windows.Forms.TabPage();
            this.rentedCars = new System.Windows.Forms.TabPage();
            this.rentalInfo = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.orderID = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.rentStart = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.rentEnd = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Make = new System.Windows.Forms.Label();
            this.DailyPrice = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.carList.SuspendLayout();
            this.customers.SuspendLayout();
            this.rentedCars.SuspendLayout();
            this.rentalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.carList.Controls.Add(this.textBox5);
            this.carList.Controls.Add(this.Make);
            this.carList.Controls.Add(this.DailyPrice);
            this.carList.Controls.Add(this.textBox1);
            this.carList.Controls.Add(this.textBox4);
            this.carList.Controls.Add(this.Model);
            this.carList.Controls.Add(this.Color);
            this.carList.Controls.Add(this.textBox2);
            this.carList.Controls.Add(this.textBox3);
            this.carList.Controls.Add(this.Year);
            this.carList.Location = new System.Drawing.Point(4, 24);
            this.carList.Name = "carList";
            this.carList.Padding = new System.Windows.Forms.Padding(3);
            this.carList.Size = new System.Drawing.Size(953, 510);
            this.carList.TabIndex = 0;
            this.carList.Text = "Car List";
            this.carList.UseVisualStyleBackColor = true;
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
            // rentalInfo
            // 
            this.rentalInfo.Controls.Add(this.dataGridView2);
            this.rentalInfo.Controls.Add(this.textBox6);
            this.rentalInfo.Controls.Add(this.orderID);
            this.rentalInfo.Controls.Add(this.textBox7);
            this.rentalInfo.Controls.Add(this.textBox8);
            this.rentalInfo.Controls.Add(this.rentStart);
            this.rentalInfo.Controls.Add(this.totalPrice);
            this.rentalInfo.Controls.Add(this.textBox9);
            this.rentalInfo.Controls.Add(this.textBox10);
            this.rentalInfo.Controls.Add(this.rentEnd);
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
            this.dataGridView2.Location = new System.Drawing.Point(6, 124);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(941, 336);
            this.dataGridView2.TabIndex = 23;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // orderID
            // 
            this.orderID.AutoSize = true;
            this.orderID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderID.Location = new System.Drawing.Point(93, 50);
            this.orderID.Name = "orderID";
            this.orderID.Size = new System.Drawing.Size(69, 20);
            this.orderID.TabIndex = 13;
            this.orderID.Text = "Order ID";
            this.orderID.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // textBox7
            // 
            this.textBox7.AcceptsTab = true;
            this.textBox7.BackColor = System.Drawing.SystemColors.Window;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Location = new System.Drawing.Point(93, 73);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(119, 23);
            this.textBox7.TabIndex = 14;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.AcceptsTab = true;
            this.textBox8.BackColor = System.Drawing.SystemColors.Window;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Location = new System.Drawing.Point(556, 73);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(119, 23);
            this.textBox8.TabIndex = 20;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // rentStart
            // 
            this.rentStart.AutoSize = true;
            this.rentStart.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rentStart.Location = new System.Drawing.Point(245, 50);
            this.rentStart.Name = "rentStart";
            this.rentStart.Size = new System.Drawing.Size(117, 20);
            this.rentStart.TabIndex = 15;
            this.rentStart.Text = "Rent Start Date";
            this.rentStart.Click += new System.EventHandler(this.label4_Click);
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalPrice.Location = new System.Drawing.Point(556, 50);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(82, 20);
            this.totalPrice.TabIndex = 19;
            this.totalPrice.Text = "Total Price";
            this.totalPrice.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox9
            // 
            this.textBox9.AcceptsTab = true;
            this.textBox9.BackColor = System.Drawing.SystemColors.Window;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Location = new System.Drawing.Point(245, 73);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(119, 23);
            this.textBox9.TabIndex = 16;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.AcceptsTab = true;
            this.textBox10.BackColor = System.Drawing.SystemColors.Window;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Location = new System.Drawing.Point(400, 73);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(119, 23);
            this.textBox10.TabIndex = 18;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // rentEnd
            // 
            this.rentEnd.AutoSize = true;
            this.rentEnd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rentEnd.Location = new System.Drawing.Point(400, 50);
            this.rentEnd.Name = "rentEnd";
            this.rentEnd.Size = new System.Drawing.Size(109, 20);
            this.rentEnd.TabIndex = 17;
            this.rentEnd.Text = "Rent End Date";
            this.rentEnd.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox6
            // 
            this.textBox6.AcceptsTab = true;
            this.textBox6.BackColor = System.Drawing.SystemColors.Window;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(703, 73);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(119, 23);
            this.textBox6.TabIndex = 22;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(941, 336);
            this.dataGridView1.TabIndex = 23;
            // 
            // textBox5
            // 
            this.textBox5.AcceptsTab = true;
            this.textBox5.BackColor = System.Drawing.SystemColors.Window;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(703, 73);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(119, 23);
            this.textBox5.TabIndex = 22;
            // 
            // Make
            // 
            this.Make.AutoSize = true;
            this.Make.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Make.Location = new System.Drawing.Point(93, 50);
            this.Make.Name = "Make";
            this.Make.Size = new System.Drawing.Size(47, 20);
            this.Make.TabIndex = 13;
            this.Make.Text = "Make";
            // 
            // DailyPrice
            // 
            this.DailyPrice.AutoSize = true;
            this.DailyPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DailyPrice.Location = new System.Drawing.Point(703, 50);
            this.DailyPrice.Name = "DailyPrice";
            this.DailyPrice.Size = new System.Drawing.Size(82, 20);
            this.DailyPrice.TabIndex = 21;
            this.DailyPrice.Text = "Daily Price";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(93, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 23);
            this.textBox1.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.AcceptsTab = true;
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(556, 73);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(119, 23);
            this.textBox4.TabIndex = 20;
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Model.Location = new System.Drawing.Point(245, 50);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(53, 20);
            this.Model.TabIndex = 15;
            this.Model.Text = "Model";
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Color.Location = new System.Drawing.Point(556, 50);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(46, 20);
            this.Color.TabIndex = 19;
            this.Color.Text = "Color";
            // 
            // textBox2
            // 
            this.textBox2.AcceptsTab = true;
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(245, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 23);
            this.textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.AcceptsTab = true;
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(400, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(119, 23);
            this.textBox3.TabIndex = 18;
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Year.Location = new System.Drawing.Point(400, 50);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(39, 20);
            this.Year.TabIndex = 17;
            this.Year.Text = "Year";
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
            this.customers.ResumeLayout(false);
            this.customers.PerformLayout();
            this.rentedCars.ResumeLayout(false);
            this.rentedCars.PerformLayout();
            this.rentalInfo.ResumeLayout(false);
            this.rentalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private Label orderID;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label rentStart;
        private Label totalPrice;
        private TextBox textBox9;
        private TextBox textBox10;
        private Label rentEnd;
        private DataGridView dataGridView1;
        private TextBox textBox5;
        private Label Make;
        private Label DailyPrice;
        private TextBox textBox1;
        private TextBox textBox4;
        private Label Model;
        private Label Color;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label Year;
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
        private TextBox textBox6;
    }
}