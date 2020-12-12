using System;
using System.Configuration;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Capstone
{
    public partial class EditDevice : Form
    {
        private readonly Inventory _Inventory;


        public EditDevice(Inventory Inventory)
        {
            InitializeComponent();
            _Inventory = Inventory;
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveCheck();
        }

        private void SaveCheck()
        {
            string connStr = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                //try
                //{
                    conn.Open();

                    string nameField = DeviceNameBox.Text;
                    string descriptionField = descriptBox.Text;

                    string query = "UPDATE Device SET DeviceName = @DeviceName, Description = @description WHERE Id = @Id; ";

                    SQLiteCommand cmd = new SQLiteCommand(query, conn);

                    cmd.Parameters.AddWithValue("@DeviceName", nameField);
                    cmd.Parameters.AddWithValue("@description", descriptionField);
                    cmd.Parameters.AddWithValue("@Id", IdLabel.Text);

                    int a = cmd.ExecuteNonQuery();

                    if (a == 0)
                    {
                        MessageBox.Show("Update Failed. Please try again.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Device Updated Successfully!");
                        conn.Close();
                        _Inventory.LoadDeviceDb();

                        this.Close();
                    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("SQL Error");
               // }

            }
        }
    }
}
