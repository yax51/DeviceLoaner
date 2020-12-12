using System;
using System.Configuration;
using System.Data.SQLite;
using System.Windows.Forms;


namespace Capstone
{

    public partial class AddDevice : Form
    {
        private readonly Inventory _Inventory;

        public AddDevice(Inventory Inventory)
        {
            InitializeComponent();
            _Inventory = Inventory;
        }


        //Adds a new device into the DB
        private void AddDeviceButton_Click(object sender, EventArgs e)
        {
            deviceCheck();
        }

        //Checks if Asset tag exists
        //Didn't include the Unique constraint in DB to allow for devices that have no asset tag
        private void deviceCheck()
        {
            string connStr = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            string asset = AssetBox.Text;
            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();

                string query = "SELECT AssetTag FROM Device WHERE AssetTag = @Asset";

                string addQuery = "INSERT INTO Device (DeviceName, AssetTag, Description, OnLoan)" +
                                       "VALUES (@DeviceName, @AssetTag, @Description, 'No')";
                SQLiteCommand addCmd = new SQLiteCommand(addQuery, conn);
                addCmd.Parameters.AddWithValue("@AssetTag", asset);
                addCmd.Parameters.AddWithValue("@DeviceName", DeviceNameBox.Text);
                addCmd.Parameters.AddWithValue("@Description", DescriptionBox.Text);

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@DeviceName", DeviceNameBox.Text);
                cmd.Parameters.AddWithValue("@Asset", asset);
                cmd.Parameters.AddWithValue("@Description", DescriptionBox.Text);


                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr.HasRows == true)
                    {
                        MessageBox.Show("Device Already Exists");
                        rdr.Close();
                        return;
                    }

                }

                addCmd.ExecuteNonQuery();
                MessageBox.Show("Device Added Sucessfully");
                _Inventory.LoadDeviceDb();
                conn.Close();
                this.Close();
            }


        }

    }
}
