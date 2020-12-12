using DataLibrary;
using System;
using System.Configuration;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Capstone
{

    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            LoadDeviceDb();

        }

        SqliteDataAccess config = new SqliteDataAccess();
        string sql;

        //Add a device window
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddDevice addDevice = new AddDevice(this);
            addDevice.Show();
        }

        //Loads DataBase into DGV
        public void LoadDeviceDb()
        {
            sql = "SELECT Id AS 'Id', DeviceName AS 'Device Name', AssetTag AS 'Asset Tag', Description, OnLoan As 'On Loan', Notes FROM Device";
            config.LoadDataTable(sql, InventoryTable);
            this.InventoryTable.Columns["Id"].Visible = false;

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditDevice editDevice = new EditDevice(this);

            editDevice.IdLabel.Text = InventoryTable.CurrentRow.Cells[0].Value.ToString();
            editDevice.DeviceNameBox.Text = InventoryTable.CurrentRow.Cells[1].Value.ToString();
            editDevice.AssetBox.Text = InventoryTable.CurrentRow.Cells[2].Value.ToString();
            editDevice.descriptBox.Text = InventoryTable.CurrentRow.Cells[3].Value.ToString();
            editDevice.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InventoryTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                string HeaderText = InventoryTable.Columns[e.ColumnIndex].HeaderText;
                if (InventoryTable.CurrentCell != null && InventoryTable.CurrentCell.Value != null)
                {
                    MessageBox.Show(InventoryTable.CurrentCell.Value.ToString(), HeaderText);
                }
            }

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                try
                {
                    string query = "DELETE FROM Device WHERE Id = @Id";

                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", InventoryTable.CurrentRow.Cells[0].Value.ToString());

                    if (MessageBox.Show("Are you sure you want to delete this device?\nThis action cannot be undone", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        conn.Open();

                        cmd.ExecuteNonQuery();
                        LoadDeviceDb();

                        conn.Close();

                    }
                    else
                    {
                        MessageBox.Show("Operation aborted"); ;
                        return;
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SQL Error");
                    conn.Close();
                }

            }
        }

    }
}
