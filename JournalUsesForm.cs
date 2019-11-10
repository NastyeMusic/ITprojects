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
    public partial class JournalUsesForm : Form
    {
        public JournalUsesForm()
        {
            InitializeComponent();
        }

        public BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet dataSetForCarriers, dataSetForPracticeLessons;
        string LastSearchingCarrierText = "";
        int LastFoundCarrierRow = -1;
        string LastSearchingUsageText = "";
        int LastFoundUsageRow = -1;

        bool FormLoad = false;
        bool FirstLoad = true;

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
        }

        void ReloadPracticeLessons(int CarrierID)
        {
            dataSetForPracticeLessons = BusinessLogic.GetPracticeLessonsForCarrier(CarrierID);
            PracticeLessons_dGV.DataSource = dataSetForPracticeLessons;
            PracticeLessons_dGV.DataMember = "PracticeLessons";

            PracticeLessons_dGV.Columns["ID"].Visible = false;
            PracticeLessons_dGV.Columns["Student"].Visible = false;
            PracticeLessons_dGV.Columns["AppointedDate"].Visible = false;
            PracticeLessons_dGV.Columns["AppointedTime"].Visible = false;
            PracticeLessons_dGV.Columns["FactDate"].Visible = false;
            PracticeLessons_dGV.Columns["FactTime"].Visible = false;
            PracticeLessons_dGV.Columns["StudentFIO"].Visible = false;
            PracticeLessons_dGV.Columns["CarrierName"].Visible = false;

            IDPLColumn.DataPropertyName = "ID";
            AppointedDateColumn.DataPropertyName = "AppointedDate";
            AppointedTimeColumn.DataPropertyName = "AppointedTime";
            FactDateColumn.DataPropertyName = "FactDate";
            FactTimeColumn.DataPropertyName = "FactTime";
            StudentColumn.DataPropertyName = "StudentFIO";

            InstructorColumn.DataSource = dataSetForPracticeLessons.Students;
            InstructorColumn.DisplayMember = "InstructorName";
            InstructorColumn.ValueMember = "ID";
            InstructorColumn.DataPropertyName = "Student";
        }

        private void Carriers_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (FormLoad && Carriers_dataGridView.SelectedRows.Count > 0)
                ReloadPracticeLessons(Convert.ToInt32(Carriers_dataGridView.SelectedRows[0].Cells["ID"].Value));
        }

        private void SearchCarrier_button_Click(object sender, EventArgs e)
        {
            SearchingInDataGridViewClass.Search(SearchCarrier_textBox, ref Carriers_dataGridView, DirectionCarrier_checkBox,
                ref LastSearchingCarrierText, ref LastFoundCarrierRow, "BrandColumn", "ModelColumn", "StateNumberColumn");
        }

        private void SearchCarrier_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Enter)
            {
                SearchCarrier_button_Click(sender, e);
            }
            if ((char)e.KeyChar == (Char)Keys.Back)
            {
                LastSearchingCarrierText = "";
            }
        }

        private void SearchInUsage_button_Click(object sender, EventArgs e)
        {
            SearchingInDataGridViewClass.Search(SearchInUsage_textBox, ref PracticeLessons_dGV, DirectionInUsage_checkBox,
                ref LastSearchingUsageText, ref LastFoundUsageRow, "InstructorColumn", "StudentColumn");
        }

        private void SearchInUsage_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Enter)
            {
                SearchInUsage_button_Click(sender, e);
            }
            if ((char)e.KeyChar == (Char)Keys.Back)
            {
                LastSearchingUsageText = "";
            }
        }

        private void ReloadCarriers_button_Click(object sender, EventArgs e)
        {
            FormLoad = false;
            ReloadCarriers();
            FormLoad = true;
            Carriers_dataGridView_SelectionChanged(sender, e);
        }

        private void ReloadPracticeLessons_button_Click(object sender, EventArgs e)
        {
            Carriers_dataGridView_SelectionChanged(sender, e);
        }

        private void CarriersUseJournalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.Perem(MainForm.FormsNames[11], false);
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void JournalUsesForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                if (!FirstLoad)
                    ReloadCarriers_button_Click(sender, e);
                else
                    FirstLoad = false;
            }
        }

        private void CarriersUseJournalForm_Load(object sender, EventArgs e)
        {
            ReloadCarriers();
            FormLoad = true;
            Carriers_dataGridView_SelectionChanged(sender, e);
        }
    }
}
