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
    public partial class NeedsForReplacementPracticeLessonsForm : Form
    {
        public NeedsForReplacementPracticeLessonsForm(DateTime BeginDate, DateTime EndDate)
        {
            InitializeComponent();
            this.BeginDate = BeginDate;
            this.EndDate = EndDate;
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet dataSet;

        DateTime BeginDate;
        DateTime EndDate;

        int LastSelectionIndexInPracticeLessons;

        void ReloadPracticeLessonsNeedsForReplacement()
        {
            dataSet = BusinessLogic.ReadPracticeLessonsNeedsForReplacement(BeginDate, EndDate);
            PracticeLessonsOfStudent_dGV.DataSource = dataSet;
            PracticeLessonsOfStudent_dGV.DataMember = "PracticeLessons";

            PracticeLessonsOfStudent_dGV.Columns["ID"].Visible = false;
            PracticeLessonsOfStudent_dGV.Columns["Student"].Visible = false;
            PracticeLessonsOfStudent_dGV.Columns["AppointedDate"].Visible = false;
            PracticeLessonsOfStudent_dGV.Columns["AppointedTime"].Visible = false;
            PracticeLessonsOfStudent_dGV.Columns["FactDate"].Visible = false;
            PracticeLessonsOfStudent_dGV.Columns["FactTime"].Visible = false;
            PracticeLessonsOfStudent_dGV.Columns["StudentFIO"].Visible = false;
            PracticeLessonsOfStudent_dGV.Columns["CarrierName"].Visible = false;

            IDPLColumn.DataPropertyName = "ID";
            AppointedDateColumn.DataPropertyName = "AppointedDate";
            AppointedTimeColumn.DataPropertyName = "AppointedTime";
            FactDateColumn.DataPropertyName = "FactDate";
            FactTimeColumn.DataPropertyName = "FactTime";
            StudentColumn.DataPropertyName = "StudentFIO";

            InstructorColumn.DataSource = dataSet.Students;
            InstructorColumn.DisplayMember = "InstructorName";
            InstructorColumn.ValueMember = "ID";
            InstructorColumn.DataPropertyName = "Student";

            CarrierColumn.DataSource = dataSet.Students;
            CarrierColumn.DisplayMember = "CarrierName";
            CarrierColumn.ValueMember = "ID";
            CarrierColumn.DataPropertyName = "Student";
        }

        private void NeedsForReplacementPracticeLessonsForm_Load(object sender, EventArgs e)
        {
            ReloadPracticeLessonsNeedsForReplacement();
        }

        private void NeedsForReplacementPracticeLessonsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CarriersNeedsInRepairForm.NeedsForReplacementPracticeLessonsFormOpened = false;
        }

        private void PracticeLessonsOfStudent_dGV_SelectionChanged(object sender, EventArgs e)
        {
            if (PracticeLessonsOfStudent_dGV.SelectedRows.Count == 1)
            {
                Edit_button.Enabled = true;
            }
            else
            {
                Edit_button.Enabled = false;
            }
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndexInPracticeLessons = PracticeLessonsOfStudent_dGV.SelectedRows[0].Index;
            dataSet = BusinessLogic.ReadPracticeLessons();
            AddEditPracticeLessonForm EditPracticeLesson;
            EditPracticeLesson = new AddEditPracticeLessonForm(dataSet.PracticeLessons, dataSet.Students, null,
                dataSet.PracticeLessons.Rows.Find(PracticeLessonsOfStudent_dGV.SelectedRows[0].Cells["ID"].Value));
            EditPracticeLesson.Text = "Редактирование практического занятия";
            this.Enabled = false;
            EditPracticeLesson.ShowDialog();
            if (EditPracticeLesson.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WritePracticeLessons(dataSet);
                ReloadPracticeLessonsNeedsForReplacement();
            }
            this.Enabled = true;
        }
    }
}
