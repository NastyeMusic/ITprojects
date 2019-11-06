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
    public partial class GroupsForm : Form
    {
        public GroupsForm()
        {
            InitializeComponent();
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet dataSet;
        string LastSearchingText = "";
        int LastFoundRow = -1;

        int LastSelectionIndex;
        bool FirstLoad = true;

        void ReloadGroups()
        {
            dataSet = BusinessLogic.ReadGroups();
            Groups_dataGridView.DataSource = dataSet;
            Groups_dataGridView.DataMember = "Groups";

            Groups_dataGridView.Columns["ID"].Visible = false;
            Groups_dataGridView.Columns["Name"].Visible = false;
            Groups_dataGridView.Columns["StartLearning"].Visible = false;
            Groups_dataGridView.Columns["EndLearning"].Visible = false;
            Groups_dataGridView.Columns["Category"].Visible = false;
            Groups_dataGridView.Columns["Teacher"].Visible = false;
            Groups_dataGridView.Columns["TeacherFIO"].Visible = false;
            Groups_dataGridView.Columns["CategoryName"].Visible = false;

            IDColumn.DataPropertyName = "ID";
            NameColumn.DataPropertyName = "Name";
            StartLearningColumn.DataPropertyName = "StartLearning";
            EndLearningColumn.DataPropertyName = "EndLearning";
            CategoryColumn.DataPropertyName = "CategoryName";
            TeacherColumn.DataPropertyName = "TeacherFIO";

            if (LastSelectionIndex != -1)
                Groups_dataGridView.CurrentCell = Groups_dataGridView[1, LastSelectionIndex];
        }

        private void GroupsForm_Load(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            ReloadGroups();
            Edit_button.Enabled = false;
            Delete_button.Enabled = false;
            Groups_dataGridView_SelectionChanged(sender, e);
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            SearchingInDataGridViewClass.Search(SearchGroup_textBox, ref Groups_dataGridView, Direction_checkBox,
                ref LastSearchingText, ref LastFoundRow, "NameColumn");
        }

        private void SearchGroup_textBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Groups_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (Groups_dataGridView.SelectedRows.Count == 1)
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

        private void Add_button_Click(object sender, EventArgs e)
        {
            ReloadGroups();
            AddEditGroupForm AddGroup = new AddEditGroupForm(dataSet.Groups, dataSet.Categories, dataSet.TheoryTeachers, null);
            AddGroup.Text = "Добавление группы";
            this.Enabled = false;
            AddGroup.ShowDialog();            
            if (AddGroup.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteGroups(dataSet);
                ReloadGroups();
            }
            this.Enabled = true;
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = Groups_dataGridView.SelectedRows[0].Index;
            ReloadGroups();
            AddEditGroupForm EditGroup = new AddEditGroupForm(dataSet.Groups, dataSet.Categories, dataSet.TheoryTeachers, dataSet.Groups.Rows.Find(Groups_dataGridView.SelectedRows[0].Cells["ID"].Value));
            EditGroup.Text = "Редактирование группы";
            this.Enabled = false;
            EditGroup.ShowDialog();
            if (EditGroup.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteGroups(dataSet);
                ReloadGroups();
            }
            this.Enabled = true;
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            if (Groups_dataGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Не выбрана строка для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    dataSet.Groups.Rows.Find(Groups_dataGridView.SelectedRows[0].Cells["ID"].Value).Delete();
                    dataSet = BusinessLogic.WriteGroups(dataSet);
                    ReloadGroups();
                }
                catch
                {
                    MessageBox.Show("Не удалось удалить выбранную строку.\nСкорее всего, на данную строку имеются ссылки из других таблиц", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReloadGroups();
                }
            }
        }

        private void GroupsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            MainForm.Perem(MainForm.FormsNames[1], false);
        }

        private void ReloadGroups_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            ReloadGroups();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GroupsForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                if (!FirstLoad)
                    ReloadGroups_button_Click(sender, e);
                else
                    FirstLoad = false;
            }
        }
    }
}
