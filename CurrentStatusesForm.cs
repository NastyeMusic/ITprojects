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
        AutoschoolDataSet dataSetForCarriersByStatus, dataSetForCarriersStatuses;

        bool FormLoad = false;
        CarriersNeedsInRepairForm CarriersNeedsInRepairForm;
        static public bool CarriersNeedsInRepairFormOpened = false;

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

        private void GetCarriersByCondition_button_Click(object sender, EventArgs e)
        {
            if (Condition_comboBox.SelectedItem == null)
                return;
            if (Condition_comboBox.SelectedItem.ToString() == "Занято")
            {
                CarriersByCondition_dataGridView.Rows.Clear();
                DateTime Date = Convert.ToDateTime(Date_dateTimePicker.Text).Date;
                TimeSpan Time = Convert.ToDateTime(Time_dateTimePicker.Text).TimeOfDay;

                AutoschoolDataSet TempDS = new AutoschoolDataSet();
                TempDS = BusinessLogic.ReadBusyCarriers(Date, Time, 45);
                for (int i = 0; i < TempDS.Carriers.Rows.Count; i++)
                {
                    CarriersByCondition_dataGridView.Rows.Add(TempDS.Carriers.Rows[i]["ID"], TempDS.Carriers.Rows[i]["Brand"],
                        TempDS.Carriers.Rows[i]["Model"], TempDS.Carriers.Rows[i]["StateNumber"],
                        TempDS.Carriers.Rows[i]["Color"],
                        TempDS.Transmissions.Rows.Find(TempDS.Carriers.Rows[i]["Transmission"].ToString())["Transmission"],
                        TempDS.Categories.Rows.Find(TempDS.Carriers.Rows[i]["Category"].ToString())["Name"],
                        TempDS.CarriersStatuses.Rows.Find(TempDS.Carriers.Rows[i]["Status"].ToString())["Name"]);
                }
            }
            else if (Condition_comboBox.SelectedItem.ToString() == "Свободно")
            {
                CarriersByCondition_dataGridView.Rows.Clear();
                DateTime Date = Convert.ToDateTime(Date_dateTimePicker.Text).Date;
                TimeSpan Time = Convert.ToDateTime(Time_dateTimePicker.Text).TimeOfDay;

                AutoschoolDataSet BusyCarriers = new AutoschoolDataSet();
                BusyCarriers = BusinessLogic.ReadBusyCarriers(Date, Time, 45);
                AutoschoolDataSet AllCarriers = BusinessLogic.ReadCarriers();
                bool Find;
                for (int i = 0; i < AllCarriers.Carriers.Rows.Count; i++)
                {
                    Find = false;
                    for (int j = 0; j < BusyCarriers.Carriers.Rows.Count; j++)
                    {
                        if (AllCarriers.Carriers.Rows[i]["ID"].ToString() == BusyCarriers.Carriers.Rows[j]["ID"].ToString())
                        {
                            Find = true;
                            break;
                        }
                    }
                    if (!Find)
                    {
                        CarriersByCondition_dataGridView.Rows.Add(AllCarriers.Carriers.Rows[i]["ID"], AllCarriers.Carriers.Rows[i]["Brand"],
                                AllCarriers.Carriers.Rows[i]["Model"], AllCarriers.Carriers.Rows[i]["StateNumber"],
                                AllCarriers.Carriers.Rows[i]["Color"],
                                AllCarriers.Transmissions.Rows.Find(AllCarriers.Carriers.Rows[i]["Transmission"].ToString())["Transmission"],
                                AllCarriers.Categories.Rows.Find(AllCarriers.Carriers.Rows[i]["Category"].ToString())["Name"],
                                AllCarriers.CarriersStatuses.Rows.Find(AllCarriers.Carriers.Rows[i]["Status"].ToString())["Name"]);
                    }
                }
            }
            else if (Condition_comboBox.SelectedItem.ToString() == "В ремонте")
            {
                CarriersByCondition_dataGridView.Rows.Clear();
                DateTime Date = Convert.ToDateTime(Date_dateTimePicker.Text).Date;

                AutoschoolDataSet TempDS = new AutoschoolDataSet();
                TempDS = BusinessLogic.ReadRepairingCarriers(Date);
                for (int i = 0; i < TempDS.Carriers.Rows.Count; i++)
                {
                    CarriersByCondition_dataGridView.Rows.Add(TempDS.Carriers.Rows[i]["ID"], TempDS.Carriers.Rows[i]["Brand"],
                        TempDS.Carriers.Rows[i]["Model"], TempDS.Carriers.Rows[i]["StateNumber"],
                        TempDS.Carriers.Rows[i]["Color"],
                        TempDS.Transmissions.Rows.Find(TempDS.Carriers.Rows[i]["Transmission"].ToString())["Transmission"],
                        TempDS.Categories.Rows.Find(TempDS.Carriers.Rows[i]["Category"].ToString())["Name"],
                        TempDS.CarriersStatuses.Rows.Find(TempDS.Carriers.Rows[i]["Status"].ToString())["Name"]);
                }
            }
            else if (Condition_comboBox.SelectedItem.ToString() == "Не ремонтируется")
            {
                CarriersByCondition_dataGridView.Rows.Clear();
                DateTime Date = Convert.ToDateTime(Date_dateTimePicker.Text).Date;

                AutoschoolDataSet RepairingCarriers = new AutoschoolDataSet();
                RepairingCarriers = BusinessLogic.ReadRepairingCarriers(Date);
                AutoschoolDataSet AllCarriers = BusinessLogic.ReadCarriers();
                bool Find;
                for (int i = 0; i < AllCarriers.Carriers.Rows.Count; i++)
                {
                    Find = false;
                    for (int j = 0; j < RepairingCarriers.Carriers.Rows.Count; j++)
                    {
                        if (AllCarriers.Carriers.Rows[i]["ID"].ToString() == RepairingCarriers.Carriers.Rows[j]["ID"].ToString())
                        {
                            Find = true;
                            break;
                        }
                    }
                    if (!Find)
                    {
                        CarriersByCondition_dataGridView.Rows.Add(AllCarriers.Carriers.Rows[i]["ID"], AllCarriers.Carriers.Rows[i]["Brand"],
                                AllCarriers.Carriers.Rows[i]["Model"], AllCarriers.Carriers.Rows[i]["StateNumber"],
                                AllCarriers.Carriers.Rows[i]["Color"],
                                AllCarriers.Transmissions.Rows.Find(AllCarriers.Carriers.Rows[i]["Transmission"].ToString())["Transmission"],
                                AllCarriers.Categories.Rows.Find(AllCarriers.Carriers.Rows[i]["Category"].ToString())["Name"],
                                AllCarriers.CarriersStatuses.Rows.Find(AllCarriers.Carriers.Rows[i]["Status"].ToString())["Name"]);
                    }
                }
            }
            else if (Condition_comboBox.SelectedItem.ToString() == "Свободно и не ремонтируется")
            {
                CarriersByCondition_dataGridView.Rows.Clear();
                DateTime Date = Convert.ToDateTime(Date_dateTimePicker.Text).Date;
                TimeSpan Time = Convert.ToDateTime(Time_dateTimePicker.Text).TimeOfDay;

                AutoschoolDataSet BusyCarriers = new AutoschoolDataSet();
                BusyCarriers = BusinessLogic.ReadBusyCarriers(Date, Time, 45);
                AutoschoolDataSet RepairingCarriers = new AutoschoolDataSet();
                RepairingCarriers = BusinessLogic.ReadRepairingCarriers(Date);
                AutoschoolDataSet AllCarriers = BusinessLogic.ReadCarriers();
                bool Find;
                for (int i = 0; i < AllCarriers.Carriers.Rows.Count; i++)
                {
                    Find = false;
                    for (int j = 0; j < RepairingCarriers.Carriers.Rows.Count; j++)
                    {
                        if (AllCarriers.Carriers.Rows[i]["ID"].ToString() == RepairingCarriers.Carriers.Rows[j]["ID"].ToString())
                        {
                            Find = true;
                            break;
                        }
                    }
                    for (int j = 0; j < BusyCarriers.Carriers.Rows.Count; j++)
                    {
                        if (AllCarriers.Carriers.Rows[i]["ID"].ToString() == BusyCarriers.Carriers.Rows[j]["ID"].ToString())
                        {
                            Find = true;
                            break;
                        }
                    }
                    if (!Find)
                    {
                        CarriersByCondition_dataGridView.Rows.Add(AllCarriers.Carriers.Rows[i]["ID"], AllCarriers.Carriers.Rows[i]["Brand"],
                                AllCarriers.Carriers.Rows[i]["Model"], AllCarriers.Carriers.Rows[i]["StateNumber"],
                                AllCarriers.Carriers.Rows[i]["Color"],
                                AllCarriers.Transmissions.Rows.Find(AllCarriers.Carriers.Rows[i]["Transmission"].ToString())["Transmission"],
                                AllCarriers.Categories.Rows.Find(AllCarriers.Carriers.Rows[i]["Category"].ToString())["Name"],
                                AllCarriers.CarriersStatuses.Rows.Find(AllCarriers.Carriers.Rows[i]["Status"].ToString())["Name"]);
                    }
                }
            }
        }

        private void GetCarriersNeedsInReplacement_button_Click(object sender, EventArgs e)
        {
            if (!CarriersNeedsInRepairFormOpened)
            {
                CarriersNeedsInRepairForm = new CarriersNeedsInRepairForm();
                CarriersNeedsInRepairForm.Show();
                CarriersNeedsInRepairFormOpened = true;
            }
            else
                CarriersNeedsInRepairForm.Activate();
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
