
namespace HotelDatabaseView
{
    partial class FormCheckIn
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
            this.textBoxArrival = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelDepature = new System.Windows.Forms.Label();
            this.textBoxDepature = new System.Windows.Forms.TextBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxArrival
            // 
            this.textBoxArrival.Location = new System.Drawing.Point(14, 58);
            this.textBoxArrival.Name = "textBoxArrival";
            this.textBoxArrival.Size = new System.Drawing.Size(493, 26);
            this.textBoxArrival.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(14, 36);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(126, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Дата прибытия";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(303, 324);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(186, 42);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(48, 324);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(186, 42);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // labelDepature
            // 
            this.labelDepature.AutoSize = true;
            this.labelDepature.Location = new System.Drawing.Point(12, 103);
            this.labelDepature.Name = "labelDepature";
            this.labelDepature.Size = new System.Drawing.Size(117, 20);
            this.labelDepature.TabIndex = 18;
            this.labelDepature.Text = "Дата отбытия";
            // 
            // textBoxDepature
            // 
            this.textBoxDepature.Location = new System.Drawing.Point(18, 136);
            this.textBoxDepature.Name = "textBoxDepature";
            this.textBoxDepature.Size = new System.Drawing.Size(493, 26);
            this.textBoxDepature.TabIndex = 19;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(14, 188);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(65, 20);
            this.labelClient.TabIndex = 22;
            this.labelClient.Text = "Клиент";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(18, 229);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(489, 28);
            this.comboBoxClient.TabIndex = 23;
            // 
            // FormCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 378);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.textBoxDepature);
            this.Controls.Add(this.labelDepature);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxArrival);
            this.Controls.Add(this.labelName);
            this.Name = "FormCheckIn";
            this.Text = "Заезд";
            this.Load += new System.EventHandler(this.FormCheckIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxArrival;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelDepature;
        private System.Windows.Forms.TextBox textBoxDepature;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.ComboBox comboBoxClient;
    }
}