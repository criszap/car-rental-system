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
                            "RENT_START TEXT, " +
                            "RENT_END TEXT, " +
                            "TOTAL_PRICE INTEGER, " +
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
            showALLData("CAR_LIST");
        }

        //show data in car table
        private void showALLData(string table) {
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
                showALLData("CAR_LIST");
            }
            catch (Exception) {
                Console.WriteLine("Cannot insert data");
                return;
            }
        }   

    }
}