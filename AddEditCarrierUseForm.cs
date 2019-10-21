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
    public partial class AddEditCarrierUseForm : Form
    {
        public AddEditCarrierUseForm(AutoschoolDataSet.CarriersUsesDataTable carriersUsesDataTable,
            AutoschoolDataSet.InstructorsDataTable instructorsDataTable,
            AutoschoolDataSet.CarriersDataTable carriersDataTable, DataRow row)
        {
            InitializeComponent();
            this.carriersUsesDataTable = carriersUsesDataTable;
            this.instructorsDataTable = instructorsDataTable;
            this.carriersDataTable = carriersDataTable;
            dataRow = row;
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet.CarriersUsesDataTable carriersUsesDataTable;
        AutoschoolDataSet.InstructorsDataTable instructorsDataTable;
        AutoschoolDataSet.CarriersDataTable carriersDataTable;
        DataRow dataRow;

        private void AddEditCarrierUse_Load(object sender, EventArgs e)
        {
            Instructor_comboBox.DataSource = instructorsDataTable;
            Instructor_comboBox.DisplayMember = "FIO";
            Instructor_comboBox.ValueMember = "ID";
            Instructor_comboBox.AutoCompleteMode = AutoCompleteMode.Append;

            Carrier_comboBox.DataSource = carriersDataTable;
            Carrier_comboBox.DisplayMember = "FinalName";
            Carrier_comboBox.ValueMember = "ID";
            Carrier_comboBox.AutoCompleteMode = AutoCompleteMode.Append;

            if (dataRow != null)
            {
                Instructor_comboBox.SelectedValue = dataRow["Instructor"].ToString();
                Carrier_comboBox.SelectedValue = dataRow["Carrier"].ToString();
            }
            else
            {
                Instructor_comboBox.SelectedIndex = -1;
                Carrier_comboBox.SelectedIndex = -1;
            }
        }

        private void AddEditCarrierUse_FormClosing(object sender, FormClosingEventArgs e)
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
                    if (Carrier_comboBox.SelectedIndex == -1)
                    {
                        Carrier_comboBox.Focus();
                        throw new Exception("Не выбрано ТС");
                    }
                    AutoschoolDataSet TempDS = new AutoschoolDataSet();
                    TempDS = BusinessLogic.ReadInstructorsCategoriesByInstructorID(Convert.ToInt32(Instructor_comboBox.SelectedValue));
                    bool Find = false;
                    for (int i = 0; i < TempDS.InstructorsCategories.Rows.Count; i++)
                    {
                        if (carriersDataTable[Carrier_comboBox.SelectedIndex].Category == Convert.ToInt32(TempDS.InstructorsCategories.Rows[i][2].ToString()))
                        {
                            Find = true;
                            break;
                        }
                    }
                    if (!Find)
                        throw new Exception("Выбранный инструктор не обладает категорией, необходимой для управления данным транспортным средством");
                    TempDS = BusinessLogic.ReadCarriersUsesByInstructorCarrierID(Convert.ToInt32(Instructor_comboBox.SelectedValue), 
                        Convert.ToInt32(Carrier_comboBox.SelectedValue));
                    if (TempDS.CarriersUses.Rows.Count > 0)
                        throw new Exception("Такая связка между инструктором и транспортным средством уже существует");
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
                    dataRow["Carrier"] = Carrier_comboBox.SelectedValue;
                }
                else
                {
                    carriersUsesDataTable.AddCarriersUsesRow(instructorsDataTable[Instructor_comboBox.SelectedIndex],
                        carriersDataTable[Carrier_comboBox.SelectedIndex]);
                }
            }
        }
    }
}
