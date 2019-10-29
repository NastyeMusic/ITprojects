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
    public partial class TheoryTeachersScheduleForm : Form
    {
        public TheoryTeachersScheduleForm()
        {
            InitializeComponent();
        }

        public BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet dataSet, dataSetForTheoryTeachers;

        bool FormLoad = false;

        void ReloadTheoryTeachersSchedule(int TeacherID)
        {
            dataSet = BusinessLogic.GetTheoryTeacherSchedule(TeacherID);
            TheoryTeachersSchedule_dGV.DataSource = dataSet;
            TheoryTeachersSchedule_dGV.DataMember = "TheoryLessons";

            TheoryTeachersSchedule_dGV.Columns["ID"].Visible = false;
            TheoryTeachersSchedule_dGV.Columns["Date"].Visible = false;
            TheoryTeachersSchedule_dGV.Columns["Time"].Visible = false;
            TheoryTeachersSchedule_dGV.Columns["Auditorium"].Visible = false;
            TheoryTeachersSchedule_dGV.Columns["Group"].Visible = false;

            IDColumn.DataPropertyName = "ID";
            TheoryDateColumn.DataPropertyName = "Date";
            TheoryTimeColumn.DataPropertyName = "Time";

            AuditoriumColumn.DataSource = dataSet.Auditoriums;
            AuditoriumColumn.DisplayMember = "Name";
            AuditoriumColumn.ValueMember = "ID";
            AuditoriumColumn.DataPropertyName = "Auditorium";

            GroupColumn.DataSource = dataSet.Groups;
            GroupColumn.DisplayMember = "Name";
            GroupColumn.ValueMember = "ID";
            GroupColumn.DataPropertyName = "Group";
        }

        private void TheoryTeachersScheduleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            MainForm.Perem(MainForm.FormsNames[16], false);
        }

        private void SelectedTheoryTeacher_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedTheoryTeacher_comboBox.SelectedIndex != -1 && FormLoad)
            {
                int TeacherID = Convert.ToInt32(SelectedTheoryTeacher_comboBox.SelectedValue);
                ReloadTheoryTeachersSchedule(TeacherID);
            }
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReloadTeachers_button_Click(object sender, EventArgs e)
        {
            FormLoad = false;
            string temp = "";
            if (SelectedTheoryTeacher_comboBox.SelectedValue != null)
                temp = SelectedTheoryTeacher_comboBox.SelectedValue.ToString();

            dataSetForTheoryTeachers = BusinessLogic.ReadTheoryTeachers();
            SelectedTheoryTeacher_comboBox.DataSource = dataSetForTheoryTeachers.TheoryTeachers;
            SelectedTheoryTeacher_comboBox.DisplayMember = "FIO";
            SelectedTheoryTeacher_comboBox.ValueMember = "ID";
            SelectedTheoryTeacher_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            SelectedTheoryTeacher_comboBox.AutoCompleteMode = AutoCompleteMode.Append;

            FormLoad = true;
            if (temp != "")
            {
                try
                {
                    SelectedTheoryTeacher_comboBox.SelectedValue = temp;
                }
                catch
                {
                    SelectedTheoryTeacher_comboBox.SelectedIndex = -1;
                }
            }
            else
            {
                SelectedTheoryTeacher_comboBox.SelectedIndex = -1;
            }
        }

        private void TheoryTeachersScheduleForm_Load(object sender, EventArgs e)
        {
            dataSetForTheoryTeachers = BusinessLogic.ReadTheoryTeachers();
            SelectedTheoryTeacher_comboBox.DataSource = dataSetForTheoryTeachers.TheoryTeachers;
            SelectedTheoryTeacher_comboBox.DisplayMember = "FIO";
            SelectedTheoryTeacher_comboBox.ValueMember = "ID";
            SelectedTheoryTeacher_comboBox.SelectedIndex = -1;
            SelectedTheoryTeacher_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            SelectedTheoryTeacher_comboBox.AutoCompleteMode = AutoCompleteMode.Append;

            FormLoad = true;
        }
    }
}
