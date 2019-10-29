namespace Автошкола
{
    partial class StudentsScheduleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.TheoryLessonsOfStudent_dGV = new System.Windows.Forms.DataGridView();
            this.IDTLColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheoryDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheoryTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuditoriumColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GroupColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TeacherColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PracticeLessonsOfStudent_dGV = new System.Windows.Forms.DataGridView();
            this.IDPLColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointedTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstructorColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CarrierColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FactDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SelectedStudent_comboBox = new System.Windows.Forms.ComboBox();
            this.Close_button = new System.Windows.Forms.Button();
            this.ReloadStudents_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TheoryLessonsOfStudent_dGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeLessonsOfStudent_dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбор курсанта";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1043, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Теоретические занятия";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 324);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1043, 18);
            this.label4.TabIndex = 43;
            this.label4.Text = "Практические  занятия";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Edit_button
            // 
            this.Edit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_button.Location = new System.Drawing.Point(911, 430);
            this.Edit_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(144, 47);
            this.Edit_button.TabIndex = 46;
            this.Edit_button.Text = "Редактировать выбранное";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_button.Location = new System.Drawing.Point(911, 492);
            this.Delete_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(144, 47);
            this.Delete_button.TabIndex = 45;
            this.Delete_button.Text = "Удалить выбранное";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_button.Location = new System.Drawing.Point(911, 368);
            this.Add_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(144, 47);
            this.Add_button.TabIndex = 44;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // TheoryLessonsOfStudent_dGV
            // 
            this.TheoryLessonsOfStudent_dGV.AllowUserToAddRows = false;
            this.TheoryLessonsOfStudent_dGV.AllowUserToDeleteRows = false;
            this.TheoryLessonsOfStudent_dGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TheoryLessonsOfStudent_dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TheoryLessonsOfStudent_dGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TheoryLessonsOfStudent_dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TheoryLessonsOfStudent_dGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDTLColumn,
            this.TheoryDateColumn,
            this.TheoryTimeColumn,
            this.AuditoriumColumn,
            this.GroupColumn,
            this.TeacherColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TheoryLessonsOfStudent_dGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.TheoryLessonsOfStudent_dGV.Location = new System.Drawing.Point(12, 74);
            this.TheoryLessonsOfStudent_dGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TheoryLessonsOfStudent_dGV.MultiSelect = false;
            this.TheoryLessonsOfStudent_dGV.Name = "TheoryLessonsOfStudent_dGV";
            this.TheoryLessonsOfStudent_dGV.ReadOnly = true;
            this.TheoryLessonsOfStudent_dGV.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TheoryLessonsOfStudent_dGV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.TheoryLessonsOfStudent_dGV.RowTemplate.Height = 24;
            this.TheoryLessonsOfStudent_dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TheoryLessonsOfStudent_dGV.Size = new System.Drawing.Size(893, 231);
            this.TheoryLessonsOfStudent_dGV.TabIndex = 50;
            // 
            // IDTLColumn
            // 
            this.IDTLColumn.HeaderText = "Код";
            this.IDTLColumn.Name = "IDTLColumn";
            this.IDTLColumn.ReadOnly = true;
            this.IDTLColumn.Visible = false;
            this.IDTLColumn.Width = 42;
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
            // PracticeLessonsOfStudent_dGV
            // 
            this.PracticeLessonsOfStudent_dGV.AllowUserToAddRows = false;
            this.PracticeLessonsOfStudent_dGV.AllowUserToDeleteRows = false;
            this.PracticeLessonsOfStudent_dGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PracticeLessonsOfStudent_dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PracticeLessonsOfStudent_dGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.PracticeLessonsOfStudent_dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PracticeLessonsOfStudent_dGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPLColumn,
            this.AppointedDateColumn,
            this.AppointedTimeColumn,
            this.InstructorColumn,
            this.CarrierColumn,
            this.FactDateColumn,
            this.FactTimeColumn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PracticeLessonsOfStudent_dGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.PracticeLessonsOfStudent_dGV.Location = new System.Drawing.Point(12, 347);
            this.PracticeLessonsOfStudent_dGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PracticeLessonsOfStudent_dGV.MultiSelect = false;
            this.PracticeLessonsOfStudent_dGV.Name = "PracticeLessonsOfStudent_dGV";
            this.PracticeLessonsOfStudent_dGV.ReadOnly = true;
            this.PracticeLessonsOfStudent_dGV.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PracticeLessonsOfStudent_dGV.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.PracticeLessonsOfStudent_dGV.RowTemplate.Height = 24;
            this.PracticeLessonsOfStudent_dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PracticeLessonsOfStudent_dGV.Size = new System.Drawing.Size(893, 327);
            this.PracticeLessonsOfStudent_dGV.TabIndex = 51;
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
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1043, 2);
            this.label2.TabIndex = 52;
            this.label2.Text = "label2";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(12, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1043, 2);
            this.label5.TabIndex = 53;
            this.label5.Text = "label5";
            // 
            // SelectedStudent_comboBox
            // 
            this.SelectedStudent_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedStudent_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedStudent_comboBox.FormattingEnabled = true;
            this.SelectedStudent_comboBox.Location = new System.Drawing.Point(141, 11);
            this.SelectedStudent_comboBox.Name = "SelectedStudent_comboBox";
            this.SelectedStudent_comboBox.Size = new System.Drawing.Size(764, 26);
            this.SelectedStudent_comboBox.TabIndex = 54;
            this.SelectedStudent_comboBox.SelectedIndexChanged += new System.EventHandler(this.SelectedStudent_comboBox_SelectedIndexChanged);
            this.SelectedStudent_comboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SelectedStudent_comboBox_KeyDown);
            this.SelectedStudent_comboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SelectedStudent_comboBox_KeyPress);
            // 
            // Close_button
            // 
            this.Close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_button.Location = new System.Drawing.Point(911, 626);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(144, 48);
            this.Close_button.TabIndex = 55;
            this.Close_button.Text = "Закрыть";
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // ReloadStudents_button
            // 
            this.ReloadStudents_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReloadStudents_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadStudents_button.Image = global::Автошкола.Properties.Resources._288px_Crystal_128_reload_Little2;
            this.ReloadStudents_button.Location = new System.Drawing.Point(911, 6);
            this.ReloadStudents_button.Name = "ReloadStudents_button";
            this.ReloadStudents_button.Size = new System.Drawing.Size(45, 35);
            this.ReloadStudents_button.TabIndex = 68;
            this.ReloadStudents_button.UseVisualStyleBackColor = true;
            this.ReloadStudents_button.Click += new System.EventHandler(this.ReloadStudents_button_Click);
            // 
            // StudentsScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1067, 685);
            this.Controls.Add(this.ReloadStudents_button);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.SelectedStudent_comboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PracticeLessonsOfStudent_dGV);
            this.Controls.Add(this.TheoryLessonsOfStudent_dGV);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1024, 685);
            this.Name = "StudentsScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расписание курсанта";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentsScheduleForm_FormClosing);
            this.Load += new System.EventHandler(this.StudentsScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TheoryLessonsOfStudent_dGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeLessonsOfStudent_dGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.DataGridView TheoryLessonsOfStudent_dGV;
        private System.Windows.Forms.DataGridView PracticeLessonsOfStudent_dGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SelectedStudent_comboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTLColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheoryDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheoryTimeColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn AuditoriumColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn GroupColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn TeacherColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPLColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointedDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointedTimeColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn InstructorColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn CarrierColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactTimeColumn;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button ReloadStudents_button;
    }
}