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
    public partial class GroupsScheduleForm : Form
    {
        public GroupsScheduleForm()
        {
            InitializeComponent();
        }

        public BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet dataSet, dataSetForGroups;
        int LastSelectionIndex;
        bool FormLoad = false;

        void ReloadTheoryLessons(int GroupID)
        {
            dataSet = BusinessLogic.ReadTheoryLessonsByGroupID(GroupID);
            TheoryLessonsOfGroup_dGV.DataSource = dataSet;
            TheoryLessonsOfGroup_dGV.DataMember = "TheoryLessons";

            TheoryLessonsOfGroup_dGV.Columns["ID"].Visible = false;
            TheoryLessonsOfGroup_dGV.Columns["Date"].Visible = false;
            TheoryLessonsOfGroup_dGV.Columns["Time"].Visible = false;
            TheoryLessonsOfGroup_dGV.Columns["Auditorium"].Visible = false;
            TheoryLessonsOfGroup_dGV.Columns["Group"].Visible = false;

            IDColumn.DataPropertyName = "ID";
            TheoryDateColumn.DataPropertyName = "Date";
            TheoryTimeColumn.DataPropertyName = "Time";

            AuditoriumColumn.DataSource = dataSet.Auditoriums;
            AuditoriumColumn.DisplayMember = "Name";
            AuditoriumColumn.ValueMember = "ID";
            AuditoriumColumn.DataPropertyName = "Auditorium";

            TeacherColumn.DataSource = dataSet.Groups;
            TeacherColumn.DisplayMember = "TeacherFIO";
            TeacherColumn.ValueMember = "ID";
            TeacherColumn.DataPropertyName = "Group";
        }

        private void GroupsScheduleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            MainForm.Perem(MainForm.FormsNames[14], false);
        }

        private void TheoryLessonsOfGroup_dGV_SelectionChanged(object sender, EventArgs e)
        {
            if (TheoryLessonsOfGroup_dGV.SelectedRows.Count == 1)
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

        private void SelectedGroup_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedGroup_comboBox.SelectedIndex != -1 && FormLoad)
            {
                int GroupID = Convert.ToInt32(SelectedGroup_comboBox.SelectedValue);
                ReloadTheoryLessons(GroupID);
            }
        }

        private void SelectedGroup_comboBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void SelectedGroup_comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*for (int i = 0; i < SelectedGroup_comboBox.Items.Count; i++)
            {
                if (((AutoschoolDataSet.GroupsRow)((DataRowView)(SelectedGroup_comboBox.Items[i])).Row).Name.ToLower().Contains(SelectedGroup_comboBox.Text.ToLower()))
                {
                    SelectedGroup_comboBox.SelectedIndex = i;
                    break;
                }
            }*/
        }

        private void Add_button_Click(object sender, EventArgs e)
        {            
            if (SelectedGroup_comboBox.SelectedValue != null)
                ReloadTheoryLessons(Convert.ToInt32(SelectedGroup_comboBox.SelectedValue));
            else
                ReloadTheoryLessons(-1);
            dataSet = BusinessLogic.ReadTheoryLessons();
            AddEditTheoryLessonForm AddTheoryLesson;
            if (SelectedGroup_comboBox.SelectedIndex != -1)
                AddTheoryLesson = new AddEditTheoryLessonForm(dataSet.TheoryLessons, dataSet.Groups, dataSet.Auditoriums, 
                    dataSet.Groups.Rows.Find(SelectedGroup_comboBox.SelectedValue), null);
            else
                AddTheoryLesson = new AddEditTheoryLessonForm(dataSet.TheoryLessons, dataSet.Groups, dataSet.Auditoriums, null, null);
            AddTheoryLesson.Text = "Добавление теоретического занятия";
            this.Enabled = false;
            AddTheoryLesson.ShowDialog();
            if (AddTheoryLesson.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteTheoryLessons(dataSet);
                if (SelectedGroup_comboBox.SelectedIndex != -1)
                    ReloadTheoryLessons(Convert.ToInt32(SelectedGroup_comboBox.SelectedValue));
            }
            this.Enabled = true;
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = TheoryLessonsOfGroup_dGV.SelectedRows[0].Index;
            if (SelectedGroup_comboBox.SelectedValue != null)
                ReloadTheoryLessons(Convert.ToInt32(SelectedGroup_comboBox.SelectedValue));
            else
                ReloadTheoryLessons(-1);
            dataSet = BusinessLogic.ReadTheoryLessons();
            AddEditTheoryLessonForm EditTheoryLesson;
            if (SelectedGroup_comboBox.SelectedIndex != -1)
                EditTheoryLesson = new AddEditTheoryLessonForm(dataSet.TheoryLessons, dataSet.Groups, dataSet.Auditoriums,
                    dataSet.Groups.Rows.Find(SelectedGroup_comboBox.SelectedValue),
                    dataSet.TheoryLessons.Rows.Find(TheoryLessonsOfGroup_dGV.SelectedRows[0].Cells["ID"].Value));
            else
                EditTheoryLesson = new AddEditTheoryLessonForm(dataSet.TheoryLessons, dataSet.Groups, dataSet.Auditoriums, null,
                    dataSet.TheoryLessons.Rows.Find(TheoryLessonsOfGroup_dGV.SelectedRows[0].Cells["ID"].Value));
            EditTheoryLesson.Text = "Редактирование теоретического занятия";
            this.Enabled = false;
            EditTheoryLesson.ShowDialog();
            if (EditTheoryLesson.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteTheoryLessons(dataSet);
                if (SelectedGroup_comboBox.SelectedIndex != -1)
                    ReloadTheoryLessons(Convert.ToInt32(SelectedGroup_comboBox.SelectedValue));
            }
            this.Enabled = true;
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            if (TheoryLessonsOfGroup_dGV.SelectedRows.Count != 1)
            {
                MessageBox.Show("Не выбрана строка для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    dataSet.TheoryLessons.Rows.Find(TheoryLessonsOfGroup_dGV.SelectedRows[0].Cells["ID"].Value).Delete();
                    dataSet = BusinessLogic.WriteTheoryLessons(dataSet);
                    if (SelectedGroup_comboBox.SelectedIndex != -1)
                        ReloadTheoryLessons(Convert.ToInt32(SelectedGroup_comboBox.SelectedValue));
                }
                catch
                {
                    MessageBox.Show("Не удалось удалить выбранную строку.\nСкорее всего, на данную строку имеются ссылки из других таблиц", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (SelectedGroup_comboBox.SelectedIndex != -1)
                        ReloadTheoryLessons(Convert.ToInt32(SelectedGroup_comboBox.SelectedValue));
                }
            }
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReloadGroups_button_Click(object sender, EventArgs e)
        {
            FormLoad = false;
            string temp = "";
            if (SelectedGroup_comboBox.SelectedValue != null)
                temp = SelectedGroup_comboBox.SelectedValue.ToString();

            LastSelectionIndex = -1;

            dataSetForGroups = BusinessLogic.ReadGroups();
            SelectedGroup_comboBox.DataSource = dataSetForGroups.Groups;
            SelectedGroup_comboBox.DisplayMember = "Name";
            SelectedGroup_comboBox.ValueMember = "ID";
            SelectedGroup_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            SelectedGroup_comboBox.AutoCompleteMode = AutoCompleteMode.Append;

            Edit_button.Enabled = false;
            Delete_button.Enabled = false;
            TheoryLessonsOfGroup_dGV_SelectionChanged(sender, e);

            FormLoad = true;
            if (temp != "")
            {
                try
                {
                    SelectedGroup_comboBox.SelectedValue = temp;
                }
                catch
                {
                    SelectedGroup_comboBox.SelectedIndex = -1;
                }
            }
            else
            {
                SelectedGroup_comboBox.SelectedIndex = -1;
            }
        }

        private void GroupsScheduleForm_Load(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;

            dataSetForGroups = BusinessLogic.ReadGroups();
            SelectedGroup_comboBox.DataSource = dataSetForGroups.Groups;
            SelectedGroup_comboBox.DisplayMember = "Name";
            SelectedGroup_comboBox.ValueMember = "ID";
            SelectedGroup_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            SelectedGroup_comboBox.AutoCompleteMode = AutoCompleteMode.Append;

            Edit_button.Enabled = false;
            Delete_button.Enabled = false;
            TheoryLessonsOfGroup_dGV_SelectionChanged(sender, e);

            FormLoad = true;
            SelectedGroup_comboBox.SelectedIndex = -1;
        }
    }
}
