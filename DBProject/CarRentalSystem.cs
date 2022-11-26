using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Web;
using System.Diagnostics;

namespace DBProject {
    public partial class CarRentalSystem : Form {
        //path of database
        string path = "CARRENTALSYSTEM.db";

        //database create debug
        string cs = @"URI=file:" + Application.StartupPath + "\\CARRENTALSYSTEM.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public CarRentalSystem() {
            InitializeComponent();
        }

        // creates DB & checks if created already
        private void Create_db() {
            if (!System.IO.File.Exists(path)) {
                SQLiteConnection.CreateFile(path);

                using (var sqlite = new SQLiteConnection(@"Data Source =" + path)) {
                    sqlite.Open();

                    // CAR_LIST table creation
                    string sql = "CREATE TABLE CAR_LIST(" +
                        "CAR_ID INTEGER, " +
                        "MAKE TEXT, " +
                        "MODEL TEXT, " +
                        "YEAR INTEGER, " +
                        "COLOR TEXT, " +
                        "DAILY_PRICE INTEGER, " +
                        "AVAILABLE TEXT, " +
                        "PRIMARY KEY (CAR_ID)" +
                      ");";
                    SQLiteCommand CARLISTcommand = new SQLiteCommand(sql, sqlite);
                    CARLISTcommand.ExecuteNonQuery();

                    // CUSTOMERS table creation
                    sql = "CREATE TABLE CUSTOMERS(" +
                            "CUST_ID INTEGER, " +
                            "FIRST_NAME TEXT, " +
                            "LAST_NAME TEXT, " +
                            "EMAIL TEXT, " +
                            "PRIMARY KEY (CUST_ID)" +
                          ");" ;
                    SQLiteCommand CUSTOMERScommand = new SQLiteCommand(sql, sqlite);
                    CUSTOMERScommand.ExecuteNonQuery();

                    // RENTED_CARS table creation
                    sql = "CREATE TABLE RENTED_CARS(" +
                            "ORDER_ID INTEGER, " +
                            "CAR_ID INTEGER, " +
                            "CUST_ID INTEGER, " +
                            "CITY TEXT, " +
                            "STATE TEXT, " +
                            "FOREIGN KEY (CAR_ID) REFERENCES CAR_LIST(CAR_ID), " +
                            "FOREIGN KEY (CUST_ID) REFERENCES CUSTOMERS(CUST_ID), " +
                            "PRIMARY KEY (ORDER_ID)" +
                          ");";
                    SQLiteCommand RENTEDCARScommand = new SQLiteCommand(sql, sqlite);
                    RENTEDCARScommand.ExecuteNonQuery();

                    // RENTAL_INFO table creation
                    sql = "CREATE TABLE RENTAL_INFO(" +
                            "ORDER_ID INTEGER, " +
                            "RENT_START VARCHAR(10), " +
                            "RENT_END VARCHAR(10), " +
                            "TOTAL_PRICE INTEGER, " +
                            "FOREIGN KEY (ORDER_ID) REFERENCES RENTED_CARS(ORDER_ID), " +
                            "PRIMARY KEY (ORDER_ID)" +
                          ");";
                    SQLiteCommand RENTALINFOcommand = new SQLiteCommand(sql, sqlite);
                    RENTALINFOcommand.ExecuteNonQuery();
                }
            }
            else {
                Console.WriteLine("Database cannot be created");
                return;
            }
        }

        // loads CAR_LIST table and shows data
        private void CarList_Load(object sender, EventArgs e) {
            Create_db();
            showCarListData("CAR_LIST");
            showCustData("CUSTOMERS");
            showRentedCarsData("RENTED_CARS");
            showRentalInfoData("RENTAL_INFO");
        }

        //show data in car_list table
        private void showCarListData(string table) {
            using (var con = new SQLiteConnection(cs)) {
                con.Open();
                string stm = "SELECT * FROM " + table;
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();

                while (dr.Read()) {
                    car_list.Rows.Insert(0, dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetInt32(3), 
                        dr.GetString(4), dr.GetInt32(5), dr.GetString(6));
                }
            }
        }

