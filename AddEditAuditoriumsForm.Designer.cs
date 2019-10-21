namespace Автошкола
{
    partial class AddEditAuditoriumsForm
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
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.AuditoriumName_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel_button
            // 
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(852, 55);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(142, 35);
            this.Cancel_button.TabIndex = 34;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = true;
            // 
            // Save_button
            // 
            this.Save_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_button.Location = new System.Drawing.Point(685, 55);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(142, 35);
            this.Save_button.TabIndex = 33;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(12, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(982, 2);
            this.label6.TabIndex = 32;
            this.label6.Text = "label6";
            // 
            // AuditoriumName_textBox
            // 
            this.AuditoriumName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuditoriumName_textBox.Location = new System.Drawing.Point(229, 12);
            this.AuditoriumName_textBox.Name = "AuditoriumName_textBox";
            this.AuditoriumName_textBox.Size = new System.Drawing.Size(765, 24);
            this.AuditoriumName_textBox.TabIndex = 31;
            this.AuditoriumName_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AuditoriumName_textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Наименование аудитории";
            // 
            // AddEditAuditoriumsForm
            // 
            this.AcceptButton = this.Save_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.Cancel_button;
            this.ClientSize = new System.Drawing.Size(1006, 98);
            this.ControlBox = false;
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AuditoriumName_textBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 145);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 145);
            this.Name = "AddEditAuditoriumsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditAuditoriumsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditAuditoriumsForm_FormClosing);
            this.Load += new System.EventHandler(this.AddEditAuditoriumsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AuditoriumName_textBox;
        private System.Windows.Forms.Label label1;
    }
}