namespace Автошкола
{
    partial class GroupsScheduleForm
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
            this.SelectedGroup_comboBox = new System.Windows.Forms.ComboBox();
            this.TheoryLessonsOfGroup_dGV = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheoryDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheoryTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuditoriumColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TeacherColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Close_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TheoryLessonsOfGroup_dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectedGroup_comboBox
            // 
            this.SelectedGroup_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedGroup_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedGroup_comboBox.FormattingEnabled = true;
            this.SelectedGroup_comboBox.Location = new System.Drawing.Point(127, 11);
            this.SelectedGroup_comboBox.Name = "SelectedGroup_comboBox";
            this.SelectedGroup_comboBox.Size = new System.Drawing.Size(928, 26);
            this.SelectedGroup_comboBox.TabIndex = 65;
            this.SelectedGroup_comboBox.SelectedIndexChanged += new System.EventHandler(this.SelectedGroup_comboBox_SelectedIndexChanged);
            this.SelectedGroup_comboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SelectedGroup_comboBox_KeyDown);
            this.SelectedGroup_comboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SelectedGroup_comboBox_KeyPress);
            // 
            // TheoryLessonsOfGroup_dGV
            // 
            this.TheoryLessonsOfGroup_dGV.AllowUserToAddRows = false;
            this.TheoryLessonsOfGroup_dGV.AllowUserToDeleteRows = false;
            this.TheoryLessonsOfGroup_dGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TheoryLessonsOfGroup_dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TheoryLessonsOfGroup_dGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TheoryLessonsOfGroup_dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TheoryLessonsOfGroup_dGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.TheoryDateColumn,
            this.TheoryTimeColumn,
            this.AuditoriumColumn,
            this.TeacherColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TheoryLessonsOfGroup_dGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.TheoryLessonsOfGroup_dGV.Location = new System.Drawing.Point(12, 42);
            this.TheoryLessonsOfGroup_dGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TheoryLessonsOfGroup_dGV.MultiSelect = false;
            this.TheoryLessonsOfGroup_dGV.Name = "TheoryLessonsOfGroup_dGV";
            this.TheoryLessonsOfGroup_dGV.ReadOnly = true;
            this.TheoryLessonsOfGroup_dGV.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TheoryLessonsOfGroup_dGV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.TheoryLessonsOfGroup_dGV.RowTemplate.Height = 24;
            this.TheoryLessonsOfGroup_dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TheoryLessonsOfGroup_dGV.Size = new System.Drawing.Size(893, 585);
            this.TheoryLessonsOfGroup_dGV.TabIndex = 61;
            this.TheoryLessonsOfGroup_dGV.SelectionChanged += new System.EventHandler(this.TheoryLessonsOfGroup_dGV_SelectionChanged);
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
            // TeacherColumn
            // 
            this.TeacherColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.TeacherColumn.HeaderText = "Преподаватель теории";
            this.TeacherColumn.Name = "TeacherColumn";
            this.TeacherColumn.ReadOnly = true;
            this.TeacherColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TeacherColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TeacherColumn.Width = 181;
            // 
            // Edit_button
            // 
            this.Edit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_button.Location = new System.Drawing.Point(911, 122);
            this.Edit_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(144, 47);
            this.Edit_button.TabIndex = 60;
            this.Edit_button.Text = "Редактировать выбранное";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_button.Location = new System.Drawing.Point(911, 184);
            this.Delete_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(144, 47);
            this.Delete_button.TabIndex = 59;
            this.Delete_button.Text = "Удалить выбранное";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_button.Location = new System.Drawing.Point(911, 60);
            this.Add_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(144, 47);
            this.Add_button.TabIndex = 58;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 55;
            this.label1.Text = "Выбор группы";
            // 
            // Close_button
            // 
            this.Close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_button.Location = new System.Drawing.Point(911, 578);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(144, 48);
            this.Close_button.TabIndex = 66;
            this.Close_button.Text = "Закрыть";
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // GroupsScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1067, 638);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.SelectedGroup_comboBox);
            this.Controls.Add(this.TheoryLessonsOfGroup_dGV);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1024, 685);
            this.Name = "GroupsScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расписание группы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GroupsScheduleForm_FormClosing);
            this.Load += new System.EventHandler(this.GroupsScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TheoryLessonsOfGroup_dGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectedGroup_comboBox;
        private System.Windows.Forms.DataGridView TheoryLessonsOfGroup_dGV;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheoryDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheoryTimeColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn AuditoriumColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn TeacherColumn;
        private System.Windows.Forms.Button Close_button;
    }
}