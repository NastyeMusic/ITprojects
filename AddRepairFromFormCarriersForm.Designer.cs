namespace Автошкола
{
    partial class AddRepairFromFormCarriersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SelectedCarrier_label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectedMaster_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Work_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EndRepair_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.BeginRepair_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.DirectionMaster_checkBox = new System.Windows.Forms.CheckBox();
            this.SearchMaster_button = new System.Windows.Forms.Button();
            this.SearchMaster_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReloadMasters_button = new System.Windows.Forms.Button();
            this.Masters_dataGridView = new System.Windows.Forms.DataGridView();
            this.MastersIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatronymicNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkStatusColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FIOColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Masters_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectedCarrier_label
            // 
            this.SelectedCarrier_label.AutoSize = true;
            this.SelectedCarrier_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedCarrier_label.Location = new System.Drawing.Point(507, 9);
            this.SelectedCarrier_label.Name = "SelectedCarrier_label";
            this.SelectedCarrier_label.Size = new System.Drawing.Size(46, 18);
            this.SelectedCarrier_label.TabIndex = 25;
            this.SelectedCarrier_label.Text = "<ТС>";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(272, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(229, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "Выбранное ремонтируемое ТС:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(982, 2);
            this.label2.TabIndex = 26;
            this.label2.Text = "label2";
            // 
            // SelectedMaster_label
            // 
            this.SelectedMaster_label.AutoSize = true;
            this.SelectedMaster_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedMaster_label.Location = new System.Drawing.Point(225, 263);
            this.SelectedMaster_label.Name = "SelectedMaster_label";
            this.SelectedMaster_label.Size = new System.Drawing.Size(136, 18);
            this.SelectedMaster_label.TabIndex = 34;
            this.SelectedMaster_label.Text = "<мастер сервиса>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 18);
            this.label5.TabIndex = 33;
            this.label5.Text = "Выбранный мастер сервиса:";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(982, 2);
            this.label4.TabIndex = 35;
            this.label4.Text = "label4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 18);
            this.label6.TabIndex = 36;
            this.label6.Text = "Проводимые работы:";
            // 
            // Work_textBox
            // 
            this.Work_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Work_textBox.Location = new System.Drawing.Point(178, 296);
            this.Work_textBox.Multiline = true;
            this.Work_textBox.Name = "Work_textBox";
            this.Work_textBox.Size = new System.Drawing.Size(816, 87);
            this.Work_textBox.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(12, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(982, 2);
            this.label7.TabIndex = 38;
            this.label7.Text = "label7";
            // 
            // EndRepair_dateTimePicker
            // 
            this.EndRepair_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndRepair_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndRepair_dateTimePicker.Location = new System.Drawing.Point(697, 400);
            this.EndRepair_dateTimePicker.Name = "EndRepair_dateTimePicker";
            this.EndRepair_dateTimePicker.Size = new System.Drawing.Size(297, 24);
            this.EndRepair_dateTimePicker.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(507, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 18);
            this.label8.TabIndex = 41;
            this.label8.Text = "Дата окончания ремонта";
            // 
            // BeginRepair_dateTimePicker
            // 
            this.BeginRepair_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BeginRepair_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BeginRepair_dateTimePicker.Location = new System.Drawing.Point(178, 400);
            this.BeginRepair_dateTimePicker.Name = "BeginRepair_dateTimePicker";
            this.BeginRepair_dateTimePicker.Size = new System.Drawing.Size(297, 24);
            this.BeginRepair_dateTimePicker.TabIndex = 40;
            this.BeginRepair_dateTimePicker.ValueChanged += new System.EventHandler(this.BeginRepair_dateTimePicker_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(13, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 18);
            this.label9.TabIndex = 39;
            this.label9.Text = "Дата начала ремонта";
            // 
            // Cancel_button
            // 
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(852, 436);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(142, 35);
            this.Cancel_button.TabIndex = 45;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = true;
            // 
            // Save_button
            // 
            this.Save_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_button.Location = new System.Drawing.Point(685, 440);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(142, 35);
            this.Save_button.TabIndex = 44;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(12, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(982, 2);
            this.label10.TabIndex = 43;
            this.label10.Text = "label10";
            // 
            // DirectionMaster_checkBox
            // 
            this.DirectionMaster_checkBox.AutoSize = true;
            this.DirectionMaster_checkBox.Checked = true;
            this.DirectionMaster_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DirectionMaster_checkBox.Location = new System.Drawing.Point(892, 46);
            this.DirectionMaster_checkBox.Name = "DirectionMaster_checkBox";
            this.DirectionMaster_checkBox.Size = new System.Drawing.Size(102, 21);
            this.DirectionMaster_checkBox.TabIndex = 93;
            this.DirectionMaster_checkBox.Text = "поиск вниз";
            this.DirectionMaster_checkBox.UseVisualStyleBackColor = true;
            // 
            // SearchMaster_button
            // 
            this.SearchMaster_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchMaster_button.Location = new System.Drawing.Point(788, 40);
            this.SearchMaster_button.Name = "SearchMaster_button";
            this.SearchMaster_button.Size = new System.Drawing.Size(98, 31);
            this.SearchMaster_button.TabIndex = 92;
            this.SearchMaster_button.Text = "Найти";
            this.SearchMaster_button.UseVisualStyleBackColor = true;
            this.SearchMaster_button.Click += new System.EventHandler(this.SearchMaster_button_Click);
            // 
            // SearchMaster_textBox
            // 
            this.SearchMaster_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchMaster_textBox.Location = new System.Drawing.Point(403, 44);
            this.SearchMaster_textBox.Name = "SearchMaster_textBox";
            this.SearchMaster_textBox.Size = new System.Drawing.Size(379, 24);
            this.SearchMaster_textBox.TabIndex = 91;
            this.SearchMaster_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchMaster_textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(283, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 90;
            this.label1.Text = "Поиск мастера";
            // 
            // ReloadMasters_button
            // 
            this.ReloadMasters_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadMasters_button.Image = global::Автошкола.Properties.Resources._288px_Crystal_128_reload_Little2;
            this.ReloadMasters_button.Location = new System.Drawing.Point(946, 74);
            this.ReloadMasters_button.Name = "ReloadMasters_button";
            this.ReloadMasters_button.Size = new System.Drawing.Size(45, 35);
            this.ReloadMasters_button.TabIndex = 89;
            this.ReloadMasters_button.UseVisualStyleBackColor = true;
            this.ReloadMasters_button.Click += new System.EventHandler(this.ReloadMasters_button_Click);
            // 
            // Masters_dataGridView
            // 
            this.Masters_dataGridView.AllowUserToAddRows = false;
            this.Masters_dataGridView.AllowUserToDeleteRows = false;
            this.Masters_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Masters_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.Masters_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Masters_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MastersIDColumn,
            this.SurnameColumn,
            this.FirstNameColumn,
            this.PatronymicNameColumn,
            this.WorkStatusColumn,
            this.FIOColumn});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Masters_dataGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.Masters_dataGridView.Location = new System.Drawing.Point(12, 74);
            this.Masters_dataGridView.MultiSelect = false;
            this.Masters_dataGridView.Name = "Masters_dataGridView";
            this.Masters_dataGridView.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Masters_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.Masters_dataGridView.RowHeadersVisible = false;
            this.Masters_dataGridView.RowTemplate.Height = 24;
            this.Masters_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Masters_dataGridView.Size = new System.Drawing.Size(931, 186);
            this.Masters_dataGridView.TabIndex = 88;
            this.Masters_dataGridView.SelectionChanged += new System.EventHandler(this.Masters_dataGridView_SelectionChanged);
            // 
            // MastersIDColumn
            // 
            this.MastersIDColumn.HeaderText = "Код";
            this.MastersIDColumn.Name = "MastersIDColumn";
            this.MastersIDColumn.ReadOnly = true;
            this.MastersIDColumn.Visible = false;
            // 
            // SurnameColumn
            // 
            this.SurnameColumn.HeaderText = "Фамилия";
            this.SurnameColumn.Name = "SurnameColumn";
            this.SurnameColumn.ReadOnly = true;
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.HeaderText = "Имя";
            this.FirstNameColumn.Name = "FirstNameColumn";
            this.FirstNameColumn.ReadOnly = true;
            // 
            // PatronymicNameColumn
            // 
            this.PatronymicNameColumn.HeaderText = "Отчество";
            this.PatronymicNameColumn.Name = "PatronymicNameColumn";
            this.PatronymicNameColumn.ReadOnly = true;
            // 
            // WorkStatusColumn
            // 
            this.WorkStatusColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.WorkStatusColumn.HeaderText = "Рабочий статус";
            this.WorkStatusColumn.Name = "WorkStatusColumn";
            this.WorkStatusColumn.ReadOnly = true;
            this.WorkStatusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WorkStatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FIOColumn
            // 
            this.FIOColumn.HeaderText = "ФИО";
            this.FIOColumn.Name = "FIOColumn";
            this.FIOColumn.ReadOnly = true;
            this.FIOColumn.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 18);
            this.label3.TabIndex = 87;
            this.label3.Text = "Список мастеров сервиса";
            // 
            // AddRepairFromFormCarriersForm
            // 
            this.AcceptButton = this.Save_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.Cancel_button;
            this.ClientSize = new System.Drawing.Size(1006, 482);
            this.ControlBox = false;
            this.Controls.Add(this.DirectionMaster_checkBox);
            this.Controls.Add(this.SearchMaster_button);
            this.Controls.Add(this.SearchMaster_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReloadMasters_button);
            this.Controls.Add(this.Masters_dataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EndRepair_dateTimePicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BeginRepair_dateTimePicker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Work_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SelectedMaster_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectedCarrier_label);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 529);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 529);
            this.Name = "AddRepairFromFormCarriersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление ремонта для выбранного ТС";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddRepairFromFormCarriersForm_FormClosing);
            this.Load += new System.EventHandler(this.AddRepairFromFormCarriersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Masters_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectedCarrier_label;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SelectedMaster_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Work_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker EndRepair_dateTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker BeginRepair_dateTimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox DirectionMaster_checkBox;
        private System.Windows.Forms.Button SearchMaster_button;
        private System.Windows.Forms.TextBox SearchMaster_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReloadMasters_button;
        private System.Windows.Forms.DataGridView Masters_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MastersIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatronymicNameColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn WorkStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIOColumn;
        private System.Windows.Forms.Label label3;
    }
}