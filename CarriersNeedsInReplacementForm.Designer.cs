﻿namespace Автошкола
{
    partial class CarriersNeedsInReplacementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarriersNeedsInReplacementForm));
            this.CarriersToReplacement_dataGridView = new System.Windows.Forms.DataGridView();
            this.CarrierIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBeginRepair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEndRepair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstructorIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstructorNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarrierUseIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReasonColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReplacementIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.DateBegin_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateEnd_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Get_button = new System.Windows.Forms.Button();
            this.AddReplacement_button = new System.Windows.Forms.Button();
            this.ChangePractiseLessons_button = new System.Windows.Forms.Button();
            this.EditReplacement_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CarriersToReplacement_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CarriersToReplacement_dataGridView
            // 
            this.CarriersToReplacement_dataGridView.AllowUserToAddRows = false;
            this.CarriersToReplacement_dataGridView.AllowUserToDeleteRows = false;
            this.CarriersToReplacement_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CarriersToReplacement_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.CarriersToReplacement_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarriersToReplacement_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarrierIDColumn,
            this.BrandColumn,
            this.ModelColumn,
            this.StateNumberColumn,
            this.DateBeginRepair,
            this.DateEndRepair,
            this.InstructorIDColumn,
            this.InstructorNameColumn,
            this.CarrierUseIDColumn,
            this.ReasonColumn,
            this.ReplacementIDColumn});
            this.CarriersToReplacement_dataGridView.Location = new System.Drawing.Point(12, 42);
            this.CarriersToReplacement_dataGridView.MultiSelect = false;
            this.CarriersToReplacement_dataGridView.Name = "CarriersToReplacement_dataGridView";
            this.CarriersToReplacement_dataGridView.ReadOnly = true;
            this.CarriersToReplacement_dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarriersToReplacement_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CarriersToReplacement_dataGridView.RowTemplate.Height = 24;
            this.CarriersToReplacement_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarriersToReplacement_dataGridView.Size = new System.Drawing.Size(1006, 551);
            this.CarriersToReplacement_dataGridView.TabIndex = 35;
            this.CarriersToReplacement_dataGridView.SelectionChanged += new System.EventHandler(this.CarriersToReplacement_dataGridView_SelectionChanged);
            // 
            // CarrierIDColumn
            // 
            this.CarrierIDColumn.HeaderText = "Код ТС";
            this.CarrierIDColumn.Name = "CarrierIDColumn";
            this.CarrierIDColumn.ReadOnly = true;
            this.CarrierIDColumn.Visible = false;
            this.CarrierIDColumn.Width = 61;
            // 
            // BrandColumn
            // 
            this.BrandColumn.HeaderText = "Марка";
            this.BrandColumn.Name = "BrandColumn";
            this.BrandColumn.ReadOnly = true;
            this.BrandColumn.Width = 79;
            // 
            // ModelColumn
            // 
            this.ModelColumn.HeaderText = "Модель";
            this.ModelColumn.Name = "ModelColumn";
            this.ModelColumn.ReadOnly = true;
            this.ModelColumn.Width = 87;
            // 
            // StateNumberColumn
            // 
            this.StateNumberColumn.HeaderText = "Гос.рег.№";
            this.StateNumberColumn.Name = "StateNumberColumn";
            this.StateNumberColumn.ReadOnly = true;
            this.StateNumberColumn.Width = 103;
            // 
            // DateBeginRepair
            // 
            this.DateBeginRepair.HeaderText = "Дата начала нужды в замене";
            this.DateBeginRepair.Name = "DateBeginRepair";
            this.DateBeginRepair.ReadOnly = true;
            this.DateBeginRepair.Width = 168;
            // 
            // DateEndRepair
            // 
            this.DateEndRepair.HeaderText = "Дата окончания нужды в замене";
            this.DateEndRepair.Name = "DateEndRepair";
            this.DateEndRepair.ReadOnly = true;
            this.DateEndRepair.Width = 189;
            // 
            // InstructorIDColumn
            // 
            this.InstructorIDColumn.HeaderText = "Код инструктора";
            this.InstructorIDColumn.Name = "InstructorIDColumn";
            this.InstructorIDColumn.ReadOnly = true;
            this.InstructorIDColumn.Visible = false;
            this.InstructorIDColumn.Width = 136;
            // 
            // InstructorNameColumn
            // 
            this.InstructorNameColumn.HeaderText = "Инструктор";
            this.InstructorNameColumn.Name = "InstructorNameColumn";
            this.InstructorNameColumn.ReadOnly = true;
            this.InstructorNameColumn.Width = 114;
            // 
            // CarrierUseIDColumn
            // 
            this.CarrierUseIDColumn.HeaderText = "CarrierUseID";
            this.CarrierUseIDColumn.Name = "CarrierUseIDColumn";
            this.CarrierUseIDColumn.ReadOnly = true;
            this.CarrierUseIDColumn.Visible = false;
            this.CarrierUseIDColumn.Width = 118;
            // 
            // ReasonColumn
            // 
            this.ReasonColumn.HeaderText = "Причина проблемы";
            this.ReasonColumn.Name = "ReasonColumn";
            this.ReasonColumn.ReadOnly = true;
            this.ReasonColumn.Width = 152;
            // 
            // ReplacementIDColumn
            // 
            this.ReplacementIDColumn.HeaderText = "ReplacementID";
            this.ReplacementIDColumn.Name = "ReplacementIDColumn";
            this.ReplacementIDColumn.ReadOnly = true;
            this.ReplacementIDColumn.Visible = false;
            this.ReplacementIDColumn.Width = 133;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Начальная дата";
            // 
            // DateBegin_dateTimePicker
            // 
            this.DateBegin_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateBegin_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateBegin_dateTimePicker.Location = new System.Drawing.Point(150, 12);
            this.DateBegin_dateTimePicker.Name = "DateBegin_dateTimePicker";
            this.DateBegin_dateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.DateBegin_dateTimePicker.TabIndex = 37;
            // 
            // DateEnd_dateTimePicker
            // 
            this.DateEnd_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateEnd_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateEnd_dateTimePicker.Location = new System.Drawing.Point(523, 12);
            this.DateEnd_dateTimePicker.Name = "DateEnd_dateTimePicker";
            this.DateEnd_dateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.DateEnd_dateTimePicker.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(401, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Конечная дата";
            // 
            // Get_button
            // 
            this.Get_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Get_button.Location = new System.Drawing.Point(788, 7);
            this.Get_button.Name = "Get_button";
            this.Get_button.Size = new System.Drawing.Size(107, 33);
            this.Get_button.TabIndex = 40;
            this.Get_button.Text = "Получить";
            this.Get_button.UseVisualStyleBackColor = true;
            this.Get_button.Click += new System.EventHandler(this.Get_button_Click);
            // 
            // AddReplacement_button
            // 
            this.AddReplacement_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddReplacement_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddReplacement_button.Location = new System.Drawing.Point(1024, 42);
            this.AddReplacement_button.Name = "AddReplacement_button";
            this.AddReplacement_button.Size = new System.Drawing.Size(151, 78);
            this.AddReplacement_button.TabIndex = 41;
            this.AddReplacement_button.Text = "Временно заменить выбранное ТС";
            this.AddReplacement_button.UseVisualStyleBackColor = true;
            this.AddReplacement_button.Click += new System.EventHandler(this.AddReplacement_button_Click);
            // 
            // ChangePractiseLessons_button
            // 
            this.ChangePractiseLessons_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangePractiseLessons_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePractiseLessons_button.Location = new System.Drawing.Point(1024, 210);
            this.ChangePractiseLessons_button.Name = "ChangePractiseLessons_button";
            this.ChangePractiseLessons_button.Size = new System.Drawing.Size(151, 78);
            this.ChangePractiseLessons_button.TabIndex = 42;
            this.ChangePractiseLessons_button.Text = "Перенести назначенные на эти дни занятия";
            this.ChangePractiseLessons_button.UseVisualStyleBackColor = true;
            this.ChangePractiseLessons_button.Click += new System.EventHandler(this.ChangePractiseLessons_button_Click);
            // 
            // EditReplacement_button
            // 
            this.EditReplacement_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditReplacement_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditReplacement_button.Location = new System.Drawing.Point(1024, 126);
            this.EditReplacement_button.Name = "EditReplacement_button";
            this.EditReplacement_button.Size = new System.Drawing.Size(151, 78);
            this.EditReplacement_button.TabIndex = 43;
            this.EditReplacement_button.Text = "Редактировать замену выбранного ТС";
            this.EditReplacement_button.UseVisualStyleBackColor = true;
            this.EditReplacement_button.Click += new System.EventHandler(this.EditReplacement_button_Click);
            // 
            // CarriersNeedsInReplacementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1187, 605);
            this.Controls.Add(this.EditReplacement_button);
            this.Controls.Add(this.ChangePractiseLessons_button);
            this.Controls.Add(this.AddReplacement_button);
            this.Controls.Add(this.Get_button);
            this.Controls.Add(this.DateEnd_dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateBegin_dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarriersToReplacement_dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 47);
            this.Name = "CarriersNeedsInReplacementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ТС, требующие замены из-за ремонта";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CarriersNeedsInRepairForm_FormClosing);
            this.Load += new System.EventHandler(this.CarriersNeedsInRepairForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarriersToReplacement_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CarriersToReplacement_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateBegin_dateTimePicker;
        private System.Windows.Forms.DateTimePicker DateEnd_dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Get_button;
        private System.Windows.Forms.Button AddReplacement_button;
        private System.Windows.Forms.Button ChangePractiseLessons_button;
        private System.Windows.Forms.Button EditReplacement_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarrierIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateBeginRepair;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEndRepair;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstructorIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstructorNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarrierUseIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReasonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReplacementIDColumn;
    }
}