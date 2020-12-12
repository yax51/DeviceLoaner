using DataLibrary;
using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Capstone
{
    public partial class MainForm : Form
    {

        
        public DataTable dt;

        public MainForm()
        {
            InitializeComponent();
            LoadOnLoan();
            firstRun();
            
        }


        SqliteDataAccess config = new SqliteDataAccess();
        string sql;

        //Device check out window
        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            CheckOut DeviceOut = new CheckOut(this);
            DeviceOut.Show();


        }

        //Full Inventory window
        private void InventoryButton_Click(object sender, EventArgs e)
        {
            Inventory Inv = new Inventory();
            Inv.ShowDialog();
        }

        //Views the devices that are currently on loan
        private void ViewDeviceButton_Click(object sender, EventArgs e)
        {
            History LoanHistory = new History();
            LoanHistory.Show();

        }

        //Loads devices that have been check out
        public void LoadOnLoan()
        {
            sql = "SELECT Id, DeviceName, AssetTag, Description, OnLoan, Notes, CheckOut, CheckIn, Name, BadgeNo, Dept, TimeStamp FROM Device WHERE OnLoan = 'Yes'";
            config.LoadDataTable(sql, DeviceOnLoanTable);
            this.DeviceOnLoanTable.Columns["Id"].Visible = false;
            this.DeviceOnLoanTable.Columns["TimeStamp"].Visible = false;
            this.DeviceOnLoanTable.Columns["OnLoan"].Visible = false;


        }

        //Sets on loan status to no and refreshes dgv

        private void CheckInButton_Click(object sender, EventArgs e)
        {

            string connStr = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                foreach (DataGridViewRow r in DeviceOnLoanTable.SelectedRows)
                {
                    string query = "UPDATE Device SET OnLoan = 'No' WHERE Id = " + DeviceOnLoanTable.CurrentRow.Cells[0].Value + ";";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                        LoadOnLoan();
                        DeviceOnLoanTable.Refresh();
                    }
                    conn.Close();
                }

            }

        }

        private void firstRun()
        {
            string rowCheck = "SELECT COUNT(*) FROM Device;";

            string connStr = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();

                SQLiteCommand cmd = new SQLiteCommand(rowCheck, conn);

                int a = Convert.ToInt32(cmd.ExecuteScalar());

                if (a < 1)
                {
                    DialogResult result = MessageBox.Show("No Devices found in Inventory!\nWould you like to add some devices now?", "Empty Database", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Inventory inventory = new Inventory();
                        inventory.ShowDialog();

                        conn.Close();
                        this.Hide();

                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void DeviceOnLoanTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                string HeaderText = DeviceOnLoanTable.Columns[e.ColumnIndex].HeaderText;
                if (DeviceOnLoanTable.CurrentCell != null && DeviceOnLoanTable.CurrentCell.Value != null)
                {
                    MessageBox.Show(DeviceOnLoanTable.CurrentCell.Value.ToString(), HeaderText);
                }
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void viewDeviceHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.ShowDialog();
        }


        private void inventoryMenuItem_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.ShowDialog();
        }

        private void addDeviceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            AddDevice addDevice = new AddDevice(inventory);
            addDevice.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
