namespace Автошкола
{
    partial class ReplacementsCarriersForm
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
            this.ReplacementsCarriers_dataGridView = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIOColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ReplaceableCarrierColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ReplacingCarrierColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DateBeginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEndColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Close_button = new System.Windows.Forms.Button();
            this.ReloadReplacementsCarriers_button = new System.Windows.Forms.Button();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Direction_checkBox = new System.Windows.Forms.CheckBox();
            this.Search_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReplacementsCarriers_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Edit_button
            // 
            this.Edit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_button.Location = new System.Drawing.Point(1040, 191);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(135, 48);
            this.Edit_button.TabIndex = 47;
            this.Edit_button.Text = "Редактировать выбранное";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_button.Location = new System.Drawing.Point(1040, 254);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(135, 48);
            this.Delete_button.TabIndex = 46;
            this.Delete_button.Text = "Удалить выбранное";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_button.Location = new System.Drawing.Point(1040, 128);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(135, 48);
            this.Add_button.TabIndex = 45;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // ReplacementsCarriers_dataGridView
            // 
            this.ReplacementsCarriers_dataGridView.AllowUserToAddRows = false;
            this.ReplacementsCarriers_dataGridView.AllowUserToDeleteRows = false;
            this.ReplacementsCarriers_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReplacementsCarriers_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReplacementsCarriers_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ReplacementsCarriers_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReplacementsCarriers_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.FIOColumn,
            this.ReplaceableCarrierColumn,
            this.ReplacingCarrierColumn,
            this.DateBeginColumn,
            this.DateEndColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReplacementsCarriers_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ReplacementsCarriers_dataGridView.Location = new System.Drawing.Point(12, 43);
            this.ReplacementsCarriers_dataGridView.MultiSelect = false;
            this.ReplacementsCarriers_dataGridView.Name = "ReplacementsCarriers_dataGridView";
            this.ReplacementsCarriers_dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReplacementsCarriers_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ReplacementsCarriers_dataGridView.RowHeadersVisible = false;
            this.ReplacementsCarriers_dataGridView.RowTemplate.Height = 24;
            this.ReplacementsCarriers_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReplacementsCarriers_dataGridView.Size = new System.Drawing.Size(1022, 581);
            this.ReplacementsCarriers_dataGridView.TabIndex = 44;
            this.ReplacementsCarriers_dataGridView.SelectionChanged += new System.EventHandler(this.ReplacementsCarriers_dataGridView_SelectionChanged);
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "Код";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Visible = false;
            // 
            // FIOColumn
            // 
            this.FIOColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.FIOColumn.HeaderText = "ФИО";
            this.FIOColumn.Name = "FIOColumn";
            this.FIOColumn.ReadOnly = true;
            this.FIOColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FIOColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ReplaceableCarrierColumn
            // 
            this.ReplaceableCarrierColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ReplaceableCarrierColumn.HeaderText = "Заменяемое ТС";
            this.ReplaceableCarrierColumn.Name = "ReplaceableCarrierColumn";
            this.ReplaceableCarrierColumn.ReadOnly = true;
            this.ReplaceableCarrierColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReplaceableCarrierColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ReplacingCarrierColumn
            // 
            this.ReplacingCarrierColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ReplacingCarrierColumn.HeaderText = "Заменяющее ТС";
            this.ReplacingCarrierColumn.Name = "ReplacingCarrierColumn";
            this.ReplacingCarrierColumn.ReadOnly = true;
            this.ReplacingCarrierColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReplacingCarrierColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DateBeginColumn
            // 
            this.DateBeginColumn.HeaderText = "Дата начала замены";
            this.DateBeginColumn.Name = "DateBeginColumn";
            this.DateBeginColumn.ReadOnly = true;
            this.DateBeginColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DateEndColumn
            // 
            this.DateEndColumn.HeaderText = "Дата окончания замены";
            this.DateEndColumn.Name = "DateEndColumn";
            this.DateEndColumn.ReadOnly = true;
            // 
            // Close_button
            // 
            this.Close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_button.Location = new System.Drawing.Point(1040, 576);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(135, 48);
            this.Close_button.TabIndex = 51;
            this.Close_button.Text = "Закрыть";
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // ReloadReplacementsCarriers_button
            // 
            this.ReloadReplacementsCarriers_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReloadReplacementsCarriers_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadReplacementsCarriers_button.Image = global::Автошкола.Properties.Resources._288px_Crystal_128_reload_Little2;
            this.ReloadReplacementsCarriers_button.Location = new System.Drawing.Point(1040, 64);
            this.ReloadReplacementsCarriers_button.Name = "ReloadReplacementsCarriers_button";
            this.ReloadReplacementsCarriers_button.Size = new System.Drawing.Size(45, 35);
            this.ReloadReplacementsCarriers_button.TabIndex = 50;
            this.ReloadReplacementsCarriers_button.UseVisualStyleBackColor = true;
            this.ReloadReplacementsCarriers_button.Click += new System.EventHandler(this.ReloadReplacementsCarriers_button_Click);
            // 
            // Search_textBox
            // 
            this.Search_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_textBox.Location = new System.Drawing.Point(70, 13);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(860, 24);
            this.Search_textBox.TabIndex = 43;
            this.Search_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Search_textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "Поиск";
            // 
            // Direction_checkBox
            // 
            this.Direction_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Direction_checkBox.AutoSize = true;
            this.Direction_checkBox.Checked = true;
            this.Direction_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Direction_checkBox.Location = new System.Drawing.Point(1040, 17);
            this.Direction_checkBox.Name = "Direction_checkBox";
            this.Direction_checkBox.Size = new System.Drawing.Size(102, 21);
            this.Direction_checkBox.TabIndex = 49;
            this.Direction_checkBox.Text = "поиск вниз";
            this.Direction_checkBox.UseVisualStyleBackColor = true;
            // 
            // Search_button
            // 
            this.Search_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_button.Location = new System.Drawing.Point(936, 9);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(98, 32);
            this.Search_button.TabIndex = 48;
            this.Search_button.Text = "Найти";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // ReplacementsCarriersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1187, 632);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.ReplacementsCarriers_dataGridView);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.ReloadReplacementsCarriers_button);
            this.Controls.Add(this.Search_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Direction_checkBox);
            this.Controls.Add(this.Search_button);
            this.MinimumSize = new System.Drawing.Size(1024, 679);
            this.Name = "ReplacementsCarriersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Замены ТС инструкторов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReplacementsCarriersForm_FormClosing);
            this.Load += new System.EventHandler(this.ReplacementsCarriersForm_Load);
            this.VisibleChanged += new System.EventHandler(this.ReplacementsCarriersForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ReplacementsCarriers_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.DataGridView ReplacementsCarriers_dataGridView;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button ReloadReplacementsCarriers_button;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Direction_checkBox;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn FIOColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ReplaceableCarrierColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ReplacingCarrierColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateBeginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEndColumn;
    }
}