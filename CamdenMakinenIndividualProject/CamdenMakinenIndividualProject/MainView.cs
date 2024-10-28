using MySql.Data.MySqlClient;

namespace CamdenMakinenIndividualProject
{
    public partial class MainView : Form
    {
        public MainView()
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventView view = new EventView();
            view.Show();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            EventDelete delete = new EventDelete();
            delete.Show();
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            EventEdit edit = new EventEdit();
            edit.Show();
        }
        private void addButton_Click(Object sender, EventArgs e)
        {
            EventAdd add = new EventAdd();
            add.Show();
        }
    }
}
