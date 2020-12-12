namespace Capstone
{
    partial class Inventory
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
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.InventoryTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(920, 64);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(144, 56);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add Device";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(920, 176);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(144, 56);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove Device";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(920, 280);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(144, 56);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit Device";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(24, 24);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // InventoryTable
            // 
            this.InventoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.InventoryTable.Location = new System.Drawing.Point(24, 64);
            this.InventoryTable.Name = "InventoryTable";
            this.InventoryTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InventoryTable.Size = new System.Drawing.Size(872, 272);
            this.InventoryTable.TabIndex = 6;
            this.InventoryTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryTable_CellClick);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1099, 393);
            this.Controls.Add(this.InventoryTable);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Inventory";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.InventoryTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button BackButton;
        public System.Windows.Forms.DataGridView InventoryTable;
    }
}