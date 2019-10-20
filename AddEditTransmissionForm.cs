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
    public partial class AddEditTransmissionForm : Form
    {
        public AddEditTransmissionForm(AutoschoolDataSet.TransmissionsDataTable transmissionsDataTable, DataRow row)
        {
            InitializeComponent();
            this.transmissionsDataTable = transmissionsDataTable;
            dataRow = row;
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet.TransmissionsDataTable transmissionsDataTable;
        DataRow dataRow;

        private void AddEditTransmissionForm_Load(object sender, EventArgs e)
        {
            if (dataRow != null)
            {
                TransmissionName_textBox.Text = dataRow["Transmission"].ToString();
            }
            else
            {
                TransmissionName_textBox.Text = "";
            }
        }

        private void AddEditTransmissionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    if (TransmissionName_textBox.Text.Trim() == "")
                    {
                        throw new Exception("Не указано наименование трансмиссии");
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
                    dataRow["Transmission"] = TransmissionName_textBox.Text;
                }
                else
                {
                    transmissionsDataTable.AddTransmissionsRow(TransmissionName_textBox.Text);
                }
            }
        }

        private void TransmissionName_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((TransmissionName_textBox.TextLength - TransmissionName_textBox.SelectionLength) >= 10)
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
