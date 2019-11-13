namespace Автошкола
{
    partial class NeedsForReplacementPracticeLessonsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NeedsForReplacementPracticeLessonsForm));
            this.Close_button = new System.Windows.Forms.Button();
            this.PracticeLessonsOfStudent_dGV = new System.Windows.Forms.DataGridView();
            this.IDPLColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointedTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstructorColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CarrierColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FactDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeLessonsOfStudent_dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Close_button
            // 
            this.Close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_button.Location = new System.Drawing.Point(1031, 352);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(144, 48);
            this.Close_button.TabIndex = 60;
            this.Close_button.Text = "Закрыть";
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // PracticeLessonsOfStudent_dGV
            // 
            this.PracticeLessonsOfStudent_dGV.AllowUserToAddRows = false;
            this.PracticeLessonsOfStudent_dGV.AllowUserToDeleteRows = false;
            this.PracticeLessonsOfStudent_dGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PracticeLessonsOfStudent_dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PracticeLessonsOfStudent_dGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PracticeLessonsOfStudent_dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PracticeLessonsOfStudent_dGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPLColumn,
            this.AppointedDateColumn,
            this.AppointedTimeColumn,
            this.StudentColumn,
            this.InstructorColumn,
            this.CarrierColumn,
            this.FactDateColumn,
            this.FactTimeColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PracticeLessonsOfStudent_dGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.PracticeLessonsOfStudent_dGV.Location = new System.Drawing.Point(12, 11);
            this.PracticeLessonsOfStudent_dGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PracticeLessonsOfStudent_dGV.MultiSelect = false;
            this.PracticeLessonsOfStudent_dGV.Name = "PracticeLessonsOfStudent_dGV";
            this.PracticeLessonsOfStudent_dGV.ReadOnly = true;
            this.PracticeLessonsOfStudent_dGV.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PracticeLessonsOfStudent_dGV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.PracticeLessonsOfStudent_dGV.RowTemplate.Height = 24;
            this.PracticeLessonsOfStudent_dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PracticeLessonsOfStudent_dGV.Size = new System.Drawing.Size(1013, 389);
            this.PracticeLessonsOfStudent_dGV.TabIndex = 59;
            this.PracticeLessonsOfStudent_dGV.SelectionChanged += new System.EventHandler(this.PracticeLessonsOfStudent_dGV_SelectionChanged);
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
            // StudentColumn
            // 
            this.StudentColumn.HeaderText = "Курсант";
            this.StudentColumn.Name = "StudentColumn";
            this.StudentColumn.ReadOnly = true;
            this.StudentColumn.Width = 93;
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
            // CarrierColumn
            // 
            this.CarrierColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.CarrierColumn.HeaderText = "ТС";
            this.CarrierColumn.Name = "CarrierColumn";
            this.CarrierColumn.ReadOnly = true;
            this.CarrierColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CarrierColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CarrierColumn.Width = 57;
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
            // Edit_button
            // 
            this.Edit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_button.Location = new System.Drawing.Point(1031, 92);
            this.Edit_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(144, 47);
            this.Edit_button.TabIndex = 58;
            this.Edit_button.Text = "Редактировать выбранное";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // NeedsForReplacementPracticeLessonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1187, 412);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.PracticeLessonsOfStudent_dGV);
            this.Controls.Add(this.Edit_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1205, 459);
            this.Name = "NeedsForReplacementPracticeLessonsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Занятия, назначенные в выбранный промежуток времени";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NeedsForReplacementPracticeLessonsForm_FormClosing);
            this.Load += new System.EventHandler(this.NeedsForReplacementPracticeLessonsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PracticeLessonsOfStudent_dGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.DataGridView PracticeLessonsOfStudent_dGV;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPLColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointedDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointedTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn InstructorColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn CarrierColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactTimeColumn;
    }
}