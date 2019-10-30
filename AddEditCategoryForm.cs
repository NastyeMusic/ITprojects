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
    public partial class AddEditCategoryForm : Form
    {
        public AddEditCategoryForm(AutoschoolDataSet.CategoriesDataTable categoriesDataTable, DataRow row)
        {
            InitializeComponent();
            this.categoriesDataTable = categoriesDataTable;
            dataRow = row;
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet.CategoriesDataTable categoriesDataTable;
        DataRow dataRow;

        private void AddEditCategoryForm_Load(object sender, EventArgs e)
        {
            if (dataRow != null)
            {
                CategoryName_textBox.Text = dataRow["Name"].ToString();
            }
            else
            {
                CategoryName_textBox.Text = "";
            }
        }

        private void AddEditCategoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    if (CategoryName_textBox.Text.Trim() == "")
                    {
                        throw new Exception("Не указано наименование категории");
                    }
                    if (dataRow != null)
                    {
                        for (int i = 0; i < categoriesDataTable.Rows.Count; i++)
                        {
                            if ((categoriesDataTable[i][0].ToString() != dataRow[0].ToString()) && (categoriesDataTable[i][1].ToString().ToLower() == CategoryName_textBox.Text.Trim().ToLower()))
                            {
                                throw new Exception("Категория с таким наименованием уже имеется в базе");
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < categoriesDataTable.Rows.Count; i++)
                        {
                            if (categoriesDataTable[i][1].ToString().ToLower() == CategoryName_textBox.Text.Trim().ToLower())
                            {
                                throw new Exception("Категория с таким наименованием уже имеется в базе");
                            }
                        }
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Ошибка");
                    e.Cancel = true;
                    return;
                }
                if (dataRow != null)
                {
                    dataRow["Name"] = CategoryName_textBox.Text;
                }
                else
                {
                    categoriesDataTable.AddCategoriesRow(CategoryName_textBox.Text);
                }
            }
        }

        private void CategoryName_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((CategoryName_textBox.TextLength - CategoryName_textBox.SelectionLength) >= 25 && (char)e.KeyChar != (Char)Keys.Back)
                e.Handled = true;
            else
            {
                if ((char)e.KeyChar == (Char)Keys.Back) return;
                if ((char)e.KeyChar == (Char)Keys.Space) return;
                if ((char)e.KeyChar == (Char)Keys.ControlKey) return;
                if (char.IsLetterOrDigit(e.KeyChar)) return;
                e.Handled = true;
            }
        }
    }
}