        // handler for CAR_LIST insert button
        private void insert_car_list_Click(object sender, EventArgs e) {
            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(con);

            try {
                cmd.CommandText = "INSERT INTO CAR_LIST(MAKE, MODEL, YEAR, COLOR, DAILY_PRICE, AVAILABLE) " +
                   "VALUES(@MAKE, @MODEL, @YEAR, @COLOR, @DAILY_PRICE, @AVAILABLE)";

                var max_id_cmd = new SQLiteCommand(con);
                max_id_cmd.CommandText = "SELECT MAX(CAR_ID) FROM CAR_LIST";

                string MAKE = makeField.Text;
                string MODEL = modelField.Text;
                string YEAR = yearField.Text;
                string COLOR = colorField.Text;
                string DAILY_PRICE = dailyPriceField.Text;
                string AVAILABLE = "";

                if (availableField.Checked) {
                    AVAILABLE = "Y";
                }
                else {
                    AVAILABLE = "N";
                }

                cmd.Parameters.AddWithValue("@MAKE", MAKE);
                cmd.Parameters.AddWithValue("@MODEL", MODEL);
                cmd.Parameters.AddWithValue("@YEAR", YEAR);
                cmd.Parameters.AddWithValue("@COLOR", COLOR);
                cmd.Parameters.AddWithValue("@DAILY_PRICE", DAILY_PRICE);
                cmd.Parameters.AddWithValue("@AVAILABLE", AVAILABLE);


                cmd.ExecuteNonQuery();
                car_list.Rows.Clear();
                showCarListData("CAR_LIST");
            }
            catch (Exception) {
                Console.WriteLine("Cannot insert data");
                return;
            }
        }

        //show data in car_list table
        private void showCustData(string table)
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                string stm = "SELECT * FROM " + table;
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    customersTable.Rows.Insert(0, dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3));
                }
            }
        }

        // handler for CUSTOMERS insert button
        private void insert_cust_list_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "INSERT INTO CUSTOMERS(FIRST_NAME, LAST_NAME, EMAIL) " +
                   "VALUES(@FIRST_NAME, @LAST_NAME, @EMAIL)";

                var max_id_cmd = new SQLiteCommand(con);
                max_id_cmd.CommandText = "SELECT MAX(CUST_ID) FROM CUSTOMERS";

                string FIRST_NAME = customerFNField.Text;
                string LAST_NAME = customerLNField.Text;
                string EMAIL = customerEmailField.Text;

                cmd.Parameters.AddWithValue("@FIRST_NAME", FIRST_NAME);
                cmd.Parameters.AddWithValue("@LAST_NAME", LAST_NAME);
                cmd.Parameters.AddWithValue("@EMAIL", EMAIL);


                cmd.ExecuteNonQuery();
                customersTable.Rows.Clear();
                showCustData("CUSTOMERS");
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot insert data");
                return;
            }
        }

        private void showRentedCarsData(string table)
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                string stm = "SELECT * FROM " + table;
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    rentedCarsTable.Rows.Insert(0, dr.GetInt32(0), dr.GetInt32(1), dr.GetInt32(2), dr.GetString(3), dr.GetString(4));
                }
            }
        }

        private void insert_rented_cars_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "INSERT INTO RENTED_CARS(CAR_ID, CUST_ID, CITY, STATE) " +
                   "VALUES(@CAR_ID, @CUST_ID, @CITY, @STATE)";

                var max_id_cmd = new SQLiteCommand(con);
                max_id_cmd.CommandText = "SELECT MAX(ORDER_ID) FROM RENTED_CARS";

                string CAR_ID = rcCARIDField.Text;
                string CUST_ID = rcCUSTIDField.Text;
                string CITY = rcCITYField.Text;
                string STATE = rcSTATEField.Text;

                cmd.Parameters.AddWithValue("@CAR_ID", CAR_ID);
                cmd.Parameters.AddWithValue("@CUST_ID", CUST_ID);
                cmd.Parameters.AddWithValue("@CITY", CITY);
                cmd.Parameters.AddWithValue("@STATE", STATE);


                cmd.ExecuteNonQuery();
                rentedCarsTable.Rows.Clear();
                showRentedCarsData("RENTED_CARS");
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot insert data");
                return;
            }
        }

        private void showRentalInfoData(string table)
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                string stm = "SELECT * FROM " + table;
                var cmd = new SQLiteCommand(stm, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    rentalInfoTable.Rows.Insert(0, dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetInt32(3));
                }
            }
        }

        private void insert_rental_info_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "INSERT INTO RENTAL_INFO(ORDER_ID, RENT_START, RENT_END, TOTAL_PRICE) " +
                   "VALUES(@ORDER_ID, @RENT_START, @RENT_END, @TOTAL_PRICE)";

                //var max_id_cmd = new SQLiteCommand(con);
                //max_id_cmd.CommandText = "SELECT MAX(ORDER_ID) FROM RENTED_CARS";

                string ORDER_ID = rentalOrderIdField.Text;
                string RENT_START = rentStartField.Text;
                string RENT_END = rentEndField.Text;
                string TOTAL_PRICE = totalPriceField.Text;

                cmd.Parameters.AddWithValue("@ORDER_ID", ORDER_ID);
                cmd.Parameters.AddWithValue("@RENT_START", RENT_START);
                cmd.Parameters.AddWithValue("@RENT_END", RENT_END);
                cmd.Parameters.AddWithValue("@TOTAL_PRICE", TOTAL_PRICE);


                cmd.ExecuteNonQuery();
                rentalInfoTable.Rows.Clear();
                showRentalInfoData("RENTAL_INFO");
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot insert data");
                return;
            }
        }
    }
}