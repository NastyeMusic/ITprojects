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
    public partial class CurrentStatusesForm : Form
    {
        public CurrentStatusesForm()
        {
            InitializeComponent();
        }

        public BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet dataSetForCarriersByStatus, dataSetForCarriersByCondition, dataSetForCarriersStatuses;

        bool FormLoad = false;

        void ReloadCarriersByCarrierStatus(int StatusID)
        {
            dataSetForCarriersByStatus = BusinessLogic.ReadCarriersByStatusID(StatusID);
            CarriersByStatus_dataGridView.DataSource = dataSetForCarriersByStatus;
            CarriersByStatus_dataGridView.DataMember = "Carriers";

            CarriersByStatus_dataGridView.Columns["ID"].Visible = false;
            CarriersByStatus_dataGridView.Columns["Brand"].Visible = false;
            CarriersByStatus_dataGridView.Columns["Model"].Visible = false;
            CarriersByStatus_dataGridView.Columns["StateNumber"].Visible = false;
            CarriersByStatus_dataGridView.Columns["Color"].Visible = false;
            CarriersByStatus_dataGridView.Columns["Transmission"].Visible = false;
            CarriersByStatus_dataGridView.Columns["Category"].Visible = false;
            CarriersByStatus_dataGridView.Columns["Status"].Visible = false;
            CarriersByStatus_dataGridView.Columns["FinalName"].Visible = false;

            IDColumn.DataPropertyName = "ID";
            BrandColumn.DataPropertyName = "Brand";
            ModelColumn.DataPropertyName = "Model";
            StateNumberColumn.DataPropertyName = "StateNumber";
            ColorColumn.DataPropertyName = "Color";

            TransmissionColumn.DataSource = dataSetForCarriersByStatus.Transmissions;
            TransmissionColumn.DisplayMember = "Transmission";
            TransmissionColumn.ValueMember = "ID";
            TransmissionColumn.DataPropertyName = "Transmission";

            CategoryColumn.DataSource = dataSetForCarriersByStatus.Categories;
            CategoryColumn.DisplayMember = "Name";
            CategoryColumn.ValueMember = "ID";
            CategoryColumn.DataPropertyName = "Category";

            StatusColumn.DataSource = dataSetForCarriersByStatus.CarriersStatuses;
            StatusColumn.DisplayMember = "Name";
            StatusColumn.ValueMember = "ID";
            StatusColumn.DataPropertyName = "Status";
        }

        private void CurrentStatusesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.Perem(MainForm.FormsNames[12], false);
        }

        private void CurrentStatusesForm_Load(object sender, EventArgs e)
        {
            dataSetForCarriersStatuses = BusinessLogic.ReadCarriersStatuses();
            SelectedCarrierStatus_comboBox.DataSource = dataSetForCarriersStatuses.CarriersStatuses;
            SelectedCarrierStatus_comboBox.DisplayMember = "Name";
            SelectedCarrierStatus_comboBox.ValueMember = "ID";
            SelectedCarrierStatus_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            SelectedCarrierStatus_comboBox.AutoCompleteMode = AutoCompleteMode.Append;

            FormLoad = true;
            SelectedCarrierStatus_comboBox.SelectedIndex = -1;
        }

        private void SelectedCarrierStatus_comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (SelectedCarrierStatus_comboBox.SelectedIndex != -1 && FormLoad)
            {
                int CarrierStatusID = Convert.ToInt32(SelectedCarrierStatus_comboBox.SelectedValue);
                ReloadCarriersByCarrierStatus(CarrierStatusID);
            }
        }

        private void ReloadCarriers_button_Click(object sender, EventArgs e)
        {
            SelectedCarrierStatus_comboBox_SelectedValueChanged(sender, e);
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReloadCarriersStatuses_button_Click(object sender, EventArgs e)
        {
            FormLoad = false;
            string temp = "";
            if (SelectedCarrierStatus_comboBox.SelectedValue != null)
                temp = SelectedCarrierStatus_comboBox.SelectedValue.ToString();

            dataSetForCarriersStatuses = BusinessLogic.ReadCarriersStatuses();
            SelectedCarrierStatus_comboBox.DataSource = dataSetForCarriersStatuses.CarriersStatuses;
            SelectedCarrierStatus_comboBox.DisplayMember = "Name";
            SelectedCarrierStatus_comboBox.ValueMember = "ID";
            SelectedCarrierStatus_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            SelectedCarrierStatus_comboBox.AutoCompleteMode = AutoCompleteMode.Append;

            FormLoad = true;
            if (temp != "")
            {
                try
                {
                    SelectedCarrierStatus_comboBox.SelectedValue = temp;
                }
                catch
                {
                    SelectedCarrierStatus_comboBox.SelectedIndex = -1;
                }
            }
            else
            {
                SelectedCarrierStatus_comboBox.SelectedIndex = -1;
            }
        }                
    }
}
