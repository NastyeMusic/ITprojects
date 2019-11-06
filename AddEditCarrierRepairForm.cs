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
    public partial class AddEditCarrierRepairForm : Form
    {
        public AddEditCarrierRepairForm(AutoschoolDataSet.CarriersRepairsDataTable carriersRepairsDataTable,
            AutoschoolDataSet.ServiceMastersDataTable serviceMastersDataTable, AutoschoolDataSet.CarriersDataTable carriersDataTable,
            DataRow row)
        {
            InitializeComponent();
            this.carriersRepairsDataTable = carriersRepairsDataTable;
            this.serviceMastersDataTable = serviceMastersDataTable;
            this.carriersDataTable = carriersDataTable;
            dataRow = row;
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet.CarriersRepairsDataTable carriersRepairsDataTable;
        AutoschoolDataSet.ServiceMastersDataTable serviceMastersDataTable;
        AutoschoolDataSet.CarriersDataTable carriersDataTable;
        DataRow dataRow;

        AutoschoolDataSet dataSetForCarriers, dataSetForServiceMasters;

        int SelectedCarrierID = -1;
        int SelectedServiceMasterID = -1;

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

        void ReloadMasters()
        {
            dataSetForServiceMasters = BusinessLogic.ReadServiceMasters();
            Masters_dataGridView.DataSource = dataSetForServiceMasters;
            Masters_dataGridView.DataMember = "ServiceMasters";

            Masters_dataGridView.Columns["ID"].Visible = false;
            Masters_dataGridView.Columns["Surname"].Visible = false;
            Masters_dataGridView.Columns["FirstName"].Visible = false;
            Masters_dataGridView.Columns["PatronymicName"].Visible = false;
            Masters_dataGridView.Columns["WorkStatus"].Visible = false;
            Masters_dataGridView.Columns["FIO"].Visible = false;
            Masters_dataGridView.Columns["WorkStatusName"].Visible = false;

            MastersIDColumn.DataPropertyName = "ID";
            SurnameColumn.DataPropertyName = "Surname";
            FirstNameColumn.DataPropertyName = "FirstName";
            PatronymicNameColumn.DataPropertyName = "PatronymicName";

            WorkStatusColumn.DataSource = dataSetForServiceMasters.WorkStatuses;
            WorkStatusColumn.DisplayMember = "Name";
            WorkStatusColumn.ValueMember = "ID";
            WorkStatusColumn.DataPropertyName = "WorkStatus";

            FIOColumn.DataPropertyName = "FIO";

            if (Masters_dataGridView.RowCount == 1)
            {
                Masters_dataGridView.Rows[0].Cells["SurnameColumn"].Selected = true;
                ChangeSelectedMaster();
            }
        }

        private void BeginRepair_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            EndRepair_dateTimePicker.MinDate = Convert.ToDateTime(BeginRepair_dateTimePicker.Text).AddDays(1);
        }

        private void Carriers_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (FormLoad)
                ChangeSelectedCarrier();
        }

        private void Masters_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (FormLoad)
                ChangeSelectedMaster();
        }

        private void ReloadCarriers_button_Click(object sender, EventArgs e)
        {
            SelectedCarrierID = -1;
            ReloadCarriers();
            ChangeSelectedCarrier();
        }

        private void ReloadMasters_button_Click(object sender, EventArgs e)
        {
            SelectedServiceMasterID = -1;
            ReloadMasters();
            ChangeSelectedMaster();          
        }

        private void AddEditCarrierRepairForm_Load(object sender, EventArgs e)
        {
            ReloadCarriers();
            ReloadMasters();
            FormLoad = true;
            if (dataRow != null)
            {
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

                // находим мастера сервиса
                for (int i = 0; i < Masters_dataGridView.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dataRow["Master"].ToString()) == Convert.ToInt32(Masters_dataGridView["MastersIDColumn", i].Value))
                    {
                        Masters_dataGridView.Rows[i].Cells["SurnameColumn"].Selected = true;
                        ChangeSelectedMaster();
                        break;
                    }
                }

                Work_textBox.Text = dataRow[3].ToString();
                BeginRepair_dateTimePicker.Text = dataRow["BeginDate"].ToString();
                EndRepair_dateTimePicker.Text = dataRow["EndDate"].ToString();
            }
            else
            {
                Carriers_dataGridView.Rows[0].Cells["BrandColumn"].Selected = true;
                ChangeSelectedCarrier();
                Masters_dataGridView.Rows[0].Cells["SurnameColumn"].Selected = true;
                ChangeSelectedMaster();
                Work_textBox.Text = "";
            }
            BeginRepair_dateTimePicker_ValueChanged(sender, e);
        }

        private void AddEditCarrierRepairForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {                    
                    if (SelectedCarrierID == -1)
                    {
                        throw new Exception("Не выбрано ТС для ремонта");
                    }
                    if (SelectedServiceMasterID == -1)
                    {
                        throw new Exception("Не выбран мастер, который будет заниматься ремонтом");
                    }
                    if (Work_textBox.Text == "")
                    {
                        Work_textBox.Focus();
                        throw new Exception("Не указаны проводимые работы по ремонту");
                    }                    
                    if (Masters_dataGridView["WorkStatusName", Masters_dataGridView.SelectedRows[0].Index].Value.ToString() != "Работает")
                    {
                        DialogResult result = MessageBox.Show("Вы выбрали отсутствующего мастера сервиса. Вы уверены, что хотите продолжить?", "Выбор отсутствующего сотрудника", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                        {
                            e.Cancel = true;
                            return;
                        }
                    }
                    AutoschoolDataSet TempDS = new AutoschoolDataSet();
                    TempDS = BusinessLogic.ReadCarriersRepairsByCarrierID(SelectedCarrierID);
                    if (dataRow != null)
                    {
                        for (int i = 0; i < TempDS.CarriersRepairs.Rows.Count; i++)
                        {
                            if (dataRow["ID"].ToString() == TempDS.CarriersRepairs.Rows[i]["ID"].ToString())
                                continue;
                            DateTime BeginRepairInBdRow = Convert.ToDateTime(TempDS.CarriersRepairs.Rows[i]["BeginDate"].ToString()).Date;
                            DateTime EndRepairInBdRow = Convert.ToDateTime(TempDS.CarriersRepairs.Rows[i]["EndDate"].ToString()).Date;
                            DateTime Begin = Convert.ToDateTime(BeginRepair_dateTimePicker.Text).Date;
                            DateTime End = Convert.ToDateTime(EndRepair_dateTimePicker.Text).Date;
                            if (BeginRepairInBdRow > Begin && End <= BeginRepairInBdRow)
                                continue;
                            if (EndRepairInBdRow <= Begin)
                                continue;
                            else
                            {
                                throw new Exception("Выбранное ТС уже ремонтируется в указанное время");
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < TempDS.CarriersRepairs.Rows.Count; i++)
                        {
                            DateTime BeginRepairInBdRow = Convert.ToDateTime(TempDS.CarriersRepairs.Rows[i]["BeginDate"].ToString()).Date;
                            DateTime EndRepairInBdRow = Convert.ToDateTime(TempDS.CarriersRepairs.Rows[i]["EndDate"].ToString()).Date;
                            DateTime Begin = Convert.ToDateTime(BeginRepair_dateTimePicker.Text).Date;
                            DateTime End = Convert.ToDateTime(EndRepair_dateTimePicker.Text).Date;
                            if (BeginRepairInBdRow > Begin && End <= BeginRepairInBdRow)
                                continue;
                            if (EndRepairInBdRow <= Begin)
                                continue;
                            else
                            {
                                throw new Exception("Выбранное ТС уже ремонтируется в указанное время");
                            }
                        }
                    }

                    TempDS = BusinessLogic.ReadCarriersRepairsByServiceMasterID(SelectedServiceMasterID);
                    if (dataRow != null)
                    {
                        for (int i = 0; i < TempDS.CarriersRepairs.Rows.Count; i++)
                        {
                            if (dataRow["ID"].ToString() == TempDS.CarriersRepairs.Rows[i]["ID"].ToString())
                                continue;
                            DateTime BeginRepairInBdRow = Convert.ToDateTime(TempDS.CarriersRepairs.Rows[i]["BeginDate"].ToString()).Date;
                            DateTime EndRepairInBdRow = Convert.ToDateTime(TempDS.CarriersRepairs.Rows[i]["EndDate"].ToString()).Date;
                            DateTime Begin = Convert.ToDateTime(BeginRepair_dateTimePicker.Text).Date;
                            DateTime End = Convert.ToDateTime(EndRepair_dateTimePicker.Text).Date;
                            if (BeginRepairInBdRow > Begin && End <= BeginRepairInBdRow)
                                continue;
                            if (EndRepairInBdRow <= Begin)
                                continue;
                            else
                            {
                                throw new Exception("Выбранный мастер сервиса в указанное время уже занят");
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < TempDS.CarriersRepairs.Rows.Count; i++)
                        {
                            DateTime BeginRepairInBdRow = Convert.ToDateTime(TempDS.CarriersRepairs.Rows[i]["BeginDate"].ToString()).Date;
                            DateTime EndRepairInBdRow = Convert.ToDateTime(TempDS.CarriersRepairs.Rows[i]["EndDate"].ToString()).Date;
                            DateTime Begin = Convert.ToDateTime(BeginRepair_dateTimePicker.Text).Date;
                            DateTime End = Convert.ToDateTime(EndRepair_dateTimePicker.Text).Date;
                            if (BeginRepairInBdRow > Begin && End <= BeginRepairInBdRow)
                                continue;
                            if (EndRepairInBdRow <= Begin)
                                continue;
                            else
                            {
                                throw new Exception("Выбранный мастер сервиса в указанное время уже занят");
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
                    dataRow["Carrier"] = SelectedCarrierID;
                    dataRow["Master"] = SelectedServiceMasterID;
                    dataRow["Work"] = Work_textBox.Text;
                    dataRow["DateBeginReplacement"] = Convert.ToDateTime(BeginRepair_dateTimePicker.Text).Date;
                    dataRow["DateEndReplacement"] = Convert.ToDateTime(EndRepair_dateTimePicker.Text).Date;
                }
                else
                {
                    carriersRepairsDataTable.AddCarriersRepairsRow((AutoschoolDataSet.CarriersRow)carriersDataTable.Rows.Find(SelectedCarrierID),
                        (AutoschoolDataSet.ServiceMastersRow)serviceMastersDataTable.Rows.Find(SelectedServiceMasterID),
                        Work_textBox.Text,
                        Convert.ToDateTime(BeginRepair_dateTimePicker.Text).Date,
                        Convert.ToDateTime(EndRepair_dateTimePicker.Text).Date);
                }
            }
        }

        void ChangeSelectedMaster()
        {
            if (Masters_dataGridView.RowCount > 0 && Masters_dataGridView.SelectedRows.Count > 0)
            {
                int CurRow = Masters_dataGridView.SelectedRows[0].Index;
                SelectedServiceMasterID = Convert.ToInt32(Masters_dataGridView[0, CurRow].Value);
                SelectedMaster_label.Text = Masters_dataGridView["FIO", CurRow].Value.ToString();
            }
            else
            {
                SelectedServiceMasterID = -1;
                SelectedMaster_label.Text = "";
            }
        }
    }
}
