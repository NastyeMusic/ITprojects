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
                    if (WorkStatusName_textBox.Text == "")
                    {
                        throw new Exception("Не указано наименование аудитории");
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
    }
}
