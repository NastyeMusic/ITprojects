﻿namespace Автошкола
{
    partial class AddEditCarrierRepairForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Carriers_dataGridView = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransmissionColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CategoryColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FinalNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ReloadCarriers_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SelectedCarrier_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectedMaster_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ReloadMasters_button = new System.Windows.Forms.Button();
            this.Masters_dataGridView = new System.Windows.Forms.DataGridView();
            this.MastersIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatronymicNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkStatusColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FIOColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Work_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.EndRepair_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.BeginRepair_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.DirectionCarrier_checkBox = new System.Windows.Forms.CheckBox();
            this.SearchCarrier_button = new System.Windows.Forms.Button();
            this.SearchCarrier_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DirectionMaster_checkBox = new System.Windows.Forms.CheckBox();
            this.SearchMaster_button = new System.Windows.Forms.Button();
            this.SearchMaster_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Carriers_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Masters_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Carriers_dataGridView
            // 
            this.Carriers_dataGridView.AllowUserToAddRows = false;
            this.Carriers_dataGridView.AllowUserToDeleteRows = false;
            this.Carriers_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Carriers_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Carriers_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Carriers_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.BrandColumn,
            this.ModelColumn,
            this.StateNumberColumn,
            this.ColorColumn,
            this.TransmissionColumn,
            this.CategoryColumn,
            this.StatusColumn,
            this.FinalNameColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Carriers_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.Carriers_dataGridView.Location = new System.Drawing.Point(12, 42);
            this.Carriers_dataGridView.MultiSelect = false;
            this.Carriers_dataGridView.Name = "Carriers_dataGridView";
            this.Carriers_dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Carriers_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Carriers_dataGridView.RowHeadersVisible = false;
            this.Carriers_dataGridView.RowTemplate.Height = 24;
            this.Carriers_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Carriers_dataGridView.Size = new System.Drawing.Size(931, 197);
            this.Carriers_dataGridView.TabIndex = 58;
            this.Carriers_dataGridView.SelectionChanged += new System.EventHandler(this.Carriers_dataGridView_SelectionChanged);
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "Код";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Visible = false;
            this.IDColumn.Width = 42;
            // 
            // BrandColumn
            // 
            this.BrandColumn.HeaderText = "Марка";
            this.BrandColumn.Name = "BrandColumn";
            this.BrandColumn.ReadOnly = true;
            this.BrandColumn.Width = 82;
            // 
            // ModelColumn
            // 
            this.ModelColumn.HeaderText = "Модель";
            this.ModelColumn.Name = "ModelColumn";
            this.ModelColumn.ReadOnly = true;
            this.ModelColumn.Width = 93;
            // 
            // StateNumberColumn
            // 
            this.StateNumberColumn.HeaderText = "Гос.рег.№";
            this.StateNumberColumn.Name = "StateNumberColumn";
            this.StateNumberColumn.ReadOnly = true;
            this.StateNumberColumn.Width = 108;
            // 
            // ColorColumn
            // 
            this.ColorColumn.HeaderText = "Цвет";
            this.ColorColumn.Name = "ColorColumn";
            this.ColorColumn.ReadOnly = true;
            this.ColorColumn.Width = 71;
            // 
            // TransmissionColumn
            // 
            this.TransmissionColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.TransmissionColumn.HeaderText = "Трансмиссия";
            this.TransmissionColumn.Name = "TransmissionColumn";
            this.TransmissionColumn.ReadOnly = true;
            this.TransmissionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TransmissionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TransmissionColumn.Width = 129;
            // 
            // CategoryColumn
            // 
            this.CategoryColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.CategoryColumn.HeaderText = "Категория";
            this.CategoryColumn.Name = "CategoryColumn";
            this.CategoryColumn.ReadOnly = true;
            this.CategoryColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CategoryColumn.Width = 109;
            // 
            // StatusColumn
            // 
            this.StatusColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.StatusColumn.HeaderText = "Статус";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            this.StatusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.StatusColumn.Width = 85;
            // 
            // FinalNameColumn
            // 
            this.FinalNameColumn.HeaderText = "FinalName";
            this.FinalNameColumn.Name = "FinalNameColumn";
            this.FinalNameColumn.ReadOnly = true;
            this.FinalNameColumn.Visible = false;
            this.FinalNameColumn.Width = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 57;
            this.label1.Text = "Список ТС";
            // 
            // ReloadCarriers_button
            // 
            this.ReloadCarriers_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadCarriers_button.Image = global::Автошкола.Properties.Resources._288px_Crystal_128_reload_Little2;
            this.ReloadCarriers_button.Location = new System.Drawing.Point(948, 42);
            this.ReloadCarriers_button.Name = "ReloadCarriers_button";
            this.ReloadCarriers_button.Size = new System.Drawing.Size(45, 35);
            this.ReloadCarriers_button.TabIndex = 59;
            this.ReloadCarriers_button.UseVisualStyleBackColor = true;
            this.ReloadCarriers_button.Click += new System.EventHandler(this.ReloadCarriers_button_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(982, 2);
            this.label5.TabIndex = 62;
            this.label5.Text = "label5";
            // 
            // SelectedCarrier_label
            // 
            this.SelectedCarrier_label.AutoSize = true;
            this.SelectedCarrier_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedCarrier_label.Location = new System.Drawing.Point(247, 242);
            this.SelectedCarrier_label.Name = "SelectedCarrier_label";
            this.SelectedCarrier_label.Size = new System.Drawing.Size(46, 18);
            this.SelectedCarrier_label.TabIndex = 61;
            this.SelectedCarrier_label.Text = "<ТС>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 18);
            this.label3.TabIndex = 60;
            this.label3.Text = "Выбранное ремонтируемое ТС:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(9, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(982, 2);
            this.label2.TabIndex = 68;
            this.label2.Text = "label2";
            // 
            // SelectedMaster_label
            // 
            this.SelectedMaster_label.AutoSize = true;
            this.SelectedMaster_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedMaster_label.Location = new System.Drawing.Point(222, 498);
            this.SelectedMaster_label.Name = "SelectedMaster_label";
            this.SelectedMaster_label.Size = new System.Drawing.Size(136, 18);
            this.SelectedMaster_label.TabIndex = 67;
            this.SelectedMaster_label.Text = "<мастер сервиса>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 18);
            this.label6.TabIndex = 66;
            this.label6.Text = "Выбранный мастер сервиса:";
            // 
            // ReloadMasters_button
            // 
            this.ReloadMasters_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadMasters_button.Image = global::Автошкола.Properties.Resources._288px_Crystal_128_reload_Little2;
            this.ReloadMasters_button.Location = new System.Drawing.Point(946, 309);
            this.ReloadMasters_button.Name = "ReloadMasters_button";
            this.ReloadMasters_button.Size = new System.Drawing.Size(45, 35);
            this.ReloadMasters_button.TabIndex = 65;
            this.ReloadMasters_button.UseVisualStyleBackColor = true;
            this.ReloadMasters_button.Click += new System.EventHandler(this.ReloadMasters_button_Click);
            // 
            // Masters_dataGridView
            // 
            this.Masters_dataGridView.AllowUserToAddRows = false;
            this.Masters_dataGridView.AllowUserToDeleteRows = false;
            this.Masters_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Masters_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Masters_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Masters_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MastersIDColumn,
            this.SurnameColumn,
            this.FirstNameColumn,
            this.PatronymicNameColumn,
            this.WorkStatusColumn,
            this.FIOColumn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Masters_dataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.Masters_dataGridView.Location = new System.Drawing.Point(12, 309);
            this.Masters_dataGridView.MultiSelect = false;
            this.Masters_dataGridView.Name = "Masters_dataGridView";
            this.Masters_dataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Masters_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Masters_dataGridView.RowHeadersVisible = false;
            this.Masters_dataGridView.RowTemplate.Height = 24;
            this.Masters_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Masters_dataGridView.Size = new System.Drawing.Size(931, 186);
            this.Masters_dataGridView.TabIndex = 64;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 18);
            this.label7.TabIndex = 63;
            this.label7.Text = "Список мастеров сервиса";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(9, 530);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 18);
            this.label8.TabIndex = 69;
            this.label8.Text = "Проводимые работы";
            // 
            // Work_textBox
            // 
            this.Work_textBox.Location = new System.Drawing.Point(174, 529);
            this.Work_textBox.Multiline = true;
            this.Work_textBox.Name = "Work_textBox";
            this.Work_textBox.Size = new System.Drawing.Size(820, 69);
            this.Work_textBox.TabIndex = 70;
            this.Work_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Work_textBox_KeyPress);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(12, 603);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(982, 2);
            this.label9.TabIndex = 71;
            this.label9.Text = "label9";
            // 
            // Cancel_button
            // 
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(852, 650);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(142, 35);
            this.Cancel_button.TabIndex = 78;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = true;
            // 
            // Save_button
            // 
            this.Save_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_button.Location = new System.Drawing.Point(685, 650);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(142, 35);
            this.Save_button.TabIndex = 77;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(12, 642);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(982, 2);
            this.label13.TabIndex = 76;
            this.label13.Text = "label13";
            // 
            // EndRepair_dateTimePicker
            // 
            this.EndRepair_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndRepair_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndRepair_dateTimePicker.Location = new System.Drawing.Point(700, 610);
            this.EndRepair_dateTimePicker.Name = "EndRepair_dateTimePicker";
            this.EndRepair_dateTimePicker.Size = new System.Drawing.Size(294, 24);
            this.EndRepair_dateTimePicker.TabIndex = 75;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(503, 615);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 18);
            this.label11.TabIndex = 74;
            this.label11.Text = "Дата окончания ремонта";
            // 
            // BeginRepair_dateTimePicker
            // 
            this.BeginRepair_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BeginRepair_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BeginRepair_dateTimePicker.Location = new System.Drawing.Point(186, 610);
            this.BeginRepair_dateTimePicker.Name = "BeginRepair_dateTimePicker";
            this.BeginRepair_dateTimePicker.Size = new System.Drawing.Size(294, 24);
            this.BeginRepair_dateTimePicker.TabIndex = 73;
            this.BeginRepair_dateTimePicker.ValueChanged += new System.EventHandler(this.BeginRepair_dateTimePicker_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(12, 615);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 18);
            this.label12.TabIndex = 72;
            this.label12.Text = "Дата начала ремонта";
            // 
            // DirectionCarrier_checkBox
            // 
            this.DirectionCarrier_checkBox.AutoSize = true;
            this.DirectionCarrier_checkBox.Checked = true;
            this.DirectionCarrier_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DirectionCarrier_checkBox.Location = new System.Drawing.Point(891, 14);
            this.DirectionCarrier_checkBox.Name = "DirectionCarrier_checkBox";
            this.DirectionCarrier_checkBox.Size = new System.Drawing.Size(102, 21);
            this.DirectionCarrier_checkBox.TabIndex = 82;
            this.DirectionCarrier_checkBox.Text = "поиск вниз";
            this.DirectionCarrier_checkBox.UseVisualStyleBackColor = true;
            // 
            // SearchCarrier_button
            // 
            this.SearchCarrier_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchCarrier_button.Location = new System.Drawing.Point(787, 8);
            this.SearchCarrier_button.Name = "SearchCarrier_button";
            this.SearchCarrier_button.Size = new System.Drawing.Size(98, 31);
            this.SearchCarrier_button.TabIndex = 81;
            this.SearchCarrier_button.Text = "Найти";
            this.SearchCarrier_button.UseVisualStyleBackColor = true;
            this.SearchCarrier_button.Click += new System.EventHandler(this.SearchCarrier_button_Click);
            // 
            // SearchCarrier_textBox
            // 
            this.SearchCarrier_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchCarrier_textBox.Location = new System.Drawing.Point(402, 12);
            this.SearchCarrier_textBox.Name = "SearchCarrier_textBox";
            this.SearchCarrier_textBox.Size = new System.Drawing.Size(379, 24);
            this.SearchCarrier_textBox.TabIndex = 80;
            this.SearchCarrier_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchCarrier_textBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(320, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 79;
            this.label4.Text = "Поиск ТС";
            // 
            // DirectionMaster_checkBox
            // 
            this.DirectionMaster_checkBox.AutoSize = true;
            this.DirectionMaster_checkBox.Checked = true;
            this.DirectionMaster_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DirectionMaster_checkBox.Location = new System.Drawing.Point(892, 281);
            this.DirectionMaster_checkBox.Name = "DirectionMaster_checkBox";
            this.DirectionMaster_checkBox.Size = new System.Drawing.Size(102, 21);
            this.DirectionMaster_checkBox.TabIndex = 86;
            this.DirectionMaster_checkBox.Text = "поиск вниз";
            this.DirectionMaster_checkBox.UseVisualStyleBackColor = true;
            // 
            // SearchMaster_button
            // 
            this.SearchMaster_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchMaster_button.Location = new System.Drawing.Point(788, 275);
            this.SearchMaster_button.Name = "SearchMaster_button";
            this.SearchMaster_button.Size = new System.Drawing.Size(98, 31);
            this.SearchMaster_button.TabIndex = 85;
            this.SearchMaster_button.Text = "Найти";
            this.SearchMaster_button.UseVisualStyleBackColor = true;
            this.SearchMaster_button.Click += new System.EventHandler(this.SearchMaster_button_Click);
            // 
            // SearchMaster_textBox
            // 
            this.SearchMaster_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchMaster_textBox.Location = new System.Drawing.Point(403, 279);
            this.SearchMaster_textBox.Name = "SearchMaster_textBox";
            this.SearchMaster_textBox.Size = new System.Drawing.Size(379, 24);
            this.SearchMaster_textBox.TabIndex = 84;
            this.SearchMaster_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchMaster_textBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(283, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 18);
            this.label10.TabIndex = 83;
            this.label10.Text = "Поиск мастера";
            // 
            // AddEditCarrierRepairForm
            // 
            this.AcceptButton = this.Save_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.Cancel_button;
            this.ClientSize = new System.Drawing.Size(1006, 692);
            this.ControlBox = false;
            this.Controls.Add(this.DirectionMaster_checkBox);
            this.Controls.Add(this.SearchMaster_button);
            this.Controls.Add(this.SearchMaster_textBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DirectionCarrier_checkBox);
            this.Controls.Add(this.SearchCarrier_button);
            this.Controls.Add(this.SearchCarrier_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.EndRepair_dateTimePicker);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BeginRepair_dateTimePicker);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Work_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectedMaster_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ReloadMasters_button);
            this.Controls.Add(this.Masters_dataGridView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SelectedCarrier_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReloadCarriers_button);
            this.Controls.Add(this.Carriers_dataGridView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 739);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 739);
            this.Name = "AddEditCarrierRepairForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditCarrierRepairForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditCarrierRepairForm_FormClosing);
            this.Load += new System.EventHandler(this.AddEditCarrierRepairForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Carriers_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Masters_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReloadCarriers_button;
        private System.Windows.Forms.DataGridView Carriers_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label SelectedCarrier_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SelectedMaster_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ReloadMasters_button;
        private System.Windows.Forms.DataGridView Masters_dataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Work_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker EndRepair_dateTimePicker;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker BeginRepair_dateTimePicker;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn MastersIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatronymicNameColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn WorkStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIOColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn TransmissionColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn CategoryColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn StatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalNameColumn;
        private System.Windows.Forms.CheckBox DirectionCarrier_checkBox;
        private System.Windows.Forms.Button SearchCarrier_button;
        private System.Windows.Forms.TextBox SearchCarrier_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox DirectionMaster_checkBox;
        private System.Windows.Forms.Button SearchMaster_button;
        private System.Windows.Forms.TextBox SearchMaster_textBox;
        private System.Windows.Forms.Label label10;
    }
}