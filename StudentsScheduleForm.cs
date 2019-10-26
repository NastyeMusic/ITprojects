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
    public partial class StudentsScheduleForm : Form
    {
        public StudentsScheduleForm()
        {
            InitializeComponent();
        }

        public BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet dataSet, dataSetForStudents;

        int LastSelectionIndexInPracticeLessons;

        bool FormLoad = false;

        void ReloadTheoryLessons(int StudentID)
        {
            AutoschoolDataSet TempDS = BusinessLogic.GetGroupOfStudent(StudentID);
            int GroupID = Convert.ToInt32(TempDS.Students[0][0].ToString());
            dataSet = BusinessLogic.ReadTheoryLessonsByGroupID(GroupID);
            TheoryLessonsOfStudent_dGV.DataSource = dataSet;
            TheoryLessonsOfStudent_dGV.DataMember = "TheoryLessons";

            TheoryLessonsOfStudent_dGV.Columns["ID"].Visible = false;
            TheoryLessonsOfStudent_dGV.Columns["Date"].Visible = false;
            TheoryLessonsOfStudent_dGV.Columns["Time"].Visible = false;
            TheoryLessonsOfStudent_dGV.Columns["Auditorium"].Visible = false;
            TheoryLessonsOfStudent_dGV.Columns["Group"].Visible = false;

            IDTLColumn.DataPropertyName = "ID";
            TheoryDateColumn.DataPropertyName = "Date";
            TheoryDateColumn.DataPropertyName = "Time";

            AuditoriumColumn.DataSource = dataSet.Auditoriums;
            AuditoriumColumn.DisplayMember = "Name";
            AuditoriumColumn.ValueMember = "ID";
            AuditoriumColumn.DataPropertyName = "Auditorium";

            GroupColumn.DataSource = dataSet.Groups;
            GroupColumn.DisplayMember = "Name";
            GroupColumn.ValueMember = "ID";
            GroupColumn.DataPropertyName = "Group";

            TeacherColumn.DataSource = dataSet.Groups;
            TeacherColumn.DisplayMember = "TeacherFIO";
            TeacherColumn.ValueMember = "ID";
            TeacherColumn.DataPropertyName = "Group";
        }

        void ReloadPracticeLessons(int StudentID)
        {
            dataSet = BusinessLogic.ReadPracticeLessonsByStudentID(StudentID);
            PracticeLessonsOfStudent_dGV.DataSource = dataSet;
            PracticeLessonsOfStudent_dGV.DataMember = "PracticeLessons";

            PracticeLessonsOfStudent_dGV.Columns["ID"].Visible = false;
            PracticeLessonsOfStudent_dGV.Columns["Student"].Visible = false;
            PracticeLessonsOfStudent_dGV.Columns["AppointedDate"].Visible = false;
            PracticeLessonsOfStudent_dGV.Columns["AppointedTime"].Visible = false;
            PracticeLessonsOfStudent_dGV.Columns["FactDate"].Visible = false;
            PracticeLessonsOfStudent_dGV.Columns["FactTime"].Visible = false;

            IDPLColumn.DataPropertyName = "ID";
            AppointedDateColumn.DataPropertyName = "AppointedDate";
            AppointedTimeColumn.DataPropertyName = "AppointedTime";
            FactDateColumn.DataPropertyName = "FactDate";
            FactTimeColumn.DataPropertyName = "FactTime";

            InstructorColumn.DataSource = dataSet.Students;
            InstructorColumn.DisplayMember = "InstructorName";
            InstructorColumn.ValueMember = "ID";
            InstructorColumn.DataPropertyName = "Student";

            CarrierColumn.DataSource = dataSet.Students;
            CarrierColumn.DisplayMember = "CarrierName";
            CarrierColumn.ValueMember = "ID";
            CarrierColumn.DataPropertyName = "Student";

            if (LastSelectionIndexInPracticeLessons != -1)
                PracticeLessonsOfStudent_dGV.CurrentCell = PracticeLessonsOfStudent_dGV[1, LastSelectionIndexInPracticeLessons];
        }

        private void StudentsScheduleForm_Load(object sender, EventArgs e)
        {
            LastSelectionIndexInPracticeLessons = -1;

            dataSetForStudents = BusinessLogic.ReadStudents();
            SelectedStudent_comboBox.DataSource = dataSetForStudents.Students;
            SelectedStudent_comboBox.DisplayMember = "FIO";
            SelectedStudent_comboBox.ValueMember = "ID";           
            
            Edit_button.Enabled = false;
            Delete_button.Enabled = false;
            PracticeLessonsOfStudent_dGV_SelectionChanged(sender, e);

            FormLoad = true;
            SelectedStudent_comboBox.SelectedIndex = -1;
        }

        private void StudentsScheduleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            MainForm.Perem(MainForm.FormsNames[6], false);
        }

        private void PracticeLessonsOfStudent_dGV_SelectionChanged(object sender, EventArgs e)
        {
            if (PracticeLessonsOfStudent_dGV.SelectedRows.Count == 1)
            {
                Edit_button.Enabled = true;
                Delete_button.Enabled = true;
            }
            else
            {
                Edit_button.Enabled = false;
                Delete_button.Enabled = false;
            }
        }

        private void SelectedStudent_comboBox_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void SelectedStudent_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedStudent_comboBox.SelectedIndex != -1 && FormLoad)
            {
                int StudentID = Convert.ToInt32(SelectedStudent_comboBox.SelectedValue);
                ReloadTheoryLessons(StudentID);
                ReloadPracticeLessons(StudentID);
            }
        }

        private void SelectedStudent_comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < SelectedStudent_comboBox.Items.Count; i++)
            {
                if (((AutoschoolDataSet.StudentsRow)((DataRowView)(SelectedStudent_comboBox.Items[i])).Row).FIO.ToLower().Contains(SelectedStudent_comboBox.Text.ToLower()))
                {
                    SelectedStudent_comboBox.SelectedIndex = i;
                    break;
                }
            }
        }
    }
}
