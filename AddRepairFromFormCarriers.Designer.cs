namespace Автошкола
{
    partial class AddRepairFromFormCarriers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ChoosenCarrier_label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CarriersUses_dataGridView = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIOColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direction_checkBox = new System.Windows.Forms.CheckBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.SearchGroup_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChoosenServiceMaster_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EndLearning_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.BeginLearning_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CarriersUses_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ChoosenCarrier_label
            // 
            this.ChoosenCarrier_label.AutoSize = true;
            this.ChoosenCarrier_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoosenCarrier_label.Location = new System.Drawing.Point(507, 9);
            this.ChoosenCarrier_label.Name = "ChoosenCarrier_label";
            this.ChoosenCarrier_label.Size = new System.Drawing.Size(46, 18);
            this.ChoosenCarrier_label.TabIndex = 25;
            this.ChoosenCarrier_label.Text = "<ТС>";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Список мастеров сервиса:";
            // 
            // CarriersUses_dataGridView
            // 
            this.CarriersUses_dataGridView.AllowUserToAddRows = false;
            this.CarriersUses_dataGridView.AllowUserToDeleteRows = false;
            this.CarriersUses_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarriersUses_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.CarriersUses_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarriersUses_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.FIOColumn,
            this.WorkStatusColumn});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CarriersUses_dataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.CarriersUses_dataGridView.Location = new System.Drawing.Point(12, 72);
            this.CarriersUses_dataGridView.MultiSelect = false;
            this.CarriersUses_dataGridView.Name = "CarriersUses_dataGridView";
            this.CarriersUses_dataGridView.ReadOnly = true;
            this.CarriersUses_dataGridView.RowTemplate.Height = 24;
            this.CarriersUses_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarriersUses_dataGridView.Size = new System.Drawing.Size(982, 208);
            this.CarriersUses_dataGridView.TabIndex = 28;
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "Код";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Visible = false;
            this.IDColumn.Width = 65;
            // 
            // FIOColumn
            // 
            this.FIOColumn.HeaderText = "ФИО";
            this.FIOColumn.Name = "FIOColumn";
            this.FIOColumn.ReadOnly = true;
            this.FIOColumn.Width = 73;
            // 
            // WorkStatusColumn
            // 
            this.WorkStatusColumn.HeaderText = "Рабочий статус";
            this.WorkStatusColumn.Name = "WorkStatusColumn";
            this.WorkStatusColumn.ReadOnly = true;
            this.WorkStatusColumn.Width = 134;
            // 
            // Direction_checkBox
            // 
            this.Direction_checkBox.AutoSize = true;
            this.Direction_checkBox.Checked = true;
            this.Direction_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Direction_checkBox.Location = new System.Drawing.Point(892, 45);
            this.Direction_checkBox.Name = "Direction_checkBox";
            this.Direction_checkBox.Size = new System.Drawing.Size(102, 21);
            this.Direction_checkBox.TabIndex = 32;
            this.Direction_checkBox.Text = "поиск вниз";
            this.Direction_checkBox.UseVisualStyleBackColor = true;
            // 
            // Search_button
            // 
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_button.Location = new System.Drawing.Point(788, 41);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(98, 25);
            this.Search_button.TabIndex = 31;
            this.Search_button.Text = "Найти";
            this.Search_button.UseVisualStyleBackColor = true;
            // 
            // SearchGroup_textBox
            // 
            this.SearchGroup_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchGroup_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchGroup_textBox.Location = new System.Drawing.Point(397, 41);
            this.SearchGroup_textBox.Name = "SearchGroup_textBox";
            this.SearchGroup_textBox.Size = new System.Drawing.Size(385, 24);
            this.SearchGroup_textBox.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(277, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Поиск мастера";
            // 
            // ChoosenServiceMaster_label
            // 
            this.ChoosenServiceMaster_label.AutoSize = true;
            this.ChoosenServiceMaster_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoosenServiceMaster_label.Location = new System.Drawing.Point(225, 283);
            this.ChoosenServiceMaster_label.Name = "ChoosenServiceMaster_label";
            this.ChoosenServiceMaster_label.Size = new System.Drawing.Size(136, 18);
            this.ChoosenServiceMaster_label.TabIndex = 34;
            this.ChoosenServiceMaster_label.Text = "<мастер сервиса>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 18);
            this.label5.TabIndex = 33;
            this.label5.Text = "Выбранный мастер сервиса:";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(982, 2);
            this.label4.TabIndex = 35;
            this.label4.Text = "label4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 18);
            this.label6.TabIndex = 36;
            this.label6.Text = "Проводимые работы:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(178, 316);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(816, 87);
            this.textBox1.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(12, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(982, 2);
            this.label7.TabIndex = 38;
            this.label7.Text = "label7";
            // 
            // EndLearning_dateTimePicker
            // 
            this.EndLearning_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndLearning_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndLearning_dateTimePicker.Location = new System.Drawing.Point(697, 420);
            this.EndLearning_dateTimePicker.Name = "EndLearning_dateTimePicker";
            this.EndLearning_dateTimePicker.Size = new System.Drawing.Size(297, 24);
            this.EndLearning_dateTimePicker.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(507, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 18);
            this.label8.TabIndex = 41;
            this.label8.Text = "Дата окончания ремонта";
            // 
            // BeginLearning_dateTimePicker
            // 
            this.BeginLearning_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BeginLearning_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BeginLearning_dateTimePicker.Location = new System.Drawing.Point(178, 420);
            this.BeginLearning_dateTimePicker.Name = "BeginLearning_dateTimePicker";
            this.BeginLearning_dateTimePicker.Size = new System.Drawing.Size(297, 24);
            this.BeginLearning_dateTimePicker.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(13, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 18);
            this.label9.TabIndex = 39;
            this.label9.Text = "Дата начала ремонта";
            // 
            // Cancel_button
            // 
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(852, 456);
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
            this.Save_button.Location = new System.Drawing.Point(685, 460);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(142, 35);
            this.Save_button.TabIndex = 44;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(12, 452);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(982, 2);
            this.label10.TabIndex = 43;
            this.label10.Text = "label10";
            // 
            // AddRepairFromFormCarriers
            // 
            this.AcceptButton = this.Save_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.Cancel_button;
            this.ClientSize = new System.Drawing.Size(1006, 507);
            this.ControlBox = false;
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EndLearning_dateTimePicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BeginLearning_dateTimePicker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChoosenServiceMaster_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Direction_checkBox);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.SearchGroup_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CarriersUses_dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChoosenCarrier_label);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 554);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 554);
            this.Name = "AddRepairFromFormCarriers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRepairFromFormCarriers";
            ((System.ComponentModel.ISupportInitialize)(this.CarriersUses_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChoosenCarrier_label;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CarriersUses_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIOColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkStatusColumn;
        private System.Windows.Forms.CheckBox Direction_checkBox;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.TextBox SearchGroup_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ChoosenServiceMaster_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker EndLearning_dateTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker BeginLearning_dateTimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Label label10;
    }
}