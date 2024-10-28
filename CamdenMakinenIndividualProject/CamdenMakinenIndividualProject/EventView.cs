using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace CamdenMakinenIndividualProject
{
    public partial class EventView : Form
    {
        public EventView()
        {
            InitializeComponent();
            monthPicker.Format = DateTimePickerFormat.Custom;
            monthPicker.CustomFormat = "MM/yyyy";
            string connStr = "NULL";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "CREATE TABLE IF NOT EXISTS Makinen_Calendar" +
                    "(ID INT PRIMARY KEY AUTO_INCREMENT, " +
                    "eventName VARCHAR(50) NOT NULL, " +
                    "eventDate DATE NOT NULL, " +
                    "eventStart DATETIME NOT NULL, " +
                    "eventEnd DATETIME NOT NULL, " +
                    "eventDescription VARCHAR(200) NOT NULL)";


                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }
        private void hubEVButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EventView_Load(object sender, EventArgs e)
        {
            string connStr = "NULL";

            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM Makinen_Calendar";


                MySqlCommand cmd = new MySqlCommand(sql, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    StringBuilder sb = new StringBuilder();

                    while (reader.Read())
                    {

                        sb.AppendLine($"ID: {reader.GetInt32(0)}     Name: {reader.GetString(1)}    Description: {reader.GetString(5)}    Start: {reader.GetDateTime(3)}  End: {reader.GetDateTime(4)}");
                    }
                    reader.Close();
                    eventViewBox.Text = sb.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }

        private void eventViewBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void weekViewButton_Click(object sender, EventArgs e)
        {
            string connStr = "NULL";

            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM Makinen_Calendar ORDER BY WEEK(eventStart)";


                MySqlCommand cmd = new MySqlCommand(sql, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    StringBuilder sb = new StringBuilder();

                    while (reader.Read())
                    {

                        sb.AppendLine($"ID: {reader.GetInt32(0)}     Name: {reader.GetString(1)}    Description: {reader.GetString(5)}    Start: {reader.GetDateTime(3)}  End: {reader.GetDateTime(4)}");
                    }
                    reader.Close();
                    eventViewBox.Text = sb.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }

        private void monthViewButton_Click(object sender, EventArgs e)
        {
            string connStr = "NULL";

            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                int month = monthPicker.Value.Month;
                int year = monthPicker.Value.Year;
                string sql = $"SELECT * FROM Makinen_Calendar WHERE MONTH(eventStart) = {month} AND YEAR(eventStart) = {year}";


                MySqlCommand cmd = new MySqlCommand(sql, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    StringBuilder sb = new StringBuilder();

                    while (reader.Read())
                    {

                        sb.AppendLine($"ID: {reader.GetInt32(0)}     Name: {reader.GetString(1)}    Description: {reader.GetString(5)}    Start: {reader.GetDateTime(3)}  End: {reader.GetDateTime(4)}");
                    }
                    reader.Close();
                    eventViewBox.Text = sb.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            string connStr = "NULL";

            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM Makinen_Calendar";


                MySqlCommand cmd = new MySqlCommand(sql, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    StringBuilder sb = new StringBuilder();

                    while (reader.Read())
                    {

                        sb.AppendLine($"ID: {reader.GetInt32(0)}     Name: {reader.GetString(1)}    Description: {reader.GetString(5)}    Start: {reader.GetDateTime(3)}  End: {reader.GetDateTime(4)}");
                    }
                    reader.Close();
                    eventViewBox.Text = sb.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }
    }
}
