
namespace HotelDatabaseView
{
    partial class FormAddHotelRooms
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
            this.comboBoxSelectRoom = new System.Windows.Forms.ComboBox();
            this.labelRoom = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSelectRoom
            // 
            this.comboBoxSelectRoom.FormattingEnabled = true;
            this.comboBoxSelectRoom.Location = new System.Drawing.Point(154, 20);
            this.comboBoxSelectRoom.Name = "comboBoxSelectRoom";
            this.comboBoxSelectRoom.Size = new System.Drawing.Size(247, 28);
            this.comboBoxSelectRoom.TabIndex = 13;
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(38, 20);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(75, 20);
            this.labelRoom.TabIndex = 12;
            this.labelRoom.Text = "Комната";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(154, 97);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(112, 34);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(287, 97);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(104, 34);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormAddHotelRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 142);
            this.Controls.Add(this.comboBoxSelectRoom);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Name = "FormAddHotelRooms";
            this.Text = "FormAddHotelRooms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelectRoom;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}