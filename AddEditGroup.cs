using System;
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
    public partial class AddEditGroup : Form
    {
        public AddEditGroup(AutoschoolDataSet.GroupsDataTable groupsDataTable, AutoschoolDataSet.CategoriesDataTable categoriesDataTable, AutoschoolDataSet.TheoryTeachersDataTable theoryTeachersDataTable, DataRow row)
        {
            InitializeComponent();
            this.groupsDataTable = groupsDataTable;
            this.categoriesDataTable = categoriesDataTable;
            this.theoryTeachersDataTable = theoryTeachersDataTable;
            dataRow = row;
        }
        public BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet.GroupsDataTable groupsDataTable;
        AutoschoolDataSet.CategoriesDataTable categoriesDataTable;
        AutoschoolDataSet.TheoryTeachersDataTable theoryTeachersDataTable;
        DataRow dataRow;

        private void AddEditGroup_Load(object sender, EventArgs e)
        {
            Category_comboBox.DataSource = groupsDataTable;
            Category_comboBox.DisplayMember = "Name";
            Category_comboBox.ValueMember = "ID";
            Category_comboBox.AutoCompleteMode = AutoCompleteMode.Append;

            TheoryTeacher_comboBox.DataSource = theoryTeachersDataTable;
            TheoryTeacher_comboBox.DisplayMember = "FIO";
            TheoryTeacher_comboBox.ValueMember = "ID";
            TheoryTeacher_comboBox.AutoCompleteMode = AutoCompleteMode.Append;

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
        }

        private void AddEditGroup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    if (GroupName_textBox.Text == "")
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
                    groupsDataTable.AddGroupsRow(GroupName_textBox.Text, Convert.ToDateTime(BeginLearning_dateTimePicker.Text).Date, Convert.ToDateTime(EndLearning_dateTimePicker.Text).Date, categoriesDataTable[Category_comboBox.SelectedIndex], theoryTeachersDataTable[TheoryTeacher_comboBox.SelectedIndex]);
                }
            }
        }
    }
}
