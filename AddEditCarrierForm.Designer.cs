namespace Автошкола
{
    partial class AddEditCarrierForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Brand_textBox = new System.Windows.Forms.TextBox();
            this.Model_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Color_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StateNumber_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Transmission_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Category_comboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Status_comboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Марка";
            // 
            // Brand_textBox
            // 
            this.Brand_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Brand_textBox.Location = new System.Drawing.Point(82, 12);
            this.Brand_textBox.Name = "Brand_textBox";
            this.Brand_textBox.Size = new System.Drawing.Size(286, 24);
            this.Brand_textBox.TabIndex = 2;
            this.Brand_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Brand_textBox_KeyPress);
            // 
            // Model_textBox
            // 
            this.Model_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Model_textBox.Location = new System.Drawing.Point(82, 42);
            this.Model_textBox.Name = "Model_textBox";
            this.Model_textBox.Size = new System.Drawing.Size(286, 24);
            this.Model_textBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Модель";
            // 
            // Color_textBox
            // 
            this.Color_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Color_textBox.Location = new System.Drawing.Point(82, 72);
            this.Color_textBox.Name = "Color_textBox";
            this.Color_textBox.Size = new System.Drawing.Size(286, 24);
            this.Color_textBox.TabIndex = 6;
            this.Color_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Color_textBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цвет";
            // 
            // StateNumber_textBox
            // 
            this.StateNumber_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StateNumber_textBox.Location = new System.Drawing.Point(700, 12);
            this.StateNumber_textBox.Name = "StateNumber_textBox";
            this.StateNumber_textBox.Size = new System.Drawing.Size(294, 24);
            this.StateNumber_textBox.TabIndex = 8;
            this.StateNumber_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StateNumber_textBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(389, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Государственный регистрационный номер";
            // 
            // Transmission_comboBox
            // 
            this.Transmission_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Transmission_comboBox.FormattingEnabled = true;
            this.Transmission_comboBox.Location = new System.Drawing.Point(700, 42);
            this.Transmission_comboBox.Name = "Transmission_comboBox";
            this.Transmission_comboBox.Size = new System.Drawing.Size(294, 26);
            this.Transmission_comboBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(594, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Трансмиссия";
            // 
            // Category_comboBox
            // 
            this.Category_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Category_comboBox.FormattingEnabled = true;
            this.Category_comboBox.Location = new System.Drawing.Point(700, 72);
            this.Category_comboBox.Name = "Category_comboBox";
            this.Category_comboBox.Size = new System.Drawing.Size(294, 26);
            this.Category_comboBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(614, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Категория";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(12, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(982, 2);
            this.label7.TabIndex = 18;
            this.label7.Text = "label7";
            // 
            // Status_comboBox
            // 
            this.Status_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status_comboBox.FormattingEnabled = true;
            this.Status_comboBox.Location = new System.Drawing.Point(82, 115);
            this.Status_comboBox.Name = "Status_comboBox";
            this.Status_comboBox.Size = new System.Drawing.Size(286, 26);
            this.Status_comboBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(20, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Статус";
            // 
            // Cancel_button
            // 
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(852, 156);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(142, 35);
            this.Cancel_button.TabIndex = 32;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = true;
            // 
            // Save_button
            // 
            this.Save_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_button.Location = new System.Drawing.Point(685, 156);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(142, 35);
            this.Save_button.TabIndex = 31;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(12, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(982, 2);
            this.label9.TabIndex = 30;
            this.label9.Text = "label9";
            // 
            // AddEditCarrierForm
            // 
            this.AcceptButton = this.Save_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.Cancel_button;
            this.ClientSize = new System.Drawing.Size(1006, 202);
            this.ControlBox = false;
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Status_comboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Category_comboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Transmission_comboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StateNumber_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Color_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Model_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Brand_textBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 249);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 249);
            this.Name = "AddEditCarrierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditCarrierForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditCarrierForm_FormClosing);
            this.Load += new System.EventHandler(this.AddEditCarrierForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Brand_textBox;
        private System.Windows.Forms.TextBox Model_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Color_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StateNumber_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Transmission_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Category_comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Status_comboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Label label9;
    }
}