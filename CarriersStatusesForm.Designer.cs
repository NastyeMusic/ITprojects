namespace Автошкола
{
    partial class CarriersStatusesForm
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
            this.CarriersStatuses_dataGridView = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reload_button = new System.Windows.Forms.Button();
            this.Close_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CarriersStatuses_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Edit_button
            // 
            this.Edit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_button.Location = new System.Drawing.Point(1040, 184);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(135, 48);
            this.Edit_button.TabIndex = 17;
            this.Edit_button.Text = "Редактировать выбранное";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_button.Location = new System.Drawing.Point(1040, 247);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(135, 48);
            this.Delete_button.TabIndex = 16;
            this.Delete_button.Text = "Удалить выбранное";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_button.Location = new System.Drawing.Point(1040, 121);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(135, 48);
            this.Add_button.TabIndex = 15;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // CarriersStatuses_dataGridView
            // 
            this.CarriersStatuses_dataGridView.AllowUserToAddRows = false;
            this.CarriersStatuses_dataGridView.AllowUserToDeleteRows = false;
            this.CarriersStatuses_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CarriersStatuses_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarriersStatuses_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CarriersStatuses_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarriersStatuses_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.NameColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CarriersStatuses_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.CarriersStatuses_dataGridView.Location = new System.Drawing.Point(12, 12);
            this.CarriersStatuses_dataGridView.MultiSelect = false;
            this.CarriersStatuses_dataGridView.Name = "CarriersStatuses_dataGridView";
            this.CarriersStatuses_dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarriersStatuses_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CarriersStatuses_dataGridView.RowHeadersVisible = false;
            this.CarriersStatuses_dataGridView.RowTemplate.Height = 24;
            this.CarriersStatuses_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarriersStatuses_dataGridView.Size = new System.Drawing.Size(1022, 611);
            this.CarriersStatuses_dataGridView.TabIndex = 14;
            this.CarriersStatuses_dataGridView.SelectionChanged += new System.EventHandler(this.CarriersStatuses_dataGridView_SelectionChanged);
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
            this.NameColumn.HeaderText = "Наименование статуса";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // Reload_button
            // 
            this.Reload_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Reload_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reload_button.Image = global::Автошкола.Properties.Resources._288px_Crystal_128_reload_Little2;
            this.Reload_button.Location = new System.Drawing.Point(1040, 42);
            this.Reload_button.Name = "Reload_button";
            this.Reload_button.Size = new System.Drawing.Size(45, 35);
            this.Reload_button.TabIndex = 31;
            this.Reload_button.UseVisualStyleBackColor = true;
            this.Reload_button.Click += new System.EventHandler(this.Reload_button_Click);
            // 
            // Close_button
            // 
            this.Close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_button.Location = new System.Drawing.Point(1040, 572);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(135, 48);
            this.Close_button.TabIndex = 32;
            this.Close_button.Text = "Закрыть";
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // CarriersStatusesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1187, 632);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.Reload_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.CarriersStatuses_dataGridView);
            this.MinimumSize = new System.Drawing.Size(1024, 679);
            this.Name = "CarriersStatusesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статусы ТС";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CarriersStatusesForm_FormClosing);
            this.Load += new System.EventHandler(this.CarriersStatusesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarriersStatuses_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.DataGridView CarriersStatuses_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.Button Reload_button;
        private System.Windows.Forms.Button Close_button;
    }
}