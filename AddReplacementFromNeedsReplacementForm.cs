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
    public partial class AddReplacementFromNeedsReplacementForm : Form
    {
        public AddReplacementFromNeedsReplacementForm(AutoschoolDataSet.ReplacementsCarriersDataTable replacementsCarriersDataTable,
            AutoschoolDataSet.CarriersUsesDataTable carriersUsesDataTable, AutoschoolDataSet.CarriersDataTable carriersDataTable,
            AutoschoolDataSet.InstructorsDataTable instructorsDataTable,
            DataGridViewRow row)
        {
            InitializeComponent();
            this.replacementsCarriersDataTable = replacementsCarriersDataTable;
            this.carriersUsesDataTable = carriersUsesDataTable;
            this.carriersDataTable = carriersDataTable;
            this.instructorsDataTable = instructorsDataTable;
            dataRow = row;
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet.ReplacementsCarriersDataTable replacementsCarriersDataTable;
        AutoschoolDataSet.CarriersUsesDataTable carriersUsesDataTable;
        AutoschoolDataSet.CarriersDataTable carriersDataTable;
        AutoschoolDataSet.InstructorsDataTable instructorsDataTable;
        DataGridViewRow dataRow;

        AutoschoolDataSet dataSetForReplacingCarriers;

        int SelectedReplaceableCarrierID = -1;
        int SelectedCarrierUseID = -1;
        int SelectedReplacingCarrierID = -1;
        int SelectedInstructorID = -1;

        bool FormLoad = false;

        string LastReplacingCarrierSearchingText = "";
        int LastReplacingCarrierFoundRow = -1;

        void ReloadReplacingCarriers()
        {
            dataSetForReplacingCarriers = BusinessLogic.ReadCarriersByStatusName("Резерв");
            ReplacingCarriers_dataGridView.DataSource = dataSetForReplacingCarriers;
            ReplacingCarriers_dataGridView.DataMember = "Carriers";

            ReplacingCarriers_dataGridView.Columns["ID"].Visible = false;
            ReplacingCarriers_dataGridView.Columns["Brand"].Visible = false;
            ReplacingCarriers_dataGridView.Columns["Model"].Visible = false;
            ReplacingCarriers_dataGridView.Columns["StateNumber"].Visible = false;
            ReplacingCarriers_dataGridView.Columns["Color"].Visible = false;
            ReplacingCarriers_dataGridView.Columns["Transmission"].Visible = false;
            ReplacingCarriers_dataGridView.Columns["Category"].Visible = false;
            ReplacingCarriers_dataGridView.Columns["Status"].Visible = false;
            ReplacingCarriers_dataGridView.Columns["FinalName"].Visible = false;

            ID2Column.DataPropertyName = "ID";
            Brand2Column.DataPropertyName = "Brand";
            Model2Column.DataPropertyName = "Model";
            StateNumber2Column.DataPropertyName = "StateNumber";
            Color2Column.DataPropertyName = "Color";

            Transmission2Column.DataSource = dataSetForReplacingCarriers.Transmissions;
            Transmission2Column.DisplayMember = "Transmission";
            Transmission2Column.ValueMember = "ID";
            Transmission2Column.DataPropertyName = "Transmission";

            Category2Column.DataSource = dataSetForReplacingCarriers.Categories;
            Category2Column.DisplayMember = "Name";
            Category2Column.ValueMember = "ID";
            Category2Column.DataPropertyName = "Category";

            Status2Column.DataSource = dataSetForReplacingCarriers.CarriersStatuses;
            Status2Column.DisplayMember = "Name";
            Status2Column.ValueMember = "ID";
            Status2Column.DataPropertyName = "Status";

            if (ReplacingCarriers_dataGridView.RowCount == 1)
            {
                ReplacingCarriers_dataGridView.Rows[0].Cells["Brand2Column"].Selected = true;
                ChangeSelectedReplacingCarrier();
            }
        }

        void ChangeSelectedReplacingCarrier()
        {
            if (ReplacingCarriers_dataGridView.SelectedRows.Count > 0)
            {
                int CurRow = ReplacingCarriers_dataGridView.SelectedRows[0].Index;
                SelectedReplacingCarrierID = Convert.ToInt32(ReplacingCarriers_dataGridView[0, CurRow].Value);
                SelectedReplacingCarrier_label.Text = ReplacingCarriers_dataGridView["FinalName", CurRow].Value.ToString();
            }
            else
            {
                SelectedReplacingCarrierID = -1;
                SelectedReplacingCarrier_label.Text = "";
            }
        }

        private void AddReplacementFromNeedsReplacementForm_Load(object sender, EventArgs e)
        {
            ReloadReplacingCarriers();
            FormLoad = true;
            ChangeSelectedReplacingCarrier();

            SelectedInstructor_label.Text = dataRow.Cells["InstructorNameColumn"].Value.ToString();
            SelectedInstructorID = Convert.ToInt32(dataRow.Cells["InstructorIDColumn"].Value.ToString());
            SelectedReplaceableCarrierID = Convert.ToInt32(dataRow.Cells["CarrierIDColumn"].Value.ToString());
            SelectedCarrierUseID = Convert.ToInt32(dataRow.Cells["CarrierUseIDColumn"].Value.ToString());
            SelectedReplaceableCarrier_label.Text = dataRow.Cells["BrandColumn"].Value.ToString() + " " 
                + dataRow.Cells["ModelColumn"].Value.ToString() + " " + dataRow.Cells["StateNumberColumn"].Value.ToString();

            BeginReplacement_dateTimePicker.Text = dataRow.Cells["DateBeginRepair"].Value.ToString();
            EndReplacement_dateTimePicker.Text = dataRow.Cells["DateEndRepair"].Value.ToString();
            
            //BeginReplacement_dateTimePicker_ValueChanged(sender, e);
        }

        private void BeginReplacement_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            EndReplacement_dateTimePicker.MinDate = Convert.ToDateTime(BeginReplacement_dateTimePicker.Text).Date;
        }

        private void SearchReplacingCarrier_button_Click(object sender, EventArgs e)
        {
            SearchingInDataGridViewClass.Search(SearchReplacingCarrier_textBox, ref ReplacingCarriers_dataGridView,
                DirectionReplacingCarrier_checkBox, ref LastReplacingCarrierSearchingText, ref LastReplacingCarrierFoundRow,
                "Brand2Column", "Model2Column", "StateNumber2Column");
        }

        private void SearchReplacingCarrier_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Enter)
            {
                SearchReplacingCarrier_button_Click(sender, e);
            }
            if ((char)e.KeyChar == (Char)Keys.Back)
            {
                LastReplacingCarrierSearchingText = "";
            }
        }

        private void ReloadReplacingCarriers_button_Click(object sender, EventArgs e)
        {
            ReloadReplacingCarriers();
        }

        private void ReplacingCarriers_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (FormLoad)
                ChangeSelectedReplacingCarrier();
        }

        private void AddReplacementFromNeedsReplacementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    if (SelectedCarrierUseID == -1)
                    {
                        throw new Exception("Произошла ошибка при загрузке формы. Сохранение невозможно");
                    }
                    AutoschoolDataSet TempDS = new AutoschoolDataSet();
                    TempDS = BusinessLogic.ReadInstructorByID(SelectedInstructorID);
                    if (TempDS.Instructors[0]["WorkStatusName"].ToString() != "Работает")
                    {
                        DialogResult result = MessageBox.Show("Выбран отсутствующий инструктор. Вы уверены, что хотите продолжить?", "Выбор отсутствующего сотрудника", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                        {
                            e.Cancel = true;
                            return;
                        }
                    }
                    if (SelectedReplacingCarrierID == -1)
                    {
                        throw new Exception("Не выбрано заменяющее ТС");
                    }
                    TempDS = BusinessLogic.ReadReplacementsCarriersByCarrierUseID(Convert.ToInt32(BusinessLogic.ReadCarriersUsesByInstructorCarrierID(SelectedInstructorID, SelectedReplaceableCarrierID).CarriersUses[0]["ID"].ToString()));
                    for (int i = 0; i < TempDS.ReplacementsCarriers.Rows.Count; i++)
                    {
                        DateTime BeginReplacementInBdRow = Convert.ToDateTime(TempDS.ReplacementsCarriers.Rows[i]["DateBeginReplacement"].ToString()).Date;
                        DateTime EndReplacementInBdRow = Convert.ToDateTime(TempDS.ReplacementsCarriers.Rows[i]["DateEndReplacement"].ToString()).Date;
                        DateTime Begin = Convert.ToDateTime(BeginReplacement_dateTimePicker.Text).Date;
                        DateTime End = Convert.ToDateTime(EndReplacement_dateTimePicker.Text).Date;
                        if (BeginReplacementInBdRow > Begin && End < BeginReplacementInBdRow)
                            continue;
                        if (EndReplacementInBdRow < Begin)
                            continue;
                        else
                        {
                            throw new Exception("Выбранное заменяемое ТС у данного водителя уже заменяется в указанное время");
                        }
                    }

                    TempDS = BusinessLogic.ReadReplacementsCarriersByCarrierReplacementID(SelectedReplacingCarrierID);
                    for (int i = 0; i < TempDS.ReplacementsCarriers.Rows.Count; i++)
                    {
                        DateTime BeginReplacementInBdRow = Convert.ToDateTime(TempDS.ReplacementsCarriers.Rows[i]["DateBeginReplacement"].ToString()).Date;
                        DateTime EndReplacementInBdRow = Convert.ToDateTime(TempDS.ReplacementsCarriers.Rows[i]["DateEndReplacement"].ToString()).Date;
                        DateTime Begin = Convert.ToDateTime(BeginReplacement_dateTimePicker.Text).Date;
                        DateTime End = Convert.ToDateTime(EndReplacement_dateTimePicker.Text).Date;
                        if (BeginReplacementInBdRow > Begin && End < BeginReplacementInBdRow)
                            continue;
                        if (EndReplacementInBdRow < Begin)
                            continue;
                        else
                        {
                            throw new Exception("Выбранное заменяющее ТС уже используется в указанное время");
                        }
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Ошибка");
                    e.Cancel = true;
                    return;
                }                
                replacementsCarriersDataTable.AddReplacementsCarriersRow((AutoschoolDataSet.CarriersUsesRow)carriersUsesDataTable.Rows.Find(SelectedCarrierUseID),
                    (AutoschoolDataSet.CarriersRow)carriersDataTable.Rows.Find(SelectedReplacingCarrierID),
                    Convert.ToDateTime(BeginReplacement_dateTimePicker.Text).Date,
                    Convert.ToDateTime(EndReplacement_dateTimePicker.Text).Date);
            }
        }
    }
}
