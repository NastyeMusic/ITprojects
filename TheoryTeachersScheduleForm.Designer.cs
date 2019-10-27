namespace Автошкола
{
    partial class TheoryTeachersScheduleForm
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
            this.SelectedTheoryTeacher_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TheoryTeachersSchedule_dGV = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheoryDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheoryTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuditoriumColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GroupColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TheoryTeachersSchedule_dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectedTheoryTeacher_comboBox
            // 
            this.SelectedTheoryTeacher_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedTheoryTeacher_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedTheoryTeacher_comboBox.FormattingEnabled = true;
            this.SelectedTheoryTeacher_comboBox.Location = new System.Drawing.Point(247, 11);
            this.SelectedTheoryTeacher_comboBox.Name = "SelectedTheoryTeacher_comboBox";
            this.SelectedTheoryTeacher_comboBox.Size = new System.Drawing.Size(808, 26);
            this.SelectedTheoryTeacher_comboBox.TabIndex = 68;
            this.SelectedTheoryTeacher_comboBox.SelectedIndexChanged += new System.EventHandler(this.SelectedTheoryTeacher_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 18);
            this.label1.TabIndex = 66;
            this.label1.Text = "Выбор преподавателя теории";
            // 
            // TheoryTeachersSchedule_dGV
            // 
            this.TheoryTeachersSchedule_dGV.AllowUserToAddRows = false;
            this.TheoryTeachersSchedule_dGV.AllowUserToDeleteRows = false;
            this.TheoryTeachersSchedule_dGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TheoryTeachersSchedule_dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TheoryTeachersSchedule_dGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TheoryTeachersSchedule_dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TheoryTeachersSchedule_dGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.TheoryDateColumn,
            this.TheoryTimeColumn,
            this.AuditoriumColumn,
            this.GroupColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TheoryTeachersSchedule_dGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.TheoryTeachersSchedule_dGV.Location = new System.Drawing.Point(16, 42);
            this.TheoryTeachersSchedule_dGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TheoryTeachersSchedule_dGV.MultiSelect = false;
            this.TheoryTeachersSchedule_dGV.Name = "TheoryTeachersSchedule_dGV";
            this.TheoryTeachersSchedule_dGV.ReadOnly = true;
            this.TheoryTeachersSchedule_dGV.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TheoryTeachersSchedule_dGV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.TheoryTeachersSchedule_dGV.RowTemplate.Height = 24;
            this.TheoryTeachersSchedule_dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TheoryTeachersSchedule_dGV.Size = new System.Drawing.Size(1039, 585);
            this.TheoryTeachersSchedule_dGV.TabIndex = 69;
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "Код";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Visible = false;
            this.IDColumn.Width = 42;
            // 
            // TheoryDateColumn
            // 
            this.TheoryDateColumn.HeaderText = "Дата занятия";
            this.TheoryDateColumn.Name = "TheoryDateColumn";
            this.TheoryDateColumn.ReadOnly = true;
            this.TheoryDateColumn.Width = 120;
            // 
            // TheoryTimeColumn
            // 
            this.TheoryTimeColumn.HeaderText = "Время занятия";
            this.TheoryTimeColumn.Name = "TheoryTimeColumn";
            this.TheoryTimeColumn.ReadOnly = true;
            this.TheoryTimeColumn.Width = 129;
            // 
            // AuditoriumColumn
            // 
            this.AuditoriumColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.AuditoriumColumn.HeaderText = "Аудитория";
            this.AuditoriumColumn.Name = "AuditoriumColumn";
            this.AuditoriumColumn.ReadOnly = true;
            this.AuditoriumColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AuditoriumColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AuditoriumColumn.Width = 110;
            // 
            // GroupColumn
            // 
            this.GroupColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.GroupColumn.HeaderText = "Группа";
            this.GroupColumn.Name = "GroupColumn";
            this.GroupColumn.ReadOnly = true;
            this.GroupColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GroupColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.GroupColumn.Width = 85;
            // 
            // TheoryTeachersScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1067, 638);
            this.Controls.Add(this.TheoryTeachersSchedule_dGV);
            this.Controls.Add(this.SelectedTheoryTeacher_comboBox);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1024, 685);
            this.Name = "TheoryTeachersScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расписание преподавателя теории";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TheoryTeachersScheduleForm_FormClosing);
            this.Load += new System.EventHandler(this.TheoryTeachersScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TheoryTeachersSchedule_dGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectedTheoryTeacher_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TheoryTeachersSchedule_dGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheoryDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheoryTimeColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn AuditoriumColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn GroupColumn;
    }
}