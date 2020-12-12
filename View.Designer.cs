namespace Capstone
{
    partial class View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NotesBox = new System.Windows.Forms.RichTextBox();
            this.BadgeBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.AnticipatedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.OutDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AnticipatedDate = new System.Windows.Forms.Label();
            this.OutDateLabel = new System.Windows.Forms.Label();
            this.DeviceLabel = new System.Windows.Forms.Label();
            this.DeviceListBox = new System.Windows.Forms.ListBox();
            this.BadgeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NotesBox
            // 
            this.NotesBox.Enabled = false;
            this.NotesBox.Location = new System.Drawing.Point(72, 392);
            this.NotesBox.Name = "NotesBox";
            this.NotesBox.Size = new System.Drawing.Size(312, 208);
            this.NotesBox.TabIndex = 23;
            this.NotesBox.Text = "";
            // 
            // BadgeBox
            // 
            this.BadgeBox.Enabled = false;
            this.BadgeBox.Location = new System.Drawing.Point(112, 72);
            this.BadgeBox.Name = "BadgeBox";
            this.BadgeBox.Size = new System.Drawing.Size(200, 20);
            this.BadgeBox.TabIndex = 22;
            // 
            // NameBox
            // 
            this.NameBox.Enabled = false;
            this.NameBox.Location = new System.Drawing.Point(72, 24);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(200, 20);
            this.NameBox.TabIndex = 21;
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Location = new System.Drawing.Point(24, 392);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(38, 13);
            this.NotesLabel.TabIndex = 20;
            this.NotesLabel.Text = "Notes:";
            // 
            // AnticipatedDatePicker
            // 
            this.AnticipatedDatePicker.Enabled = false;
            this.AnticipatedDatePicker.Location = new System.Drawing.Point(152, 328);
            this.AnticipatedDatePicker.Name = "AnticipatedDatePicker";
            this.AnticipatedDatePicker.Size = new System.Drawing.Size(200, 20);
            this.AnticipatedDatePicker.TabIndex = 19;
            // 
            // OutDatePicker
            // 
            this.OutDatePicker.Enabled = false;
            this.OutDatePicker.Location = new System.Drawing.Point(128, 256);
            this.OutDatePicker.Name = "OutDatePicker";
            this.OutDatePicker.Size = new System.Drawing.Size(200, 20);
            this.OutDatePicker.TabIndex = 18;
            // 
            // AnticipatedDate
            // 
            this.AnticipatedDate.AutoSize = true;
            this.AnticipatedDate.Location = new System.Drawing.Point(24, 336);
            this.AnticipatedDate.Name = "AnticipatedDate";
            this.AnticipatedDate.Size = new System.Drawing.Size(124, 13);
            this.AnticipatedDate.TabIndex = 17;
            this.AnticipatedDate.Text = "Anticipated Return Date:";
            // 
            // OutDateLabel
            // 
            this.OutDateLabel.AutoSize = true;
            this.OutDateLabel.Location = new System.Drawing.Point(24, 264);
            this.OutDateLabel.Name = "OutDateLabel";
            this.OutDateLabel.Size = new System.Drawing.Size(87, 13);
            this.OutDateLabel.TabIndex = 16;
            this.OutDateLabel.Text = "Check Out Date:";
            // 
            // DeviceLabel
            // 
            this.DeviceLabel.AutoSize = true;
            this.DeviceLabel.Location = new System.Drawing.Point(24, 136);
            this.DeviceLabel.Name = "DeviceLabel";
            this.DeviceLabel.Size = new System.Drawing.Size(44, 13);
            this.DeviceLabel.TabIndex = 15;
            this.DeviceLabel.Text = "Device:";
            // 
            // DeviceListBox
            // 
            this.DeviceListBox.Enabled = false;
            this.DeviceListBox.FormattingEnabled = true;
            this.DeviceListBox.Location = new System.Drawing.Point(128, 136);
            this.DeviceListBox.Name = "DeviceListBox";
            this.DeviceListBox.Size = new System.Drawing.Size(120, 95);
            this.DeviceListBox.TabIndex = 14;
            // 
            // BadgeLabel
            // 
            this.BadgeLabel.AutoSize = true;
            this.BadgeLabel.Location = new System.Drawing.Point(24, 80);
            this.BadgeLabel.Name = "BadgeLabel";
            this.BadgeLabel.Size = new System.Drawing.Size(81, 13);
            this.BadgeLabel.TabIndex = 13;
            this.BadgeLabel.Text = "Badge Number:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(24, 32);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 12;
            this.NameLabel.Text = "Name:";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(72, 632);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 24;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(320, 632);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 25;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(200, 632);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 26;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 670);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.NotesBox);
            this.Controls.Add(this.BadgeBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.AnticipatedDatePicker);
            this.Controls.Add(this.OutDatePicker);
            this.Controls.Add(this.AnticipatedDate);
            this.Controls.Add(this.OutDateLabel);
            this.Controls.Add(this.DeviceLabel);
            this.Controls.Add(this.DeviceListBox);
            this.Controls.Add(this.BadgeLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "View";
            this.Text = "View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox NotesBox;
        private System.Windows.Forms.TextBox BadgeBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.DateTimePicker AnticipatedDatePicker;
        private System.Windows.Forms.DateTimePicker OutDatePicker;
        private System.Windows.Forms.Label AnticipatedDate;
        private System.Windows.Forms.Label OutDateLabel;
        private System.Windows.Forms.Label DeviceLabel;
        private System.Windows.Forms.ListBox DeviceListBox;
        private System.Windows.Forms.Label BadgeLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SaveButton;
    }
}