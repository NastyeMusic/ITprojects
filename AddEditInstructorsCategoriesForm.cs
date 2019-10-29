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
    public partial class AddEditInstructorsCategoriesForm : Form
    {
        public AddEditInstructorsCategoriesForm(AutoschoolDataSet.InstructorsCategoriesDataTable instructorsCategoriesDataTable, 
            AutoschoolDataSet.InstructorsDataTable instructorsDataTable,
            AutoschoolDataSet.CategoriesDataTable categoriesDataTable, DataRow row)
        {
            InitializeComponent();
            this.instructorsCategoriesDataTable = instructorsCategoriesDataTable;
            this.instructorsDataTable = instructorsDataTable;
            this.categoriesDataTable = categoriesDataTable;
            dataRow = row;
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet.InstructorsCategoriesDataTable instructorsCategoriesDataTable;
        AutoschoolDataSet.InstructorsDataTable instructorsDataTable;
        AutoschoolDataSet.CategoriesDataTable categoriesDataTable;
        DataRow dataRow;

        private void AddEditInstructorsCategoriesForm_Load(object sender, EventArgs e)
        {
            Instructor_comboBox.DataSource = instructorsDataTable;
            Instructor_comboBox.DisplayMember = "FIO";
            Instructor_comboBox.ValueMember = "ID";
            Instructor_comboBox.AutoCompleteMode = AutoCompleteMode.Append;
            Instructor_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            Category_comboBox.DataSource = categoriesDataTable;
            Category_comboBox.DisplayMember = "Name";
            Category_comboBox.ValueMember = "ID";
            Category_comboBox.AutoCompleteMode = AutoCompleteMode.Append;
            Category_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            if (dataRow != null)
            {
                Instructor_comboBox.SelectedValue = dataRow["Instructor"].ToString();
                Category_comboBox.SelectedValue = dataRow["Category"].ToString();
            }
            else
            {
                Instructor_comboBox.SelectedIndex = -1;
                Category_comboBox.SelectedIndex = -1;                
            }
        }

        private void AddEditInstructorsCategoriesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    if (Instructor_comboBox.SelectedIndex == -1)
                    {
                        Instructor_comboBox.Focus();
                        throw new Exception("Не выбран инструктор");
                    }
                    if (Category_comboBox.SelectedIndex == -1)
                    {
                        Category_comboBox.Focus();
                        throw new Exception("Не выбрана категория");
                    }
                    AutoschoolDataSet TempDS = new AutoschoolDataSet();
                    TempDS = BusinessLogic.ReadInstructorsCategoriesByInstructorIdANDCategoryId(
                        Convert.ToInt32(Instructor_comboBox.SelectedValue), Convert.ToInt32(Category_comboBox.SelectedValue));
                    if (TempDS.InstructorsCategories.Rows.Count > 0)
                        throw new Exception("Такая связка между инструктором и категорией уже существует");
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Ошибка");
                    e.Cancel = true;
                    return;
                }
                if (dataRow != null)
                {
                    dataRow["Instructor"] = Instructor_comboBox.SelectedValue;
                    dataRow["Category"] = Category_comboBox.SelectedValue;
                }
                else
                {
                    instructorsCategoriesDataTable.AddInstructorsCategoriesRow(instructorsDataTable[Instructor_comboBox.SelectedIndex], 
                        categoriesDataTable[Category_comboBox.SelectedIndex]);
                }
            }
        }
    }
}
