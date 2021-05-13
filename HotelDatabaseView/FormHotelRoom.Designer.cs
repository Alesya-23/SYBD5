
namespace HotelDatabaseView
{
    partial class FormHotelRoom
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxTypeRoom = new System.Windows.Forms.TextBox();
            this.labelTypeRoom = new System.Windows.Forms.Label();
            this.labelHotel = new System.Windows.Forms.Label();
            this.comboBoxHotel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(283, 203);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(186, 42);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(49, 203);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(186, 42);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(9, 96);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(493, 26);
            this.textBoxPrice.TabIndex = 21;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(9, 73);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(48, 20);
            this.labelPrice.TabIndex = 20;
            this.labelPrice.Text = "Цена";
            // 
            // textBoxTypeRoom
            // 
            this.textBoxTypeRoom.Location = new System.Drawing.Point(9, 33);
            this.textBoxTypeRoom.Name = "textBoxTypeRoom";
            this.textBoxTypeRoom.Size = new System.Drawing.Size(493, 26);
            this.textBoxTypeRoom.TabIndex = 19;
            // 
            // labelTypeRoom
            // 
            this.labelTypeRoom.AutoSize = true;
            this.labelTypeRoom.Location = new System.Drawing.Point(9, 11);
            this.labelTypeRoom.Name = "labelTypeRoom";
            this.labelTypeRoom.Size = new System.Drawing.Size(106, 20);
            this.labelTypeRoom.TabIndex = 18;
            this.labelTypeRoom.Text = "Тип комнаты";
            // 
            // labelHotel
            // 
            this.labelHotel.AutoSize = true;
            this.labelHotel.Location = new System.Drawing.Point(12, 134);
            this.labelHotel.Name = "labelHotel";
            this.labelHotel.Size = new System.Drawing.Size(58, 20);
            this.labelHotel.TabIndex = 25;
            this.labelHotel.Text = "Отель";
            // 
            // comboBoxHotel
            // 
            this.comboBoxHotel.FormattingEnabled = true;
            this.comboBoxHotel.Location = new System.Drawing.Point(13, 157);
            this.comboBoxHotel.Name = "comboBoxHotel";
            this.comboBoxHotel.Size = new System.Drawing.Size(493, 28);
            this.comboBoxHotel.TabIndex = 24;
            // 
            // FormHotelRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 261);
            this.Controls.Add(this.labelHotel);
            this.Controls.Add(this.comboBoxHotel);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxTypeRoom);
            this.Controls.Add(this.labelTypeRoom);
            this.Name = "FormHotelRoom";
            this.Text = "Номер отеля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxTypeRoom;
        private System.Windows.Forms.Label labelTypeRoom;
        private System.Windows.Forms.Label labelHotel;
        private System.Windows.Forms.ComboBox comboBoxHotel;
    }
}