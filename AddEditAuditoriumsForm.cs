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
    public partial class AddEditAuditoriumsForm : Form
    {
        public AddEditAuditoriumsForm(AutoschoolDataSet.AuditoriumsDataTable auditoriumsDataTable, DataRow row)
        {
            InitializeComponent();
            this.auditoriumsDataTable = auditoriumsDataTable;
            dataRow = row;
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet.AuditoriumsDataTable auditoriumsDataTable;
        DataRow dataRow;

        private void AddEditAuditoriumsForm_Load(object sender, EventArgs e)
        {
            if (dataRow != null)
            {
                AuditoriumName_textBox.Text = dataRow["Name"].ToString();
            }
            else
            {
                AuditoriumName_textBox.Text = "";
            }
        }

        private void AddEditAuditoriumsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    if (AuditoriumName_textBox.Text.Trim() == "")
                    {
                        throw new Exception("Не указано наименование аудитории");
                    }
                    for (int i = 0; i < auditoriumsDataTable.Rows.Count; i++)
                    {
                        if (auditoriumsDataTable[i][1].ToString().ToLower() == AuditoriumName_textBox.Text.ToLower())
                        {
                            throw new Exception("Аудитория с таким названием уже существует.");
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
                    dataRow["Name"] = AuditoriumName_textBox.Text;
                }
                else
                {
                    auditoriumsDataTable.AddAuditoriumsRow(AuditoriumName_textBox.Text);
                }
            }
        }

        private void AuditoriumName_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((AuditoriumName_textBox.TextLength - AuditoriumName_textBox.SelectionLength) >= 50 && (char)e.KeyChar != (Char)Keys.Back)
                e.Handled = true;
            else
            {
                if ((char)e.KeyChar == (Char)Keys.Back) return;
                if ((char)e.KeyChar == (Char)Keys.Space) return;
                if ((char)e.KeyChar == (Char)Keys.ControlKey) return;
                if (char.IsLetterOrDigit(e.KeyChar)) return;
                if ((char)e.KeyChar == '-') return;
                e.Handled = true;
            }
        }
    }
}
