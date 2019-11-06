namespace Автошкола
{
    partial class InstructorsScheduleForm
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
            this.SelectedInstructor_comboBox = new System.Windows.Forms.ComboBox();
            this.InstructorsSchedule_dGV = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointedTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentFIOColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarrierNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Close_button = new System.Windows.Forms.Button();
            this.ReloadInstructors_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InstructorsSchedule_dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectedInstructor_comboBox
            // 
            this.SelectedInstructor_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedInstructor_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedInstructor_comboBox.FormattingEnabled = true;
            this.SelectedInstructor_comboBox.Location = new System.Drawing.Point(165, 11);
            this.SelectedInstructor_comboBox.Name = "SelectedInstructor_comboBox";
            this.SelectedInstructor_comboBox.Size = new System.Drawing.Size(821, 26);
            this.SelectedInstructor_comboBox.TabIndex = 65;
            this.SelectedInstructor_comboBox.SelectedIndexChanged += new System.EventHandler(this.SelectedInstructor_comboBox_SelectedIndexChanged);
            // 
            // InstructorsSchedule_dGV
            // 
            this.InstructorsSchedule_dGV.AllowUserToAddRows = false;
            this.InstructorsSchedule_dGV.AllowUserToDeleteRows = false;
            this.InstructorsSchedule_dGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InstructorsSchedule_dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InstructorsSchedule_dGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.InstructorsSchedule_dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InstructorsSchedule_dGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.AppointedDateColumn,
            this.AppointedTimeColumn,
            this.FactDateColumn,
            this.FactTimeColumn,
            this.StudentFIOColumn,
            this.CarrierNameColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InstructorsSchedule_dGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.InstructorsSchedule_dGV.Location = new System.Drawing.Point(12, 42);
            this.InstructorsSchedule_dGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InstructorsSchedule_dGV.MultiSelect = false;
            this.InstructorsSchedule_dGV.Name = "InstructorsSchedule_dGV";
            this.InstructorsSchedule_dGV.ReadOnly = true;
            this.InstructorsSchedule_dGV.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstructorsSchedule_dGV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.InstructorsSchedule_dGV.RowTemplate.Height = 24;
            this.InstructorsSchedule_dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InstructorsSchedule_dGV.Size = new System.Drawing.Size(974, 585);
            this.InstructorsSchedule_dGV.TabIndex = 61;
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "Код";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Visible = false;
            this.IDColumn.Width = 42;
            // 
            // AppointedDateColumn
            // 
            this.AppointedDateColumn.HeaderText = "Назначенная дата занятия";
            this.AppointedDateColumn.Name = "AppointedDateColumn";
            this.AppointedDateColumn.ReadOnly = true;
            this.AppointedDateColumn.Width = 154;
            // 
            // AppointedTimeColumn
            // 
            this.AppointedTimeColumn.HeaderText = "Назначенное время занятия";
            this.AppointedTimeColumn.Name = "AppointedTimeColumn";
            this.AppointedTimeColumn.ReadOnly = true;
            this.AppointedTimeColumn.Width = 164;
            // 
            // FactDateColumn
            // 
            this.FactDateColumn.HeaderText = "Фактическая дата занятия";
            this.FactDateColumn.Name = "FactDateColumn";
            this.FactDateColumn.ReadOnly = true;
            this.FactDateColumn.Width = 154;
            // 
            // FactTimeColumn
            // 
            this.FactTimeColumn.HeaderText = "Фактическое время занятия";
            this.FactTimeColumn.Name = "FactTimeColumn";
            this.FactTimeColumn.ReadOnly = true;
            this.FactTimeColumn.Width = 165;
            // 
            // StudentFIOColumn
            // 
            this.StudentFIOColumn.HeaderText = "Курсант";
            this.StudentFIOColumn.Name = "StudentFIOColumn";
            this.StudentFIOColumn.ReadOnly = true;
            this.StudentFIOColumn.Width = 93;
            // 
            // CarrierNameColumn
            // 
            this.CarrierNameColumn.HeaderText = "ТС";
            this.CarrierNameColumn.Name = "CarrierNameColumn";
            this.CarrierNameColumn.ReadOnly = true;
            this.CarrierNameColumn.Width = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 55;
            this.label1.Text = "Выбор инструктора";
            // 
            // Close_button
            // 
            this.Close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_button.Location = new System.Drawing.Point(992, 578);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(135, 48);
            this.Close_button.TabIndex = 66;
            this.Close_button.Text = "Закрыть";
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // ReloadInstructors_button
            // 
            this.ReloadInstructors_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReloadInstructors_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadInstructors_button.Image = global::Автошкола.Properties.Resources._288px_Crystal_128_reload_Little2;
            this.ReloadInstructors_button.Location = new System.Drawing.Point(992, 6);
            this.ReloadInstructors_button.Name = "ReloadInstructors_button";
            this.ReloadInstructors_button.Size = new System.Drawing.Size(45, 35);
            this.ReloadInstructors_button.TabIndex = 68;
            this.ReloadInstructors_button.UseVisualStyleBackColor = true;
            this.ReloadInstructors_button.Click += new System.EventHandler(this.ReloadInstructors_button_Click);
            // 
            // InstructorsScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1139, 638);
            this.Controls.Add(this.ReloadInstructors_button);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.SelectedInstructor_comboBox);
            this.Controls.Add(this.InstructorsSchedule_dGV);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1024, 685);
            this.Name = "InstructorsScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расписание инструктора";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InstructorsScheduleForm_FormClosing);
            this.Load += new System.EventHandler(this.InstructorsScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InstructorsSchedule_dGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectedInstructor_comboBox;
        private System.Windows.Forms.DataGridView InstructorsSchedule_dGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointedDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointedTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentFIOColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarrierNameColumn;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button ReloadInstructors_button;
    }
}