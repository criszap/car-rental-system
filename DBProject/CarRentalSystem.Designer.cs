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
            this.rentalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.rentalInfo.ResumeLayout(false);
            this.rentalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
    }
}