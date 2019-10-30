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
    public partial class AddEditWorkStatusesForm : Form
    {
        public AddEditWorkStatusesForm(AutoschoolDataSet.WorkStatusesDataTable workStatusesDataTable, DataRow row)
        {
            InitializeComponent();
            this.workStatusesDataTable = workStatusesDataTable;
            dataRow = row;
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet.WorkStatusesDataTable workStatusesDataTable;
        DataRow dataRow;

        private void AddEditWorkStatusesForm_Load(object sender, EventArgs e)
        {
            if (dataRow != null)
            {
                WorkStatusName_textBox.Text = dataRow["Name"].ToString();
            }
            else
            {
                WorkStatusName_textBox.Text = "";
            }
        }

        private void AddEditWorkStatusesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    if (WorkStatusName_textBox.Text.Trim() == "")
                    {
                        throw new Exception("Не указано наименование рабочего статуса");
                    }
                    if (dataRow != null)
                    {
                        for (int i = 0; i < workStatusesDataTable.Rows.Count; i++)
                        {
                            if ((workStatusesDataTable[i][0].ToString() != dataRow[0].ToString()) && (workStatusesDataTable[i][1].ToString().ToLower() == WorkStatusName_textBox.Text.Trim().ToLower()))
                            {
                                throw new Exception("Рабочий статус с таким наименованием уже имеется в базе");
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < workStatusesDataTable.Rows.Count; i++)
                        {
                            if (workStatusesDataTable[i][1].ToString().ToLower() == WorkStatusName_textBox.Text.Trim().ToLower())
                            {
                                throw new Exception("Рабочий статус с таким наименованием уже имеется в базе");
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
                    dataRow["Name"] = WorkStatusName_textBox.Text;
                }
                else
                {
                    workStatusesDataTable.AddWorkStatusesRow(WorkStatusName_textBox.Text);
                }
            }
        }

        private void WorkStatusName_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((WorkStatusName_textBox.TextLength - WorkStatusName_textBox.SelectionLength) >= 50 && (char)e.KeyChar != (Char)Keys.Back)
                e.Handled = true;
            else
            {
                if ((char)e.KeyChar == (Char)Keys.Back) return;
                if ((char)e.KeyChar == (Char)Keys.Space) return;
                if (char.IsLetter(e.KeyChar)) return;
                e.Handled = true;
            }
        }
    }
}
