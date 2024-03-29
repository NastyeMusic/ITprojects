﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Автошкола
{
    public partial class AddEditGroupForm : Form
    {
        public AddEditGroupForm(AutoschoolDataSet.GroupsDataTable groupsDataTable, AutoschoolDataSet.CategoriesDataTable categoriesDataTable, AutoschoolDataSet.TheoryTeachersDataTable theoryTeachersDataTable, DataRow row)
        {
            InitializeComponent();
            this.groupsDataTable = groupsDataTable;
            this.categoriesDataTable = categoriesDataTable;
            this.theoryTeachersDataTable = theoryTeachersDataTable;
            dataRow = row;
        }
        BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet.GroupsDataTable groupsDataTable;
        AutoschoolDataSet.CategoriesDataTable categoriesDataTable;
        AutoschoolDataSet.TheoryTeachersDataTable theoryTeachersDataTable;
        DataRow dataRow;

        private void AddEditGroup_Load(object sender, EventArgs e)
        {
            Category_comboBox.DataSource = categoriesDataTable;
            Category_comboBox.DisplayMember = "Name";
            Category_comboBox.ValueMember = "ID";
            //Category_comboBox.AutoCompleteMode = AutoCompleteMode.Append;
            //Category_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            TheoryTeacher_comboBox.DataSource = theoryTeachersDataTable;
            TheoryTeacher_comboBox.DisplayMember = "FIO";
            TheoryTeacher_comboBox.ValueMember = "ID";
            TheoryTeacher_comboBox.AutoCompleteMode = AutoCompleteMode.Append;
            TheoryTeacher_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            if (dataRow != null)
            {
                GroupName_textBox.Text = dataRow["Name"].ToString();
                Category_comboBox.SelectedValue = dataRow["Category"].ToString();
                BeginLearning_dateTimePicker.Text = dataRow["StartLearning"].ToString();
                EndLearning_dateTimePicker.Text = dataRow["EndLearning"].ToString();
                TheoryTeacher_comboBox.SelectedValue = dataRow["Teacher"].ToString();
            }
            else
            {
                GroupName_textBox.Text = "";
                Category_comboBox.SelectedIndex = -1;
                TheoryTeacher_comboBox.SelectedIndex = -1;
            }
            BeginLearning_dateTimePicker_ValueChanged(sender, e);
        }

        private void AddEditGroup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    if (GroupName_textBox.Text.Trim() == "")
                    {
                        GroupName_textBox.Focus();
                        throw new Exception("Не указано имя группы");
                    }
                    if (Category_comboBox.SelectedIndex == -1)
                    {
                        Category_comboBox.Focus();
                        throw new Exception("Не выбрана категория обучения");
                    }
                    if (Convert.ToDateTime(BeginLearning_dateTimePicker.Text) >= Convert.ToDateTime(EndLearning_dateTimePicker.Text))
                    {
                        throw new Exception("Дата окончания обучения должна быть больше даты начала обучения");
                    }
                    if (TheoryTeacher_comboBox.SelectedIndex == -1)
                    {
                        TheoryTeacher_comboBox.Focus();
                        throw new Exception("Не выбран преподаватель теории для этой группы");
                    }
                    if (dataRow != null)
                    {
                        for (int i = 0; i < groupsDataTable.Rows.Count; i++)
                        {
                            if ((groupsDataTable[i][0].ToString() != dataRow[0].ToString()) && (groupsDataTable[i][1].ToString().ToLower() == GroupName_textBox.Text.Trim().ToLower()))
                            {
                                throw new Exception("Группа с таким наименованием уже имеется в базе");
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < groupsDataTable.Rows.Count; i++)
                        {
                            if (groupsDataTable[i][1].ToString().ToLower() == GroupName_textBox.Text.Trim().ToLower())
                            {
                                throw new Exception("Группа с таким наименованием уже имеется в базе");
                            }
                        }
                    }
                    AutoschoolDataSet TempDS = new AutoschoolDataSet();
                    TempDS = BusinessLogic.ReadTheoryTeacherByID(Convert.ToInt32(TheoryTeacher_comboBox.SelectedValue.ToString()));
                    if (TempDS.TheoryTeachers[0]["WorkStatusName"].ToString() != "Работает")
                    {
                        DialogResult result = MessageBox.Show("Вы выбрали отсутствующего преподавателя теории. Вы уверены, что хотите продолжить?", "Выбор отсутствующего сотрудника", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                        {
                            e.Cancel = true;
                            return;
                        }
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Ошибка");
                    e.Cancel = true;
                    return;
                }
                if (dataRow != null)
                {
                    dataRow["Name"] = GroupName_textBox.Text;
                    dataRow["StartLearning"] = Convert.ToDateTime(BeginLearning_dateTimePicker.Text).Date;
                    dataRow["EndLearning"] = Convert.ToDateTime(EndLearning_dateTimePicker.Text).Date;
                    dataRow["Category"] = Category_comboBox.SelectedValue;
                    dataRow["Teacher"] = TheoryTeacher_comboBox.SelectedValue;
                }
                else
                {
                    groupsDataTable.AddGroupsRow(GroupName_textBox.Text, Convert.ToDateTime(BeginLearning_dateTimePicker.Text).Date, 
                        Convert.ToDateTime(EndLearning_dateTimePicker.Text).Date, categoriesDataTable[Category_comboBox.SelectedIndex], 
                        theoryTeachersDataTable[TheoryTeacher_comboBox.SelectedIndex]);
                }
            }
        }

        private void GroupName_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((GroupName_textBox.TextLength - GroupName_textBox.SelectionLength) >= 50 && (char)e.KeyChar != (Char)Keys.Back)
                e.Handled = true;
            else
            {
                if ((char)e.KeyChar == (Char)Keys.Back) return;
                if ((char)e.KeyChar == (Char)Keys.ControlKey) return;
                if (char.IsLetterOrDigit(e.KeyChar)) return;
                if ((char)e.KeyChar == '-') return;
                e.Handled = true;
            }
        }

        private void BeginLearning_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            EndLearning_dateTimePicker.MinDate = Convert.ToDateTime(BeginLearning_dateTimePicker.Text).AddDays(1);
        }
    }
}
