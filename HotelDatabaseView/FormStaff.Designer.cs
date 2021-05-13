
namespace HotelDatabaseView
{
    partial class FormStaff
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
            this.textBoxEmpName = new System.Windows.Forms.TextBox();
            this.labelEmpName = new System.Windows.Forms.Label();
            this.labelOrgName = new System.Windows.Forms.Label();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.labelPost = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxHotel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxEmpName
            // 
            this.textBoxEmpName.Location = new System.Drawing.Point(25, 116);
            this.textBoxEmpName.Name = "textBoxEmpName";
            this.textBoxEmpName.Size = new System.Drawing.Size(493, 26);
            this.textBoxEmpName.TabIndex = 8;
            // 
            // labelEmpName
            // 
            this.labelEmpName.AutoSize = true;
            this.labelEmpName.Location = new System.Drawing.Point(25, 93);
            this.labelEmpName.Name = "labelEmpName";
            this.labelEmpName.Size = new System.Drawing.Size(135, 20);
            this.labelEmpName.TabIndex = 7;
            this.labelEmpName.Text = "ФИО работника:";
            // 
            // labelOrgName
            // 
            this.labelOrgName.AutoSize = true;
            this.labelOrgName.Location = new System.Drawing.Point(25, 31);
            this.labelOrgName.Name = "labelOrgName";
            this.labelOrgName.Size = new System.Drawing.Size(58, 20);
            this.labelOrgName.TabIndex = 5;
            this.labelOrgName.Text = "Отель";
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(25, 184);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(493, 26);
            this.textBoxPost.TabIndex = 10;
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Location = new System.Drawing.Point(25, 161);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(95, 20);
            this.labelPost.TabIndex = 9;
            this.labelPost.Text = "Должность";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(294, 236);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(186, 42);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(60, 236);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(186, 42);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // comboBoxHotel
            // 
            this.comboBoxHotel.FormattingEnabled = true;
            this.comboBoxHotel.Location = new System.Drawing.Point(29, 53);
            this.comboBoxHotel.Name = "comboBoxHotel";
            this.comboBoxHotel.Size = new System.Drawing.Size(493, 28);
            this.comboBoxHotel.TabIndex = 18;
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 289);
            this.Controls.Add(this.comboBoxHotel);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.textBoxEmpName);
            this.Controls.Add(this.labelEmpName);
            this.Controls.Add(this.labelOrgName);
            this.Name = "FormStaff";
            this.Text = "Сотрудник";
            this.Load += new System.EventHandler(this.FormSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmpName;
        private System.Windows.Forms.Label labelEmpName;
        private System.Windows.Forms.Label labelOrgName;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxHotel;
    }
}