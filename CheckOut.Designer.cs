namespace Capstone
{
    partial class CheckOut
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.BadgeLabel = new System.Windows.Forms.Label();
            this.DeviceListBox = new System.Windows.Forms.ListBox();
            this.DeviceLabel = new System.Windows.Forms.Label();
            this.OutDateLabel = new System.Windows.Forms.Label();
            this.AnticipatedDate = new System.Windows.Forms.Label();
            this.OutDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AnticipatedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.BadgeBox = new System.Windows.Forms.TextBox();
            this.NotesBox = new System.Windows.Forms.RichTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DeptBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(24, 32);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // BadgeLabel
            // 
            this.BadgeLabel.AutoSize = true;
            this.BadgeLabel.Location = new System.Drawing.Point(24, 64);
            this.BadgeLabel.Name = "BadgeLabel";
            this.BadgeLabel.Size = new System.Drawing.Size(81, 13);
            this.BadgeLabel.TabIndex = 1;
            this.BadgeLabel.Text = "Badge Number:";
            // 
            // DeviceListBox
            // 
            this.DeviceListBox.FormattingEnabled = true;
            this.DeviceListBox.Location = new System.Drawing.Point(96, 144);
            this.DeviceListBox.Name = "DeviceListBox";
            this.DeviceListBox.Size = new System.Drawing.Size(200, 95);
            this.DeviceListBox.TabIndex = 12;
            // 
            // DeviceLabel
            // 
            this.DeviceLabel.AutoSize = true;
            this.DeviceLabel.Location = new System.Drawing.Point(24, 144);
            this.DeviceLabel.Name = "DeviceLabel";
            this.DeviceLabel.Size = new System.Drawing.Size(44, 13);
            this.DeviceLabel.TabIndex = 3;
            this.DeviceLabel.Text = "Device:";
            // 
            // OutDateLabel
            // 
            this.OutDateLabel.AutoSize = true;
            this.OutDateLabel.Location = new System.Drawing.Point(24, 272);
            this.OutDateLabel.Name = "OutDateLabel";
            this.OutDateLabel.Size = new System.Drawing.Size(87, 13);
            this.OutDateLabel.TabIndex = 4;
            this.OutDateLabel.Text = "Check Out Date:";
            // 
            // AnticipatedDate
            // 
            this.AnticipatedDate.AutoSize = true;
            this.AnticipatedDate.Location = new System.Drawing.Point(24, 320);
            this.AnticipatedDate.Name = "AnticipatedDate";
            this.AnticipatedDate.Size = new System.Drawing.Size(124, 13);
            this.AnticipatedDate.TabIndex = 5;
            this.AnticipatedDate.Text = "Anticipated Return Date:";
            // 
            // OutDatePicker
            // 
            this.OutDatePicker.CustomFormat = "MM/dd/yyyy";
            this.OutDatePicker.Location = new System.Drawing.Point(112, 272);
            this.OutDatePicker.Name = "OutDatePicker";
            this.OutDatePicker.Size = new System.Drawing.Size(200, 20);
            this.OutDatePicker.TabIndex = 13;
            // 
            // AnticipatedDatePicker
            // 
            this.AnticipatedDatePicker.CustomFormat = "MM/dd/yyyy";
            this.AnticipatedDatePicker.Location = new System.Drawing.Point(152, 320);
            this.AnticipatedDatePicker.Name = "AnticipatedDatePicker";
            this.AnticipatedDatePicker.Size = new System.Drawing.Size(200, 20);
            this.AnticipatedDatePicker.TabIndex = 14;
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Location = new System.Drawing.Point(8, 368);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(38, 13);
            this.NotesLabel.TabIndex = 8;
            this.NotesLabel.Text = "Notes:";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(64, 32);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(232, 20);
            this.NameBox.TabIndex = 9;
            // 
            // BadgeBox
            // 
            this.BadgeBox.Location = new System.Drawing.Point(112, 64);
            this.BadgeBox.Name = "BadgeBox";
            this.BadgeBox.Size = new System.Drawing.Size(184, 20);
            this.BadgeBox.TabIndex = 10;
            // 
            // NotesBox
            // 
            this.NotesBox.Location = new System.Drawing.Point(64, 360);
            this.NotesBox.Name = "NotesBox";
            this.NotesBox.Size = new System.Drawing.Size(312, 136);
            this.NotesBox.TabIndex = 15;
            this.NotesBox.Text = "";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(176, 504);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 39);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Check Out";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Department:\r\n";
            // 
            // DeptBox
            // 
            this.DeptBox.Location = new System.Drawing.Point(96, 96);
            this.DeptBox.Name = "DeptBox";
            this.DeptBox.Size = new System.Drawing.Size(200, 20);
            this.DeptBox.TabIndex = 11;
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 561);
            this.Controls.Add(this.DeptBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveButton);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CheckOut";
            this.Text = "Check Out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label BadgeLabel;
        private System.Windows.Forms.Label DeviceLabel;
        private System.Windows.Forms.Label OutDateLabel;
        private System.Windows.Forms.Label AnticipatedDate;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox BadgeBox;
        private System.Windows.Forms.RichTextBox NotesBox;
        public System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DeptBox;
        public System.Windows.Forms.ListBox DeviceListBox;
        public System.Windows.Forms.DateTimePicker OutDatePicker;
        public System.Windows.Forms.DateTimePicker AnticipatedDatePicker;
    }
}