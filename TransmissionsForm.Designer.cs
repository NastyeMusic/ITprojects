namespace Автошкола
{
    partial class TransmissionsForm
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
            this.Transmissions_dataGridView = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.SearchTransmission_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Direction_checkBox = new System.Windows.Forms.CheckBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.Reload_button = new System.Windows.Forms.Button();
            this.Close_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Transmissions_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Transmissions_dataGridView
            // 
            this.Transmissions_dataGridView.AllowUserToAddRows = false;
            this.Transmissions_dataGridView.AllowUserToDeleteRows = false;
            this.Transmissions_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Transmissions_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Transmissions_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Transmissions_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Transmissions_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.NameColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Transmissions_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.Transmissions_dataGridView.Location = new System.Drawing.Point(12, 39);
            this.Transmissions_dataGridView.MultiSelect = false;
            this.Transmissions_dataGridView.Name = "Transmissions_dataGridView";
            this.Transmissions_dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Transmissions_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Transmissions_dataGridView.RowHeadersVisible = false;
            this.Transmissions_dataGridView.RowTemplate.Height = 24;
            this.Transmissions_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Transmissions_dataGridView.Size = new System.Drawing.Size(1022, 584);
            this.Transmissions_dataGridView.TabIndex = 24;
            this.Transmissions_dataGridView.SelectionChanged += new System.EventHandler(this.Transmissions_dataGridView_SelectionChanged);
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "Код";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Visible = false;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Наименование трансмиссии";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // Edit_button
            // 
            this.Edit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_button.Location = new System.Drawing.Point(1040, 206);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(135, 48);
            this.Edit_button.TabIndex = 21;
            this.Edit_button.Text = "Редактировать выбранное";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_button.Location = new System.Drawing.Point(1040, 269);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(135, 48);
            this.Delete_button.TabIndex = 20;
            this.Delete_button.Text = "Удалить выбранное";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_button.Location = new System.Drawing.Point(1040, 143);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(135, 48);
            this.Add_button.TabIndex = 19;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // SearchTransmission_textBox
            // 
            this.SearchTransmission_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTransmission_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTransmission_textBox.Location = new System.Drawing.Point(164, 9);
            this.SearchTransmission_textBox.Name = "SearchTransmission_textBox";
            this.SearchTransmission_textBox.Size = new System.Drawing.Size(766, 24);
            this.SearchTransmission_textBox.TabIndex = 18;
            this.SearchTransmission_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTransmission_textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Поиск трансмиссии";
            // 
            // Direction_checkBox
            // 
            this.Direction_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Direction_checkBox.AutoSize = true;
            this.Direction_checkBox.Checked = true;
            this.Direction_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Direction_checkBox.Location = new System.Drawing.Point(1040, 13);
            this.Direction_checkBox.Name = "Direction_checkBox";
            this.Direction_checkBox.Size = new System.Drawing.Size(102, 21);
            this.Direction_checkBox.TabIndex = 23;
            this.Direction_checkBox.Text = "поиск вниз";
            this.Direction_checkBox.UseVisualStyleBackColor = true;
            // 
            // Search_button
            // 
            this.Search_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_button.Location = new System.Drawing.Point(936, 3);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(98, 34);
            this.Search_button.TabIndex = 22;
            this.Search_button.Text = "Найти";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Reload_button
            // 
            this.Reload_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Reload_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reload_button.Image = global::Автошкола.Properties.Resources._288px_Crystal_128_reload_Little2;
            this.Reload_button.Location = new System.Drawing.Point(1040, 76);
            this.Reload_button.Name = "Reload_button";
            this.Reload_button.Size = new System.Drawing.Size(45, 35);
            this.Reload_button.TabIndex = 33;
            this.Reload_button.UseVisualStyleBackColor = true;
            this.Reload_button.Click += new System.EventHandler(this.Reload_button_Click);
            // 
            // Close_button
            // 
            this.Close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_button.Location = new System.Drawing.Point(1040, 575);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(135, 48);
            this.Close_button.TabIndex = 34;
            this.Close_button.Text = "Закрыть";
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // TransmissionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1187, 632);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.Reload_button);
            this.Controls.Add(this.Transmissions_dataGridView);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.SearchTransmission_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Direction_checkBox);
            this.Controls.Add(this.Search_button);
            this.MinimumSize = new System.Drawing.Size(1024, 679);
            this.Name = "TransmissionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Трансмиссии";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TransmissionsFrom_FormClosing);
            this.Load += new System.EventHandler(this.TransmissionsFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Transmissions_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Transmissions_dataGridView;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.TextBox SearchTransmission_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Direction_checkBox;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.Button Reload_button;
        private System.Windows.Forms.Button Close_button;
    }
}