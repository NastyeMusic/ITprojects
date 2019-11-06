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

        AutoschoolDataSet dataSetForCarriers;
        int SelectedCarrierID = -1;
        bool FormLoad = false;

        void ReloadCarriers()
        {
            dataSetForCarriers = BusinessLogic.ReadCarriers();
            Carriers_dataGridView.DataSource = dataSetForCarriers;
            Carriers_dataGridView.DataMember = "Carriers";

            Carriers_dataGridView.Columns["ID"].Visible = false;
            Carriers_dataGridView.Columns["Brand"].Visible = false;
            Carriers_dataGridView.Columns["Model"].Visible = false;
            Carriers_dataGridView.Columns["StateNumber"].Visible = false;
            Carriers_dataGridView.Columns["Color"].Visible = false;
            Carriers_dataGridView.Columns["Transmission"].Visible = false;
            Carriers_dataGridView.Columns["Category"].Visible = false;
            Carriers_dataGridView.Columns["Status"].Visible = false;
            Carriers_dataGridView.Columns["FinalName"].Visible = false;

            IDColumn.DataPropertyName = "ID";
            BrandColumn.DataPropertyName = "Brand";
            ModelColumn.DataPropertyName = "Model";
            StateNumberColumn.DataPropertyName = "StateNumber";
            ColorColumn.DataPropertyName = "Color";

            TransmissionColumn.DataSource = dataSetForCarriers.Transmissions;
            TransmissionColumn.DisplayMember = "Transmission";
            TransmissionColumn.ValueMember = "ID";
            TransmissionColumn.DataPropertyName = "Transmission";

            CategoryColumn.DataSource = dataSetForCarriers.Categories;
            CategoryColumn.DisplayMember = "Name";
            CategoryColumn.ValueMember = "ID";
            CategoryColumn.DataPropertyName = "Category";

            StatusColumn.DataSource = dataSetForCarriers.CarriersStatuses;
            StatusColumn.DisplayMember = "Name";
            StatusColumn.ValueMember = "ID";
            StatusColumn.DataPropertyName = "Status";

            FinalNameColumn.DataPropertyName = "FinalName";

            if (Carriers_dataGridView.RowCount == 1)
            {
                Carriers_dataGridView.Rows[0].Cells["BrandColumn"].Selected = true;
                ChangeSelectedCarrier();
            }
        }

        void ChangeSelectedCarrier()
        {
            if (Carriers_dataGridView.RowCount > 0 && Carriers_dataGridView.SelectedRows.Count > 0)
            {
                int CurRow = Carriers_dataGridView.SelectedRows[0].Index;
                SelectedCarrierID = Convert.ToInt32(Carriers_dataGridView[0, CurRow].Value);
                SelectedCarrier_label.Text = Carriers_dataGridView["FinalNameColumn", CurRow].Value.ToString();
            }
            else
            {
                SelectedCarrierID = -1;
                SelectedCarrier_label.Text = "";
            }
        }

        private void AddEditCarrierUse_Load(object sender, EventArgs e)
        {
            Instructor_comboBox.DataSource = instructorsDataTable;
            Instructor_comboBox.DisplayMember = "FIO";
            Instructor_comboBox.ValueMember = "ID";
            Instructor_comboBox.AutoCompleteMode = AutoCompleteMode.Append;
            Instructor_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            ReloadCarriers();
            FormLoad = true;

            if (dataRow != null)
            {
                Instructor_comboBox.SelectedValue = dataRow["Instructor"].ToString();
                // находим ТС
                for (int i = 0; i < Carriers_dataGridView.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dataRow["Carrier"].ToString()) == Convert.ToInt32(Carriers_dataGridView["IDColumn", i].Value))
                    {
                        Carriers_dataGridView.Rows[i].Cells["BrandColumn"].Selected = true;
                        ChangeSelectedCarrier();
                        break;
                    }
                }
            }
            else
            {
                Instructor_comboBox.SelectedIndex = -1;
                Carriers_dataGridView.Rows[0].Cells["BrandColumn"].Selected = true;
                ChangeSelectedCarrier();
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
                    if (SelectedCarrierID == -1)
                    {
                        throw new Exception("Не выбрано ТС");
                    }
                    AutoschoolDataSet TempDS = new AutoschoolDataSet();
                    TempDS = BusinessLogic.ReadInstructorByID(Convert.ToInt32(Instructor_comboBox.SelectedValue.ToString()));
                    if (TempDS.Instructors[0]["WorkStatusName"].ToString() != "Работает")
                    {
                        DialogResult result = MessageBox.Show("Вы выбрали отсутствующего инструктора. Вы уверены, что хотите продолжить?", "Выбор отсутствующего сотрудника", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                        {
                            e.Cancel = true;
                            return;
                        }
                    }
                    TempDS = BusinessLogic.ReadCarriersStatusesByID(Convert.ToInt32(Carriers_dataGridView["Status", Carriers_dataGridView.SelectedRows[0].Index].Value.ToString()));
                    if (TempDS.CarriersStatuses[0][1].ToString() == "Резерв")
                    {
                        throw new Exception("Нельзя назначить инструктору в качестве постоянного ТС то, которое является резервным");
                    }
                    TempDS = BusinessLogic.ReadInstructorsCategoriesByInstructorID(Convert.ToInt32(Instructor_comboBox.SelectedValue));
                    bool Find = false;
                    for (int i = 0; i < TempDS.InstructorsCategories.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(Carriers_dataGridView["CategoryColumn", Carriers_dataGridView.SelectedRows[0].Index].Value) == Convert.ToInt32(TempDS.InstructorsCategories.Rows[i][2].ToString()))
                        {
                            Find = true;
                            break;
                        }
                    }
                    if (!Find)
                        throw new Exception("Выбранный инструктор не обладает категорией, необходимой для управления данным транспортным средством");
                    TempDS = BusinessLogic.ReadCarriersUsesByInstructorCarrierID(Convert.ToInt32(Instructor_comboBox.SelectedValue),
                        SelectedCarrierID);
                    if (dataRow == null)
                    {
                        if (TempDS.CarriersUses.Rows.Count > 0)
                            throw new Exception("Такая связка между инструктором и транспортным средством уже существует");
                    }
                    else
                    {
                        if (TempDS.CarriersUses.Rows.Count > 0 && TempDS.CarriersUses[0].ID.ToString() != dataRow[0].ToString())
                            throw new Exception("Такая связка между инструктором и транспортным средством уже существует");
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
                    dataRow["Instructor"] = Instructor_comboBox.SelectedValue;
                    dataRow["Carrier"] = SelectedCarrierID;
                }
                else
                {
                    carriersUsesDataTable.AddCarriersUsesRow(instructorsDataTable[Instructor_comboBox.SelectedIndex],
                        (AutoschoolDataSet.CarriersRow)carriersDataTable.Rows.Find(SelectedCarrierID));
                }
            }
        }

        private void Carriers_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (FormLoad)
                ChangeSelectedCarrier();
        }

        private void ReloadCarriers_button_Click(object sender, EventArgs e)
        {
            SelectedCarrierID = -1;
            ReloadCarriers();
            ChangeSelectedCarrier();
        }
    }
}
