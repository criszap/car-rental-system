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
using System.Globalization;

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
                    string sql = "";

                    // CAR_LIST table creation
                    sql = "CREATE TABLE CAR_LIST(" +
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

                    sql = "INSERT INTO CAR_LIST(MAKE, MODEL, YEAR, COLOR, DAILY_PRICE, AVAILABLE)" +
                        "VALUES ('Ford', 'Mustang', 2014, 'Red', 69, 'Y'), " +
                               "('Nissan', 'R34 Skyline GT-R', 1998, 'Black', 212, 'N'), " +
                               "('Honda', 'Civic Type-R', 1994, 'White', 80, 'N'), " +
                               "('Mitsubishi', 'Lancer Evo X', 2008, 'Red', 105, 'N'), " +
                               "('RL', 'Octane', 2015, 'White', 315, 'N'), " +
                               "('RL', 'Dominus GT', 2016, 'Purple', 280, 'Y');";
                    SQLiteCommand CARLISTinsert = new SQLiteCommand(sql, sqlite);
                    CARLISTinsert.ExecuteNonQuery();

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

                    sql = "INSERT INTO CUSTOMERS(FIRST_NAME, LAST_NAME, EMAIL)" +
                        "VALUES ('Cristian', 'Zapata', 'czapata@gmail.com'), " +
                               "('Alejandro', 'Romero-Lopez', 'aromero@gmail.com'), " +
                               "('Jesus', 'Jimenez', 'jjimenez@gmail.com'), " +
                               "('Kwabena','Adjei','kadjei@gmail.com'), " +
                               "('Nico', 'Zamora', 'nzamora@gmail.com'), " +
                               "('Martin', 'Castillo', 'mcastillo@gmail.com');";
                    SQLiteCommand CUSTOMERSinsert = new SQLiteCommand(sql, sqlite);
                    CUSTOMERSinsert.ExecuteNonQuery();

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

                    sql = "INSERT INTO RENTED_CARS(CAR_ID, CUST_ID, CITY, STATE)" +
                        "VALUES (5, 1, 'Sunnyvale', 'California'), " +
                               "(2, 2, 'Seattle', 'Washington'), " +
                               "(6, 3, 'Wichita', 'Kansas'), " +
                               "(3, 4, 'Richmond', 'Virginia'), " +
                               "(3, 5, 'New York', 'New York'), " +
                               "(4, 6, 'Zacatecas', 'Mexico');";
                    SQLiteCommand RENTEDCARSinsert = new SQLiteCommand(sql, sqlite);
                    RENTEDCARSinsert.ExecuteNonQuery();

                    // RENTAL_INFO table creation
                    sql = "CREATE TABLE RENTAL_INFO(" +
                            "ORDER_ID INTEGER, " +
                            "RENT_START TEXT, " +
                            "RENT_END TEXT, " +
                            "TOTAL_PRICE INTEGER, " +
                            "TURNED_IN TEXT, " +
                            "FOREIGN KEY (ORDER_ID) REFERENCES RENTED_CARS(ORDER_ID), " +
                            "PRIMARY KEY (ORDER_ID)" +
                          ");";
                    SQLiteCommand RENTALINFOcommand = new SQLiteCommand(sql, sqlite);
                    RENTALINFOcommand.ExecuteNonQuery();

                    sql = "INSERT INTO RENTAL_INFO(ORDER_ID, RENT_START, RENT_END, TOTAL_PRICE, TURNED_IN)" +
                        "VALUES (1, '05/30/2023', '08/15/2023'," + getTotalPrice("1", "05/30/2023", "08/15/2023") + ", 'N'), " +
                               "(2, '05/30/2023', '08/15/2023'," + getTotalPrice("2", "05/30/2023", "08/15/2023") + ", 'N'), " +
                               "(3, '12/01/2022', '12/04/2022'," + getTotalPrice("3", "12/01/2022", "12/04/2022") + ", 'N'), " +
                               "(4, '03/05/2023', '03/11/2023'," + getTotalPrice("4", "03/05/2023", "03/11/2023") + ", 'Y'), " +
                               "(5, '06/01/2023', '08/05/2023'," + getTotalPrice("5", "06/01/2023", "08/05/2023") + ", 'N'), " +
                               "(6, '12/01/2022', '01/12/2023'," + getTotalPrice("6", "12/01/2022", "01/12/2023") + ", 'N');";
                    SQLiteCommand RENTALINFOinsert = new SQLiteCommand(sql, sqlite);
                    RENTALINFOinsert.ExecuteNonQuery();
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

        private void delete_car_list_row_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(con);


            try
            {
                cmd.CommandText = "DELETE FROM CAR_LIST WHERE CAR_ID = " + car_list.CurrentRow.Cells[0].FormattedValue.ToString();
                cmd.ExecuteNonQuery();
                car_list.Rows.Clear();
                showCarListData("CAR_LIST");
            }
            catch (Exception)
            {
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

        private void delete_customers_row_Click(object sender, EventArgs e) {

        }

        //show data in rented_cars table
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

        // handler for rented_cars insert button
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

        private void delete_rented_cars_row_Click(object sender, EventArgs e) {

        }

        //show data in rental_info table
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
                    rentalInfoTable.Rows.Insert(0, dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetInt32(3), dr.GetString(4));
                }
            }
        }

        // handler for getting the total price of a rented car
        private string getTotalPrice(string orderID, string RENT_START, string RENT_END) {
            using (var con = new SQLiteConnection(cs))
            {
                string daily_price = "";

                con.Open();
                string stm = "SELECT MAX(CAR_LIST.DAILY_PRICE) " +
                             "FROM CAR_LIST " +
                             " JOIN RENTED_CARS " +
                             " ON CAR_LIST.CAR_ID = RENTED_CARS.CAR_ID " +
                             " WHERE RENTED_CARS.ORDER_ID = " + orderID + " limit 1;";

                var cmd = new SQLiteCommand(stm, con);
                daily_price = cmd.ExecuteScalar().ToString();

                var end_date = DateTime.ParseExact(RENT_END, "MM/dd/yyyy", null);
                var start_date = DateTime.ParseExact(RENT_START, "MM/dd/yyyy", null);

                var day_diff = end_date.Subtract(start_date).Days;

                int totalPrice = ((int)day_diff + 1) * Int32.Parse(daily_price);

                return totalPrice.ToString();
            }
        }

        // handler for rental_info insert button
        private void insert_rental_info_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "INSERT INTO RENTAL_INFO(ORDER_ID, RENT_START, RENT_END, TOTAL_PRICE, TURNED_IN) " +
                   "VALUES(@ORDER_ID, @RENT_START, @RENT_END, @TOTAL_PRICE, @TURNED_IN)";

                //var max_id_cmd = new SQLiteCommand(con);
                //max_id_cmd.CommandText = "SELECT MAX(ORDER_ID) FROM RENTED_CARS";

                string ORDER_ID = rentalOrderIdField.Text;
                string RENT_START = rentStartField.Text;
                string RENT_END = rentEndField.Text;
                string TOTAL_PRICE = getTotalPrice(ORDER_ID, RENT_START, RENT_END);
                string TURNED_IN = "";

                if (turnedInField.Checked) {
                    TURNED_IN = "Y";
                } 
                else {
                    TURNED_IN = "N";
                }

                cmd.Parameters.AddWithValue("@ORDER_ID", ORDER_ID);
                cmd.Parameters.AddWithValue("@RENT_START", RENT_START);
                cmd.Parameters.AddWithValue("@RENT_END", RENT_END);
                cmd.Parameters.AddWithValue("@TOTAL_PRICE", TOTAL_PRICE);
                cmd.Parameters.AddWithValue("@TURNED_IN", TURNED_IN);


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

        private void delete_rental_info_row_Click(object sender, EventArgs e) {

        }
    }
}