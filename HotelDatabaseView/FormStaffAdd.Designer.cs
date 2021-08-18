
namespace HotelDatabaseView
{
    partial class FormStaffAdd
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelComponent = new System.Windows.Forms.Label();
            this.comboBoxSelectStaff = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(140, 100);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(112, 34);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(273, 100);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(104, 34);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // labelComponent
            // 
            this.labelComponent.AutoSize = true;
            this.labelComponent.Location = new System.Drawing.Point(24, 23);
            this.labelComponent.Name = "labelComponent";
            this.labelComponent.Size = new System.Drawing.Size(84, 20);
            this.labelComponent.TabIndex = 8;
            this.labelComponent.Text = "Персонал";
            // 
            // comboBoxSelectStaff
            // 
            this.comboBoxSelectStaff.FormattingEnabled = true;
            this.comboBoxSelectStaff.Location = new System.Drawing.Point(130, 14);
            this.comboBoxSelectStaff.Name = "comboBoxSelectStaff";
            this.comboBoxSelectStaff.Size = new System.Drawing.Size(247, 28);
            this.comboBoxSelectStaff.TabIndex = 9;
          // 
            // FormStaffAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 143);
            this.Controls.Add(this.comboBoxSelectStaff);
            this.Controls.Add(this.labelComponent);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Name = "FormStaffAdd";
            this.Text = "FormStaffAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelComponent;
        private System.Windows.Forms.ComboBox comboBoxSelectStaff;
    }
}