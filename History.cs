using DataLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Capstone
{
    public partial class History : Form
    {
        private SQLiteConnection conn = new SQLiteConnection(SqliteDataAccess.LoadConnString());
        SqliteDataAccess config = new SqliteDataAccess();
        string sql;

        List<DeviceModel> HistoryModels = new List<DeviceModel>();

        public History()
        {
            InitializeComponent();
            LoadDeviceDB();
        }

        //Loads History table based on search term
        private void LoadHistory()
        {
            sql = "SELECT * FROM Previous WHERE DeviceName = '" + SearchBox.Text + "';";

            config.LoadDataTable(sql, HistoryTable);
            this.HistoryTable.Columns["Id"].Visible = false;

        }

        //Click Event to load DGV based on search
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();

                LoadHistory();

                if (HistoryTable.Rows.Count <= 1)
                {
                    MessageBox.Show("No history found for this device. Please select a different device.");
                }

                else
                {
                    return;
                }


            }
            conn.Close();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadList()
        {
            SearchBox.DataSource = null;
            SearchBox.DataSource = HistoryModels;
            SearchBox.DisplayMember = "DeviceName";
        }

        public void LoadDeviceDB()
        {
            HistoryModels = SqliteDataAccess.LoadHistoryList();
            LoadList();
        }

        private void HistoryTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                string HeaderText = HistoryTable.Columns[e.ColumnIndex].HeaderText;
                if (HistoryTable.CurrentCell != null && HistoryTable.CurrentCell.Value != null)
                {
                    MessageBox.Show(HistoryTable.CurrentCell.Value.ToString(), HeaderText);
                }
            }
        }

    }
}
