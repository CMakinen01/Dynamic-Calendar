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
using Mysqlx.Crud;

namespace CamdenMakinenIndividualProject
{
    public partial class EventEdit : Form
    {
        public EventEdit()
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
        private void hubEditButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EventEdit_Load(object sender, EventArgs e)
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
                    editViewBox.Text = sb.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }

        private void eventEditButton_Click(object sender, EventArgs e)
        {
            if (startTimeEdit.Value >= endTimeEdit.Value)//time check
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


                    DateTime newStartCheck = startTimeEdit.Value;
                    DateTime newEndCheck = endTimeEdit.Value;



                    string sql3 = "SELECT * FROM Makinen_Calendar WHERE " +
                        "@newStart BETWEEN eventStart AND eventEnd " +
                        "OR @newEnd BETWEEN eventStart AND eventEnd";
                    MySqlCommand cmdCheck = new MySqlCommand(sql3, conn);

                    cmdCheck.Parameters.AddWithValue("@newStart", newStartCheck);
                    cmdCheck.Parameters.AddWithValue("@newEnd", newEndCheck);


                    using (MySqlDataReader reader = cmdCheck.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("EVENT CONFLICT DETECTED, RETRY", "Conflict Detected");
                        }
                        else
                        {
                            int idChosen = (int)editID.Value;
                            DateTime newStart = startTimeEdit.Value;
                            DateTime newEnd = endTimeEdit.Value;
                            String newName = editName.Text;
                            String newDesc = editDesc.Text;

                            string sql2 = "UPDATE Makinen_Calendar SET " +
                                "eventName = @eventName, " +
                                "eventDate = @eventDate, " +
                                "eventStart = @eventStart, " +
                                "eventEnd = @eventEnd, " +
                                "eventDescription = @eventDesc " +
                                "WHERE ID = @idChosen";


                            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                            //prevent SQL injection attacks
                            cmd2.Parameters.AddWithValue("@eventName", newName);
                            cmd2.Parameters.AddWithValue("@eventDate", newStart.Date);
                            cmd2.Parameters.AddWithValue("@eventStart", newStart);
                            cmd2.Parameters.AddWithValue("@eventEnd", newEnd);
                            cmd2.Parameters.AddWithValue("@eventDesc", newDesc);
                            cmd2.Parameters.AddWithValue("@idChosen", idChosen);
                            int rows = cmd2.ExecuteNonQuery();

                            if (rows > 0)
                            {
                                MessageBox.Show("Successful Edit of Event.", "Success");
                                refreshPage();
                            }
                            else
                            {
                                MessageBox.Show("Error With Edit of Event.", "Error");
                            }
                        }
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

        private void editID_ValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(editID.Value);
            if (id == 0)
            {
                editName.Text = "";
                editDesc.Text = "";
                startTimeEdit.Value = DateTime.Now;
                endTimeEdit.Value = DateTime.Now;
                return;
            }
            else
            {
                string connStr = "NULL";

                MySqlConnection conn = new MySqlConnection(connStr);

                try
                {

                    Console.WriteLine("Connecting to MySQL...");
                    conn.Open();
                    string sql = "SELECT eventName, eventStart, eventEnd, eventDescription FROM Makinen_Calendar WHERE ID = @id";


                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {


                        if (reader.Read())//populate boxes automatically so no information needs to be copied on user end
                        {
                            editName.Text = reader.GetString(0);
                            editDesc.Text = reader.GetString(3);
                            startTimeEdit.Value = reader.GetDateTime(1);
                            endTimeEdit.Value = reader.GetDateTime(2);

                        }
                        else//no valid event id selected
                        {
                            editName.Text = "";
                            editDesc.Text = "";
                            startTimeEdit.Value = DateTime.Now;
                            endTimeEdit.Value = DateTime.Now;
                        }
                        reader.Close();
                    }
                }//close try
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    Console.WriteLine(ex.ToString());//debugging window

                }
                conn.Close();
                Console.WriteLine("Done.");
            }//close else
        }
        private void startTimeEdit_ValueChanged(object sender, EventArgs e)
        {

        }

        private void endTimeEdit_ValueChanged(object sender, EventArgs e)
        {

        }

        private void editDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void editName_TextChanged(object sender, EventArgs e)
        {

        }

        private void refreshPage()//a refresh function to update event window
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
                    editViewBox.Text = sb.ToString();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }

        private void editViewBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
