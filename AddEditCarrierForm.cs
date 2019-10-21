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
    public partial class AddEditCarrierForm : Form
    {
        public AddEditCarrierForm(AutoschoolDataSet.CarriersDataTable carriersDataTable,
            AutoschoolDataSet.CategoriesDataTable categoriesDataTable, 
            AutoschoolDataSet.CarriersStatusesDataTable carriersStatusesDataTable,
            AutoschoolDataSet.TransmissionsDataTable transmissionsDataTable, DataRow row)
        {
            InitializeComponent();
            this.carriersDataTable = carriersDataTable;
            this.categoriesDataTable = categoriesDataTable;
            this.carriersStatusesDataTable = carriersStatusesDataTable;
            this.transmissionsDataTable = transmissionsDataTable;
            dataRow = row;
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet.CarriersDataTable carriersDataTable;
        AutoschoolDataSet.CategoriesDataTable categoriesDataTable;
        AutoschoolDataSet.CarriersStatusesDataTable carriersStatusesDataTable;
        AutoschoolDataSet.TransmissionsDataTable transmissionsDataTable;

        DataRow dataRow;

        private void AddEditCarrierForm_Load(object sender, EventArgs e)
        {
            Transmission_comboBox.DataSource = transmissionsDataTable;
            Transmission_comboBox.DisplayMember = "Transmission";
            Transmission_comboBox.ValueMember = "ID";
            Transmission_comboBox.AutoCompleteMode = AutoCompleteMode.Append;

            Category_comboBox.DataSource = categoriesDataTable;
            Category_comboBox.DisplayMember = "Name";
            Category_comboBox.ValueMember = "ID";
            Category_comboBox.AutoCompleteMode = AutoCompleteMode.Append;

            Status_comboBox.DataSource = carriersStatusesDataTable;
            Status_comboBox.DisplayMember = "Name";
            Status_comboBox.ValueMember = "ID";
            Status_comboBox.AutoCompleteMode = AutoCompleteMode.Append;

            if (dataRow != null)
            {
                Brand_textBox.Text = dataRow["Brand"].ToString();
                Model_textBox.Text = dataRow["Model"].ToString();
                StateNumber_textBox.Text = dataRow["StateNumber"].ToString();
                Color_textBox.Text = dataRow["Color"].ToString();
                Transmission_comboBox.SelectedValue = dataRow["Transmission"].ToString();
                Category_comboBox.SelectedValue = dataRow["Category"].ToString();
                Status_comboBox.SelectedValue = dataRow["Status"].ToString();
            }
            else
            {
                Brand_textBox.Text = "";
                Model_textBox.Text = "";
                StateNumber_textBox.Text = "";
                Color_textBox.Text = "";
                Transmission_comboBox.SelectedIndex = -1;
                Category_comboBox.SelectedIndex = -1;
                Status_comboBox.SelectedIndex = -1;
            }
        }

        private void AddEditCarrierForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    if (Brand_textBox.Text.Trim() == "")
                    {
                        Brand_textBox.Focus();
                        throw new Exception("Не указана марка транспортного средства");
                    }
                    if (Model_textBox.Text.Trim() == "")
                    {
                        Model_textBox.Focus();
                        throw new Exception("Не указана модель транспортного средства");
                    }
                    if (StateNumber_textBox.Text.Trim() == "")
                    {
                        StateNumber_textBox.Focus();
                        throw new Exception("Не указан государственный регистрационный номер транспортного средства");
                    }
                    if (Color_textBox.Text.Trim() == "")
                    {
                        Color_textBox.Focus();
                        throw new Exception("Не указан цвет транспортного средства");
                    }
                    if (Transmission_comboBox.SelectedIndex == -1)
                    {
                        Transmission_comboBox.Focus();
                        throw new Exception("Не выбрана трансмиссия транспортного средства");
                    }
                    if (Category_comboBox.SelectedIndex == -1)
                    {
                        Category_comboBox.Focus();
                        throw new Exception("Не выбрана категория транспортного средства");
                    }
                    if (Status_comboBox.SelectedIndex == -1)
                    {
                        Status_comboBox.Focus();
                        throw new Exception("Не выбран статус транспортного средства");
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
                    dataRow["Brand"] = Brand_textBox.Text;
                    dataRow["Model"] = Model_textBox.Text;
                    dataRow["StateNumber"] = StateNumber_textBox.Text;
                    dataRow["Color"] = Color_textBox.Text;
                    dataRow["Transmission"] = Transmission_comboBox.SelectedValue;
                    dataRow["Category"] = Category_comboBox.SelectedValue;
                    dataRow["Status"] = Status_comboBox.SelectedValue;
                }
                else
                {
                    carriersDataTable.AddCarriersRow(Brand_textBox.Text, Model_textBox.Text, StateNumber_textBox.Text, Color_textBox.Text,
                        transmissionsDataTable[Transmission_comboBox.SelectedIndex], categoriesDataTable[Category_comboBox.SelectedIndex],
                        carriersStatusesDataTable[Status_comboBox.SelectedIndex]);                    
                }
            }
        }

        private void Brand_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Brand_textBox.TextLength - Brand_textBox.SelectionLength) >= 50 && (char)e.KeyChar != (Char)Keys.Back)
                e.Handled = true;
            else
            {
                if ((char)e.KeyChar == (Char)Keys.Back) return;
                if ((char)e.KeyChar == (Char)Keys.Space) return;
                if ((char)e.KeyChar == (Char)Keys.ControlKey) return;
                if (char.IsLetter(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void Color_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Color_textBox.TextLength - Color_textBox.SelectionLength) >= 50 && (char)e.KeyChar != (Char)Keys.Back)
                e.Handled = true;
            else
            {
                if ((char)e.KeyChar == (Char)Keys.Back) return;
                if ((char)e.KeyChar == (Char)Keys.ControlKey) return;
                if (char.IsLetter(e.KeyChar)) return;
                if (e.KeyChar == '-') return;
                e.Handled = true;
            }
        }

        private void StateNumber_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((StateNumber_textBox.TextLength - StateNumber_textBox.SelectionLength) >= 15 && (char)e.KeyChar != (Char)Keys.Back)
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

        private void Model_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Model_textBox.TextLength - Model_textBox.SelectionLength) >= 50 && (char)e.KeyChar != (Char)Keys.Back)
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
