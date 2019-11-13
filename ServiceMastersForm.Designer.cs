namespace Автошкола
{
    partial class ServiceMastersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceMastersForm));
            this.Close_button = new System.Windows.Forms.Button();
            this.ServiceMasters_dataGridView = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatronymicNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Direction_checkBox = new System.Windows.Forms.CheckBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.RepairsOfMaster_button = new System.Windows.Forms.Button();
            this.Reload_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceMasters_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Close_button
            // 
            this.Close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_button.Location = new System.Drawing.Point(996, 576);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(135, 48);
            this.Close_button.TabIndex = 47;
            this.Close_button.Text = "Закрыть";
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // ServiceMasters_dataGridView
            // 
            this.ServiceMasters_dataGridView.AllowUserToAddRows = false;
            this.ServiceMasters_dataGridView.AllowUserToDeleteRows = false;
            this.ServiceMasters_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServiceMasters_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServiceMasters_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ServiceMasters_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceMasters_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.SurnameColumn,
            this.FirstNameColumn,
            this.PatronymicNameColumn,
            this.WorkStatusColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ServiceMasters_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ServiceMasters_dataGridView.Location = new System.Drawing.Point(12, 43);
            this.ServiceMasters_dataGridView.MultiSelect = false;
            this.ServiceMasters_dataGridView.Name = "ServiceMasters_dataGridView";
            this.ServiceMasters_dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServiceMasters_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ServiceMasters_dataGridView.RowHeadersVisible = false;
            this.ServiceMasters_dataGridView.RowTemplate.Height = 24;
            this.ServiceMasters_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceMasters_dataGridView.Size = new System.Drawing.Size(978, 581);
            this.ServiceMasters_dataGridView.TabIndex = 43;
            this.ServiceMasters_dataGridView.SelectionChanged += new System.EventHandler(this.ServiceMasters_dataGridView_SelectionChanged);
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "Код";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Visible = false;
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
            this.WorkStatusColumn.HeaderText = "Рабочий статус";
            this.WorkStatusColumn.Name = "WorkStatusColumn";
            this.WorkStatusColumn.ReadOnly = true;
            // 
            // Search_textBox
            // 
            this.Search_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_textBox.Location = new System.Drawing.Point(70, 13);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(708, 24);
            this.Search_textBox.TabIndex = 42;
            this.Search_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Search_textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "Поиск";
            // 
            // Direction_checkBox
            // 
            this.Direction_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Direction_checkBox.AutoSize = true;
            this.Direction_checkBox.Checked = true;
            this.Direction_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Direction_checkBox.Location = new System.Drawing.Point(888, 16);
            this.Direction_checkBox.Name = "Direction_checkBox";
            this.Direction_checkBox.Size = new System.Drawing.Size(102, 21);
            this.Direction_checkBox.TabIndex = 45;
            this.Direction_checkBox.Text = "поиск вниз";
            this.Direction_checkBox.UseVisualStyleBackColor = true;
            // 
            // Search_button
            // 
            this.Search_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_button.Location = new System.Drawing.Point(784, 8);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(98, 32);
            this.Search_button.TabIndex = 44;
            this.Search_button.Text = "Найти";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // RepairsOfMaster_button
            // 
            this.RepairsOfMaster_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RepairsOfMaster_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepairsOfMaster_button.Location = new System.Drawing.Point(996, 147);
            this.RepairsOfMaster_button.Name = "RepairsOfMaster_button";
            this.RepairsOfMaster_button.Size = new System.Drawing.Size(179, 98);
            this.RepairsOfMaster_button.TabIndex = 49;
            this.RepairsOfMaster_button.Text = "Список отремонтированных и ремонтируемых ТС данным мастером";
            this.RepairsOfMaster_button.UseVisualStyleBackColor = true;
            this.RepairsOfMaster_button.Click += new System.EventHandler(this.RepairsOfMaster_button_Click);
            // 
            // Reload_button
            // 
            this.Reload_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Reload_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reload_button.Image = global::Автошкола.Properties.Resources._288px_Crystal_128_reload_Little2;
            this.Reload_button.Location = new System.Drawing.Point(996, 43);
            this.Reload_button.Name = "Reload_button";
            this.Reload_button.Size = new System.Drawing.Size(45, 35);
            this.Reload_button.TabIndex = 46;
            this.Reload_button.UseVisualStyleBackColor = true;
            this.Reload_button.Click += new System.EventHandler(this.Reload_button_Click);
            // 
            // ServiceMastersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1187, 632);
            this.Controls.Add(this.RepairsOfMaster_button);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.Reload_button);
            this.Controls.Add(this.ServiceMasters_dataGridView);
            this.Controls.Add(this.Search_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Direction_checkBox);
            this.Controls.Add(this.Search_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 679);
            this.Name = "ServiceMastersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мастера сервиса";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServiceMastersForm_FormClosing);
            this.Load += new System.EventHandler(this.ServiceMastersForm_Load);
            this.VisibleChanged += new System.EventHandler(this.ServiceMastersForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceMasters_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button Reload_button;
        private System.Windows.Forms.DataGridView ServiceMasters_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatronymicNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkStatusColumn;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Direction_checkBox;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button RepairsOfMaster_button;
    }
}