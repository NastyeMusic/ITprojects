namespace Автошкола
{
    partial class WorkersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Workers_dataGridView = new System.Windows.Forms.DataGridView();
            this.SearchWorker_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Direction_checkBox = new System.Windows.Forms.CheckBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatronymicNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeWorkStatuses_button = new System.Windows.Forms.Button();
            this.ReloadWorkers_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Workers_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Edit_button
            // 
            this.Edit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_button.Location = new System.Drawing.Point(1040, 187);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(135, 48);
            this.Edit_button.TabIndex = 13;
            this.Edit_button.Text = "Редактировать выбранное";
            this.Edit_button.UseVisualStyleBackColor = true;
            // 
            // Delete_button
            // 
            this.Delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_button.Location = new System.Drawing.Point(1040, 250);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(135, 48);
            this.Delete_button.TabIndex = 12;
            this.Delete_button.Text = "Удалить выбранное";
            this.Delete_button.UseVisualStyleBackColor = true;
            // 
            // Add_button
            // 
            this.Add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_button.Location = new System.Drawing.Point(1040, 124);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(135, 48);
            this.Add_button.TabIndex = 11;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            // 
            // Workers_dataGridView
            // 
            this.Workers_dataGridView.AllowUserToAddRows = false;
            this.Workers_dataGridView.AllowUserToDeleteRows = false;
            this.Workers_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Workers_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Workers_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Workers_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Workers_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.SurnameColumn,
            this.FirstNameColumn,
            this.PatronymicNameColumn,
            this.PostColumn,
            this.WorkStatusColumn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Workers_dataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.Workers_dataGridView.Location = new System.Drawing.Point(12, 39);
            this.Workers_dataGridView.MultiSelect = false;
            this.Workers_dataGridView.Name = "Workers_dataGridView";
            this.Workers_dataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Workers_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Workers_dataGridView.RowHeadersVisible = false;
            this.Workers_dataGridView.RowTemplate.Height = 24;
            this.Workers_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Workers_dataGridView.Size = new System.Drawing.Size(1022, 584);
            this.Workers_dataGridView.TabIndex = 10;
            // 
            // SearchWorker_textBox
            // 
            this.SearchWorker_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchWorker_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchWorker_textBox.Location = new System.Drawing.Point(154, 9);
            this.SearchWorker_textBox.Name = "SearchWorker_textBox";
            this.SearchWorker_textBox.Size = new System.Drawing.Size(776, 24);
            this.SearchWorker_textBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Поиск сотрудника";
            // 
            // Direction_checkBox
            // 
            this.Direction_checkBox.AutoSize = true;
            this.Direction_checkBox.Checked = true;
            this.Direction_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Direction_checkBox.Location = new System.Drawing.Point(1040, 13);
            this.Direction_checkBox.Name = "Direction_checkBox";
            this.Direction_checkBox.Size = new System.Drawing.Size(102, 21);
            this.Direction_checkBox.TabIndex = 15;
            this.Direction_checkBox.Text = "поиск вниз";
            this.Direction_checkBox.UseVisualStyleBackColor = true;
            // 
            // Search_button
            // 
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_button.Location = new System.Drawing.Point(936, 9);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(98, 25);
            this.Search_button.TabIndex = 14;
            this.Search_button.Text = "Найти";
            this.Search_button.UseVisualStyleBackColor = true;
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "Код";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Visible = false;
            this.IDColumn.Width = 42;
            // 
            // SurnameColumn
            // 
            this.SurnameColumn.HeaderText = "Фамилия";
            this.SurnameColumn.Name = "SurnameColumn";
            this.SurnameColumn.ReadOnly = true;
            this.SurnameColumn.Width = 102;
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.HeaderText = "Имя";
            this.FirstNameColumn.Name = "FirstNameColumn";
            this.FirstNameColumn.ReadOnly = true;
            this.FirstNameColumn.Width = 67;
            // 
            // PatronymicNameColumn
            // 
            this.PatronymicNameColumn.HeaderText = "Отчество";
            this.PatronymicNameColumn.Name = "PatronymicNameColumn";
            this.PatronymicNameColumn.ReadOnly = true;
            this.PatronymicNameColumn.Width = 104;
            // 
            // PostColumn
            // 
            this.PostColumn.HeaderText = "Должность";
            this.PostColumn.Name = "PostColumn";
            this.PostColumn.ReadOnly = true;
            this.PostColumn.Width = 118;
            // 
            // WorkStatusColumn
            // 
            this.WorkStatusColumn.HeaderText = "Рабочий статус";
            this.WorkStatusColumn.Name = "WorkStatusColumn";
            this.WorkStatusColumn.ReadOnly = true;
            this.WorkStatusColumn.Width = 134;
            // 
            // ChangeWorkStatuses_button
            // 
            this.ChangeWorkStatuses_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeWorkStatuses_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeWorkStatuses_button.Location = new System.Drawing.Point(1040, 551);
            this.ChangeWorkStatuses_button.Name = "ChangeWorkStatuses_button";
            this.ChangeWorkStatuses_button.Size = new System.Drawing.Size(135, 72);
            this.ChangeWorkStatuses_button.TabIndex = 16;
            this.ChangeWorkStatuses_button.Text = "Изменение рабочих статусов";
            this.ChangeWorkStatuses_button.UseVisualStyleBackColor = true;
            this.ChangeWorkStatuses_button.Click += new System.EventHandler(this.ChangeWorkStatuses_button_Click);
            // 
            // ReloadWorkers_button
            // 
            this.ReloadWorkers_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadWorkers_button.Image = global::Автошкола.Properties.Resources._288px_Crystal_128_reload_Little2;
            this.ReloadWorkers_button.Location = new System.Drawing.Point(1040, 60);
            this.ReloadWorkers_button.Name = "ReloadWorkers_button";
            this.ReloadWorkers_button.Size = new System.Drawing.Size(45, 35);
            this.ReloadWorkers_button.TabIndex = 30;
            this.ReloadWorkers_button.UseVisualStyleBackColor = true;
            // 
            // WorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1187, 632);
            this.ControlBox = false;
            this.Controls.Add(this.ReloadWorkers_button);
            this.Controls.Add(this.ChangeWorkStatuses_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Workers_dataGridView);
            this.Controls.Add(this.SearchWorker_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Direction_checkBox);
            this.Controls.Add(this.Search_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 679);
            this.Name = "WorkersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с сотрудниками";
            ((System.ComponentModel.ISupportInitialize)(this.Workers_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.DataGridView Workers_dataGridView;
        private System.Windows.Forms.TextBox SearchWorker_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Direction_checkBox;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatronymicNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkStatusColumn;
        private System.Windows.Forms.Button ChangeWorkStatuses_button;
        private System.Windows.Forms.Button ReloadWorkers_button;
    }
}