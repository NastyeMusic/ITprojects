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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            FormsNames[0] = "Setting";
            FormsNames[1] = "GroupsForm";
            FormsNames[2] = "AuditoriumsForm";
            FormsNames[3] = "WorkersForm";
            FormsNames[4] = "TheoryTeachersForm";
            FormsNames[5] = "ServiceMastersForm";
            FormsNames[6] = "CarriersForm";
            FormsNames[7] = "CategoriesForm";
            FormsNames[8] = "TransmissionsForm";
            FormsNames[9] = "CarriersStatusesForm";
            FormsNames[10] = "CarriersRepairsForm";
            FormsNames[11] = "JournalUsesForm";
            FormsNames[12] = "CurrentStatusesForm";
            FormsNames[13] = "StudentsScheduleForm";
            FormsNames[14] = "GroupsScheduleForm";
            FormsNames[15] = "InstructorsScheduleForm";
            FormsNames[16] = "TheoryTeacherScheduleForm";
            FormsNames[17] = "InstructorsCategoriesForm";
            FormsNames[18] = "CarriersUsesForm";
            FormsNames[19] = "ReplacementCarriers";
            FormsNames[20] = "AboutProgramForm";
        }

        public BusinessLogic BusinessLogic = new BusinessLogic(); 
        AutoschoolDataSet dataSet;
        string GroupName = "";
        string LastSearchingText = "";
        int LastFoundRow = -1;
        int LastSelectionIndex;

        GroupsForm GroupsForm = new GroupsForm();
        static bool GroupsFormOpened = false;

        AuditoriumsForm AuditoriumsForm = new AuditoriumsForm();
        static bool AuditoriumsFormOpened = false;

        WorkersForm WorkersForm = new WorkersForm();
        static bool WorkersFormOpened = false;

        CarriersForm CarriersForm = new CarriersForm();
        static bool CarriersFormOpened = false;

        CategoriesForm CategoriesForm = new CategoriesForm();
        static bool CategoriesFormOpened = false;

        TransmissionsForm TransmissionsForm = new TransmissionsForm();
        static bool TransmissionsFormOpened = false;

        CarriersStatusesForm CarriersStatusesForm = new CarriersStatusesForm();
        static bool CarriersStatusesFormOpened = false;

        InstructorsCategoriesForm InstructorsCategoriesForm = new InstructorsCategoriesForm();
        static bool InstructorsCategoriesFormOpened = false;

        CarriersUsesForm CarriersUsesForm = new CarriersUsesForm();
        static bool CarriersUsesFormOpened = false;

        StudentsScheduleForm StudentsScheduleForm = new StudentsScheduleForm();
        static bool StudentsScheduleFormOpened = false;

        static public string[] FormsNames = new string[21];

        public static void Perem(string s, bool b)
        {
            switch (s)
            {
                /*case "Setting":
                    GroupsFormOpened = b;
                    break;*/
                case "GroupsForm":
                    GroupsFormOpened = b;
                    break;
                case "AuditoriumsForm":
                    AuditoriumsFormOpened = b;
                    break;
                case "WorkersForm":
                    WorkersFormOpened = b;
                    break;
                /*case "TheoryTeachersForm":
                    TheoryTeachersFormOpened = b;
                    break;*/
                /*case "ServiceMastersForm":
                    ServiceMastersFormOpened = b;
                    break;*/
                case "CarriersForm":
                    CarriersFormOpened = b;
                    break;
                case "CategoriesForm":
                    CategoriesFormOpened = b;
                    break;
                case "TransmissionsForm":
                    TransmissionsFormOpened = b;
                    break;
                case "CarriersStatusesForm":
                    CarriersStatusesFormOpened = b;
                    break;
                /*case "CarriersRepairsForm":
                    CarriersFormOpened = b;
                    break;
                case "JournalUsesForm":
                    CarriersFormOpened = b;
                    break;
                case "CurrentStatusesForm":
                    CarriersFormOpened = b;
                    break;*/
                case "StudentsScheduleForm":
                    StudentsScheduleFormOpened = b;
                    break;
                /*case "GroupsScheduleForm":
                    CarriersFormOpened = b;
                    break;
                case "InstructorsScheduleForm":
                    CarriersFormOpened = b;
                    break;
                case "TheoryTeacherScheduleForm":
                    CarriersFormOpened = b;
                    break;*/
                case "InstructorsCategoriesForm":
                    InstructorsCategoriesFormOpened = b;
                    break;
                case "CarriersUsesForm":
                    CarriersUsesFormOpened = b;
                    break;
                /*case "ReplacementCarriers":
                    CarriersFormOpened = b;
                    break;
                case "AboutProgramForm":
                    CarriersFormOpened = b;
                    break;*/
            }
        }

        void ReloadStudents(string NameOfGroup)
        {
            dataSet = BusinessLogic.ReadStudentsOfGroup(NameOfGroup);
            Students_dGV.DataSource = dataSet;
            Students_dGV.DataMember = "Students";

            Students_dGV.Columns["ID"].Visible = false;
            Students_dGV.Columns["Surname"].Visible = false;
            Students_dGV.Columns["FirstName"].Visible = false;
            Students_dGV.Columns["PatronymicName"].Visible = false;
            Students_dGV.Columns["PhoneNumber"].Visible = false;
            Students_dGV.Columns["Retraining"].Visible = false;
            Students_dGV.Columns["Group"].Visible = false;
            Students_dGV.Columns["CarrierUse"].Visible = false;
            Students_dGV.Columns["Photo"].Visible = false;
            Students_dGV.Columns["FIO"].Visible = false;
            Students_dGV.Columns["InstructorName"].Visible = false;
            Students_dGV.Columns["CarrierName"].Visible = false;

            IDColumn.DataPropertyName = "ID";
            FIOColumn.DataPropertyName = "FIO";
            PhoneNumberColumn.DataPropertyName = "PhoneNumber";
            RetrainingColumn.DataPropertyName = "Retraining";

            GroupColumn.DataSource = dataSet.Groups;
            GroupColumn.DisplayMember = "Name";
            GroupColumn.ValueMember = "ID";
            GroupColumn.DataPropertyName = "Group";

            CarrierUseColumn.DataPropertyName = "CarrierUse";

            InstructorColumn.DataPropertyName = "InstructorName";
            CarrierColumn.DataPropertyName = "CarrierName";
        }

        void ReloadGroups()
        {
            Groups_treeView.Nodes.Clear();

            dataSet = BusinessLogic.ReadGroups();
            for (int i = 0; i < dataSet.Groups.Rows.Count; i++)
            {
                int year = Convert.ToDateTime(dataSet.Groups.Rows[i][2].ToString()).Year;

                bool Find = false;
                for (int j = 0; j < Groups_treeView.Nodes.Count; j++)
                {
                    if (Convert.ToInt32(Groups_treeView.Nodes[j].Text) == year)
                    {
                        Find = true;
                        // добавляем в уже существующую ветку
                        Groups_treeView.Nodes[j].Nodes.Add(dataSet.Groups.Rows[i][1].ToString());
                        break;
                    }
                }
                if (!Find)
                {
                    // создаем новую ветку, и добавляем в нее
                    TreeNode TempNode = Groups_treeView.Nodes.Add(year.ToString());
                    TempNode.Nodes.Add(dataSet.Groups.Rows[i][1].ToString());
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            ReloadGroups();
            редактироватьЗаписьОКурсантеToolStripMenuItem.Enabled = false;
            удалитьКурсантаToolStripMenuItem.Enabled = false;
            Students_dGV_SelectionChanged(sender, e);
        }

        private void Groups_treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (Groups_treeView.SelectedNode.Level == 1)
            {
                GroupName = Groups_treeView.SelectedNode.Text;
                ReloadStudents(GroupName);
            }
            else
            {
                GroupName = "";
            }
        }

        private void UpdateGroups_Button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            ReloadGroups();
        }

        private void добавитьНовогоКурсантаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoschoolDataSet dataSetForAllStudent;
            dataSetForAllStudent = BusinessLogic.ReadStudents();
            AddEditStudentForm AddStudent;
            if (GroupName != "")
                AddStudent = new AddEditStudentForm(GroupName, dataSetForAllStudent.Students, dataSetForAllStudent.Groups, 
                    dataSetForAllStudent.Instructors, null);
            else
                AddStudent = new AddEditStudentForm(null, dataSetForAllStudent.Students, dataSetForAllStudent.Groups,
                    dataSetForAllStudent.Instructors, null);

            AddStudent.Text = "Добавление курсанта";

            редактироватьЗаписьОКурсантеToolStripMenuItem.Enabled = false;
            удалитьКурсантаToolStripMenuItem.Enabled = false;
            добавитьНовогоКурсантаToolStripMenuItem.Enabled = false;

            AddStudent.ShowDialog();
            if (AddStudent.DialogResult == DialogResult.OK)
            {
                dataSetForAllStudent = BusinessLogic.WriteStudents(dataSetForAllStudent);
                if (GroupName != "")
                    ReloadStudents(GroupName);
            }

            добавитьНовогоКурсантаToolStripMenuItem.Enabled = true;
            Students_dGV_SelectionChanged(sender, e);
        }

        private void редактироватьЗаписьОКурсантеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Students_dGV.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Не выбрана строка для редактирования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AutoschoolDataSet dataSetForAllStudent;
            dataSetForAllStudent = BusinessLogic.ReadStudents();
            AddEditStudentForm EditStudent;
            if (GroupName != "")
                EditStudent = new AddEditStudentForm(GroupName, dataSetForAllStudent.Students, dataSetForAllStudent.Groups,
                    dataSetForAllStudent.Instructors, dataSetForAllStudent.Students.Rows.Find(Students_dGV.SelectedRows[0].Cells["ID"].Value));
            else
                EditStudent = new AddEditStudentForm(null, dataSetForAllStudent.Students, dataSetForAllStudent.Groups,
                    dataSetForAllStudent.Instructors, dataSetForAllStudent.Students.Rows.Find(Students_dGV.SelectedRows[0].Cells["ID"].Value));

            EditStudent.Text = "Редактирование курсанта";
            EditStudent.ShowDialog();
            if (EditStudent.DialogResult == DialogResult.OK)
            {
                dataSetForAllStudent = BusinessLogic.WriteStudents(dataSetForAllStudent);
                if (GroupName != "")
                    ReloadStudents(GroupName);
            }
        }

        private void удалитьКурсантаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Students_dGV.SelectedRows.Count != 1)
            {
                MessageBox.Show("Не выбрана строка для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    AutoschoolDataSet dataSetForAllStudent;
                    dataSetForAllStudent = BusinessLogic.ReadStudents();
                    dataSetForAllStudent.Students.Rows.Find(Students_dGV.SelectedRows[0].Cells["ID"].Value).Delete();
                    dataSetForAllStudent = BusinessLogic.WriteStudents(dataSetForAllStudent);
                    if (GroupName != "")
                        ReloadStudents(GroupName);
                }
                catch
                {                    
                    MessageBox.Show("Не удалось удалить выбранную строку.\nСкорее всего, на данную строку имеются ссылки из других таблиц", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (GroupName != "")
                        ReloadStudents(GroupName);
                }
            }
        }

        private void Students_dGV_SelectionChanged(object sender, EventArgs e)
        {
            if (Students_dGV.SelectedRows.Count == 1)
            {
                редактироватьЗаписьОКурсантеToolStripMenuItem.Enabled = true;
                удалитьКурсантаToolStripMenuItem.Enabled = true;
            }
            else
            {
                редактироватьЗаписьОКурсантеToolStripMenuItem.Enabled = false;
                удалитьКурсантаToolStripMenuItem.Enabled = false;
            }
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            SearchingInDataGridViewClass.Search(SearchStudent_textBox, ref Students_dGV, Direction_checkBox,
                ref LastSearchingText, ref LastFoundRow, 1);            
        }

        private void SearchStudent_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Enter)
            {
                Search_button_Click(sender, e);
            }
            if ((char)e.KeyChar == (Char)Keys.Back)
            {
                LastSearchingText = "";
            }
        }

        private void учебныеГруппыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!GroupsFormOpened)
            {
                GroupsForm.Show();
                GroupsFormOpened = true;
            }
            else
            {
                GroupsForm.Activate();
            }
        }

        private void учебныеАудиторииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!AuditoriumsFormOpened)
            {
                AuditoriumsForm.Show();
                AuditoriumsFormOpened = true;
            }
            else
            {
                AuditoriumsForm.Activate();
            }
        }

        private void работаССотрудникамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!WorkersFormOpened)
            {
                WorkersForm.Show();
                WorkersFormOpened = true;
            }
            else
            {
                WorkersForm.Activate();
            }
        }

        private void учебныеТСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CarriersFormOpened)
            {
                CarriersForm.Show();
                CarriersFormOpened = true;
            }
            else
            {
                CarriersForm.Activate();
            }
        }

        private void категорииТСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CategoriesFormOpened)
            {
                CategoriesForm.Show();
                CategoriesFormOpened = true;
            }
            else
            {
                CategoriesForm.Activate();
            }
        }

        private void трансмиссииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!TransmissionsFormOpened)
            {
                TransmissionsForm.Show();
                TransmissionsFormOpened = true;
            }
            else
            {
                TransmissionsForm.Activate();
            }
        }

        private void статусыТСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CarriersStatusesFormOpened)
            {
                CarriersStatusesForm.Show();
                CarriersStatusesFormOpened = true;
            }
            else
            {
                CarriersStatusesForm.Activate();
            }
        }

        private void категорииИнструкторовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!InstructorsCategoriesFormOpened)
            {
                InstructorsCategoriesForm.Show();
                InstructorsCategoriesFormOpened = true;
            }
            else
            {
                InstructorsCategoriesForm.Activate();
            }
        }

        private void тСИнструкторовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CarriersUsesFormOpened)
            {
                CarriersUsesForm.Show();
                CarriersUsesFormOpened = true;
            }
            else
            {
                CarriersUsesForm.Activate();
            }
        }

        private void расписаниеКурсантаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!StudentsScheduleFormOpened)
            {
                StudentsScheduleForm.Show();
                StudentsScheduleFormOpened = true;
            }
            else
            {
                StudentsScheduleForm.Activate();
            }
        }
    }
}
