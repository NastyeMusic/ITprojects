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
    public partial class CarriersNeedsInRepairForm : Form
    {
        public CarriersNeedsInRepairForm()
        {
            InitializeComponent();
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        bool DGVLoad = false;

        private void CarriersNeedsInRepairForm_Load(object sender, EventArgs e)
        {

        }

        private void Get_button_Click(object sender, EventArgs e)
        {
            DGVLoad = false;
            CarriersToReplacement_dataGridView.Rows.Clear();
            DateTime BeginDate = Convert.ToDateTime(DateBegin_dateTimePicker.Text).Date;
            DateTime EndDate = Convert.ToDateTime(DateEnd_dateTimePicker.Text).Date;
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
                bool NowIsNFRDate = false;
                while (TempBeginDate <= EndRepair)
                {                    
                    AutoschoolDataSet.ReplacementsCarriersDataTable ReplacementsCarriersDT = BusinessLogic.ReadReplacementsCarriersByBeginDateANDCarrierUseID(TempBeginDate, CarrierUseID).ReplacementsCarriers;
                    for (int j = 0; j < ReplacementsCarriersDT.Rows.Count; j++)
                    {
                        DateTime EndDateInRow = Convert.ToDateTime(ReplacementsCarriersDT.Rows[j]["DateEndReplacement"].ToString()).Date;
                        if (NowIsNFRDate)
                        {
                            Array.Resize(ref EndsNewRepl, EndsNewRepl.Length + 1);
                            EndsNewRepl[EndsNewRepl.Length - 1] = TempBeginDate.AddDays(-1);
                        }
                        if (EndDateInRow >= EndRepair)
                        {
                            NeedForReplacement = false;
                            break;
                        }
                        else
                        {
                            TempBeginDate = EndDateInRow;
                        }                        
                    }
                    if (ReplacementsCarriersDT.Rows.Count == 0 && !NowIsNFRDate)
                    {
                        Array.Resize(ref BeginsNewRepl, BeginsNewRepl.Length + 1);
                        BeginsNewRepl[BeginsNewRepl.Length - 1] = TempBeginDate;
                        NowIsNFRDate = true;
                    }
                    if (!NeedForReplacement)
                        break;
                    else
                        TempBeginDate = TempBeginDate.AddDays(1);
                }
                if (BeginsNewRepl.Length == 0)
                    continue;
                for (int j = 0; j < BeginsNewRepl.Length; j++)
                {
                    if (j < EndsNewRepl.Length)
                        CarriersToReplacement_dataGridView.Rows.Add(
                            CarriersUsesWithRepairingCarriers.Rows[i]["CarrierID"].ToString(),
                            CarriersUsesWithRepairingCarriers.Rows[i]["Brand"].ToString(),
                            CarriersUsesWithRepairingCarriers.Rows[i]["Model"].ToString(),
                            CarriersUsesWithRepairingCarriers.Rows[i]["StateNumber"].ToString(),
                            BeginsNewRepl[j],
                            EndsNewRepl[j],
                            CarriersUsesWithRepairingCarriers.Rows[i]["InstructorID"].ToString(),
                            CarriersUsesWithRepairingCarriers.Rows[i]["InstructorName"].ToString(),
                            CarriersUsesWithRepairingCarriers.Rows[i]["CarrierUseID"].ToString()
                            );
                    else
                        CarriersToReplacement_dataGridView.Rows.Add(
                            CarriersUsesWithRepairingCarriers.Rows[i]["CarrierID"].ToString(),
                            CarriersUsesWithRepairingCarriers.Rows[i]["Brand"].ToString(),
                            CarriersUsesWithRepairingCarriers.Rows[i]["Model"].ToString(),
                            CarriersUsesWithRepairingCarriers.Rows[i]["StateNumber"].ToString(),
                            BeginsNewRepl[j],
                            EndRepair,
                            CarriersUsesWithRepairingCarriers.Rows[i]["InstructorID"].ToString(),
                            CarriersUsesWithRepairingCarriers.Rows[i]["InstructorName"].ToString(),
                            CarriersUsesWithRepairingCarriers.Rows[i]["CarrierUseID"].ToString()
                            );
                }
            }
            DGVLoad = true;
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
                    AddReplacement_button.Enabled = true;
                }
                else
                {
                    AddReplacement_button.Enabled = false;
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
    }
}
