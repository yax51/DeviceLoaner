namespace Capstone
{
    partial class History
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.DeviceLabel = new System.Windows.Forms.Label();
            this.HistoryTable = new System.Windows.Forms.DataGridView();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryTable)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSize = true;
            this.SearchButton.Location = new System.Drawing.Point(464, 32);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 24);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DeviceLabel
            // 
            this.DeviceLabel.AutoSize = true;
            this.DeviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceLabel.Location = new System.Drawing.Point(504, 104);
            this.DeviceLabel.Name = "DeviceLabel";
            this.DeviceLabel.Size = new System.Drawing.Size(234, 37);
            this.DeviceLabel.TabIndex = 2;
            this.DeviceLabel.Text = "Device History";
            // 
            // HistoryTable
            // 
            this.HistoryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HistoryTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.HistoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryTable.Location = new System.Drawing.Point(24, 144);
            this.HistoryTable.MultiSelect = false;
            this.HistoryTable.Name = "HistoryTable";
            this.HistoryTable.ReadOnly = true;
            this.HistoryTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.HistoryTable.Size = new System.Drawing.Size(1184, 216);
            this.HistoryTable.TabIndex = 3;
            this.HistoryTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HistoryTable_CellClick);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(592, 400);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.FormattingEnabled = true;
            this.SearchBox.Location = new System.Drawing.Point(568, 32);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(232, 21);
            this.SearchBox.TabIndex = 5;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1234, 473);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.HistoryTable);
            this.Controls.Add(this.DeviceLabel);
            this.Controls.Add(this.SearchButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "History";
            this.Text = "History";
            ((System.ComponentModel.ISupportInitialize)(this.HistoryTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label DeviceLabel;
        private System.Windows.Forms.DataGridView HistoryTable;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ComboBox SearchBox;
    }
}