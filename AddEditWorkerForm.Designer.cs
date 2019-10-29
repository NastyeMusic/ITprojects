namespace Автошкола
{
    partial class AddEditWorkerForm
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
            this.label13 = new System.Windows.Forms.Label();
            this.ChangePhoto_button = new System.Windows.Forms.Button();
            this.Photo_pictureBox = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PatronymicName_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FirstName_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Surname_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Post_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WorkStatus_comboBox = new System.Windows.Forms.ComboBox();
            this.SelectPicture_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.DeletePhoto_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Photo_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(276, 330);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(718, 2);
            this.label13.TabIndex = 29;
            this.label13.Text = "label13";
            // 
            // ChangePhoto_button
            // 
            this.ChangePhoto_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePhoto_button.Location = new System.Drawing.Point(61, 295);
            this.ChangePhoto_button.Name = "ChangePhoto_button";
            this.ChangePhoto_button.Size = new System.Drawing.Size(146, 30);
            this.ChangePhoto_button.TabIndex = 11;
            this.ChangePhoto_button.Text = "Изменить фото";
            this.ChangePhoto_button.UseVisualStyleBackColor = true;
            this.ChangePhoto_button.Click += new System.EventHandler(this.ChangePhoto_button_Click);
            // 
            // Photo_pictureBox
            // 
            this.Photo_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Photo_pictureBox.Location = new System.Drawing.Point(12, 15);
            this.Photo_pictureBox.Name = "Photo_pictureBox";
            this.Photo_pictureBox.Size = new System.Drawing.Size(246, 274);
            this.Photo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo_pictureBox.TabIndex = 27;
            this.Photo_pictureBox.TabStop = false;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(266, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(2, 355);
            this.label9.TabIndex = 26;
            // 
            // PatronymicName_textBox
            // 
            this.PatronymicName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicName_textBox.Location = new System.Drawing.Point(355, 103);
            this.PatronymicName_textBox.Name = "PatronymicName_textBox";
            this.PatronymicName_textBox.Size = new System.Drawing.Size(639, 24);
            this.PatronymicName_textBox.TabIndex = 6;
            this.PatronymicName_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatronymicName_textBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(274, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Отчество";
            // 
            // FirstName_textBox
            // 
            this.FirstName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstName_textBox.Location = new System.Drawing.Point(355, 66);
            this.FirstName_textBox.Name = "FirstName_textBox";
            this.FirstName_textBox.Size = new System.Drawing.Size(639, 24);
            this.FirstName_textBox.TabIndex = 4;
            this.FirstName_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstName_textBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(311, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Имя";
            // 
            // Surname_textBox
            // 
            this.Surname_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname_textBox.Location = new System.Drawing.Point(355, 33);
            this.Surname_textBox.Name = "Surname_textBox";
            this.Surname_textBox.Size = new System.Drawing.Size(639, 24);
            this.Surname_textBox.TabIndex = 2;
            this.Surname_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Surname_textBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(276, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Фамилия";
            // 
            // Cancel_button
            // 
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(852, 339);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(142, 35);
            this.Cancel_button.TabIndex = 13;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = true;
            // 
            // Save_button
            // 
            this.Save_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_button.Location = new System.Drawing.Point(685, 339);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(142, 35);
            this.Save_button.TabIndex = 12;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(276, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Должность";
            // 
            // Post_comboBox
            // 
            this.Post_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Post_comboBox.FormattingEnabled = true;
            this.Post_comboBox.Items.AddRange(new object[] {
            "преподаватель теории",
            "инструктор",
            "мастер сервиса"});
            this.Post_comboBox.Location = new System.Drawing.Point(371, 193);
            this.Post_comboBox.Name = "Post_comboBox";
            this.Post_comboBox.Size = new System.Drawing.Size(623, 26);
            this.Post_comboBox.TabIndex = 8;
            this.Post_comboBox.SelectedIndexChanged += new System.EventHandler(this.Post_comboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(274, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Рабочий статус";
            // 
            // WorkStatus_comboBox
            // 
            this.WorkStatus_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkStatus_comboBox.FormattingEnabled = true;
            this.WorkStatus_comboBox.Items.AddRange(new object[] {
            "преподаватель теории",
            "инструктор",
            "мастер сервиса"});
            this.WorkStatus_comboBox.Location = new System.Drawing.Point(397, 237);
            this.WorkStatus_comboBox.Name = "WorkStatus_comboBox";
            this.WorkStatus_comboBox.Size = new System.Drawing.Size(597, 26);
            this.WorkStatus_comboBox.TabIndex = 10;
            // 
            // DeletePhoto_button
            // 
            this.DeletePhoto_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeletePhoto_button.Location = new System.Drawing.Point(61, 339);
            this.DeletePhoto_button.Name = "DeletePhoto_button";
            this.DeletePhoto_button.Size = new System.Drawing.Size(146, 30);
            this.DeletePhoto_button.TabIndex = 30;
            this.DeletePhoto_button.Text = "Удалить фото";
            this.DeletePhoto_button.UseVisualStyleBackColor = true;
            this.DeletePhoto_button.Click += new System.EventHandler(this.DeletePhoto_button_Click);
            // 
            // AddEditWorkerForm
            // 
            this.AcceptButton = this.Save_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.Cancel_button;
            this.ClientSize = new System.Drawing.Size(1006, 382);
            this.ControlBox = false;
            this.Controls.Add(this.DeletePhoto_button);
            this.Controls.Add(this.WorkStatus_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Post_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.PatronymicName_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FirstName_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Surname_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ChangePhoto_button);
            this.Controls.Add(this.Photo_pictureBox);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 429);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 429);
            this.Name = "AddEditWorkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditWorkerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditWorkerForm_FormClosing);
            this.Load += new System.EventHandler(this.AddEditWorkerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Photo_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button ChangePhoto_button;
        private System.Windows.Forms.PictureBox Photo_pictureBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PatronymicName_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FirstName_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Surname_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Post_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox WorkStatus_comboBox;
        private System.Windows.Forms.OpenFileDialog SelectPicture_openFileDialog;
        private System.Windows.Forms.Button DeletePhoto_button;
    }
}