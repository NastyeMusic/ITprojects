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
    public partial class InstructorsCategoriesForm : Form
    {
        public InstructorsCategoriesForm()
        {
            InitializeComponent();
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet dataSet;
        string LastSearchingText = "";
        int LastFoundRow = -1;
        int LastSelectionIndex;

        void ReloadInstructorsCategories()
        {
            dataSet = BusinessLogic.ReadInstructorsCategories();
            InstructorsCategories_dataGridView.DataSource = dataSet;
            InstructorsCategories_dataGridView.DataMember = "InstructorsCategories";

            InstructorsCategories_dataGridView.Columns["ID"].Visible = false;
            InstructorsCategories_dataGridView.Columns["Instructor"].Visible = false;
            InstructorsCategories_dataGridView.Columns["Category"].Visible = false;
            InstructorsCategories_dataGridView.Columns["InstructorFIO"].Visible = false;

            IDColumn.DataPropertyName = "ID";

            SurnameColumn.DataSource = dataSet.Instructors;
            SurnameColumn.DisplayMember = "Surname";
            SurnameColumn.ValueMember = "ID";
            SurnameColumn.DataPropertyName = "Instructor";

            FirstNameColumn.DataSource = dataSet.Instructors;
            FirstNameColumn.DisplayMember = "FirstName";
            FirstNameColumn.ValueMember = "ID";
            FirstNameColumn.DataPropertyName = "Instructor";

            PatronymicNameColumn.DataSource = dataSet.Instructors;
            PatronymicNameColumn.DisplayMember = "PatronymicName";
            PatronymicNameColumn.ValueMember = "ID";
            PatronymicNameColumn.DataPropertyName = "Instructor";

            CategoryColumn.DataSource = dataSet.Categories;
            CategoryColumn.DisplayMember = "Name";
            CategoryColumn.ValueMember = "ID";
            CategoryColumn.DataPropertyName = "Category";

            if (LastSelectionIndex != -1)
                InstructorsCategories_dataGridView.CurrentCell = InstructorsCategories_dataGridView[1, LastSelectionIndex];
        }

        private void InstructorsCategoriesForm_Load(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            ReloadInstructorsCategories();
            Edit_button.Enabled = false;
            Delete_button.Enabled = false;
            InstructorsCategories_dataGridView_SelectionChanged(sender, e);
        }

        private void InstructorsCategories_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (InstructorsCategories_dataGridView.SelectedRows.Count == 1)
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

        private void Search_button_Click(object sender, EventArgs e)
        {
            SearchingInDataGridViewClass.Search(SearchInstructor_textBox, ref InstructorsCategories_dataGridView, Direction_checkBox,
                ref LastSearchingText, ref LastFoundRow, "SurnameColumn", "FirstNameColumn", "PatronymicNameColumn");
        }

        private void SearchInstructor_textBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ReloadInstructorsCategories_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            ReloadInstructorsCategories();
        }

        private void InstructorsCategoriesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            MainForm.Perem(MainForm.FormsNames[17], false);
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            dataSet = BusinessLogic.ReadInstructorsCategories();
            AddEditInstructorsCategoriesForm AddInstructorCategory = new AddEditInstructorsCategoriesForm(dataSet.InstructorsCategories, 
                dataSet.Instructors, dataSet.Categories, null);
            AddInstructorCategory.Text = "Добавление категории инструктору";
            this.Enabled = false;
            AddInstructorCategory.ShowDialog();
            if (AddInstructorCategory.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteInstructorsCategories(dataSet);
                ReloadInstructorsCategories();
            }
            this.Enabled = true;
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            dataSet = BusinessLogic.ReadInstructorsCategories();
            LastSelectionIndex = InstructorsCategories_dataGridView.SelectedRows[0].Index;
            AddEditInstructorsCategoriesForm EditInstructorCategory = new AddEditInstructorsCategoriesForm(dataSet.InstructorsCategories,
                dataSet.Instructors, dataSet.Categories, 
                dataSet.InstructorsCategories.Rows.Find(InstructorsCategories_dataGridView.SelectedRows[0].Cells["ID"].Value));
            EditInstructorCategory.Text = "Редактирование категории инструктора";
            this.Enabled = false;
            EditInstructorCategory.ShowDialog();
            if (EditInstructorCategory.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteInstructorsCategories(dataSet);
                ReloadInstructorsCategories();
            }
            this.Enabled = true;
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            if (InstructorsCategories_dataGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Не выбрана строка для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    dataSet.InstructorsCategories.Rows.Find(InstructorsCategories_dataGridView.SelectedRows[0].Cells["ID"].Value).Delete();
                    dataSet = BusinessLogic.WriteInstructorsCategories(dataSet);
                    ReloadInstructorsCategories();
                }
                catch
                {
                    MessageBox.Show("Не удалось удалить выбранную строку.\nСкорее всего, на данную строку имеются ссылки из других таблиц", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReloadInstructorsCategories();
                }
            }
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
