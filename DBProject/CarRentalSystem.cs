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

namespace DBProject
{
    public partial class CarRentalSystem : Form
    {
        //path of database
        string path = "CARRENTALSYSTEM.db";
        //database create debug
        string cs = @"URI=file:" + Application.StartupPath + "\\CARRENTALSYSTEM.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public CarRentalSystem()
        {
            InitializeComponent();
            data_show();
        }

        //show data in car table
        private void data_show()
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM car_list";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                car_list.Rows.Insert(0, dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetInt32(3), dr.GetString(4), dr.GetInt32(5), dr.GetString(6));
            }
        }

        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source =" + path))
                {
                    sqlite.Open();
                    string sql = "CREATE TABLE CAR_LIST(CAR_ID INT PRIMARY_KEY, MAKE TEXT, MODEL TEXT, YEAR INT, COLOR TEXT, DAILY_PRICE INT, AVAILABLE TEXT);";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                Console.WriteLine("Database cannot be created");
                return;
            }
        }

        private void CarList_Load(object sender, EventArgs e)
        {
            Create_db();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Make_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Color_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void DailyPrice_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Insert_car_list_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            cmd.CommandText = "INSERT INTO car_list(car_id, make, model, year, color, daily_price, available) VALUES (@car_id, @make, @model, @year, @color, @daily_price, @available)";

            string CAR_ID = "1";
            string MAKE = makeField.Text;
            string MODEL = modelField.Text;
            string YEAR = yearField.Text;
            string COLOR = colorField.Text;
            string DAILY_PRICE = dailyPriceField.Text;
            string AVAILABLE = availableField.Text;

            cmd.Parameters.AddWithValue("@car_id", CAR_ID);
            cmd.Parameters.AddWithValue("@make", MAKE);
            cmd.Parameters.AddWithValue("@model", MODEL);
            cmd.Parameters.AddWithValue("@year", YEAR);
            cmd.Parameters.AddWithValue("@color", COLOR);
            cmd.Parameters.AddWithValue("@daily_price", DAILY_PRICE);
            cmd.Parameters.AddWithValue("@available", AVAILABLE);

            car_list.ColumnCount = 7;
            car_list.Columns[0].Name = "Car ID";
            car_list.Columns[1].Name = "Make";
            car_list.Columns[2].Name = "Model";
            car_list.Columns[3].Name = "Year";
            car_list.Columns[4].Name = "Color";
            car_list.Columns[5].Name = "Daily Price";
            car_list.Columns[6].Name = "Available";
            string[] row = new string[] { CAR_ID, MAKE, MODEL, YEAR, COLOR, DAILY_PRICE, AVAILABLE };
            car_list.Rows.Add(row);

            cmd.ExecuteNonQuery();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void carList_Click(object sender, EventArgs e)
        {

        }

        private void Make_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void makeField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}