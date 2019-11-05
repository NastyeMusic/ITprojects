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
    public partial class AddEditReplacementCarrierForm : Form
    {
        public AddEditReplacementCarrierForm(AutoschoolDataSet.ReplacementsCarriersDataTable replacementsCarriersDataTable,
            AutoschoolDataSet.CarriersUsesDataTable carriersUsesDataTable, AutoschoolDataSet.CarriersDataTable carriersDataTable,
            AutoschoolDataSet.InstructorsDataTable instructorsDataTable, 
            DataRow row)
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
        DataRow dataRow;

        AutoschoolDataSet dataSetForReplaceableCarriers, dataSetForReplacingCarriers, dataSetForInstructorsComboBox;

        int SelectedReplaceableCarrierID = -1;
        int SelectedReplacingCarrierID = -1;

        bool FormLoad = false;

        void ReloadReplaceableCarriers(int InstructorID)
        {
            ReplaceableCarriers_dataGridView.Rows.Clear();
            dataSetForReplaceableCarriers = BusinessLogic.ReadCarriersByInstructorID(InstructorID);
            // заполняем dataGridView
            for (int i = 0; i < dataSetForReplaceableCarriers.Carriers.Rows.Count; i++)
            {
                ReplaceableCarriers_dataGridView.Rows.Add(dataSetForReplaceableCarriers.Carriers[i]["ID"],
                    dataSetForReplaceableCarriers.Carriers[i]["Brand"],
                    dataSetForReplaceableCarriers.Carriers[i]["Model"],
                    dataSetForReplaceableCarriers.Carriers[i]["StateNumber"],
                    dataSetForReplaceableCarriers.Carriers[i]["Color"],
                    dataSetForReplaceableCarriers.Transmissions.Rows.Find(dataSetForReplaceableCarriers.Carriers[i]["Transmission"])["Transmission"],
                    dataSetForReplaceableCarriers.Categories.Rows.Find(dataSetForReplaceableCarriers.Carriers[i]["Category"])["Name"],
                    dataSetForReplaceableCarriers.CarriersStatuses.Rows.Find(dataSetForReplaceableCarriers.Carriers[i]["Status"])["Name"],
                    dataSetForReplaceableCarriers.Carriers[i]["FinalName"]);
            }

            /*ReplaceableCarriers_dataGridView.DataSource = dataSetForReplaceableCarriers;
            ReplaceableCarriers_dataGridView.DataMember = "Carriers";

            ReplaceableCarriers_dataGridView.Columns["ID"].Visible = false;
            ReplaceableCarriers_dataGridView.Columns["Brand"].Visible = false;
            ReplaceableCarriers_dataGridView.Columns["Model"].Visible = false;
            ReplaceableCarriers_dataGridView.Columns["StateNumber"].Visible = false;
            ReplaceableCarriers_dataGridView.Columns["Color"].Visible = false;
            ReplaceableCarriers_dataGridView.Columns["Transmission"].Visible = false;
            ReplaceableCarriers_dataGridView.Columns["Category"].Visible = false;
            ReplaceableCarriers_dataGridView.Columns["Status"].Visible = false;
            ReplaceableCarriers_dataGridView.Columns["FinalName"].Visible = false;

            ID1Column.DataPropertyName = "ID";
            Brand1Column.DataPropertyName = "Brand";
            Model1Column.DataPropertyName = "Model";
            StateNumber1Column.DataPropertyName = "StateNumber";
            Color1Column.DataPropertyName = "Color";

            Transmission1Column.DataSource = dataSetForReplaceableCarriers.Transmissions;
            Transmission1Column.DisplayMember = "Transmission";
            Transmission1Column.ValueMember = "ID";
            Transmission1Column.DataPropertyName = "Transmission";

            Category1Column.DataSource = dataSetForReplaceableCarriers.Categories;
            Category1Column.DisplayMember = "Name";
            Category1Column.ValueMember = "ID";
            Category1Column.DataPropertyName = "Category";

            Status1Column.DataSource = dataSetForReplaceableCarriers.CarriersStatuses;
            Status1Column.DisplayMember = "Name";
            Status1Column.ValueMember = "ID";
            Status1Column.DataPropertyName = "Status";
            */
        }

        private void BeginReplacement_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            EndReplacement_dateTimePicker.MinDate = Convert.ToDateTime(BeginReplacement_dateTimePicker.Text).AddDays(1);
        }

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

        void ChangeSelectedReplaceableCarrier()
        {
            if (ReplaceableCarriers_dataGridView.RowCount > 0 && ReplaceableCarriers_dataGridView.SelectedRows.Count > 0)
            {
                int CurRow = ReplaceableCarriers_dataGridView.SelectedRows[0].Index;
                SelectedReplaceableCarrierID = Convert.ToInt32(ReplaceableCarriers_dataGridView[0, CurRow].Value);
                SelectedReplaceableCarrier_label.Text = ReplaceableCarriers_dataGridView["FinalName", CurRow].Value.ToString();
            }
        }

        private void AddEditReplacementCarrierForm_FormClosing(object sender, FormClosingEventArgs e)
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
                    if (SelectedReplaceableCarrierID  == -1)
                    {
                        throw new Exception("Не выбрано заменяемое ТС");
                    }
                    if (SelectedReplacingCarrierID == -1)
                    {
                        throw new Exception("Не выбрано заменяющее ТС");
                    }
                    AutoschoolDataSet TempDS = new AutoschoolDataSet();
                    TempDS = BusinessLogic.ReadReplacementsCarriersByCarrierUseID(Convert.ToInt32(BusinessLogic.ReadCarriersUsesByInstructorCarrierID(Convert.ToInt32(Instructor_comboBox.SelectedValue), Convert.ToInt32(ReplaceableCarriers_dataGridView.SelectedRows[0].Cells["ID1Column"].Value)).CarriersUses[0]["ID"].ToString()));
                    if (dataRow != null)
                    {
                        for (int i = 0; i < TempDS.ReplacementsCarriers.Rows.Count; i++)
                        {
                            if (dataRow["ID"].ToString() == TempDS.ReplacementsCarriers.Rows[i]["ID"].ToString())
                                continue;
                            DateTime BeginReplacementInBdRow = Convert.ToDateTime(TempDS.ReplacementsCarriers.Rows[i]["DateBeginReplacement"].ToString()).Date;
                            DateTime EndReplacementInBdRow = Convert.ToDateTime(TempDS.ReplacementsCarriers.Rows[i]["DateEndReplacement"].ToString()).Date;
                            DateTime Begin = Convert.ToDateTime(BeginReplacement_dateTimePicker.Text).Date;
                            DateTime End = Convert.ToDateTime(EndReplacement_dateTimePicker.Text).Date;
                            if (BeginReplacementInBdRow > Begin && End <= BeginReplacementInBdRow)
                                continue;
                            if (EndReplacementInBdRow <= Begin)
                                continue;
                            else
                            {
                                throw new Exception("Выбранное заменяемое ТС у данного водителя уже заменяется в указанное время");
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < TempDS.ReplacementsCarriers.Rows.Count; i++)
                        {
                            DateTime BeginReplacementInBdRow = Convert.ToDateTime(TempDS.ReplacementsCarriers.Rows[i]["DateBeginReplacement"].ToString()).Date;
                            DateTime EndReplacementInBdRow = Convert.ToDateTime(TempDS.ReplacementsCarriers.Rows[i]["DateEndReplacement"].ToString()).Date;
                            DateTime Begin = Convert.ToDateTime(BeginReplacement_dateTimePicker.Text).Date;
                            DateTime End = Convert.ToDateTime(EndReplacement_dateTimePicker.Text).Date;
                            if (BeginReplacementInBdRow > Begin && End <= BeginReplacementInBdRow)
                                continue;
                            if (EndReplacementInBdRow <= Begin)
                                continue;
                            else
                            {
                                throw new Exception("Выбранное заменяемое ТС у данного водителя уже заменяется в указанное время");
                            }
                        }
                    }
                    
                    TempDS = BusinessLogic.ReadReplacementsCarriersByCarrierReplacementID(SelectedReplacingCarrierID);
                    if (dataRow != null)
                    {
                        for (int i = 0; i < TempDS.ReplacementsCarriers.Rows.Count; i++)
                        {
                            if (dataRow["ID"].ToString() == TempDS.ReplacementsCarriers.Rows[i]["ID"].ToString())
                                continue;
                            DateTime BeginReplacementInBdRow = Convert.ToDateTime(TempDS.ReplacementsCarriers.Rows[i]["DateBeginReplacement"].ToString()).Date;
                            DateTime EndReplacementInBdRow = Convert.ToDateTime(TempDS.ReplacementsCarriers.Rows[i]["DateEndReplacement"].ToString()).Date;
                            DateTime Begin = Convert.ToDateTime(BeginReplacement_dateTimePicker.Text).Date;
                            DateTime End = Convert.ToDateTime(EndReplacement_dateTimePicker.Text).Date;
                            if (BeginReplacementInBdRow > Begin && End <= BeginReplacementInBdRow)
                                continue;
                            if (EndReplacementInBdRow <= Begin)
                                continue;
                            else
                            {
                                throw new Exception("Выбранное заменяющее ТС уже используется в указанное время");
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < TempDS.ReplacementsCarriers.Rows.Count; i++)
                        {
                            DateTime BeginReplacementInBdRow = Convert.ToDateTime(TempDS.ReplacementsCarriers.Rows[i]["DateBeginReplacement"].ToString()).Date;
                            DateTime EndReplacementInBdRow = Convert.ToDateTime(TempDS.ReplacementsCarriers.Rows[i]["DateEndReplacement"].ToString()).Date;
                            DateTime Begin = Convert.ToDateTime(BeginReplacement_dateTimePicker.Text).Date;
                            DateTime End = Convert.ToDateTime(EndReplacement_dateTimePicker.Text).Date;
                            if (BeginReplacementInBdRow > Begin && End <= BeginReplacementInBdRow)
                                continue;
                            if (EndReplacementInBdRow <= Begin)
                                continue;
                            else
                            {
                                throw new Exception("Выбранное заменяющее ТС уже используется в указанное время");
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
                int CarrierUseID = Convert.ToInt32(BusinessLogic.ReadCarriersUsesByInstructorCarrierID(Convert.ToInt32(Instructor_comboBox.SelectedValue), Convert.ToInt32(ReplaceableCarriers_dataGridView.SelectedRows[0].Cells["ID1Column"].Value)).CarriersUses[0]["ID"].ToString());
                if (dataRow != null)
                {
                    dataRow["CarrierUse"] = CarrierUseID;
                    dataRow["CarrierReplacement"] = SelectedReplacingCarrierID;
                    dataRow["DateBeginReplacement"] = Convert.ToDateTime(BeginReplacement_dateTimePicker.Text).Date;
                    dataRow["DateEndReplacement"] = Convert.ToDateTime(EndReplacement_dateTimePicker.Text).Date;
                }
                else
                {
                    replacementsCarriersDataTable.AddReplacementsCarriersRow((AutoschoolDataSet.CarriersUsesRow)carriersUsesDataTable.Rows.Find(CarrierUseID),
                        (AutoschoolDataSet.CarriersRow)carriersDataTable.Rows.Find(SelectedReplacingCarrierID), 
                        Convert.ToDateTime(BeginReplacement_dateTimePicker.Text).Date,
                        Convert.ToDateTime(EndReplacement_dateTimePicker.Text).Date);
                }
            }
        }

        private void ReplaceableCarriers_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (FormLoad)
                ChangeSelectedReplaceableCarrier();
        }

        void InstructorChanged()
        {
            if (Instructor_comboBox.SelectedIndex != -1 && FormLoad)
            {
                // отбираем ТС, прикрепленные к выбранному инструктору
                ReloadReplaceableCarriers(Convert.ToInt32(Instructor_comboBox.SelectedValue));                
                if (ReplaceableCarriers_dataGridView.RowCount == 0)
                {
                    MessageBox.Show("У выбранного инструктора отсутствуют прикрепленные ТС. \nДо тех пор, пока инструктору не будет прикреплено хотя бы одно ТС, добавление замены ТС этого инструктора невозможно.", "Ошибка");
                }
            }
            else
            {
                ReplaceableCarriers_dataGridView.Rows.Clear();
            }
            SelectedReplaceableCarrier_label.Text = "";
            SelectedReplaceableCarrierID = -1;
            if (ReplaceableCarriers_dataGridView.RowCount == 1)
            {
                ReplaceableCarriers_dataGridView.Rows[0].Cells["Brand1Column"].Selected = true;
                ChangeSelectedReplaceableCarrier();
            }
        }

        private void Instructor_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormLoad)
                InstructorChanged();
        }

        private void ReplacingCarriers_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (FormLoad)
                ChangeSelectedReplacingCarrier();
        }

        private void ReloadInstructors_button_Click(object sender, EventArgs e)
        {
            instructorsDataTable = BusinessLogic.ReadInstructors().Instructors;
        }

        private void ReloadReplaceableCarriers_button_Click(object sender, EventArgs e)
        {
            InstructorChanged();
            ChangeSelectedReplaceableCarrier();
        }

        private void ReloadReplacingCarriers_button_Click(object sender, EventArgs e)
        {
            ChangeSelectedReplacingCarrier();
        }

        void ChangeSelectedReplacingCarrier()
        {
            if (ReplacingCarriers_dataGridView.SelectedRows.Count > 0)
            {
                int CurRow = ReplacingCarriers_dataGridView.SelectedRows[0].Index;
                SelectedReplacingCarrierID = Convert.ToInt32(ReplacingCarriers_dataGridView[0, CurRow].Value);
                SelectedReplacingCarrier_label.Text = ReplacingCarriers_dataGridView["FinalName", CurRow].Value.ToString();
            }
        }

        private void AddEditReplacementCarrierForm_Load(object sender, EventArgs e)
        {
            Instructor_comboBox.DataSource = instructorsDataTable;
            Instructor_comboBox.DisplayMember = "FIO";
            Instructor_comboBox.ValueMember = "ID";
            Instructor_comboBox.AutoCompleteMode = AutoCompleteMode.Append;
            Instructor_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
                        
            ReloadReplacingCarriers();
            FormLoad = true;

            if (dataRow != null)
            {
                int InstructorID = Convert.ToInt32(BusinessLogic.ReadCarriersUsesByID(Convert.ToInt32(dataRow[1].ToString())).CarriersUses.Rows[0][1].ToString());
                Instructor_comboBox.SelectedValue = InstructorID;
                ReloadReplaceableCarriers(InstructorID);
                // получаем ТС из CarrierUses
                int CarrierID = Convert.ToInt32(carriersUsesDataTable.Rows.Find(dataRow["ID"].ToString())[2].ToString());
                // находим ТС среди заменяемых
                if (ReplaceableCarriers_dataGridView.Rows.Count > 0)
                {
                    for (int i = 0; i < ReplaceableCarriers_dataGridView.Rows.Count; i++)
                    {
                        if (CarrierID == Convert.ToInt32(ReplaceableCarriers_dataGridView["ID1Column", i].Value))
                        {
                            ReplaceableCarriers_dataGridView.Rows[i].Selected = true;
                            ChangeSelectedReplaceableCarrier();
                            break;
                        }
                    }
                }
                // находим ТС среди заменяющих
                if (ReplacingCarriers_dataGridView.Rows.Count > 0)
                {
                    for (int i = 0; i < ReplacingCarriers_dataGridView.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(dataRow["CarrierReplacement"].ToString()) == Convert.ToInt32(ReplacingCarriers_dataGridView["ID2Column", i].Value))
                        {
                            ReplacingCarriers_dataGridView.Rows[i].Selected = true;
                            ChangeSelectedReplaceableCarrier();
                            break;
                        }
                    }
                }

                BeginReplacement_dateTimePicker.Text = dataRow["DateBeginReplacement"].ToString();
                EndReplacement_dateTimePicker.Text = dataRow["DateEndReplacement"].ToString();
            }
            else
            {
                Instructor_comboBox.SelectedIndex = -1;
                ReplaceableCarriers_dataGridView.CurrentCell = null;
                ReplacingCarriers_dataGridView.CurrentCell = null;
            }
            BeginReplacement_dateTimePicker_ValueChanged(sender, e);
        }
    }
}
