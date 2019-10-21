namespace Автошкола
{
    partial class AddEditStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Group_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Surname_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FirstName_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PatronymicName_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Retraining_checkBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ChangePhoto_button = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Instructor_comboBox = new System.Windows.Forms.ComboBox();
            this.CarriersUses_dataGridView = new System.Windows.Forms.DataGridView();
            this.InstructorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarrierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstructorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarrierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarrierUseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.ChoosenInstructor_label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ChoosenCarrier_label = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Save_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.PhoneNumber_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SelectPicture_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ReloadInstructors_button = new System.Windows.Forms.Button();
            this.ReloadGroups_button = new System.Windows.Forms.Button();
            this.Photo_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CarriersUses_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Учебная группа";
            // 
            // Group_comboBox
            // 
            this.Group_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Group_comboBox.FormattingEnabled = true;
            this.Group_comboBox.Location = new System.Drawing.Point(134, 12);
            this.Group_comboBox.Name = "Group_comboBox";
            this.Group_comboBox.Size = new System.Drawing.Size(185, 26);
            this.Group_comboBox.TabIndex = 1;
            this.Group_comboBox.SelectedIndexChanged += new System.EventHandler(this.Group_comboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(982, 2);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Фамилия";
            // 
            // Surname_textBox
            // 
            this.Surname_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname_textBox.Location = new System.Drawing.Point(93, 65);
            this.Surname_textBox.Name = "Surname_textBox";
            this.Surname_textBox.Size = new System.Drawing.Size(370, 24);
            this.Surname_textBox.TabIndex = 4;
            this.Surname_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Surname_textBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(49, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Имя";
            // 
            // FirstName_textBox
            // 
            this.FirstName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstName_textBox.Location = new System.Drawing.Point(93, 95);
            this.FirstName_textBox.Name = "FirstName_textBox";
            this.FirstName_textBox.Size = new System.Drawing.Size(370, 24);
            this.FirstName_textBox.TabIndex = 6;
            this.FirstName_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstName_textBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Отчество";
            // 
            // PatronymicName_textBox
            // 
            this.PatronymicName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicName_textBox.Location = new System.Drawing.Point(93, 125);
            this.PatronymicName_textBox.Name = "PatronymicName_textBox";
            this.PatronymicName_textBox.Size = new System.Drawing.Size(370, 24);
            this.PatronymicName_textBox.TabIndex = 8;
            this.PatronymicName_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatronymicName_textBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(550, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Телефонный номер";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(494, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Имеет ли другую категорию";
            // 
            // Retraining_checkBox
            // 
            this.Retraining_checkBox.AutoSize = true;
            this.Retraining_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Retraining_checkBox.Location = new System.Drawing.Point(703, 100);
            this.Retraining_checkBox.Name = "Retraining_checkBox";
            this.Retraining_checkBox.Size = new System.Drawing.Size(18, 17);
            this.Retraining_checkBox.TabIndex = 12;
            this.Retraining_checkBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(12, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(982, 2);
            this.label8.TabIndex = 13;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(266, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(2, 316);
            this.label9.TabIndex = 14;
            // 
            // ChangePhoto_button
            // 
            this.ChangePhoto_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePhoto_button.Location = new System.Drawing.Point(61, 450);
            this.ChangePhoto_button.Name = "ChangePhoto_button";
            this.ChangePhoto_button.Size = new System.Drawing.Size(146, 30);
            this.ChangePhoto_button.TabIndex = 16;
            this.ChangePhoto_button.Text = "Изменить фото";
            this.ChangePhoto_button.UseVisualStyleBackColor = true;
            this.ChangePhoto_button.Click += new System.EventHandler(this.ChangePhoto_button_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(274, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Инструктор";
            // 
            // Instructor_comboBox
            // 
            this.Instructor_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Instructor_comboBox.FormattingEnabled = true;
            this.Instructor_comboBox.Location = new System.Drawing.Point(369, 177);
            this.Instructor_comboBox.Name = "Instructor_comboBox";
            this.Instructor_comboBox.Size = new System.Drawing.Size(574, 26);
            this.Instructor_comboBox.TabIndex = 18;
            this.Instructor_comboBox.SelectedIndexChanged += new System.EventHandler(this.Instructor_comboBox_SelectedIndexChanged);
            // 
            // CarriersUses_dataGridView
            // 
            this.CarriersUses_dataGridView.AllowUserToAddRows = false;
            this.CarriersUses_dataGridView.AllowUserToDeleteRows = false;
            this.CarriersUses_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarriersUses_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CarriersUses_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarriersUses_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InstructorColumn,
            this.CarrierColumn,
            this.InstructorID,
            this.CarrierID,
            this.CarrierUseID});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CarriersUses_dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.CarriersUses_dataGridView.Location = new System.Drawing.Point(274, 209);
            this.CarriersUses_dataGridView.MultiSelect = false;
            this.CarriersUses_dataGridView.Name = "CarriersUses_dataGridView";
            this.CarriersUses_dataGridView.ReadOnly = true;
            this.CarriersUses_dataGridView.RowTemplate.Height = 24;
            this.CarriersUses_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarriersUses_dataGridView.Size = new System.Drawing.Size(720, 215);
            this.CarriersUses_dataGridView.TabIndex = 19;
            this.CarriersUses_dataGridView.SelectionChanged += new System.EventHandler(this.CarriersUses_dataGridView_SelectionChanged);
            // 
            // InstructorColumn
            // 
            this.InstructorColumn.HeaderText = "Инструктор";
            this.InstructorColumn.Name = "InstructorColumn";
            this.InstructorColumn.ReadOnly = true;
            this.InstructorColumn.Width = 118;
            // 
            // CarrierColumn
            // 
            this.CarrierColumn.HeaderText = "ТС";
            this.CarrierColumn.Name = "CarrierColumn";
            this.CarrierColumn.ReadOnly = true;
            this.CarrierColumn.Width = 57;
            // 
            // InstructorID
            // 
            this.InstructorID.HeaderText = "InstructorID";
            this.InstructorID.Name = "InstructorID";
            this.InstructorID.ReadOnly = true;
            this.InstructorID.Visible = false;
            this.InstructorID.Width = 113;
            // 
            // CarrierID
            // 
            this.CarrierID.HeaderText = "CarrierID";
            this.CarrierID.Name = "CarrierID";
            this.CarrierID.ReadOnly = true;
            this.CarrierID.Visible = false;
            this.CarrierID.Width = 96;
            // 
            // CarrierUseID
            // 
            this.CarrierUseID.HeaderText = "CarrierUseID";
            this.CarrierUseID.Name = "CarrierUseID";
            this.CarrierUseID.ReadOnly = true;
            this.CarrierUseID.Visible = false;
            this.CarrierUseID.Width = 123;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(274, 435);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(271, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "Выбранный инструктор для курсанта:";
            // 
            // ChoosenInstructor_label
            // 
            this.ChoosenInstructor_label.AutoSize = true;
            this.ChoosenInstructor_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoosenInstructor_label.Location = new System.Drawing.Point(551, 435);
            this.ChoosenInstructor_label.Name = "ChoosenInstructor_label";
            this.ChoosenInstructor_label.Size = new System.Drawing.Size(107, 18);
            this.ChoosenInstructor_label.TabIndex = 21;
            this.ChoosenInstructor_label.Text = "<Инструктор>";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(274, 458);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 18);
            this.label12.TabIndex = 22;
            this.label12.Text = "Выбранное ТС инструктора:";
            // 
            // ChoosenCarrier_label
            // 
            this.ChoosenCarrier_label.AutoSize = true;
            this.ChoosenCarrier_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoosenCarrier_label.Location = new System.Drawing.Point(485, 458);
            this.ChoosenCarrier_label.Name = "ChoosenCarrier_label";
            this.ChoosenCarrier_label.Size = new System.Drawing.Size(46, 18);
            this.ChoosenCarrier_label.TabIndex = 23;
            this.ChoosenCarrier_label.Text = "<ТС>";
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(12, 489);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(982, 2);
            this.label13.TabIndex = 25;
            this.label13.Text = "label13";
            // 
            // Save_button
            // 
            this.Save_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_button.Location = new System.Drawing.Point(685, 495);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(142, 35);
            this.Save_button.TabIndex = 26;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            // 
            // Cancel_button
            // 
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(852, 495);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(142, 35);
            this.Cancel_button.TabIndex = 27;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = true;
            // 
            // PhoneNumber_maskedTextBox
            // 
            this.PhoneNumber_maskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumber_maskedTextBox.Location = new System.Drawing.Point(703, 65);
            this.PhoneNumber_maskedTextBox.Mask = "+7 (999) 999-9999";
            this.PhoneNumber_maskedTextBox.Name = "PhoneNumber_maskedTextBox";
            this.PhoneNumber_maskedTextBox.Size = new System.Drawing.Size(291, 24);
            this.PhoneNumber_maskedTextBox.TabIndex = 28;
            this.PhoneNumber_maskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumber_maskedTextBox_KeyPress);
            // 
            // ReloadInstructors_button
            // 
            this.ReloadInstructors_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadInstructors_button.Image = global::Автошкола.Properties.Resources._288px_Crystal_128_reload_Little2;
            this.ReloadInstructors_button.Location = new System.Drawing.Point(949, 172);
            this.ReloadInstructors_button.Name = "ReloadInstructors_button";
            this.ReloadInstructors_button.Size = new System.Drawing.Size(45, 35);
            this.ReloadInstructors_button.TabIndex = 30;
            this.ReloadInstructors_button.UseVisualStyleBackColor = true;
            this.ReloadInstructors_button.Click += new System.EventHandler(this.ReloadInstructors_button_Click);
            // 
            // ReloadGroups_button
            // 
            this.ReloadGroups_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadGroups_button.Image = global::Автошкола.Properties.Resources._288px_Crystal_128_reload_Little2;
            this.ReloadGroups_button.Location = new System.Drawing.Point(325, 7);
            this.ReloadGroups_button.Name = "ReloadGroups_button";
            this.ReloadGroups_button.Size = new System.Drawing.Size(45, 35);
            this.ReloadGroups_button.TabIndex = 29;
            this.ReloadGroups_button.UseVisualStyleBackColor = true;
            this.ReloadGroups_button.Click += new System.EventHandler(this.ReloadGroups_button_Click);
            // 
            // Photo_pictureBox
            // 
            this.Photo_pictureBox.Location = new System.Drawing.Point(12, 170);
            this.Photo_pictureBox.Name = "Photo_pictureBox";
            this.Photo_pictureBox.Size = new System.Drawing.Size(246, 274);
            this.Photo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo_pictureBox.TabIndex = 15;
            this.Photo_pictureBox.TabStop = false;
            // 
            // AddEditStudent
            // 
            this.AcceptButton = this.Save_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.Cancel_button;
            this.ClientSize = new System.Drawing.Size(1006, 542);
            this.ControlBox = false;
            this.Controls.Add(this.ReloadInstructors_button);
            this.Controls.Add(this.ReloadGroups_button);
            this.Controls.Add(this.PhoneNumber_maskedTextBox);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ChoosenCarrier_label);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ChoosenInstructor_label);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CarriersUses_dataGridView);
            this.Controls.Add(this.Instructor_comboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ChangePhoto_button);
            this.Controls.Add(this.Photo_pictureBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Retraining_checkBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PatronymicName_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FirstName_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Surname_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Group_comboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 589);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 589);
            this.Name = "AddEditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditStudent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditStudent_FormClosing);
            this.Load += new System.EventHandler(this.AddEditStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarriersUses_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Group_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Surname_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FirstName_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PatronymicName_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox Retraining_checkBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox Photo_pictureBox;
        private System.Windows.Forms.Button ChangePhoto_button;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Instructor_comboBox;
        private System.Windows.Forms.DataGridView CarriersUses_dataGridView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ChoosenInstructor_label;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label ChoosenCarrier_label;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.MaskedTextBox PhoneNumber_maskedTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstructorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarrierColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstructorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarrierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarrierUseID;
        private System.Windows.Forms.OpenFileDialog SelectPicture_openFileDialog;
        private System.Windows.Forms.Button ReloadGroups_button;
        private System.Windows.Forms.Button ReloadInstructors_button;
    }
}