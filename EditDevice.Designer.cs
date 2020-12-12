namespace Capstone
{
    partial class EditDevice
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.descriptBox = new System.Windows.Forms.RichTextBox();
            this.AssetBox = new System.Windows.Forms.TextBox();
            this.DeviceNameBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.AssetLabel = new System.Windows.Forms.Label();
            this.DeviceNameLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(72, 328);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // descriptBox
            // 
            this.descriptBox.Location = new System.Drawing.Point(104, 168);
            this.descriptBox.Name = "descriptBox";
            this.descriptBox.Size = new System.Drawing.Size(184, 136);
            this.descriptBox.TabIndex = 12;
            this.descriptBox.Text = "";
            // 
            // AssetBox
            // 
            this.AssetBox.Enabled = false;
            this.AssetBox.Location = new System.Drawing.Point(104, 104);
            this.AssetBox.Name = "AssetBox";
            this.AssetBox.Size = new System.Drawing.Size(184, 20);
            this.AssetBox.TabIndex = 11;
            // 
            // DeviceNameBox
            // 
            this.DeviceNameBox.Location = new System.Drawing.Point(104, 48);
            this.DeviceNameBox.Name = "DeviceNameBox";
            this.DeviceNameBox.Size = new System.Drawing.Size(184, 20);
            this.DeviceNameBox.TabIndex = 10;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(24, 168);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLabel.TabIndex = 9;
            this.DescriptionLabel.Text = "Description:";
            // 
            // AssetLabel
            // 
            this.AssetLabel.AutoSize = true;
            this.AssetLabel.Location = new System.Drawing.Point(24, 104);
            this.AssetLabel.Name = "AssetLabel";
            this.AssetLabel.Size = new System.Drawing.Size(58, 13);
            this.AssetLabel.TabIndex = 8;
            this.AssetLabel.Text = "Asset Tag:";
            // 
            // DeviceNameLabel
            // 
            this.DeviceNameLabel.AutoSize = true;
            this.DeviceNameLabel.Location = new System.Drawing.Point(24, 48);
            this.DeviceNameLabel.Name = "DeviceNameLabel";
            this.DeviceNameLabel.Size = new System.Drawing.Size(75, 13);
            this.DeviceNameLabel.TabIndex = 7;
            this.DeviceNameLabel.Text = "Device Name:";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(232, 328);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Enabled = false;
            this.IdLabel.Location = new System.Drawing.Point(120, 16);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(0, 13);
            this.IdLabel.TabIndex = 15;
            this.IdLabel.Visible = false;
            // 
            // EditDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 379);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.descriptBox);
            this.Controls.Add(this.AssetBox);
            this.Controls.Add(this.DeviceNameBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.AssetLabel);
            this.Controls.Add(this.DeviceNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditDevice";
            this.Text = "Edit Device";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label AssetLabel;
        private System.Windows.Forms.Label DeviceNameLabel;
        private System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.RichTextBox descriptBox;
        public System.Windows.Forms.TextBox AssetBox;
        public System.Windows.Forms.TextBox DeviceNameBox;
        public System.Windows.Forms.Label IdLabel;
    }
}