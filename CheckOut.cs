using DataLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Capstone
{
    public partial class CheckOut : Form
    {
        List<DeviceModel> DeviceModels = new List<DeviceModel>();

        private readonly MainForm _mainForm;



        public CheckOut(MainForm mainForm)
        {
            InitializeComponent();
            LoadDeviceListDB();
            _mainForm = mainForm;
        }
      
        //Updates selected device with fields and sets OnLoan to 'Yes'
        public void SaveButton_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                string itemText = DeviceListBox.GetItemText(DeviceListBox.SelectedItem);

                string query = "UPDATE Device SET OnLoan = 'Yes', Notes = @Notes, CheckOut = @CheckOut, CheckIn = @CheckIn, Name = @Name, BadgeNo = @BadgeNo, Dept = @Dept WHERE DeviceName = @DeviceName";


                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", NameBox.Text);
                cmd.Parameters.AddWithValue("@BadgeNo", BadgeBox.Text);
                cmd.Parameters.AddWithValue("@Dept", DeptBox.Text);
                cmd.Parameters.AddWithValue("@Notes", NotesBox.Text);
                cmd.Parameters.AddWithValue("@DeviceName", itemText);
                cmd.Parameters.AddWithValue("@CheckOut", OutDatePicker.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@CheckIn", AnticipatedDatePicker.Value.ToString("yyyy-MM-dd"));

                //Checks and compares check in/out dates
                if (AnticipatedDatePicker.Value < OutDatePicker.Value)
                {
                    MessageBox.Show("Error. The Anticipated Check In date must be after the Check Out date.");
                    return;
                }
                if (OutDatePicker.Value < DateTime.Today)
                {
                    MessageBox.Show("Error. The Check Out Date must not be before today.");
                    return;
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Device has been checked out");
                    _mainForm.LoadOnLoan();
                    this.Close();
                }


                conn.Close();
            }

        }


        //Loads Device Names into listbox
        public void LoadDeviceListDB()
        {
            DeviceModels = SqliteDataAccess.LoadDeviceList();
            LoadList();
        }

        //Loads Device Names into ListBox
        public void LoadList()
        {
            DeviceListBox.DataSource = null;
            DeviceListBox.DataSource = DeviceModels;
            DeviceListBox.DisplayMember = "DeviceName";

        }


    }
}
