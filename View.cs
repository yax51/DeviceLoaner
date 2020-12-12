using System;
using System.Windows.Forms;

namespace Capstone
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            AnticipatedDatePicker.Enabled = true;
            NotesBox.Enabled = true;
            SaveButton.Visible = true;


        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            AnticipatedDatePicker.Enabled = false;
            NotesBox.Enabled = false;
            SaveButton.Visible = false;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
