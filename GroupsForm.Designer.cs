namespace Автошкола
{
    partial class GroupsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SearchGroup_textBox = new System.Windows.Forms.TextBox();
            this.Groups_dataGridView = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartLearningColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndLearningColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            this.Direction_checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Groups_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск группы";
            // 
            // SearchGroup_textBox
            // 
            this.SearchGroup_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchGroup_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchGroup_textBox.Location = new System.Drawing.Point(122, 6);
            this.SearchGroup_textBox.Name = "SearchGroup_textBox";
            this.SearchGroup_textBox.Size = new System.Drawing.Size(808, 24);
            this.SearchGroup_textBox.TabIndex = 1;
            this.SearchGroup_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchGroup_textBox_KeyPress);
            // 
            // Groups_dataGridView
            // 
            this.Groups_dataGridView.AllowUserToAddRows = false;
            this.Groups_dataGridView.AllowUserToDeleteRows = false;
            this.Groups_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Groups_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Groups_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Groups_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Groups_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.NameColumn,
            this.StartLearningColumn,
            this.EndLearningColumn,
            this.CategoryColumn,
            this.TeacherColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Groups_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.Groups_dataGridView.Location = new System.Drawing.Point(12, 36);
            this.Groups_dataGridView.MultiSelect = false;
            this.Groups_dataGridView.Name = "Groups_dataGridView";
            this.Groups_dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Groups_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Groups_dataGridView.RowHeadersVisible = false;
            this.Groups_dataGridView.RowTemplate.Height = 24;
            this.Groups_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Groups_dataGridView.Size = new System.Drawing.Size(1022, 584);
            this.Groups_dataGridView.TabIndex = 2;
            this.Groups_dataGridView.SelectionChanged += new System.EventHandler(this.Groups_dataGridView_SelectionChanged);
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "Код";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Visible = false;
            this.IDColumn.Width = 42;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Наименование группы";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 175;
            // 
            // StartLearningColumn
            // 
            this.StartLearningColumn.HeaderText = "Дата начала обучения";
            this.StartLearningColumn.Name = "StartLearningColumn";
            this.StartLearningColumn.ReadOnly = true;
            this.StartLearningColumn.Width = 177;
            // 
            // EndLearningColumn
            // 
            this.EndLearningColumn.HeaderText = "Дата окончания обучения";
            this.EndLearningColumn.Name = "EndLearningColumn";
            this.EndLearningColumn.ReadOnly = true;
            this.EndLearningColumn.Width = 199;
            // 
            // CategoryColumn
            // 
            this.CategoryColumn.HeaderText = "Категория обучения";
            this.CategoryColumn.Name = "CategoryColumn";
            this.CategoryColumn.ReadOnly = true;
            this.CategoryColumn.Width = 163;
            // 
            // TeacherColumn
            // 
            this.TeacherColumn.HeaderText = "Преподаватель теории";
            this.TeacherColumn.Name = "TeacherColumn";
            this.TeacherColumn.ReadOnly = true;
            this.TeacherColumn.Width = 181;
            // 
            // Add_button
            // 
            this.Add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_button.Location = new System.Drawing.Point(1040, 36);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(135, 48);
            this.Add_button.TabIndex = 3;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_button.Location = new System.Drawing.Point(1040, 162);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(135, 48);
            this.Delete_button.TabIndex = 4;
            this.Delete_button.Text = "Удалить выбранное";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_button.Location = new System.Drawing.Point(1040, 99);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(135, 48);
            this.Edit_button.TabIndex = 5;
            this.Edit_button.Text = "Редактировать выбранное";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Search_button
            // 
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_button.Location = new System.Drawing.Point(936, 6);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(98, 25);
            this.Search_button.TabIndex = 6;
            this.Search_button.Text = "Найти";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Direction_checkBox
            // 
            this.Direction_checkBox.AutoSize = true;
            this.Direction_checkBox.Checked = true;
            this.Direction_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Direction_checkBox.Location = new System.Drawing.Point(1040, 10);
            this.Direction_checkBox.Name = "Direction_checkBox";
            this.Direction_checkBox.Size = new System.Drawing.Size(102, 21);
            this.Direction_checkBox.TabIndex = 7;
            this.Direction_checkBox.Text = "поиск вниз";
            this.Direction_checkBox.UseVisualStyleBackColor = true;
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1187, 632);
            this.Controls.Add(this.Direction_checkBox);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Groups_dataGridView);
            this.Controls.Add(this.SearchGroup_textBox);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1024, 679);
            this.Name = "GroupsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учебные группы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GroupsForm_FormClosing);
            this.Load += new System.EventHandler(this.GroupsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Groups_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchGroup_textBox;
        private System.Windows.Forms.DataGridView Groups_dataGridView;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartLearningColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndLearningColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherColumn;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.CheckBox Direction_checkBox;
    }
}