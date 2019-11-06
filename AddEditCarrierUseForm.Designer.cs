namespace Автошкола
{
    partial class AddEditCarrierUseForm
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
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Instructor_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectedCarrier_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ReloadCarriers_button = new System.Windows.Forms.Button();
            this.Carriers_dataGridView = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransmissionColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CategoryColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FinalNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Carriers_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel_button
            // 
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(852, 320);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(142, 35);
            this.Cancel_button.TabIndex = 39;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = true;
            // 
            // Save_button
            // 
            this.Save_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_button.Location = new System.Drawing.Point(685, 320);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(142, 35);
            this.Save_button.TabIndex = 38;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(12, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(982, 2);
            this.label6.TabIndex = 37;
            this.label6.Text = "label6";
            // 
            // Instructor_comboBox
            // 
            this.Instructor_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Instructor_comboBox.FormattingEnabled = true;
            this.Instructor_comboBox.Location = new System.Drawing.Point(107, 12);
            this.Instructor_comboBox.Name = "Instructor_comboBox";
            this.Instructor_comboBox.Size = new System.Drawing.Size(887, 26);
            this.Instructor_comboBox.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Инструктор";
            // 
            // SelectedCarrier_label
            // 
            this.SelectedCarrier_label.AutoSize = true;
            this.SelectedCarrier_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedCarrier_label.Location = new System.Drawing.Point(130, 284);
            this.SelectedCarrier_label.Name = "SelectedCarrier_label";
            this.SelectedCarrier_label.Size = new System.Drawing.Size(46, 18);
            this.SelectedCarrier_label.TabIndex = 66;
            this.SelectedCarrier_label.Text = "<ТС>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "Выбранное ТС:";
            // 
            // ReloadCarriers_button
            // 
            this.ReloadCarriers_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadCarriers_button.Image = global::Автошкола.Properties.Resources._288px_Crystal_128_reload_Little2;
            this.ReloadCarriers_button.Location = new System.Drawing.Point(949, 77);
            this.ReloadCarriers_button.Name = "ReloadCarriers_button";
            this.ReloadCarriers_button.Size = new System.Drawing.Size(45, 35);
            this.ReloadCarriers_button.TabIndex = 64;
            this.ReloadCarriers_button.UseVisualStyleBackColor = true;
            this.ReloadCarriers_button.Click += new System.EventHandler(this.ReloadCarriers_button_Click);
            // 
            // Carriers_dataGridView
            // 
            this.Carriers_dataGridView.AllowUserToAddRows = false;
            this.Carriers_dataGridView.AllowUserToDeleteRows = false;
            this.Carriers_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Carriers_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Carriers_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Carriers_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.BrandColumn,
            this.ModelColumn,
            this.StateNumberColumn,
            this.ColorColumn,
            this.TransmissionColumn,
            this.CategoryColumn,
            this.StatusColumn,
            this.FinalNameColumn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Carriers_dataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.Carriers_dataGridView.Location = new System.Drawing.Point(12, 77);
            this.Carriers_dataGridView.MultiSelect = false;
            this.Carriers_dataGridView.Name = "Carriers_dataGridView";
            this.Carriers_dataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Carriers_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Carriers_dataGridView.RowHeadersVisible = false;
            this.Carriers_dataGridView.RowTemplate.Height = 24;
            this.Carriers_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Carriers_dataGridView.Size = new System.Drawing.Size(931, 204);
            this.Carriers_dataGridView.TabIndex = 63;
            this.Carriers_dataGridView.SelectionChanged += new System.EventHandler(this.Carriers_dataGridView_SelectionChanged);
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "Код";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Visible = false;
            this.IDColumn.Width = 42;
            // 
            // BrandColumn
            // 
            this.BrandColumn.HeaderText = "Марка";
            this.BrandColumn.Name = "BrandColumn";
            this.BrandColumn.ReadOnly = true;
            this.BrandColumn.Width = 82;
            // 
            // ModelColumn
            // 
            this.ModelColumn.HeaderText = "Модель";
            this.ModelColumn.Name = "ModelColumn";
            this.ModelColumn.ReadOnly = true;
            this.ModelColumn.Width = 93;
            // 
            // StateNumberColumn
            // 
            this.StateNumberColumn.HeaderText = "Гос.рег.№";
            this.StateNumberColumn.Name = "StateNumberColumn";
            this.StateNumberColumn.ReadOnly = true;
            this.StateNumberColumn.Width = 108;
            // 
            // ColorColumn
            // 
            this.ColorColumn.HeaderText = "Цвет";
            this.ColorColumn.Name = "ColorColumn";
            this.ColorColumn.ReadOnly = true;
            this.ColorColumn.Width = 71;
            // 
            // TransmissionColumn
            // 
            this.TransmissionColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.TransmissionColumn.HeaderText = "Трансмиссия";
            this.TransmissionColumn.Name = "TransmissionColumn";
            this.TransmissionColumn.ReadOnly = true;
            this.TransmissionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TransmissionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TransmissionColumn.Width = 129;
            // 
            // CategoryColumn
            // 
            this.CategoryColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.CategoryColumn.HeaderText = "Категория";
            this.CategoryColumn.Name = "CategoryColumn";
            this.CategoryColumn.ReadOnly = true;
            this.CategoryColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CategoryColumn.Width = 109;
            // 
            // StatusColumn
            // 
            this.StatusColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.StatusColumn.HeaderText = "Статус";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            this.StatusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.StatusColumn.Width = 85;
            // 
            // FinalNameColumn
            // 
            this.FinalNameColumn.HeaderText = "FinalName";
            this.FinalNameColumn.Name = "FinalNameColumn";
            this.FinalNameColumn.ReadOnly = true;
            this.FinalNameColumn.Visible = false;
            this.FinalNameColumn.Width = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 62;
            this.label1.Text = "Список ТС";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(982, 2);
            this.label4.TabIndex = 67;
            this.label4.Text = "label4";
            // 
            // AddEditCarrierUseForm
            // 
            this.AcceptButton = this.Save_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.Cancel_button;
            this.ClientSize = new System.Drawing.Size(1006, 362);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SelectedCarrier_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReloadCarriers_button);
            this.Controls.Add(this.Carriers_dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Instructor_comboBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 409);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 409);
            this.Name = "AddEditCarrierUseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditCarrierUse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditCarrierUse_FormClosing);
            this.Load += new System.EventHandler(this.AddEditCarrierUse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Carriers_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Instructor_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SelectedCarrier_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ReloadCarriers_button;
        private System.Windows.Forms.DataGridView Carriers_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn TransmissionColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn CategoryColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn StatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalNameColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}