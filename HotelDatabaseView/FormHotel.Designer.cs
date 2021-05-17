namespace HotelDatabaseView
{
    partial class FormHotel
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
            this.textBoxCounroom = new System.Windows.Forms.TextBox();
            this.labelPassport = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelbusyroom = new System.Windows.Forms.Label();
            this.textBoxbusyrom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxCounroom
            // 
            this.textBoxCounroom.Location = new System.Drawing.Point(12, 97);
            this.textBoxCounroom.Name = "textBoxCounroom";
            this.textBoxCounroom.Size = new System.Drawing.Size(493, 26);
            this.textBoxCounroom.TabIndex = 8;
            // 
            // labelPassport
            // 
            this.labelPassport.AutoSize = true;
            this.labelPassport.Location = new System.Drawing.Point(12, 74);
            this.labelPassport.Name = "labelPassport";
            this.labelPassport.Size = new System.Drawing.Size(159, 20);
            this.labelPassport.TabIndex = 7;
            this.labelPassport.Text = "Количество комнат";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(12, 34);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(493, 26);
            this.textBoxFullName.TabIndex = 6;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(12, 12);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(133, 20);
            this.labelFullName.TabIndex = 5;
            this.labelFullName.Text = "Название отеля";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(286, 204);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(186, 42);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(52, 204);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(186, 42);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // labelbusyroom
            // 
            this.labelbusyroom.AutoSize = true;
            this.labelbusyroom.Location = new System.Drawing.Point(12, 141);
            this.labelbusyroom.Name = "labelbusyroom";
            this.labelbusyroom.Size = new System.Drawing.Size(234, 20);
            this.labelbusyroom.TabIndex = 18;
            this.labelbusyroom.Text = "Количество комнат заанятых";
            // 
            // textBoxbusyrom
            // 
            this.textBoxbusyrom.Location = new System.Drawing.Point(12, 164);
            this.textBoxbusyrom.Name = "textBoxbusyrom";
            this.textBoxbusyrom.Size = new System.Drawing.Size(493, 26);
            this.textBoxbusyrom.TabIndex = 19;
            // 
            // FormHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 263);
            this.Controls.Add(this.textBoxbusyrom);
            this.Controls.Add(this.labelbusyroom);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxCounroom);
            this.Controls.Add(this.labelPassport);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.labelFullName);
            this.Name = "FormHotel";
            this.Text = "FormHotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCounroom;
        private System.Windows.Forms.Label labelPassport;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelbusyroom;
        private System.Windows.Forms.TextBox textBoxbusyrom;
    }
}