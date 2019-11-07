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
            this.label1 = new System.Windows.Forms.Label();
            this.SelectedCarrierStatus_comboBox = new System.Windows.Forms.ComboBox();
            this.Carriers_dataGridView = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransmissionColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CategoryColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ReloadCarriersStatuses_button = new System.Windows.Forms.Button();
            this.ReloadCarriers_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Date_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Carriers_dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReloadCarriers_button);
            this.groupBox1.Controls.Add(this.ReloadCarriersStatuses_button);
            this.groupBox1.Controls.Add(this.Carriers_dataGridView);
            this.groupBox1.Controls.Add(this.SelectedCarrierStatus_comboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1163, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ТС с выбранным статусом";
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
            // SelectedCarrierStatus_comboBox
            // 
            this.SelectedCarrierStatus_comboBox.FormattingEnabled = true;
            this.SelectedCarrierStatus_comboBox.Location = new System.Drawing.Point(92, 28);
            this.SelectedCarrierStatus_comboBox.Name = "SelectedCarrierStatus_comboBox";
            this.SelectedCarrierStatus_comboBox.Size = new System.Drawing.Size(318, 26);
            this.SelectedCarrierStatus_comboBox.TabIndex = 1;
            // 
            // Carriers_dataGridView
            // 
            this.Carriers_dataGridView.AllowUserToAddRows = false;
            this.Carriers_dataGridView.AllowUserToDeleteRows = false;
            this.Carriers_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Carriers_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Carriers_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Carriers_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.BrandColumn,
            this.ModelColumn,
            this.StateNumberColumn,
            this.ColorColumn,
            this.TransmissionColumn,
            this.CategoryColumn,
            this.StatusColumn});
            this.Carriers_dataGridView.Location = new System.Drawing.Point(6, 60);
            this.Carriers_dataGridView.MultiSelect = false;
            this.Carriers_dataGridView.Name = "Carriers_dataGridView";
            this.Carriers_dataGridView.ReadOnly = true;
            this.Carriers_dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Carriers_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Carriers_dataGridView.RowTemplate.Height = 24;
            this.Carriers_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Carriers_dataGridView.Size = new System.Drawing.Size(1151, 195);
            this.Carriers_dataGridView.TabIndex = 34;
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
            // ReloadCarriersStatuses_button
            // 
            this.ReloadCarriersStatuses_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadCarriersStatuses_button.Image = global::Автошкола.Properties.Resources._288px_Crystal_128_reload_Little2;
            this.ReloadCarriersStatuses_button.Location = new System.Drawing.Point(416, 23);
            this.ReloadCarriersStatuses_button.Name = "ReloadCarriersStatuses_button";
            this.ReloadCarriersStatuses_button.Size = new System.Drawing.Size(45, 35);
            this.ReloadCarriersStatuses_button.TabIndex = 41;
            this.ReloadCarriersStatuses_button.UseVisualStyleBackColor = true;
            // 
            // ReloadCarriers_button
            // 
            this.ReloadCarriers_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReloadCarriers_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadCarriers_button.Image = global::Автошкола.Properties.Resources._288px_Crystal_128_reload_Little2;
            this.ReloadCarriers_button.Location = new System.Drawing.Point(1112, 23);
            this.ReloadCarriers_button.Name = "ReloadCarriers_button";
            this.ReloadCarriers_button.Size = new System.Drawing.Size(45, 35);
            this.ReloadCarriers_button.TabIndex = 42;
            this.ReloadCarriers_button.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Date_dateTimePicker);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1163, 261);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Состояние ТС на момент времени";
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
            // Date_dateTimePicker
            // 
            this.Date_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_dateTimePicker.Location = new System.Drawing.Point(124, 26);
            this.Date_dateTimePicker.Name = "Date_dateTimePicker";
            this.Date_dateTimePicker.Size = new System.Drawing.Size(168, 24);
            this.Date_dateTimePicker.TabIndex = 2;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(452, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 24);
            this.dateTimePicker1.TabIndex = 4;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(758, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 26);
            this.comboBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1013, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Получить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewComboBoxColumn2,
            this.dataGridViewComboBoxColumn3});
            this.dataGridView1.Location = new System.Drawing.Point(6, 60);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1151, 195);
            this.dataGridView1.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 42;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Марка";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 82;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Модель";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 93;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Гос.рег.№";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 108;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Цвет";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 71;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn1.HeaderText = "Трансмиссия";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.ReadOnly = true;
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn1.Width = 129;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn2.HeaderText = "Категория";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.ReadOnly = true;
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn2.Width = 109;
            // 
            // dataGridViewComboBoxColumn3
            // 
            this.dataGridViewComboBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn3.HeaderText = "Статус";
            this.dataGridViewComboBoxColumn3.Name = "dataGridViewComboBoxColumn3";
            this.dataGridViewComboBoxColumn3.ReadOnly = true;
            this.dataGridViewComboBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn3.Width = 85;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 546);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1163, 74);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ТС, требующие замены из-за ремонта";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(493, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "Получить список ТС";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CurrentStatusesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1187, 632);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(1024, 679);
            this.Name = "CurrentStatusesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Текущие состояния ТС";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Carriers_dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox SelectedCarrierStatus_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Carriers_dataGridView;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
    }
}