namespace Автошкола
{
    partial class JournalUsesForm
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
            this.SearchCarrier_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DirectionCarrier_checkBox = new System.Windows.Forms.CheckBox();
            this.SearchCarrier_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Close_button = new System.Windows.Forms.Button();
            this.PracticeLessons_dGV = new System.Windows.Forms.DataGridView();
            this.IDPLColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointedTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstructorColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.StudentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchInUsage_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DirectionInUsage_checkBox = new System.Windows.Forms.CheckBox();
            this.SearchInUsage_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ReloadCarriers_button = new System.Windows.Forms.Button();
            this.ReloadPracticeLessons_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Carriers_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeLessons_dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Carriers_dataGridView
            // 
            this.Carriers_dataGridView.AllowUserToAddRows = false;
            this.Carriers_dataGridView.AllowUserToDeleteRows = false;
            this.Carriers_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.StatusColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Carriers_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.Carriers_dataGridView.Location = new System.Drawing.Point(12, 39);
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
            this.Carriers_dataGridView.Size = new System.Drawing.Size(1163, 199);
            this.Carriers_dataGridView.TabIndex = 41;
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
            // SearchCarrier_textBox
            // 
            this.SearchCarrier_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchCarrier_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchCarrier_textBox.Location = new System.Drawing.Point(410, 8);
            this.SearchCarrier_textBox.Name = "SearchCarrier_textBox";
            this.SearchCarrier_textBox.Size = new System.Drawing.Size(492, 24);
            this.SearchCarrier_textBox.TabIndex = 40;
            this.SearchCarrier_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchCarrier_textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(328, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "Поиск ТС";
            // 
            // DirectionCarrier_checkBox
            // 
            this.DirectionCarrier_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DirectionCarrier_checkBox.AutoSize = true;
            this.DirectionCarrier_checkBox.Checked = true;
            this.DirectionCarrier_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DirectionCarrier_checkBox.Location = new System.Drawing.Point(1012, 12);
            this.DirectionCarrier_checkBox.Name = "DirectionCarrier_checkBox";
            this.DirectionCarrier_checkBox.Size = new System.Drawing.Size(102, 21);
            this.DirectionCarrier_checkBox.TabIndex = 43;
            this.DirectionCarrier_checkBox.Text = "поиск вниз";
            this.DirectionCarrier_checkBox.UseVisualStyleBackColor = true;
            // 
            // SearchCarrier_button
            // 
            this.SearchCarrier_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchCarrier_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchCarrier_button.Location = new System.Drawing.Point(908, 5);
            this.SearchCarrier_button.Name = "SearchCarrier_button";
            this.SearchCarrier_button.Size = new System.Drawing.Size(98, 30);
            this.SearchCarrier_button.TabIndex = 42;
            this.SearchCarrier_button.Text = "Найти";
            this.SearchCarrier_button.UseVisualStyleBackColor = true;
            this.SearchCarrier_button.Click += new System.EventHandler(this.SearchCarrier_button_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(11, 247);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1165, 2);
            this.label6.TabIndex = 44;
            this.label6.Text = "label6";
            // 
            // Close_button
            // 
            this.Close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_button.Location = new System.Drawing.Point(1031, 572);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(144, 48);
            this.Close_button.TabIndex = 57;
            this.Close_button.Text = "Закрыть";
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // PracticeLessons_dGV
            // 
            this.PracticeLessons_dGV.AllowUserToAddRows = false;
            this.PracticeLessons_dGV.AllowUserToDeleteRows = false;
            this.PracticeLessons_dGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PracticeLessons_dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PracticeLessons_dGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.PracticeLessons_dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PracticeLessons_dGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPLColumn,
            this.AppointedDateColumn,
            this.AppointedTimeColumn,
            this.InstructorColumn,
            this.StudentColumn,
            this.FactDateColumn,
            this.FactTimeColumn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PracticeLessons_dGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.PracticeLessons_dGV.Location = new System.Drawing.Point(12, 288);
            this.PracticeLessons_dGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PracticeLessons_dGV.MultiSelect = false;
            this.PracticeLessons_dGV.Name = "PracticeLessons_dGV";
            this.PracticeLessons_dGV.ReadOnly = true;
            this.PracticeLessons_dGV.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PracticeLessons_dGV.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.PracticeLessons_dGV.RowTemplate.Height = 24;
            this.PracticeLessons_dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PracticeLessons_dGV.Size = new System.Drawing.Size(1163, 279);
            this.PracticeLessons_dGV.TabIndex = 56;
            // 
            // IDPLColumn
            // 
            this.IDPLColumn.HeaderText = "Код";
            this.IDPLColumn.Name = "IDPLColumn";
            this.IDPLColumn.ReadOnly = true;
            this.IDPLColumn.Visible = false;
            this.IDPLColumn.Width = 42;
            // 
            // AppointedDateColumn
            // 
            this.AppointedDateColumn.HeaderText = "Назначенная дата";
            this.AppointedDateColumn.Name = "AppointedDateColumn";
            this.AppointedDateColumn.ReadOnly = true;
            this.AppointedDateColumn.Width = 150;
            // 
            // AppointedTimeColumn
            // 
            this.AppointedTimeColumn.HeaderText = "Назначенное время";
            this.AppointedTimeColumn.Name = "AppointedTimeColumn";
            this.AppointedTimeColumn.ReadOnly = true;
            this.AppointedTimeColumn.Width = 161;
            // 
            // InstructorColumn
            // 
            this.InstructorColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.InstructorColumn.HeaderText = "Инструктор";
            this.InstructorColumn.Name = "InstructorColumn";
            this.InstructorColumn.ReadOnly = true;
            this.InstructorColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.InstructorColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.InstructorColumn.Width = 118;
            // 
            // StudentColumn
            // 
            this.StudentColumn.HeaderText = "Курсант";
            this.StudentColumn.Name = "StudentColumn";
            this.StudentColumn.ReadOnly = true;
            this.StudentColumn.Width = 93;
            // 
            // FactDateColumn
            // 
            this.FactDateColumn.HeaderText = "Фактическая дата";
            this.FactDateColumn.Name = "FactDateColumn";
            this.FactDateColumn.ReadOnly = true;
            this.FactDateColumn.Width = 151;
            // 
            // FactTimeColumn
            // 
            this.FactTimeColumn.HeaderText = "Фактическое время";
            this.FactTimeColumn.Name = "FactTimeColumn";
            this.FactTimeColumn.ReadOnly = true;
            this.FactTimeColumn.Width = 162;
            // 
            // SearchInUsage_textBox
            // 
            this.SearchInUsage_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchInUsage_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchInUsage_textBox.Location = new System.Drawing.Point(410, 256);
            this.SearchInUsage_textBox.Name = "SearchInUsage_textBox";
            this.SearchInUsage_textBox.Size = new System.Drawing.Size(492, 24);
            this.SearchInUsage_textBox.TabIndex = 59;
            this.SearchInUsage_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchInUsage_textBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(352, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 58;
            this.label2.Text = "Поиск";
            // 
            // DirectionInUsage_checkBox
            // 
            this.DirectionInUsage_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DirectionInUsage_checkBox.AutoSize = true;
            this.DirectionInUsage_checkBox.Checked = true;
            this.DirectionInUsage_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DirectionInUsage_checkBox.Location = new System.Drawing.Point(1012, 260);
            this.DirectionInUsage_checkBox.Name = "DirectionInUsage_checkBox";
            this.DirectionInUsage_checkBox.Size = new System.Drawing.Size(102, 21);
            this.DirectionInUsage_checkBox.TabIndex = 61;
            this.DirectionInUsage_checkBox.Text = "поиск вниз";
            this.DirectionInUsage_checkBox.UseVisualStyleBackColor = true;
            // 
            // SearchInUsage_button
            // 
            this.SearchInUsage_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchInUsage_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchInUsage_button.Location = new System.Drawing.Point(908, 253);
            this.SearchInUsage_button.Name = "SearchInUsage_button";
            this.SearchInUsage_button.Size = new System.Drawing.Size(98, 30);
            this.SearchInUsage_button.TabIndex = 60;
            this.SearchInUsage_button.Text = "Найти";
            this.SearchInUsage_button.UseVisualStyleBackColor = true;
            this.SearchInUsage_button.Click += new System.EventHandler(this.SearchInUsage_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 62;
            this.label3.Text = "Список ТС";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 18);
            this.label4.TabIndex = 63;
            this.label4.Text = "Список использований";
            // 
            // ReloadCarriers_button
            // 
            this.ReloadCarriers_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReloadCarriers_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadCarriers_button.Image = global::Автошкола.Properties.Resources._288px_Crystal_128_reload_Little2;
            this.ReloadCarriers_button.Location = new System.Drawing.Point(1131, 3);
            this.ReloadCarriers_button.Name = "ReloadCarriers_button";
            this.ReloadCarriers_button.Size = new System.Drawing.Size(45, 35);
            this.ReloadCarriers_button.TabIndex = 64;
            this.ReloadCarriers_button.UseVisualStyleBackColor = true;
            this.ReloadCarriers_button.Click += new System.EventHandler(this.ReloadCarriers_button_Click);
            // 
            // ReloadPracticeLessons_button
            // 
            this.ReloadPracticeLessons_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReloadPracticeLessons_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadPracticeLessons_button.Image = global::Автошкола.Properties.Resources._288px_Crystal_128_reload_Little2;
            this.ReloadPracticeLessons_button.Location = new System.Drawing.Point(1131, 251);
            this.ReloadPracticeLessons_button.Name = "ReloadPracticeLessons_button";
            this.ReloadPracticeLessons_button.Size = new System.Drawing.Size(45, 35);
            this.ReloadPracticeLessons_button.TabIndex = 66;
            this.ReloadPracticeLessons_button.UseVisualStyleBackColor = true;
            this.ReloadPracticeLessons_button.Click += new System.EventHandler(this.ReloadPracticeLessons_button_Click);
            // 
            // JournalUsesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1187, 632);
            this.Controls.Add(this.ReloadPracticeLessons_button);
            this.Controls.Add(this.ReloadCarriers_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchInUsage_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DirectionInUsage_checkBox);
            this.Controls.Add(this.SearchInUsage_button);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.PracticeLessons_dGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Carriers_dataGridView);
            this.Controls.Add(this.SearchCarrier_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DirectionCarrier_checkBox);
            this.Controls.Add(this.SearchCarrier_button);
            this.MinimumSize = new System.Drawing.Size(1024, 679);
            this.Name = "JournalUsesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал использования ТС";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CarriersUseJournalForm_FormClosing);
            this.Load += new System.EventHandler(this.CarriersUseJournalForm_Load);
            this.VisibleChanged += new System.EventHandler(this.JournalUsesForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Carriers_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeLessons_dGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Carriers_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn TransmissionColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn CategoryColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn StatusColumn;
        private System.Windows.Forms.TextBox SearchCarrier_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox DirectionCarrier_checkBox;
        private System.Windows.Forms.Button SearchCarrier_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.DataGridView PracticeLessons_dGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPLColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointedDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointedTimeColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn InstructorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactTimeColumn;
        private System.Windows.Forms.TextBox SearchInUsage_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox DirectionInUsage_checkBox;
        private System.Windows.Forms.Button SearchInUsage_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ReloadCarriers_button;
        private System.Windows.Forms.Button ReloadPracticeLessons_button;
    }
}