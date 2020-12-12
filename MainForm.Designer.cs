namespace Capstone
{
    partial class MainForm
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
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.ViewDeviceButton = new System.Windows.Forms.Button();
            this.InventoryButton = new System.Windows.Forms.Button();
            this.CheckInButton = new System.Windows.Forms.Button();
            this.DeviceOnLoanTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDeviceHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeviceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DeviceOnLoanTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Location = new System.Drawing.Point(64, 48);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(128, 64);
            this.CheckOutButton.TabIndex = 2;
            this.CheckOutButton.Text = "Check Out Device";
            this.CheckOutButton.UseVisualStyleBackColor = true;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // ViewDeviceButton
            // 
            this.ViewDeviceButton.Location = new System.Drawing.Point(64, 152);
            this.ViewDeviceButton.Name = "ViewDeviceButton";
            this.ViewDeviceButton.Size = new System.Drawing.Size(128, 64);
            this.ViewDeviceButton.TabIndex = 3;
            this.ViewDeviceButton.Text = "View Device History";
            this.ViewDeviceButton.UseVisualStyleBackColor = true;
            this.ViewDeviceButton.Click += new System.EventHandler(this.ViewDeviceButton_Click);
            // 
            // InventoryButton
            // 
            this.InventoryButton.Location = new System.Drawing.Point(64, 248);
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.Size = new System.Drawing.Size(128, 64);
            this.InventoryButton.TabIndex = 4;
            this.InventoryButton.Text = "Inventory";
            this.InventoryButton.UseVisualStyleBackColor = true;
            this.InventoryButton.Click += new System.EventHandler(this.InventoryButton_Click);
            // 
            // CheckInButton
            // 
            this.CheckInButton.Location = new System.Drawing.Point(64, 344);
            this.CheckInButton.Name = "CheckInButton";
            this.CheckInButton.Size = new System.Drawing.Size(128, 64);
            this.CheckInButton.TabIndex = 5;
            this.CheckInButton.Text = "Check In Device";
            this.CheckInButton.UseVisualStyleBackColor = true;
            this.CheckInButton.Click += new System.EventHandler(this.CheckInButton_Click);
            // 
            // DeviceOnLoanTable
            // 
            this.DeviceOnLoanTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeviceOnLoanTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DeviceOnLoanTable.Location = new System.Drawing.Point(248, 48);
            this.DeviceOnLoanTable.Name = "DeviceOnLoanTable";
            this.DeviceOnLoanTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeviceOnLoanTable.Size = new System.Drawing.Size(984, 360);
            this.DeviceOnLoanTable.TabIndex = 6;
            this.DeviceOnLoanTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeviceOnLoanTable_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Devices Currently On Loan";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1266, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDeviceHistoryToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem2.Text = "View";
            // 
            // viewDeviceHistoryToolStripMenuItem
            // 
            this.viewDeviceHistoryToolStripMenuItem.Name = "viewDeviceHistoryToolStripMenuItem";
            this.viewDeviceHistoryToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.viewDeviceHistoryToolStripMenuItem.Text = "View Device History";
            this.viewDeviceHistoryToolStripMenuItem.Click += new System.EventHandler(this.viewDeviceHistoryToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryMenuItem,
            this.addDeviceToolStripMenuItem1});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // inventoryMenuItem
            // 
            this.inventoryMenuItem.Name = "inventoryMenuItem";
            this.inventoryMenuItem.Size = new System.Drawing.Size(134, 22);
            this.inventoryMenuItem.Text = "Inventory";
            this.inventoryMenuItem.Click += new System.EventHandler(this.inventoryMenuItem_Click);
            // 
            // addDeviceToolStripMenuItem1
            // 
            this.addDeviceToolStripMenuItem1.Name = "addDeviceToolStripMenuItem1";
            this.addDeviceToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.addDeviceToolStripMenuItem1.Text = "Add Device";
            this.addDeviceToolStripMenuItem1.Click += new System.EventHandler(this.addDeviceToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem3.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeviceOnLoanTable);
            this.Controls.Add(this.CheckInButton);
            this.Controls.Add(this.InventoryButton);
            this.Controls.Add(this.ViewDeviceButton);
            this.Controls.Add(this.CheckOutButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Loaner Device Tracking";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            
            ((System.ComponentModel.ISupportInitialize)(this.DeviceOnLoanTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.Button ViewDeviceButton;
        private System.Windows.Forms.Button InventoryButton;
        private System.Windows.Forms.Button CheckInButton;
        public System.Windows.Forms.DataGridView DeviceOnLoanTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem viewDeviceHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem addDeviceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryMenuItem;
    }
}

