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
    public partial class CarriersNeedsInReplacementForm : Form
    {
        public CarriersNeedsInReplacementForm()
        {
            InitializeComponent();
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        bool DGVLoad = false;
        NeedsForReplacementPracticeLessonsForm NeedsForReplacementPracticeLessonsForm;
        static public bool NeedsForReplacementPracticeLessonsFormOpened = false;

        private void CarriersNeedsInRepairForm_Load(object sender, EventArgs e)
        {
            AddReplacement_button.Enabled = false;
            ChangePractiseLessons_button.Enabled = false;
            EditReplacement_button.Enabled = false;
        }

        private void Get_button_Click(object sender, EventArgs e)
        {
            DGVLoad = false;
            CarriersToReplacement_dataGridView.Rows.Clear();
            DateTime BeginDate = Convert.ToDateTime(DateBegin_dateTimePicker.Text).Date;
            DateTime EndDate = Convert.ToDateTime(DateEnd_dateTimePicker.Text).Date;
            // отбираем CarriersUses с ремонтируемыми ТС
            DataTable CarriersUsesWithRepairingCarriers = BusinessLogic.ReadCarriersUsesWithRepairingCarriers(BeginDate, EndDate).Tables["CarrierUsesWithRepairingCarriers"];
            //AutoschoolDataSet.CarriersRepairsDataTable CarriersRepairsDT = BusinessLogic.ReadCarriersRepairsByBeginEndDates(BeginDate, EndDate).CarriersRepairs;
            for (int i = 0; i < CarriersUsesWithRepairingCarriers.Rows.Count; i++)
            {                
                int CarrierUseID = Convert.ToInt32(CarriersUsesWithRepairingCarriers.Rows[i]["CarrierUseID"].ToString());
                DateTime BeginRepair = Convert.ToDateTime(CarriersUsesWithRepairingCarriers.Rows[i]["BeginDate"].ToString()).Date;
                DateTime EndRepair = Convert.ToDateTime(CarriersUsesWithRepairingCarriers.Rows[i]["EndDate"].ToString()).Date;
                DateTime TempBeginDate = BeginRepair;
                bool NeedForReplacement = true;
                //bool NeedAutoIncr = true;
                //DateTime NFRBeginDate = BeginRepair;
                //DateTime NFREndDate = EndRepair;
                DateTime[] BeginsNewRepl = new DateTime[0];
                DateTime[] EndsNewRepl = new DateTime[0];
                string[] Reason = new string[0];
                int[] ReplacementID = new int[0];
                bool NowIsNFRDate = false;
                while (TempBeginDate <= (EndRepair <= EndDate? EndRepair : EndDate))
                {
                    // проверяем, есть ли во время ремонта занятия
                    AutoschoolDataSet.PracticeLessonsDataTable PracticeLessonsDT = BusinessLogic.ReadPracticeLessonsByCarrierUseID_AND_DatesBeginEnd(CarrierUseID, TempBeginDate, (EndRepair <= EndDate ? EndRepair : EndDate)).PracticeLessons;
                    // если нет занятий, но не рассматриваем этот период
                    if (PracticeLessonsDT.Rows.Count == 0)
                        break;

                    // в дату TempBeginDate у CarriersUses отбираем замены
                        AutoschoolDataSet.ReplacementsCarriersDataTable ReplacementsCarriersDT = BusinessLogic.ReadReplacementsCarriersByBeginDateANDCarrierUseID(TempBeginDate, CarrierUseID).ReplacementsCarriers;
                    for (int j = 0; j < ReplacementsCarriersDT.Rows.Count; j++)
                    {
                        DateTime EndDateInRow = Convert.ToDateTime(ReplacementsCarriersDT.Rows[j]["DateEndReplacement"].ToString()).Date;


                        // проверяем, не находится ли в ремонте и заменяющее ТС во время замены
                        AutoschoolDataSet.CarriersRepairsDataTable ReplacementInRepairDT = BusinessLogic.ReadByCarrierID_AND_CrossInBeginEndDates(
                            Convert.ToInt32(ReplacementsCarriersDT.Rows[j]["CarrierReplacement"].ToString()),
                            TempBeginDate, EndDateInRow).CarriersRepairs;
                        // если да
                        if (ReplacementInRepairDT.Rows.Count > 0)
                        {
                            // определяем периоды, когда заменяющее ТС в ремонте
                            for (int k = 0; k < ReplacementInRepairDT.Rows.Count; k++)
                            {
                                // фиксируем начало периода отсутствия замены
                                Array.Resize(ref BeginsNewRepl, BeginsNewRepl.Length + 1);
                                if (Convert.ToDateTime(ReplacementInRepairDT.Rows[k]["BeginDate"]).Date > TempBeginDate)
                                    BeginsNewRepl[BeginsNewRepl.Length - 1] = Convert.ToDateTime(ReplacementInRepairDT.Rows[k]["BeginDate"]).Date;
                                else
                                    BeginsNewRepl[BeginsNewRepl.Length - 1] = TempBeginDate;
                                // фиксируем причину
                                Array.Resize(ref Reason, Reason.Length + 1);
                                Reason[Reason.Length - 1] = "И основное ТС, и его замена находятся в ремонте";
                                // фиксируем ID ReplacementCarrier
                                Array.Resize(ref ReplacementID, ReplacementID.Length + 1);
                                ReplacementID[ReplacementID.Length - 1] = Convert.ToInt32(ReplacementsCarriersDT.Rows[j]["ID"].ToString());
                                // фиксируем окончание этого периода
                                Array.Resize(ref EndsNewRepl, EndsNewRepl.Length + 1);
                                if (Convert.ToDateTime(ReplacementInRepairDT.Rows[k]["EndDate"]).Date > EndDateInRow)
                                    EndsNewRepl[EndsNewRepl.Length - 1] = EndDateInRow;
                                else
                                    EndsNewRepl[EndsNewRepl.Length - 1] = Convert.ToDateTime(ReplacementInRepairDT.Rows[k]["EndDate"]).Date;
                            }
                        }

                        
                        // если до этого был период отсутствия замены
                        if (NowIsNFRDate)
                        {
                            // фиксируем окончание этого периода
                            Array.Resize(ref EndsNewRepl, EndsNewRepl.Length + 1);
                            EndsNewRepl[EndsNewRepl.Length - 1] = TempBeginDate.AddDays(-1);
                            NowIsNFRDate = false;
                        }
                        if (EndDateInRow >= (EndRepair <= EndDate ? EndRepair : EndDate))
                        {
                            // замена уже есть
                            NeedForReplacement = false;
                            break;
                        }
                        else
                        {
                            TempBeginDate = EndDateInRow;
                        }                        
                    }
                    // если замены у CarrierUse с ремонтируемым ТС нет и период отсутствия замены только начался
                    if (ReplacementsCarriersDT.Rows.Count == 0 && !NowIsNFRDate)
                    {
                        // фиксируем начало периода отсутствия замены
                        Array.Resize(ref BeginsNewRepl, BeginsNewRepl.Length + 1);
                        BeginsNewRepl[BeginsNewRepl.Length - 1] = TempBeginDate;
                        // фиксируем причину
                        Array.Resize(ref Reason, Reason.Length + 1);
                        Reason[Reason.Length - 1] = "Нет замены у основного ТС";
                        NowIsNFRDate = true;
                        // фиксируем ID ReplacementCarrier
                        Array.Resize(ref ReplacementID, ReplacementID.Length + 1);
                        ReplacementID[ReplacementID.Length - 1] = -1;
                    }
                    // если замена уже есть - заканчиваем рассмотрение этой CarrierUse
                    if (!NeedForReplacement)
                        break;
                    // иначе рассматриваем следующий день
                    else
                        TempBeginDate = TempBeginDate.AddDays(1);
                }
                // если периодов отсутствия замены не было - переходим к следующей CarrierUse
                if (BeginsNewRepl.Length == 0)
                    continue;
                // выводим все периоды отсутствия замены
                for (int j = 0; j < BeginsNewRepl.Length; j++)
                {
                    if (j < EndsNewRepl.Length)
                        CarriersToReplacement_dataGridView.Rows.Add(
                            CarriersUsesWithRepairingCarriers.Rows[i]["CarrierID"].ToString(),
                            CarriersUsesWithRepairingCarriers.Rows[i]["Brand"].ToString(),
                            CarriersUsesWithRepairingCarriers.Rows[i]["Model"].ToString(),
                            CarriersUsesWithRepairingCarriers.Rows[i]["StateNumber"].ToString(),
                            BeginsNewRepl[j].Date.ToShortDateString(),
                            EndsNewRepl[j].Date.ToShortDateString(),
                            CarriersUsesWithRepairingCarriers.Rows[i]["InstructorID"].ToString(),
                            CarriersUsesWithRepairingCarriers.Rows[i]["InstructorName"].ToString(),
                            CarriersUsesWithRepairingCarriers.Rows[i]["CarrierUseID"].ToString(),
                            Reason[j],
                            ReplacementID[j]
                            );
                    else
                        CarriersToReplacement_dataGridView.Rows.Add(
                            CarriersUsesWithRepairingCarriers.Rows[i]["CarrierID"].ToString(),
                            CarriersUsesWithRepairingCarriers.Rows[i]["Brand"].ToString(),
                            CarriersUsesWithRepairingCarriers.Rows[i]["Model"].ToString(),
                            CarriersUsesWithRepairingCarriers.Rows[i]["StateNumber"].ToString(),
                            BeginsNewRepl[j].Date.ToShortDateString(),
                            (EndRepair <= EndDate ? EndRepair : EndDate).Date.ToShortDateString(),
                            CarriersUsesWithRepairingCarriers.Rows[i]["InstructorID"].ToString(),
                            CarriersUsesWithRepairingCarriers.Rows[i]["InstructorName"].ToString(),
                            CarriersUsesWithRepairingCarriers.Rows[i]["CarrierUseID"].ToString(),
                            Reason[j],
                            ReplacementID[j]
                            );
                }
            }
            DGVLoad = true;
            CarriersToReplacement_dataGridView_SelectionChanged(sender, e);
        }

        private void CarriersNeedsInRepairForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CurrentStatusesForm.CarriersNeedsInRepairFormOpened = false;
        }

        private void CarriersToReplacement_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVLoad)
            {
                if (CarriersToReplacement_dataGridView.SelectedRows.Count == 1)
                {
                    if (CarriersToReplacement_dataGridView.SelectedRows[0].Cells["ReasonColumn"].Value.ToString() == "Нет замены у основного ТС")
                    {
                        AddReplacement_button.Enabled = true;
                        EditReplacement_button.Enabled = false;
                    }
                    else
                    {
                        AddReplacement_button.Enabled = false;
                        EditReplacement_button.Enabled = true;
                    }
                    ChangePractiseLessons_button.Enabled = true;
                }
                else
                {
                    AddReplacement_button.Enabled = false;
                    ChangePractiseLessons_button.Enabled = false;
                    EditReplacement_button.Enabled = false;
                }
            }
        }

        private void AddReplacement_button_Click(object sender, EventArgs e)
        {
            AutoschoolDataSet dataSet = BusinessLogic.ReadReplacementsCarriers();
            AddReplacementFromNeedsReplacementForm AddReplacementCarrier = new AddReplacementFromNeedsReplacementForm(dataSet.ReplacementsCarriers,
                dataSet.CarriersUses, dataSet.Carriers, dataSet.Instructors, CarriersToReplacement_dataGridView.SelectedRows[0]);
            AddReplacementCarrier.Text = "Добавление замены ТС инструктора";
            this.Enabled = false;
            AddReplacementCarrier.ShowDialog();
            if (AddReplacementCarrier.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteReplacementsCarriers(dataSet);
                Get_button_Click(sender, e);
            }
            this.Enabled = true;
        }

        private void ChangePractiseLessons_button_Click(object sender, EventArgs e)
        {
            DateTime Begin = Convert.ToDateTime(CarriersToReplacement_dataGridView.SelectedRows[0].Cells["DateBeginRepair"].Value).Date;
            DateTime End = Convert.ToDateTime(CarriersToReplacement_dataGridView.SelectedRows[0].Cells["DateEndRepair"].Value).Date;
            if (!NeedsForReplacementPracticeLessonsFormOpened)
            {
                NeedsForReplacementPracticeLessonsForm = new NeedsForReplacementPracticeLessonsForm(Begin, End);
                NeedsForReplacementPracticeLessonsForm.Show();
                NeedsForReplacementPracticeLessonsFormOpened = true;
            }
            else
                NeedsForReplacementPracticeLessonsForm.Activate();
        }

        private void EditReplacement_button_Click(object sender, EventArgs e)
        {
            AutoschoolDataSet dataSet = BusinessLogic.ReadReplacementsCarriers();
            AddEditReplacementCarrierForm EditReplacementCarrier = new AddEditReplacementCarrierForm(dataSet.ReplacementsCarriers,
                dataSet.CarriersUses, dataSet.Carriers, dataSet.Instructors,
                dataSet.ReplacementsCarriers.Rows.Find(CarriersToReplacement_dataGridView.SelectedRows[0].Cells["ReplacementIDColumn"].Value));
            EditReplacementCarrier.Text = "Редактирование замены ТС инструктора";
            EditReplacementCarrier.Instructor_comboBox.Enabled = false;
            EditReplacementCarrier.ReloadInstructors_button.Enabled = false;
            EditReplacementCarrier.SearchReplaceableCarrier_button.Enabled = false;
            EditReplacementCarrier.SearchReplaceableCarrier_textBox.Enabled = false;
            EditReplacementCarrier.DirectionReplaceableCarrier_checkBox.Enabled = false;
            EditReplacementCarrier.ReloadReplaceableCarriers_button.Enabled = false;
            EditReplacementCarrier.ReplaceableCarriers_dataGridView.Enabled = false;
            this.Enabled = false;
            EditReplacementCarrier.ShowDialog();
            if (EditReplacementCarrier.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteReplacementsCarriers(dataSet);
                Get_button_Click(sender, e);
            }
            this.Enabled = true;
        }
    }
}
