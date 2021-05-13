
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
            this.textBoxPassport = new System.Windows.Forms.TextBox();
            this.labelPassport = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPassport
            // 
            this.textBoxPassport.Location = new System.Drawing.Point(12, 97);
            this.textBoxPassport.Name = "textBoxPassport";
            this.textBoxPassport.Size = new System.Drawing.Size(493, 26);
            this.textBoxPassport.TabIndex = 8;
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
            // 
            // FormHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 263);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxPassport);
            this.Controls.Add(this.labelPassport);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.labelFullName);
            this.Name = "FormHotel";
            this.Text = "FormHotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassport;
        private System.Windows.Forms.Label labelPassport;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
    }
}