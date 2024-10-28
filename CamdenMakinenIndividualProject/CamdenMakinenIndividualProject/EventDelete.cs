using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CamdenMakinenIndividualProject
{
    public partial class EventDelete : Form
    {
        public EventDelete()
        {
            InitializeComponent();
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
        private void hubDeleteButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EventDelete_Load(object sender, EventArgs e)
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
                    StringBuilder sb = new StringBuilder();//To display events

                    while (reader.Read())
                    {

                        sb.AppendLine($"ID: {reader.GetInt32(0)}     Name: {reader.GetString(1)}    Start: {reader.GetDateTime(3)}  End: {reader.GetDateTime(4)}");
                    }
                    reader.Close();
                    deleteViewBox.Text = sb.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }

        private void deleteViewBox_TextChanged(object sender, EventArgs e)
        {

        }



        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(deleteID.Text))//if nothing is entered, display error
            {
                MessageBox.Show("Error with Deletion, Try Again.", "Error");
            }
            else
            {
                int idChosen = int.Parse(deleteID.Text);

                string connStr = "NULL";

                MySqlConnection conn = new MySqlConnection(connStr);

                try
                {

                    Console.WriteLine("Connecting to MySQL...");
                    conn.Open();
                    string sql = $"DELETE FROM Makinen_Calendar WHERE ID = {idChosen}";


                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    int amount = cmd.ExecuteNonQuery();
                    if (amount >= 1)
                    {
                        MessageBox.Show("Event Deleted Successfully.", "Confirmation");
                        refreshPage();
                    }
                    else
                    {
                        MessageBox.Show("Error with Deletion, Try Again.", "Error");//if an invalid ID was entered

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    Console.WriteLine(ex.ToString());//debugging
                }
                conn.Close();
                Console.WriteLine("Done.");
            }
        }

       
        private void refreshPage()
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

                        sb.AppendLine($"ID: {reader.GetInt32(0)}     Name: {reader.GetString(1)}    Start: {reader.GetDateTime(3)}  End: {reader.GetDateTime(4)}");
                    }
                    reader.Close();
                    deleteViewBox.Text = sb.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }

        private void deleteID_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
