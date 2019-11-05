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
            AutoschoolDataSet TempDS = BusinessLogic.ReadStudentByID(StudentID);
            int GroupID = Convert.ToInt32(TempDS.Students[0][6].ToString());
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
            TheoryTimeColumn.DataPropertyName = "Time";

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
            PracticeLessonsOfStudent_dGV.Columns["StudentFIO"].Visible = false;
            PracticeLessonsOfStudent_dGV.Columns["CarrierName"].Visible = false;

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
            SelectedStudent_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            SelectedStudent_comboBox.AutoCompleteMode = AutoCompleteMode.Append;

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
            MainForm.Perem(MainForm.FormsNames[13], false);
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
            LastSelectionIndexInPracticeLessons = -1;
            if (SelectedStudent_comboBox.SelectedIndex != -1 && FormLoad)
            {
                int StudentID = Convert.ToInt32(SelectedStudent_comboBox.SelectedValue);
                ReloadTheoryLessons(StudentID);
                ReloadPracticeLessons(StudentID);
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            ReloadPracticeLessons(Convert.ToInt32(SelectedStudent_comboBox.SelectedValue));
            AddEditPracticeLessonForm AddPracticeLesson;
            if (SelectedStudent_comboBox.SelectedIndex != -1)
                AddPracticeLesson = new AddEditPracticeLessonForm(dataSet.PracticeLessons, dataSet.Students, 
                    dataSet.Students.Rows.Find(SelectedStudent_comboBox.SelectedValue),
                    null);
            else
                AddPracticeLesson = new AddEditPracticeLessonForm(dataSet.PracticeLessons, dataSet.Students, null, null);
            AddPracticeLesson.Text = "Добавление практического занятия";
            this.Enabled = false;
            AddPracticeLesson.ShowDialog();
            if (AddPracticeLesson.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WritePracticeLessons(dataSet);
                if (SelectedStudent_comboBox.SelectedIndex != -1)
                    ReloadPracticeLessons(Convert.ToInt32(SelectedStudent_comboBox.SelectedValue));
            }
            this.Enabled = true;
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndexInPracticeLessons = PracticeLessonsOfStudent_dGV.SelectedRows[0].Index;
            ReloadPracticeLessons(Convert.ToInt32(SelectedStudent_comboBox.SelectedValue));
            AddEditPracticeLessonForm EditPracticeLesson;
            if (SelectedStudent_comboBox.SelectedIndex != -1)
                EditPracticeLesson = new AddEditPracticeLessonForm(dataSet.PracticeLessons, dataSet.Students,
                    dataSet.Students.Rows.Find(SelectedStudent_comboBox.SelectedValue),
                    dataSet.PracticeLessons.Rows.Find(PracticeLessonsOfStudent_dGV.SelectedRows[0].Cells["ID"].Value));
            else
                EditPracticeLesson = new AddEditPracticeLessonForm(dataSet.PracticeLessons, dataSet.Students, null,
                    dataSet.PracticeLessons.Rows.Find(PracticeLessonsOfStudent_dGV.SelectedRows[0].Cells["ID"].Value));
            EditPracticeLesson.Text = "Редактирование практического занятия";
            this.Enabled = false;
            EditPracticeLesson.ShowDialog();
            if (EditPracticeLesson.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WritePracticeLessons(dataSet);
                if (SelectedStudent_comboBox.SelectedIndex != -1)
                    ReloadPracticeLessons(Convert.ToInt32(SelectedStudent_comboBox.SelectedValue));
            }
            this.Enabled = true;
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndexInPracticeLessons = -1;
            if (PracticeLessonsOfStudent_dGV.SelectedRows.Count != 1)
            {
                MessageBox.Show("Не выбрана строка для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    dataSet.PracticeLessons.Rows.Find(PracticeLessonsOfStudent_dGV.SelectedRows[0].Cells["ID"].Value).Delete();
                    dataSet = BusinessLogic.WritePracticeLessons(dataSet);
                    if (SelectedStudent_comboBox.SelectedIndex != -1)
                        ReloadPracticeLessons(Convert.ToInt32(SelectedStudent_comboBox.SelectedValue));
                }
                catch
                {
                    MessageBox.Show("Не удалось удалить выбранную строку.\nСкорее всего, на данную строку имеются ссылки из других таблиц", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (SelectedStudent_comboBox.SelectedIndex != -1)
                        ReloadPracticeLessons(Convert.ToInt32(SelectedStudent_comboBox.SelectedValue));
                }
            }
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReloadStudents_button_Click(object sender, EventArgs e)
        {
            FormLoad = false;
            string temp = "";
            if (SelectedStudent_comboBox.SelectedValue != null)
                temp = SelectedStudent_comboBox.SelectedValue.ToString();

            LastSelectionIndexInPracticeLessons = -1;

            dataSetForStudents = BusinessLogic.ReadStudents();
            SelectedStudent_comboBox.DataSource = dataSetForStudents.Students;
            SelectedStudent_comboBox.DisplayMember = "FIO";
            SelectedStudent_comboBox.ValueMember = "ID";
            SelectedStudent_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            SelectedStudent_comboBox.AutoCompleteMode = AutoCompleteMode.Append;

            Edit_button.Enabled = false;
            Delete_button.Enabled = false;
            PracticeLessonsOfStudent_dGV_SelectionChanged(sender, e);

            FormLoad = true;
            if (temp != "")
            {
                try
                {
                    SelectedStudent_comboBox.SelectedValue = temp;
                }
                catch
                {
                    SelectedStudent_comboBox.SelectedIndex = -1;
                }
            }
            else
            {
                SelectedStudent_comboBox.SelectedIndex = -1;
            }
        }

        private void SelectedStudent_comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*for (int i = 0; i < SelectedStudent_comboBox.Items.Count; i++)
            {
                if (((AutoschoolDataSet.StudentsRow)((DataRowView)(SelectedStudent_comboBox.Items[i])).Row).FIO.ToLower().Contains(SelectedStudent_comboBox.Text.ToLower()))
                {
                    SelectedStudent_comboBox.SelectedIndex = i;
                    break;
                }
            }*/
        }
    }
}
