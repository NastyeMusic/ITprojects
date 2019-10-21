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
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

        public BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet dataSet;
        string LastSearchingText = "";
        int LastFoundRow = -1;

        int LastSelectionIndex;

        void ReloadCategories()
        {
            dataSet = BusinessLogic.ReadCategories();
            Categories_dataGridView.DataSource = dataSet;
            Categories_dataGridView.DataMember = "Categories";

            Categories_dataGridView.Columns["ID"].Visible = false;
            Categories_dataGridView.Columns["Name"].Visible = false;

            IDColumn.DataPropertyName = "ID";
            NameColumn.DataPropertyName = "Name";

            if (LastSelectionIndex != -1)
                Categories_dataGridView.CurrentCell = Categories_dataGridView[1, LastSelectionIndex];
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            ReloadCategories();
            Edit_button.Enabled = false;
            Delete_button.Enabled = false;
            Categories_dataGridView_SelectionChanged(sender, e);
        }

        private void Categories_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (Categories_dataGridView.SelectedRows.Count == 1)
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
            bool Find = false;
            string CurrentSearchingText = SearchCategory_textBox.Text.Trim();
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
                for (int i = BeginRow; i < Categories_dataGridView.RowCount; i++)
                {
                    if (Categories_dataGridView[1, i].Value.ToString().Contains(CurrentSearchingText))
                    {
                        Categories_dataGridView.CurrentCell = Categories_dataGridView[1, i];
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
                    if (Categories_dataGridView[1, i].Value.ToString().Contains(CurrentSearchingText))
                    {
                        Categories_dataGridView.CurrentCell = Categories_dataGridView[1, i];
                        LastFoundRow = i;
                        return;
                    }
                }
                if (!Find)
                {
                    DialogResult result = MessageBox.Show("Поиск достиг первой строки таблицы. Продолжить поиск с конца таблицы?", "Поиск", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        BeginRow = Categories_dataGridView.RowCount - 1;
                        goto Search;
                    }
                }
            }
        }

        private void SearchCategory_textBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CategoriesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            MainForm.Perem(MainForm.FormsNames[7], false);
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            AddEditCategoryForm AddCategory = new AddEditCategoryForm(dataSet.Categories, null);
            AddCategory.Text = "Добавление категории";
            this.Enabled = false;
            AddCategory.ShowDialog();
            if (AddCategory.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteCategories(dataSet);
                ReloadCategories();
            }
            this.Enabled = true;
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = Categories_dataGridView.SelectedRows[0].Index;
            AddEditCategoryForm EditCategory = new AddEditCategoryForm(dataSet.Categories, dataSet.Categories.Rows.Find(Categories_dataGridView.SelectedRows[0].Cells["ID"].Value));
            EditCategory.Text = "Редактирование категории";
            this.Enabled = false;
            EditCategory.ShowDialog();
            if (EditCategory.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteCategories(dataSet);
                ReloadCategories();
            }
            this.Enabled = true;
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (Categories_dataGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Не выбрана строка для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    dataSet.Categories.Rows.Find(Categories_dataGridView.SelectedRows[0].Cells["ID"].Value).Delete();
                    dataSet = BusinessLogic.WriteCategories(dataSet);
                    ReloadCategories();
                }
                catch
                {
                    MessageBox.Show("Не удалось удалить выбранную строку.\nСкорее всего, на данную строку имеются ссылки из других таблиц", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReloadCategories();
                }
            }
        }
    }
}
