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
        bool FirstLoad = true;

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
            SearchingInDataGridViewClass.Search(SearchCategory_textBox, ref Categories_dataGridView, Direction_checkBox,
                ref LastSearchingText, ref LastFoundRow, "NameColumn");            
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
            MainForm.Perem(MainForm.FormsNames[7], false);
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            dataSet = BusinessLogic.ReadCategories();
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
            dataSet = BusinessLogic.ReadCategories();
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
            LastSelectionIndex = -1;
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

        private void Reload_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            ReloadCategories();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CategoriesForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                if (!FirstLoad)
                    Reload_button_Click(sender, e);
                else
                    FirstLoad = false;
            }
        }
    }
}
