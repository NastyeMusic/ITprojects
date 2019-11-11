namespace Автошкола
{
    partial class CurrentStatusesForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CarriersByStatus_dataGridView = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransmissionColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CategoryColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SelectedCarrierStatus_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CarriersByCondition_dataGridView = new System.Windows.Forms.DataGridView();
            this.ID2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateNumber2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transmission2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GetCarriersByCondition_button = new System.Windows.Forms.Button();
            this.Condition_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Time_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Date_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GetCarriersNeedsInReplacement_button = new System.Windows.Forms.Button();
            this.Close_button = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ReloadCarriers_button = new System.Windows.Forms.Button();
            this.ReloadCarriersStatuses_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarriersByStatus_dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarriersByCondition_dataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReloadCarriers_button);
            this.groupBox1.Controls.Add(this.ReloadCarriersStatuses_button);
            this.groupBox1.Controls.Add(this.CarriersByStatus_dataGridView);
            this.groupBox1.Controls.Add(this.SelectedCarrierStatus_comboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1161, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ТС с выбранным статусом";
            // 
            // CarriersByStatus_dataGridView
            // 
            this.CarriersByStatus_dataGridView.AllowUserToAddRows = false;
            this.CarriersByStatus_dataGridView.AllowUserToDeleteRows = false;
            this.CarriersByStatus_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CarriersByStatus_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CarriersByStatus_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarriersByStatus_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.BrandColumn,
            this.ModelColumn,
            this.StateNumberColumn,
            this.ColorColumn,
            this.TransmissionColumn,
            this.CategoryColumn,
            this.StatusColumn});
            this.CarriersByStatus_dataGridView.Location = new System.Drawing.Point(6, 60);
            this.CarriersByStatus_dataGridView.MultiSelect = false;
            this.CarriersByStatus_dataGridView.Name = "CarriersByStatus_dataGridView";
            this.CarriersByStatus_dataGridView.ReadOnly = true;
            this.CarriersByStatus_dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarriersByStatus_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CarriersByStatus_dataGridView.RowTemplate.Height = 24;
            this.CarriersByStatus_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarriersByStatus_dataGridView.Size = new System.Drawing.Size(1149, 196);
            this.CarriersByStatus_dataGridView.TabIndex = 34;
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "Код";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Visible = false;
            // 
            // BrandColumn
            // 
            this.BrandColumn.HeaderText = "Марка";
            this.BrandColumn.Name = "BrandColumn";
            this.BrandColumn.ReadOnly = true;
            // 
            // ModelColumn
            // 
            this.ModelColumn.HeaderText = "Модель";
            this.ModelColumn.Name = "ModelColumn";
            this.ModelColumn.ReadOnly = true;
            // 
            // StateNumberColumn
            // 
            this.StateNumberColumn.HeaderText = "Гос.рег.№";
            this.StateNumberColumn.Name = "StateNumberColumn";
            this.StateNumberColumn.ReadOnly = true;
            // 
            // ColorColumn
            // 
            this.ColorColumn.HeaderText = "Цвет";
            this.ColorColumn.Name = "ColorColumn";
            this.ColorColumn.ReadOnly = true;
            // 
            // TransmissionColumn
            // 
            this.TransmissionColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.TransmissionColumn.HeaderText = "Трансмиссия";
            this.TransmissionColumn.Name = "TransmissionColumn";
            this.TransmissionColumn.ReadOnly = true;
            this.TransmissionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TransmissionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CategoryColumn
            // 
            this.CategoryColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.CategoryColumn.HeaderText = "Категория";
            this.CategoryColumn.Name = "CategoryColumn";
            this.CategoryColumn.ReadOnly = true;
            this.CategoryColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // StatusColumn
            // 
            this.StatusColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.StatusColumn.HeaderText = "Статус";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            this.StatusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SelectedCarrierStatus_comboBox
            // 
            this.SelectedCarrierStatus_comboBox.FormattingEnabled = true;
            this.SelectedCarrierStatus_comboBox.Location = new System.Drawing.Point(92, 28);
            this.SelectedCarrierStatus_comboBox.Name = "SelectedCarrierStatus_comboBox";
            this.SelectedCarrierStatus_comboBox.Size = new System.Drawing.Size(318, 26);
            this.SelectedCarrierStatus_comboBox.TabIndex = 1;
            this.SelectedCarrierStatus_comboBox.SelectedValueChanged += new System.EventHandler(this.SelectedCarrierStatus_comboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Статус ТС";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CarriersByCondition_dataGridView);
            this.groupBox2.Controls.Add(this.GetCarriersByCondition_button);
            this.groupBox2.Controls.Add(this.Condition_comboBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Time_dateTimePicker);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Date_dateTimePicker);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1161, 258);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Состояние ТС на момент времени";
            // 
            // CarriersByCondition_dataGridView
            // 
            this.CarriersByCondition_dataGridView.AllowUserToAddRows = false;
            this.CarriersByCondition_dataGridView.AllowUserToDeleteRows = false;
            this.CarriersByCondition_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CarriersByCondition_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CarriersByCondition_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarriersByCondition_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID2Column,
            this.Brand2Column,
            this.Model2Column,
            this.StateNumber2Column,
            this.Color2Column,
            this.Transmission2Column,
            this.Category2Column,
            this.Status2Column});
            this.CarriersByCondition_dataGridView.Location = new System.Drawing.Point(6, 60);
            this.CarriersByCondition_dataGridView.MultiSelect = false;
            this.CarriersByCondition_dataGridView.Name = "CarriersByCondition_dataGridView";
            this.CarriersByCondition_dataGridView.ReadOnly = true;
            this.CarriersByCondition_dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarriersByCondition_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.CarriersByCondition_dataGridView.RowTemplate.Height = 24;
            this.CarriersByCondition_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarriersByCondition_dataGridView.Size = new System.Drawing.Size(1149, 192);
            this.CarriersByCondition_dataGridView.TabIndex = 35;
            // 
            // ID2Column
            // 
            this.ID2Column.HeaderText = "Код";
            this.ID2Column.Name = "ID2Column";
            this.ID2Column.ReadOnly = true;
            this.ID2Column.Visible = false;
            // 
            // Brand2Column
            // 
            this.Brand2Column.HeaderText = "Марка";
            this.Brand2Column.Name = "Brand2Column";
            this.Brand2Column.ReadOnly = true;
            // 
            // Model2Column
            // 
            this.Model2Column.HeaderText = "Модель";
            this.Model2Column.Name = "Model2Column";
            this.Model2Column.ReadOnly = true;
            // 
            // StateNumber2Column
            // 
            this.StateNumber2Column.HeaderText = "Гос.рег.№";
            this.StateNumber2Column.Name = "StateNumber2Column";
            this.StateNumber2Column.ReadOnly = true;
            // 
            // Color2Column
            // 
            this.Color2Column.HeaderText = "Цвет";
            this.Color2Column.Name = "Color2Column";
            this.Color2Column.ReadOnly = true;
            // 
            // Transmission2Column
            // 
            this.Transmission2Column.HeaderText = "Трансмиссия";
            this.Transmission2Column.Name = "Transmission2Column";
            this.Transmission2Column.ReadOnly = true;
            this.Transmission2Column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Category2Column
            // 
            this.Category2Column.HeaderText = "Категория";
            this.Category2Column.Name = "Category2Column";
            this.Category2Column.ReadOnly = true;
            this.Category2Column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Status2Column
            // 
            this.Status2Column.HeaderText = "Статус";
            this.Status2Column.Name = "Status2Column";
            this.Status2Column.ReadOnly = true;
            this.Status2Column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // GetCarriersByCondition_button
            // 
            this.GetCarriersByCondition_button.Location = new System.Drawing.Point(1013, 21);
            this.GetCarriersByCondition_button.Name = "GetCarriersByCondition_button";
            this.GetCarriersByCondition_button.Size = new System.Drawing.Size(144, 33);
            this.GetCarriersByCondition_button.TabIndex = 7;
            this.GetCarriersByCondition_button.Text = "Получить";
            this.GetCarriersByCondition_button.UseVisualStyleBackColor = true;
            this.GetCarriersByCondition_button.Click += new System.EventHandler(this.GetCarriersByCondition_button_Click);
            // 
            // Condition_comboBox
            // 
            this.Condition_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Condition_comboBox.FormattingEnabled = true;
            this.Condition_comboBox.Items.AddRange(new object[] {
            "Занято",
            "Свободно",
            "В ремонте",
            "Не ремонтируется",
            "Свободно и не ремонтируется"});
            this.Condition_comboBox.Location = new System.Drawing.Point(758, 25);
            this.Condition_comboBox.Name = "Condition_comboBox";
            this.Condition_comboBox.Size = new System.Drawing.Size(239, 26);
            this.Condition_comboBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(644, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Состояние ТС";
            // 
            // Time_dateTimePicker
            // 
            this.Time_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Time_dateTimePicker.Location = new System.Drawing.Point(452, 25);
            this.Time_dateTimePicker.Name = "Time_dateTimePicker";
            this.Time_dateTimePicker.Size = new System.Drawing.Size(151, 24);
            this.Time_dateTimePicker.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Выберите время";
            // 
            // Date_dateTimePicker
            // 
            this.Date_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_dateTimePicker.Location = new System.Drawing.Point(124, 26);
            this.Date_dateTimePicker.Name = "Date_dateTimePicker";
            this.Date_dateTimePicker.Size = new System.Drawing.Size(168, 24);
            this.Date_dateTimePicker.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите дату";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.GetCarriersNeedsInReplacement_button);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 546);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1013, 74);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ТС, требующие замены из-за ремонта";
            // 
            // GetCarriersNeedsInReplacement_button
            // 
            this.GetCarriersNeedsInReplacement_button.Location = new System.Drawing.Point(432, 23);
            this.GetCarriersNeedsInReplacement_button.Name = "GetCarriersNeedsInReplacement_button";
            this.GetCarriersNeedsInReplacement_button.Size = new System.Drawing.Size(208, 34);
            this.GetCarriersNeedsInReplacement_button.TabIndex = 0;
            this.GetCarriersNeedsInReplacement_button.Text = "Получить список ТС";
            this.GetCarriersNeedsInReplacement_button.UseVisualStyleBackColor = true;
            this.GetCarriersNeedsInReplacement_button.Click += new System.EventHandler(this.GetCarriersNeedsInReplacement_button_Click);
            // 
            // Close_button
            // 
            this.Close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_button.Location = new System.Drawing.Point(1031, 572);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(144, 48);
            this.Close_button.TabIndex = 56;
            this.Close_button.Text = "Закрыть";
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1163, 528);
            this.splitContainer1.SplitterDistance = 264;
            this.splitContainer1.TabIndex = 57;
            // 
            // ReloadCarriers_button
            // 
            this.ReloadCarriers_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReloadCarriers_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadCarriers_button.Image = global::Автошкола.Properties.Resources._288px_Crystal_128_reload_Little2;
            this.ReloadCarriers_button.Location = new System.Drawing.Point(1110, 23);
            this.ReloadCarriers_button.Name = "ReloadCarriers_button";
            this.ReloadCarriers_button.Size = new System.Drawing.Size(45, 35);
            this.ReloadCarriers_button.TabIndex = 42;
            this.ReloadCarriers_button.UseVisualStyleBackColor = true;
            this.ReloadCarriers_button.Click += new System.EventHandler(this.ReloadCarriers_button_Click);
            // 
            // ReloadCarriersStatuses_button
            // 
            this.ReloadCarriersStatuses_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadCarriersStatuses_button.Image = global::Автошкола.Properties.Resources._288px_Crystal_128_reload_Little2;
            this.ReloadCarriersStatuses_button.Location = new System.Drawing.Point(416, 23);
            this.ReloadCarriersStatuses_button.Name = "ReloadCarriersStatuses_button";
            this.ReloadCarriersStatuses_button.Size = new System.Drawing.Size(45, 35);
            this.ReloadCarriersStatuses_button.TabIndex = 41;
            this.ReloadCarriersStatuses_button.UseVisualStyleBackColor = true;
            this.ReloadCarriersStatuses_button.Click += new System.EventHandler(this.ReloadCarriersStatuses_button_Click);
            // 
            // CurrentStatusesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1187, 632);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.groupBox3);
            this.MinimumSize = new System.Drawing.Size(1024, 679);
            this.Name = "CurrentStatusesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Текущие состояния ТС";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CurrentStatusesForm_FormClosing);
            this.Load += new System.EventHandler(this.CurrentStatusesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarriersByStatus_dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarriersByCondition_dataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox SelectedCarrierStatus_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CarriersByStatus_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn TransmissionColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn CategoryColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn StatusColumn;
        private System.Windows.Forms.Button ReloadCarriers_button;
        private System.Windows.Forms.Button ReloadCarriersStatuses_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Date_dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Time_dateTimePicker;
        private System.Windows.Forms.ComboBox Condition_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GetCarriersByCondition_button;
        private System.Windows.Forms.DataGridView CarriersByCondition_dataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button GetCarriersNeedsInReplacement_button;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateNumber2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transmission2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status2Column;
    }
}