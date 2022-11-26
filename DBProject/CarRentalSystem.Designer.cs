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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarRentalSystem));
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.carList = new System.Windows.Forms.TabPage();
            this.availableField = new System.Windows.Forms.CheckBox();
            this.insert_car_list = new System.Windows.Forms.Button();
            this.car_list = new System.Windows.Forms.DataGridView();
            this.carID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.make = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daily_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.available = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.insert_cust_list = new System.Windows.Forms.Button();
            this.customersTable = new System.Windows.Forms.DataGridView();
            this.CUST_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIRST_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAST_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailField = new System.Windows.Forms.TextBox();
            this.customerFNLabel = new System.Windows.Forms.Label();
            this.customerEmailLabel = new System.Windows.Forms.Label();
            this.customerFNField = new System.Windows.Forms.TextBox();
            this.customerLNField = new System.Windows.Forms.TextBox();
            this.customerLNLabel = new System.Windows.Forms.Label();
            this.rentedCars = new System.Windows.Forms.TabPage();
            this.rentedCarsTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAR_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcSTATEField = new System.Windows.Forms.TextBox();
            this.rcSTATELabel = new System.Windows.Forms.Label();
            this.rcCITYField = new System.Windows.Forms.TextBox();
            this.rcCARIDLabel = new System.Windows.Forms.Label();
            this.rcCITYLabel = new System.Windows.Forms.Label();
            this.rcCARIDField = new System.Windows.Forms.TextBox();
            this.rcCUSTIDField = new System.Windows.Forms.TextBox();
            this.rcCUSTIDLabel = new System.Windows.Forms.Label();
            this.rentalInfo = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rent_start_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rent_end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalOrderIdLabel = new System.Windows.Forms.Label();
            this.rentalOrderIdField = new System.Windows.Forms.TextBox();
            this.totalPriceField = new System.Windows.Forms.TextBox();
            this.rentStartLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.rentStartField = new System.Windows.Forms.TextBox();
            this.rentEndField = new System.Windows.Forms.TextBox();
            this.rentEndLabel = new System.Windows.Forms.Label();
            this.insert_rented_cars = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.carList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.car_list)).BeginInit();
            this.customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersTable)).BeginInit();
            this.rentedCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentedCarsTable)).BeginInit();
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
            this.carList.Controls.Add(this.availableField);
            this.carList.Controls.Add(this.insert_car_list);
            this.carList.Controls.Add(this.car_list);
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
            // 
            // availableField
            // 
            this.availableField.AutoSize = true;
            this.availableField.Location = new System.Drawing.Point(850, 71);
            this.availableField.Name = "availableField";
            this.availableField.Size = new System.Drawing.Size(74, 19);
            this.availableField.TabIndex = 25;
            this.availableField.Text = "Available";
            this.availableField.UseVisualStyleBackColor = true;
            // 
            // insert_car_list
            // 
            this.insert_car_list.Location = new System.Drawing.Point(850, 95);
            this.insert_car_list.Name = "insert_car_list";
            this.insert_car_list.Size = new System.Drawing.Size(75, 23);
            this.insert_car_list.TabIndex = 24;
            this.insert_car_list.Text = "Insert";
            this.insert_car_list.UseVisualStyleBackColor = true;
            this.insert_car_list.Click += new System.EventHandler(this.insert_car_list_Click);
            // 
            // car_list
            // 
            this.car_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.car_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carID,
            this.make,
            this.model,
            this.year,
            this.color,
            this.daily_price,
            this.available});
            this.car_list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.car_list.Location = new System.Drawing.Point(6, 124);
            this.car_list.Name = "car_list";
            this.car_list.RowTemplate.Height = 25;
            this.car_list.Size = new System.Drawing.Size(941, 336);
            this.car_list.TabIndex = 23;
            // 
            // carID
            // 
            this.carID.HeaderText = "Car ID";
            this.carID.Name = "carID";
            this.carID.Width = 130;
            // 
            // make
            // 
            this.make.HeaderText = "Make";
            this.make.Name = "make";
            this.make.Width = 130;
            // 
            // model
            // 
            this.model.HeaderText = "Model";
            this.model.Name = "model";
            this.model.Width = 130;
            // 
            // year
            // 
            this.year.HeaderText = "Year";
            this.year.Name = "year";
            this.year.Width = 130;
            // 
            // color
            // 
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.Width = 130;
            // 
            // daily_price
            // 
            this.daily_price.HeaderText = "Daily Price";
            this.daily_price.Name = "daily_price";
            this.daily_price.Width = 130;
            // 
            // available
            // 
            this.available.HeaderText = "Available";
            this.available.Name = "available";
            this.available.Width = 130;
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
            this.customers.Controls.Add(this.insert_cust_list);
            this.customers.Controls.Add(this.customersTable);
            this.customers.Controls.Add(this.customerEmailField);
            this.customers.Controls.Add(this.customerFNLabel);
            this.customers.Controls.Add(this.customerEmailLabel);
            this.customers.Controls.Add(this.customerFNField);
            this.customers.Controls.Add(this.customerLNField);
            this.customers.Controls.Add(this.customerLNLabel);
            this.customers.Location = new System.Drawing.Point(4, 24);
            this.customers.Name = "customers";
            this.customers.Padding = new System.Windows.Forms.Padding(3);
            this.customers.Size = new System.Drawing.Size(953, 510);
            this.customers.TabIndex = 1;
            this.customers.Text = "Customers";
            this.customers.UseVisualStyleBackColor = true;
            // 
            // insert_cust_list
            // 
            this.insert_cust_list.Location = new System.Drawing.Point(850, 95);
            this.insert_cust_list.Name = "insert_cust_list";
            this.insert_cust_list.Size = new System.Drawing.Size(75, 23);
            this.insert_cust_list.TabIndex = 24;
            this.insert_cust_list.Text = "Insert";
            this.insert_cust_list.UseVisualStyleBackColor = true;
            this.insert_cust_list.Click += new System.EventHandler(this.insert_cust_list_Click);
            // 
            // customersTable
            // 
            this.customersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUST_ID,
            this.FIRST_NAME,
            this.LAST_NAME,
            this.EMAIL});
            this.customersTable.Location = new System.Drawing.Point(6, 124);
            this.customersTable.Name = "customersTable";
            this.customersTable.RowTemplate.Height = 25;
            this.customersTable.Size = new System.Drawing.Size(941, 336);
            this.customersTable.TabIndex = 23;
            // 
            // CUST_ID
            // 
            this.CUST_ID.HeaderText = "CUSTOMER ID";
            this.CUST_ID.Name = "CUST_ID";
            this.CUST_ID.Width = 225;
            // 
            // FIRST_NAME
            // 
            this.FIRST_NAME.HeaderText = "FIRST NAME";
            this.FIRST_NAME.Name = "FIRST_NAME";
            this.FIRST_NAME.Width = 225;
            // 
            // LAST_NAME
            // 
            this.LAST_NAME.HeaderText = "LAST NAME";
            this.LAST_NAME.Name = "LAST_NAME";
            this.LAST_NAME.Width = 225;
            // 
            // EMAIL
            // 
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Width = 225;
            // 
            // customerEmailField
            // 
            this.customerEmailField.AcceptsTab = true;
            this.customerEmailField.BackColor = System.Drawing.SystemColors.Window;
            this.customerEmailField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerEmailField.Location = new System.Drawing.Point(400, 73);
            this.customerEmailField.Name = "customerEmailField";
            this.customerEmailField.Size = new System.Drawing.Size(119, 23);
            this.customerEmailField.TabIndex = 20;
            // 
            // customerFNLabel
            // 
            this.customerFNLabel.AutoSize = true;
            this.customerFNLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerFNLabel.Location = new System.Drawing.Point(93, 50);
            this.customerFNLabel.Name = "customerFNLabel";
            this.customerFNLabel.Size = new System.Drawing.Size(86, 20);
            this.customerFNLabel.TabIndex = 15;
            this.customerFNLabel.Text = "First Name";
            // 
            // customerEmailLabel
            // 
            this.customerEmailLabel.AutoSize = true;
            this.customerEmailLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerEmailLabel.Location = new System.Drawing.Point(400, 50);
            this.customerEmailLabel.Name = "customerEmailLabel";
            this.customerEmailLabel.Size = new System.Drawing.Size(47, 20);
            this.customerEmailLabel.TabIndex = 19;
            this.customerEmailLabel.Text = "Email";
            // 
            // customerFNField
            // 
            this.customerFNField.AcceptsTab = true;
            this.customerFNField.BackColor = System.Drawing.SystemColors.Window;
            this.customerFNField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerFNField.Location = new System.Drawing.Point(93, 73);
            this.customerFNField.Name = "customerFNField";
            this.customerFNField.Size = new System.Drawing.Size(119, 23);
            this.customerFNField.TabIndex = 16;
            // 
            // customerLNField
            // 
            this.customerLNField.AcceptsTab = true;
            this.customerLNField.BackColor = System.Drawing.SystemColors.Window;
            this.customerLNField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerLNField.Location = new System.Drawing.Point(245, 73);
            this.customerLNField.Name = "customerLNField";
            this.customerLNField.Size = new System.Drawing.Size(119, 23);
            this.customerLNField.TabIndex = 18;
            // 
            // customerLNLabel
            // 
            this.customerLNLabel.AutoSize = true;
            this.customerLNLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerLNLabel.Location = new System.Drawing.Point(245, 50);
            this.customerLNLabel.Name = "customerLNLabel";
            this.customerLNLabel.Size = new System.Drawing.Size(84, 20);
            this.customerLNLabel.TabIndex = 17;
            this.customerLNLabel.Text = "Last Name";
            // 
            // rentedCars
            // 
            this.rentedCars.Controls.Add(this.insert_rented_cars);
            this.rentedCars.Controls.Add(this.rentedCarsTable);
            this.rentedCars.Controls.Add(this.rcSTATEField);
            this.rentedCars.Controls.Add(this.rcSTATELabel);
            this.rentedCars.Controls.Add(this.rcCITYField);
            this.rentedCars.Controls.Add(this.rcCARIDLabel);
            this.rentedCars.Controls.Add(this.rcCITYLabel);
            this.rentedCars.Controls.Add(this.rcCARIDField);
            this.rentedCars.Controls.Add(this.rcCUSTIDField);
            this.rentedCars.Controls.Add(this.rcCUSTIDLabel);
            this.rentedCars.Location = new System.Drawing.Point(4, 24);
            this.rentedCars.Name = "rentedCars";
            this.rentedCars.Size = new System.Drawing.Size(953, 510);
            this.rentedCars.TabIndex = 2;
            this.rentedCars.Text = "Rented Cars";
            this.rentedCars.UseVisualStyleBackColor = true;
            // 
            // rentedCarsTable
            // 
            this.rentedCarsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentedCarsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.CAR_ID,
            this.dataGridViewTextBoxColumn2,
            this.CITY,
            this.STATE});
            this.rentedCarsTable.Location = new System.Drawing.Point(6, 124);
            this.rentedCarsTable.Name = "rentedCarsTable";
            this.rentedCarsTable.RowTemplate.Height = 25;
            this.rentedCarsTable.Size = new System.Drawing.Size(941, 336);
            this.rentedCarsTable.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ORDER ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 180;
            // 
            // CAR_ID
            // 
            this.CAR_ID.HeaderText = "CAR ID";
            this.CAR_ID.Name = "CAR_ID";
            this.CAR_ID.Width = 180;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "CUST ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 180;
            // 
            // CITY
            // 
            this.CITY.HeaderText = "CITY";
            this.CITY.Name = "CITY";
            this.CITY.Width = 180;
            // 
            // STATE
            // 
            this.STATE.HeaderText = "STATE";
            this.STATE.Name = "STATE";
            this.STATE.Width = 180;
            // 
            // rcSTATEField
            // 
            this.rcSTATEField.AcceptsTab = true;
            this.rcSTATEField.BackColor = System.Drawing.SystemColors.Window;
            this.rcSTATEField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rcSTATEField.Location = new System.Drawing.Point(556, 73);
            this.rcSTATEField.Name = "rcSTATEField";
            this.rcSTATEField.Size = new System.Drawing.Size(119, 23);
            this.rcSTATEField.TabIndex = 22;
            // 
            // rcSTATELabel
            // 
            this.rcSTATELabel.AutoSize = true;
            this.rcSTATELabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rcSTATELabel.Location = new System.Drawing.Point(556, 50);
            this.rcSTATELabel.Name = "rcSTATELabel";
            this.rcSTATELabel.Size = new System.Drawing.Size(45, 20);
            this.rcSTATELabel.TabIndex = 21;
            this.rcSTATELabel.Text = "State";
            // 
            // rcCITYField
            // 
            this.rcCITYField.AcceptsTab = true;
            this.rcCITYField.BackColor = System.Drawing.SystemColors.Window;
            this.rcCITYField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rcCITYField.Location = new System.Drawing.Point(400, 73);
            this.rcCITYField.Name = "rcCITYField";
            this.rcCITYField.Size = new System.Drawing.Size(119, 23);
            this.rcCITYField.TabIndex = 20;
            // 
            // rcCARIDLabel
            // 
            this.rcCARIDLabel.AutoSize = true;
            this.rcCARIDLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rcCARIDLabel.Location = new System.Drawing.Point(93, 50);
            this.rcCARIDLabel.Name = "rcCARIDLabel";
            this.rcCARIDLabel.Size = new System.Drawing.Size(52, 20);
            this.rcCARIDLabel.TabIndex = 15;
            this.rcCARIDLabel.Text = "Car ID";
            // 
            // rcCITYLabel
            // 
            this.rcCITYLabel.AutoSize = true;
            this.rcCITYLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rcCITYLabel.Location = new System.Drawing.Point(400, 50);
            this.rcCITYLabel.Name = "rcCITYLabel";
            this.rcCITYLabel.Size = new System.Drawing.Size(36, 20);
            this.rcCITYLabel.TabIndex = 19;
            this.rcCITYLabel.Text = "City";
            // 
            // rcCARIDField
            // 
            this.rcCARIDField.AcceptsTab = true;
            this.rcCARIDField.BackColor = System.Drawing.SystemColors.Window;
            this.rcCARIDField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rcCARIDField.Location = new System.Drawing.Point(93, 73);
            this.rcCARIDField.Name = "rcCARIDField";
            this.rcCARIDField.Size = new System.Drawing.Size(119, 23);
            this.rcCARIDField.TabIndex = 16;
            // 
            // rcCUSTIDField
            // 
            this.rcCUSTIDField.AcceptsTab = true;
            this.rcCUSTIDField.BackColor = System.Drawing.SystemColors.Window;
            this.rcCUSTIDField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rcCUSTIDField.Location = new System.Drawing.Point(245, 73);
            this.rcCUSTIDField.Name = "rcCUSTIDField";
            this.rcCUSTIDField.Size = new System.Drawing.Size(119, 23);
            this.rcCUSTIDField.TabIndex = 18;
            // 
            // rcCUSTIDLabel
            // 
            this.rcCUSTIDLabel.AutoSize = true;
            this.rcCUSTIDLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rcCUSTIDLabel.Location = new System.Drawing.Point(245, 50);
            this.rcCUSTIDLabel.Name = "rcCUSTIDLabel";
            this.rcCUSTIDLabel.Size = new System.Drawing.Size(97, 20);
            this.rcCUSTIDLabel.TabIndex = 17;
            this.rcCUSTIDLabel.Text = "Customer ID";
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
            // rentalOrderIdLabel
            // 
            this.rentalOrderIdLabel.AutoSize = true;
            this.rentalOrderIdLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rentalOrderIdLabel.Location = new System.Drawing.Point(93, 50);
            this.rentalOrderIdLabel.Name = "rentalOrderIdLabel";
            this.rentalOrderIdLabel.Size = new System.Drawing.Size(69, 20);
            this.rentalOrderIdLabel.TabIndex = 13;
            this.rentalOrderIdLabel.Text = "Order ID";
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
            // 
            // insert_rented_cars
            // 
            this.insert_rented_cars.Location = new System.Drawing.Point(850, 95);
            this.insert_rented_cars.Name = "insert_rented_cars";
            this.insert_rented_cars.Size = new System.Drawing.Size(75, 23);
            this.insert_rented_cars.TabIndex = 24;
            this.insert_rented_cars.Text = "Insert";
            this.insert_rented_cars.UseVisualStyleBackColor = true;
            this.insert_rented_cars.Click += new System.EventHandler(this.insert_rented_cars_Click);
            // 
            // CarRentalSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 575);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CarRentalSystem";
            this.Text = "Car Rental System";
            this.Load += new System.EventHandler(this.CarList_Load);
            this.tabControl1.ResumeLayout(false);
            this.carList.ResumeLayout(false);
            this.carList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.car_list)).EndInit();
            this.customers.ResumeLayout(false);
            this.customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersTable)).EndInit();
            this.rentedCars.ResumeLayout(false);
            this.rentedCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentedCarsTable)).EndInit();
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
        private DataGridView car_list;
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
        private DataGridView customersTable;
        private TextBox customerEmailField;
        private Label customerFNLabel;
        private Label customerEmailLabel;
        private TextBox customerFNField;
        private TextBox customerLNField;
        private Label customerLNLabel;
        private DataGridView rentedCarsTable;
        private TextBox rcSTATEField;
        private Label rcSTATELabel;
        private TextBox rcCITYField;
        private Label rcCARIDLabel;
        private Label rcCITYLabel;
        private TextBox rcCARIDField;
        private TextBox rcCUSTIDField;
        private Label rcCUSTIDLabel;
        private DataGridViewTextBoxColumn order_id;
        private DataGridViewTextBoxColumn rent_start_date;
        private DataGridViewTextBoxColumn rent_end_date;
        private DataGridViewTextBoxColumn total_price;
        private DataGridViewTextBoxColumn CUST_ID;
        private DataGridViewTextBoxColumn FIRST_NAME;
        private DataGridViewTextBoxColumn LAST_NAME;
        private DataGridViewTextBoxColumn EMAIL;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn CAR_ID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn CITY;
        private DataGridViewTextBoxColumn STATE;
        private Button insert_car_list;
        private CheckBox availableField;
        private DataGridViewTextBoxColumn carID;
        private DataGridViewTextBoxColumn make;
        private DataGridViewTextBoxColumn model;
        private DataGridViewTextBoxColumn year;
        private DataGridViewTextBoxColumn color;
        private DataGridViewTextBoxColumn daily_price;
        private DataGridViewTextBoxColumn available;
        private Button insert_cust_list;
        private Button insert_rented_cars;
    }
}