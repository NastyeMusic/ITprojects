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
    public partial class AddEditCarriersStatusesForm : Form
    {
        public AddEditCarriersStatusesForm(AutoschoolDataSet.CarriersStatusesDataTable carriersStatusesDataTable, DataRow row)
        {
            InitializeComponent();
            this.carriersStatusesDataTable = carriersStatusesDataTable;
            dataRow = row;
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet.CarriersStatusesDataTable carriersStatusesDataTable;
        DataRow dataRow;

        private void AddEditCarriersStatusesForm_Load(object sender, EventArgs e)
        {
            if (dataRow != null)
            {
                CarrierStatusName_textBox.Text = dataRow["Name"].ToString();
            }
            else
            {
                CarrierStatusName_textBox.Text = "";
            }
        }

        private void AddEditCarriersStatusesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    if (CarrierStatusName_textBox.Text.Trim() == "")
                    {
                        throw new Exception("Не указано наименование статуса ТС");
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
                    dataRow["Name"] = CarrierStatusName_textBox.Text;
                }
                else
                {
                    carriersStatusesDataTable.AddCarriersStatusesRow(CarrierStatusName_textBox.Text);
                }
            }
        }

        private void CarrierStatusName_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((CarrierStatusName_textBox.TextLength - CarrierStatusName_textBox.SelectionLength) >= 10)
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
