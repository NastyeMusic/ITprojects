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
        }

        public BusinessLogic BusinessLogic = new BusinessLogic(); 
        AutoschoolDataSet dataSet;
        string GroupName = null;
        string LastSearchingText = "";
        int LastFoundRow = -1;

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
            
            PhotoColumn.DataPropertyName = "Photo";
        }

        void ReloadGroups()
        {
            Groups_treeView.Nodes.Clear();

            dataSet = BusinessLogic.ReadGroups();
            DataGridView Groups_dGV = new DataGridView();
            Groups_dGV.DataSource = dataSet;
            Groups_dGV.DataMember = "Groups";

            for (int i = 0; i < Groups_dGV.RowCount; i++)
            {
                int year = Convert.ToDateTime(Groups_dGV[2, i].ToString()).Year;

                bool Find = false;
                for (int j = 0; j < Groups_treeView.Nodes.Count; j++)
                {
                    if (Convert.ToInt32(Groups_treeView.Nodes[j].Text) == year)
                    {
                        Find = true;
                        // добавляем в уже существующую ветку
                        Groups_treeView.Nodes[j].Nodes.Add(Groups_dGV[1, i].ToString());
                        break;
                    }
                }
                if (!Find)
                {
                    // создаем новую ветку, и добавляем в нее
                    TreeNode TempNode = Groups_treeView.Nodes.Add(year.ToString());
                    TempNode.Nodes.Add(Groups_dGV[1, i].ToString());
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReloadGroups();
            редактироватьЗаписьОКурсантеToolStripMenuItem.Enabled = false;
            удалитьКурсантаToolStripMenuItem.Enabled = false;
        }

        private void Groups_treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (Groups_treeView.SelectedNode.Level == 2)
            {
                GroupName = Groups_treeView.SelectedNode.Text;
                ReloadStudents(GroupName);
            }
        }

        private void UpdateGroups_Button_Click(object sender, EventArgs e)
        {
            ReloadGroups();
        }

        private void добавитьНовогоКурсантаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoschoolDataSet dataSetForAllStudent;
            dataSetForAllStudent = BusinessLogic.ReadStudents();
            AddEditStudent AddStudent;
            if (GroupName != "")
                AddStudent = new AddEditStudent(GroupName, dataSetForAllStudent.Students, dataSetForAllStudent.Groups, 
                    dataSetForAllStudent.Instructors, null);
            else
                AddStudent = new AddEditStudent(null, dataSetForAllStudent.Students, dataSetForAllStudent.Groups,
                    dataSetForAllStudent.Instructors, null);

            AddStudent.Text = "Добавление курсанта";

            редактироватьЗаписьОКурсантеToolStripMenuItem.Enabled = false;
            удалитьКурсантаToolStripMenuItem.Enabled = false;
            добавитьНовогоКурсантаToolStripMenuItem.Enabled = false;

            AddStudent.ShowDialog();
            if (AddStudent.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteStudents(dataSet);
                if (GroupName != "")
                    ReloadStudents(GroupName);
            }

            добавитьНовогоКурсантаToolStripMenuItem.Enabled = true;
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

        private void редактироватьЗаписьОКурсантеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Students_dGV.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Не выбрана строка для редактирования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AutoschoolDataSet dataSetForAllStudent;
            dataSetForAllStudent = BusinessLogic.ReadStudents();
            AddEditStudent EditStudent;
            if (GroupName != "")
                EditStudent = new AddEditStudent(GroupName, dataSetForAllStudent.Students, dataSetForAllStudent.Groups,
                    dataSetForAllStudent.Instructors, dataSet.Students.Rows.Find(Students_dGV.SelectedRows[0].Cells["ID"].Value));
            else
                EditStudent = new AddEditStudent(null, dataSetForAllStudent.Students, dataSetForAllStudent.Groups,
                    dataSetForAllStudent.Instructors, dataSet.Students.Rows.Find(Students_dGV.SelectedRows[0].Cells["ID"].Value));

            EditStudent.Text = "Редактирование курсанта";
            EditStudent.ShowDialog();
            if (EditStudent.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteStudents(dataSet);
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
                    dataSet.Students.Rows.Find(Students_dGV.SelectedRows[0].Cells["ID"].Value).Delete();
                    dataSet = BusinessLogic.WriteStudents(dataSet);
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
            bool Find = false;
            string CurrentSearchingText = SearchStudent_textBox.Text.Trim();
            int BeginRow = 0;
            if (LastSearchingText == CurrentSearchingText)
            {
                if (Direction_checkBox.Checked)
                    BeginRow = LastFoundRow + 1;
                else
                    BeginRow = LastFoundRow - 1;
            }
            else
                LastSearchingText = CurrentSearchingText;
            Search:
            if (Direction_checkBox.Checked)
            {
                for (int i = BeginRow; i < Students_dGV.RowCount; i++)
                {
                    if (Students_dGV[1, i].Value.ToString().Contains(CurrentSearchingText))
                    {
                        Students_dGV.CurrentCell = Students_dGV[1, i];
                        LastFoundRow = i;
                        return;
                    }
                }
                if (!Find)
                {
                    DialogResult result = MessageBox.Show("Поиск достиг последней строки таблицы. Продолжить поиск с начала таблицы?", "Поиск", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        BeginRow = 0;
                        goto Search;
                    }
                }
            }
            else
            {
                for (int i = BeginRow; i >= 0; i--)
                {
                    if (Students_dGV[1, i].Value.ToString().Contains(CurrentSearchingText))
                    {
                        Students_dGV.CurrentCell = Students_dGV[1, i];
                        LastFoundRow = i;
                        return;
                    }
                }
                if (!Find)
                {
                    DialogResult result = MessageBox.Show("Поиск достиг первой строки таблицы. Продолжить поиск с конца таблицы?", "Поиск", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        BeginRow = Students_dGV.RowCount - 1;
                        goto Search;
                    }
                }
            }
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
    }
}
