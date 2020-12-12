namespace Capstone
{
    partial class AddDevice
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
            this.DeviceNameLabel = new System.Windows.Forms.Label();
            this.AssetLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DeviceNameBox = new System.Windows.Forms.TextBox();
            this.AssetBox = new System.Windows.Forms.TextBox();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.AddDeviceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeviceNameLabel
            // 
            this.DeviceNameLabel.AutoSize = true;
            this.DeviceNameLabel.Location = new System.Drawing.Point(16, 40);
            this.DeviceNameLabel.Name = "DeviceNameLabel";
            this.DeviceNameLabel.Size = new System.Drawing.Size(75, 13);
            this.DeviceNameLabel.TabIndex = 0;
            this.DeviceNameLabel.Text = "Device Name:";
            // 
            // AssetLabel
            // 
            this.AssetLabel.AutoSize = true;
            this.AssetLabel.Location = new System.Drawing.Point(16, 112);
            this.AssetLabel.Name = "AssetLabel";
            this.AssetLabel.Size = new System.Drawing.Size(58, 13);
            this.AssetLabel.TabIndex = 1;
            this.AssetLabel.Text = "Asset Tag:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(16, 176);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "Description:";
            // 
            // DeviceNameBox
            // 
            this.DeviceNameBox.Location = new System.Drawing.Point(96, 32);
            this.DeviceNameBox.Name = "DeviceNameBox";
            this.DeviceNameBox.Size = new System.Drawing.Size(184, 20);
            this.DeviceNameBox.TabIndex = 3;
            // 
            // AssetBox
            // 
            this.AssetBox.Location = new System.Drawing.Point(96, 104);
            this.AssetBox.Name = "AssetBox";
            this.AssetBox.Size = new System.Drawing.Size(184, 20);
            this.AssetBox.TabIndex = 4;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(96, 176);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(184, 136);
            this.DescriptionBox.TabIndex = 5;
            this.DescriptionBox.Text = "";
            // 
            // AddDeviceButton
            // 
            this.AddDeviceButton.Location = new System.Drawing.Point(128, 336);
            this.AddDeviceButton.Name = "AddDeviceButton";
            this.AddDeviceButton.Size = new System.Drawing.Size(75, 23);
            this.AddDeviceButton.TabIndex = 6;
            this.AddDeviceButton.Text = "Add Device";
            this.AddDeviceButton.UseVisualStyleBackColor = true;
            this.AddDeviceButton.Click += new System.EventHandler(this.AddDeviceButton_Click);
            // 
            // AddDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 385);
            this.Controls.Add(this.AddDeviceButton);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.AssetBox);
            this.Controls.Add(this.DeviceNameBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.AssetLabel);
            this.Controls.Add(this.DeviceNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddDevice";
            this.Text = "AddDevice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeviceNameLabel;
        private System.Windows.Forms.Label AssetLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DeviceNameBox;
        private System.Windows.Forms.TextBox AssetBox;
        private System.Windows.Forms.RichTextBox DescriptionBox;
        private System.Windows.Forms.Button AddDeviceButton;
    }
}