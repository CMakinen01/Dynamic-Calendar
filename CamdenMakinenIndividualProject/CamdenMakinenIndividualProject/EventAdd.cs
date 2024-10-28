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
//Test Git Repo
namespace CamdenMakinenIndividualProject
{
    public partial class EventAdd : Form
    {



        public EventAdd()
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








        private void hubAddButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EventAdd_Load(object sender, EventArgs e)
        {

        }

        private void eventAddButton_Click(object sender, EventArgs e)
        {
            if (startTimeAdd.Value >= endTimeAdd.Value)
            {
                MessageBox.Show("Make Sure End Time is Strictly Greater Than Start Time.", "Time Error");
            }

            else
            {
                string connStr2 = "NULL";

                MySqlConnection conn = new MySqlConnection(connStr2);

                try
                {

                    Console.WriteLine("Connecting to MySQL...");
                    conn.Open();

                    DateTime newStart = startTimeAdd.Value;
                    DateTime newEnd = endTimeAdd.Value;



                    string sql2 = "SELECT * FROM Makinen_Calendar WHERE " +
                        "@newStart BETWEEN eventStart AND eventEnd " +
                        "OR @newEnd BETWEEN eventStart AND eventEnd";


                    MySqlCommand cmd2 = new MySqlCommand(sql2, conn);

                    cmd2.Parameters.AddWithValue("@newStart", newStart);
                    cmd2.Parameters.AddWithValue("@newEnd", newEnd);

                    using (MySqlDataReader reader = cmd2.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("EVENT CONFLICT DETECTED, RETRY", "Conflict Detected");
                        }
                        else
                        {
                            reader.Close();
                            string sql3 = "INSERT INTO Makinen_Calendar (eventName, eventDate, eventStart, eventEnd, eventDescription) " +
                                "VALUES (@eventName, @eventDate, @eventStart, @eventEnd, @eventDescription)";
                            MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
                            cmd3.Parameters.AddWithValue("@eventName", addEName.Text);
                            cmd3.Parameters.AddWithValue("@eventDate", startTimeAdd.Value);
                            cmd3.Parameters.AddWithValue("@eventStart", startTimeAdd.Value);
                            cmd3.Parameters.AddWithValue("@eventEnd", endTimeAdd.Value);
                            cmd3.Parameters.AddWithValue("@eventDescription", addEDesc.Text);
                            cmd3.ExecuteNonQuery();
                            MessageBox.Show("Event Added", "Confirmation");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    Console.WriteLine(ex.ToString());
                }
                conn.Close();
                Console.WriteLine("Done.");
            }


        }

        private void startTimeAdd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void endTimeAdd_ValueChanged(object sender, EventArgs e)
        {

        }

    

        private void addEName_TextChanged(object sender, EventArgs e)
        {

        }

        private void addEDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
