namespace HotelDatabaseView
{
    partial class FormMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSoft = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSoftEq = new System.Windows.Forms.ToolStripMenuItem();
            this.заездToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEmployees,
            this.toolStripMenuItemSuppliers,
            this.toolStripMenuItemTypes,
            this.toolStripMenuItemSoft,
            this.toolStripMenuItemSoftEq,
            this.заездToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(995, 33);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolStripMenuItemEmployees
            // 
            this.toolStripMenuItemEmployees.Name = "toolStripMenuItemEmployees";
            this.toolStripMenuItemEmployees.Size = new System.Drawing.Size(126, 29);
            this.toolStripMenuItemEmployees.Text = "Сотрудники";
            this.toolStripMenuItemEmployees.Click += new System.EventHandler(this.ToolStripMenuItemStaffs_Click);
            // 
            // toolStripMenuItemSuppliers
            // 
            this.toolStripMenuItemSuppliers.Name = "toolStripMenuItemSuppliers";
            this.toolStripMenuItemSuppliers.Size = new System.Drawing.Size(96, 29);
            this.toolStripMenuItemSuppliers.Text = "Клиенты";
            this.toolStripMenuItemSuppliers.Click += new System.EventHandler(this.ToolStripMenuItemClients_Click);
            // 
            // toolStripMenuItemTypes
            // 
            this.toolStripMenuItemTypes.Name = "toolStripMenuItemTypes";
            this.toolStripMenuItemTypes.Size = new System.Drawing.Size(77, 29);
            this.toolStripMenuItemTypes.Text = "Отели";
            this.toolStripMenuItemTypes.Click += new System.EventHandler(this.ToolStripMenuItemHotels_Click);
            // 
            // toolStripMenuItemSoft
            // 
            this.toolStripMenuItemSoft.Name = "toolStripMenuItemSoft";
            this.toolStripMenuItemSoft.Size = new System.Drawing.Size(101, 29);
            this.toolStripMenuItemSoft.Text = "Комнаты";
            this.toolStripMenuItemSoft.Click += new System.EventHandler(this.ToolStripMenuItemRooms_Click);
            // 
            // toolStripMenuItemSoftEq
            // 
            this.toolStripMenuItemSoftEq.Name = "toolStripMenuItemSoftEq";
            this.toolStripMenuItemSoftEq.Size = new System.Drawing.Size(104, 29);
            this.toolStripMenuItemSoftEq.Text = "Выплаты ";
            this.toolStripMenuItemSoftEq.Click += new System.EventHandler(this.ToolStripMenuItemPays_Click);
            // 
            // заездToolStripMenuItem
            // 
            this.заездToolStripMenuItem.Name = "заездToolStripMenuItem";
            this.заездToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.заездToolStripMenuItem.Text = "Заезды";
            this.заездToolStripMenuItem.Click += new System.EventHandler(this.заездToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 46);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(687, 281);
            this.dataGridView.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 395);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "Главная форма отеля";
            this.Load += new System.EventHandler(this.RefreshDataGrid);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEmployees;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSuppliers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTypes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSoft;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSoftEq;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem заездToolStripMenuItem;
    }
}