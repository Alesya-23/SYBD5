﻿
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonUpd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.броньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEmployees,
            this.toolStripMenuItemSuppliers,
            this.toolStripMenuItemTypes,
            this.toolStripMenuItemSoft,
            this.toolStripMenuItemSoftEq,
            this.броньToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(2117, 33);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolStripMenuItemEmployees
            // 
            this.toolStripMenuItemEmployees.Name = "toolStripMenuItemEmployees";
            this.toolStripMenuItemEmployees.Size = new System.Drawing.Size(126, 29);
            this.toolStripMenuItemEmployees.Text = "Сотрудники";
            this.toolStripMenuItemEmployees.Click += new System.EventHandler(this.ToolStripMenuItemEmployees_Click);
            // 
            // toolStripMenuItemSuppliers
            // 
            this.toolStripMenuItemSuppliers.Name = "toolStripMenuItemSuppliers";
            this.toolStripMenuItemSuppliers.Size = new System.Drawing.Size(96, 29);
            this.toolStripMenuItemSuppliers.Text = "Клиенты";
            this.toolStripMenuItemSuppliers.Click += new System.EventHandler(this.ToolStripMenuItemSuppliers_Click);
            // 
            // toolStripMenuItemTypes
            // 
            this.toolStripMenuItemTypes.Name = "toolStripMenuItemTypes";
            this.toolStripMenuItemTypes.Size = new System.Drawing.Size(77, 29);
            this.toolStripMenuItemTypes.Text = "Отели";
            this.toolStripMenuItemTypes.Click += new System.EventHandler(this.ToolStripMenuItemTypes_Click);
            // 
            // toolStripMenuItemSoft
            // 
            this.toolStripMenuItemSoft.Name = "toolStripMenuItemSoft";
            this.toolStripMenuItemSoft.Size = new System.Drawing.Size(101, 29);
            this.toolStripMenuItemSoft.Text = "Комнаты";
            this.toolStripMenuItemSoft.Click += new System.EventHandler(this.ToolStripMenuItemSoft_Click);
            // 
            // toolStripMenuItemSoftEq
            // 
            this.toolStripMenuItemSoftEq.Name = "toolStripMenuItemSoftEq";
            this.toolStripMenuItemSoftEq.Size = new System.Drawing.Size(104, 29);
            this.toolStripMenuItemSoftEq.Text = "Выплаты ";
            this.toolStripMenuItemSoftEq.Click += new System.EventHandler(this.ToolStripMenuItemSoftEq_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 62);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1807, 479);
            this.dataGridView.TabIndex = 1;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(1837, 107);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(246, 44);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Создать запись";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // buttonUpd
            // 
            this.buttonUpd.Location = new System.Drawing.Point(1837, 196);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(246, 44);
            this.buttonUpd.TabIndex = 3;
            this.buttonUpd.Text = "Изменить запись";
            this.buttonUpd.UseVisualStyleBackColor = true;
            this.buttonUpd.Click += new System.EventHandler(this.ButtonUpd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1837, 284);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(246, 44);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Удалить запись";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // броньToolStripMenuItem
            // 
            this.броньToolStripMenuItem.Name = "броньToolStripMenuItem";
            this.броньToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.броньToolStripMenuItem.Text = "Бронь";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2117, 553);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpd);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "Учёт вычислительной техники на предпиятии";
            this.Load += new System.EventHandler(this.FormMain_Load);
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
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonUpd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ToolStripMenuItem броньToolStripMenuItem;
    }
}