namespace Автошкола
{
    partial class CarriersForm
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
            this.Edit_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Carriers_dataGridView = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransmissionColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CategoryColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AddRepairSelectedCarrier_button = new System.Windows.Forms.Button();
            this.SearchCarrier_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Direction_checkBox = new System.Windows.Forms.CheckBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.ReloadCarriers_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Carriers_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Edit_button
            // 
            this.Edit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_button.Location = new System.Drawing.Point(1040, 187);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(135, 48);
            this.Edit_button.TabIndex = 36;
            this.Edit_button.Text = "Редактировать выбранное";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_button.Location = new System.Drawing.Point(1040, 250);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(135, 48);
            this.Delete_button.TabIndex = 35;
            this.Delete_button.Text = "Удалить выбранное";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_button.Location = new System.Drawing.Point(1040, 124);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(135, 48);
            this.Add_button.TabIndex = 34;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Carriers_dataGridView
            // 
            this.Carriers_dataGridView.AllowUserToAddRows = false;
            this.Carriers_dataGridView.AllowUserToDeleteRows = false;
            this.Carriers_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.Carriers_dataGridView.Size = new System.Drawing.Size(1022, 581);
            this.Carriers_dataGridView.TabIndex = 33;
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
            // AddRepairSelectedCarrier_button
            // 
            this.AddRepairSelectedCarrier_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRepairSelectedCarrier_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRepairSelectedCarrier_button.Location = new System.Drawing.Point(1040, 551);
            this.AddRepairSelectedCarrier_button.Name = "AddRepairSelectedCarrier_button";
            this.AddRepairSelectedCarrier_button.Size = new System.Drawing.Size(135, 72);
            this.AddRepairSelectedCarrier_button.TabIndex = 39;
            this.AddRepairSelectedCarrier_button.Text = "Добавить выбранное ТС в ремонт";
            this.AddRepairSelectedCarrier_button.UseVisualStyleBackColor = true;
            this.AddRepairSelectedCarrier_button.Click += new System.EventHandler(this.AddRepairSelectedCarrier_button_Click);
            // 
            // SearchCarrier_textBox
            // 
            this.SearchCarrier_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchCarrier_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchCarrier_textBox.Location = new System.Drawing.Point(94, 9);
            this.SearchCarrier_textBox.Name = "SearchCarrier_textBox";
            this.SearchCarrier_textBox.Size = new System.Drawing.Size(836, 24);
            this.SearchCarrier_textBox.TabIndex = 32;
            this.SearchCarrier_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchCarrier_textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Поиск ТС";
            // 
            // Direction_checkBox
            // 
            this.Direction_checkBox.AutoSize = true;
            this.Direction_checkBox.Checked = true;
            this.Direction_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Direction_checkBox.Location = new System.Drawing.Point(1040, 13);
            this.Direction_checkBox.Name = "Direction_checkBox";
            this.Direction_checkBox.Size = new System.Drawing.Size(102, 21);
            this.Direction_checkBox.TabIndex = 38;
            this.Direction_checkBox.Text = "поиск вниз";
            this.Direction_checkBox.UseVisualStyleBackColor = true;
            // 
            // Search_button
            // 
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_button.Location = new System.Drawing.Point(936, 6);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(98, 30);
            this.Search_button.TabIndex = 37;
            this.Search_button.Text = "Найти";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // ReloadCarriers_button
            // 
            this.ReloadCarriers_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadCarriers_button.Image = global::Автошкола.Properties.Resources._288px_Crystal_128_reload_Little2;
            this.ReloadCarriers_button.Location = new System.Drawing.Point(1040, 60);
            this.ReloadCarriers_button.Name = "ReloadCarriers_button";
            this.ReloadCarriers_button.Size = new System.Drawing.Size(45, 35);
            this.ReloadCarriers_button.TabIndex = 40;
            this.ReloadCarriers_button.UseVisualStyleBackColor = true;
            this.ReloadCarriers_button.Click += new System.EventHandler(this.ReloadCarriers_button_Click);
            // 
            // CarriersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1187, 632);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Carriers_dataGridView);
            this.Controls.Add(this.ReloadCarriers_button);
            this.Controls.Add(this.AddRepairSelectedCarrier_button);
            this.Controls.Add(this.SearchCarrier_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Direction_checkBox);
            this.Controls.Add(this.Search_button);
            this.MinimumSize = new System.Drawing.Size(1024, 679);
            this.Name = "CarriersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учебные ТС";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CarriersForm_FormClosing);
            this.Load += new System.EventHandler(this.CarriersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Carriers_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.DataGridView Carriers_dataGridView;
        private System.Windows.Forms.Button ReloadCarriers_button;
        private System.Windows.Forms.Button AddRepairSelectedCarrier_button;
        private System.Windows.Forms.TextBox SearchCarrier_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Direction_checkBox;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn TransmissionColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn CategoryColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn StatusColumn;
    }
}