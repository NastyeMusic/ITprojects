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
    public partial class AddRepairFromFormCarriersForm : Form
    {
        public AddRepairFromFormCarriersForm(AutoschoolDataSet.CarriersRepairsDataTable carriersRepairsDataTable,
            AutoschoolDataSet.ServiceMastersDataTable serviceMastersDataTable, AutoschoolDataSet.CarriersDataTable carriersDataTable,
            DataRow CarrierRow)
        {
            InitializeComponent();
            this.carriersRepairsDataTable = carriersRepairsDataTable;
            this.serviceMastersDataTable = serviceMastersDataTable;
            this.carriersDataTable = carriersDataTable;
            this.CarrierRow = CarrierRow;
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet.CarriersRepairsDataTable carriersRepairsDataTable;
        AutoschoolDataSet.ServiceMastersDataTable serviceMastersDataTable;
        AutoschoolDataSet.CarriersDataTable carriersDataTable;
        DataRow CarrierRow;

        AutoschoolDataSet dataSetForServiceMasters;

        int SelectedCarrierID;
        int SelectedServiceMasterID = -1;

        bool FormLoad = false;

        string LastMasterSearchingText = "";
        int LastMasterFoundRow = -1;

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

        private void AddRepairFromFormCarriersForm_Load(object sender, EventArgs e)
        {
            ReloadMasters();
            FormLoad = true;

            // устанавливаем выбранное ТС
            SelectedCarrier_label.Text = CarrierRow["FinalName"].ToString();
            SelectedCarrierID = Convert.ToInt32(CarrierRow["ID"].ToString());

            Masters_dataGridView.Rows[0].Cells["SurnameColumn"].Selected = true;
            ChangeSelectedMaster();
            Work_textBox.Text = "";
            
            BeginRepair_dateTimePicker_ValueChanged(sender, e);
        }

        private void BeginRepair_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            EndRepair_dateTimePicker.MinDate = Convert.ToDateTime(BeginRepair_dateTimePicker.Text).AddDays(1);
        }

        private void Masters_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (FormLoad)
                ChangeSelectedMaster();
        }

        private void ReloadMasters_button_Click(object sender, EventArgs e)
        {
            SelectedServiceMasterID = -1;
            ReloadMasters();
            ChangeSelectedMaster();
        }

        private void SearchMaster_button_Click(object sender, EventArgs e)
        {
            SearchingInDataGridViewClass.Search(SearchMaster_textBox, ref Masters_dataGridView, DirectionMaster_checkBox,
                ref LastMasterSearchingText, ref LastMasterFoundRow, "SurnameColumn", "FirstNameColumn", "PatronymicNameColumn");
        }

        private void SearchMaster_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Enter)
            {
                SearchMaster_button_Click(sender, e);
            }
            if ((char)e.KeyChar == (Char)Keys.Back)
            {
                LastMasterSearchingText = "";
            }
        }

        private void AddRepairFromFormCarriersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
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

                    TempDS = BusinessLogic.ReadCarriersRepairsByServiceMasterID(SelectedServiceMasterID);
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
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Ошибка");
                    e.Cancel = true;
                    return;
                }
                carriersRepairsDataTable.AddCarriersRepairsRow((AutoschoolDataSet.CarriersRow)carriersDataTable.Rows.Find(SelectedCarrierID),
                    (AutoschoolDataSet.ServiceMastersRow)serviceMastersDataTable.Rows.Find(SelectedServiceMasterID),
                    Work_textBox.Text,
                    Convert.ToDateTime(BeginRepair_dateTimePicker.Text).Date,
                    Convert.ToDateTime(EndRepair_dateTimePicker.Text).Date);
            }
        }
    }
}
