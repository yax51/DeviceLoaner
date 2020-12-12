using System;
using System.Configuration;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Capstone
{
    public partial class SplashScreen : Form
    {


        public SplashScreen()
        {
            InitializeComponent();
            CreateTables();
            
        }

        public MainForm MainForm
        {
            get => default;
            set
            {
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
        private void Splash_Close()
        {
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            slider.Width += 2;

            if (slider.Width > 350)
            {
                Splash_Close();
                timer1.Stop();
                
                MainForm mainForm = new MainForm();

                mainForm.ShowDialog();
                
            }

            
        }

        public void CreateTables()
        {


            try
            {
                File.ReadAllText("Test.Db");
            }
            catch (FileNotFoundException e)
            {
                File.Create(e.FileName);
            }

            string connStr = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();

                string createDevice = "CREATE TABLE IF NOT EXISTS 'Device'" +
                    "('Id' INTEGER NOT NULL UNIQUE, " +
                    "'DeviceName' TEXT NOT NULL," +
                    "'AssetTag' TEXT NOT NULL, " +
                    "'Description' TEXT DEFAULT ' '," +
                    "'OnLoan' TEXT DEFAULT 'No ', " +
                    "'Notes' TEXT DEFAULT ' ', " +
                    "'CheckOut' TEXT DEFAULT ' ', " +
                    "'CheckIn'   TEXT DEFAULT ' ', " +
                    "'Name' TEXT DEFAULT ' ', " +
                    "'BadgeNo' TEXT DEFAULT ' ', " +
                    "'Dept' TEXT DEFAULT ' ', " +
                    "'TimeStamp' TEXT DEFAULT CURRENT_TIMESTAMP, " +
                    "PRIMARY KEY('Id' AUTOINCREMENT));";

                string createPrevious = "CREATE TABLE IF NOT EXISTS 'Previous'" +
                     "('Id' INTEGER NOT NULL, " +
                    "'DeviceName' TEXT NOT NULL," +
                    "'AssetTag' TEXT NOT NULL, " +
                    "'Description' TEXT DEFAULT ' '," +
                    "'OnLoan' TEXT DEFAULT 'No ', " +
                    "'Notes' TEXT DEFAULT ' ', " +
                    "'CheckOut' TEXT DEFAULT ' ', " +
                    "'CheckIn'   TEXT DEFAULT ' ', " +
                    "'Name' TEXT DEFAULT ' ', " +
                    "'BadgeNo' TEXT DEFAULT ' ', " +
                    "'Dept' TEXT DEFAULT ' ', " +
                    "'TimeStamp' TEXT DEFAULT CURRENT_TIMESTAMP); ";

                string createInsertTrigger = "CREATE TRIGGER IF NOT EXISTS insert_previous " +
                                             "AFTER INSERT ON Device " +
                                             "FOR EACH ROW " +
                                             "BEGIN " +
                                             "INSERT INTO Previous(Id, DeviceName, AssetTag, Description, OnLoan, Notes, CheckOut, CheckIn, Name, BadgeNo, Dept, TimeStamp) " +
                                             "VALUES(new.Id, new.DeviceName, new.AssetTag, new.Description, new.OnLoan, new.Notes, new.CheckOut, new.CheckIn, new.Name, new.BadgeNo, new.Dept, CURRENT_TIMESTAMP); " +
                                             "END;";

                string createUpdateTrigger = "CREATE TRIGGER IF NOT EXISTS update_previous " +
                                             "AFTER UPDATE ON Device " +
                                             "FOR EACH ROW " +
                                             "BEGIN " +
                                             "INSERT INTO Previous(Id, DeviceName, AssetTag, Description, OnLoan, Notes, CheckOut, CheckIn, Name, BadgeNo, Dept, TimeStamp) " +
                                             "VALUES(old.Id, old.DeviceName, old.AssetTag, old.Description, old.OnLoan, old.Notes, old.CheckOut, old.CheckIn, old.Name, old.BadgeNo, old.Dept, CURRENT_TIMESTAMP); " +
                                             "END;";


                SQLiteCommand cmd = new SQLiteCommand(createDevice, conn);
                SQLiteCommand cmd2 = new SQLiteCommand(createPrevious, conn);
                SQLiteCommand cmd3 = new SQLiteCommand(createInsertTrigger, conn);
                SQLiteCommand cmd4 = new SQLiteCommand(createUpdateTrigger, conn);
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();

            }
        }

    }
}
