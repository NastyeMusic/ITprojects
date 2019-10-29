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
    public partial class InstructorsScheduleForm : Form
    {
        public InstructorsScheduleForm()
        {
            InitializeComponent();
        }

        public BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet dataSet, dataSetForInstructors;

        bool FormLoad = false;

        void ReloadInstructorsSchedule(int InstructorID)
        {
            if (InstructorID != -1)
            {
                dataSet = BusinessLogic.GetInstructorSchedule(InstructorID);
            }
            else
            {
                dataSet.Clear();
            }            
            InstructorsSchedule_dGV.DataSource = dataSet;
            InstructorsSchedule_dGV.DataMember = "PracticeLessons";

            InstructorsSchedule_dGV.Columns["ID"].Visible = false;
            InstructorsSchedule_dGV.Columns["Student"].Visible = false;
            InstructorsSchedule_dGV.Columns["AppointedDate"].Visible = false;
            InstructorsSchedule_dGV.Columns["AppointedTime"].Visible = false;
            InstructorsSchedule_dGV.Columns["FactDate"].Visible = false;
            InstructorsSchedule_dGV.Columns["FactTime"].Visible = false;
            InstructorsSchedule_dGV.Columns["StudentFIO"].Visible = false;
            InstructorsSchedule_dGV.Columns["CarrierName"].Visible = false;

            IDColumn.DataPropertyName = "ID";
            AppointedDateColumn.DataPropertyName = "AppointedDate";
            AppointedTimeColumn.DataPropertyName = "AppointedTime";
            FactDateColumn.DataPropertyName = "FactDate";
            FactTimeColumn.DataPropertyName = "FactTime";
            StudentFIOColumn.DataPropertyName = "StudentFIO";
            CarrierNameColumn.DataPropertyName = "CarrierName";
        }

        private void InstructorsScheduleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            MainForm.Perem(MainForm.FormsNames[15], false);
        }

        private void SelectedInstructor_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedInstructor_comboBox.SelectedIndex != -1 && FormLoad)
            {
                int InstructorID = Convert.ToInt32(SelectedInstructor_comboBox.SelectedValue);
                ReloadInstructorsSchedule(InstructorID);
            }
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReloadInstructors_button_Click(object sender, EventArgs e)
        {
            FormLoad = false;
            string temp = "";
            if (SelectedInstructor_comboBox.SelectedValue != null)
                temp = SelectedInstructor_comboBox.SelectedValue.ToString();

            dataSetForInstructors = BusinessLogic.ReadInstructors();
            SelectedInstructor_comboBox.DataSource = dataSetForInstructors.Instructors;
            SelectedInstructor_comboBox.DisplayMember = "FIO";
            SelectedInstructor_comboBox.ValueMember = "ID";
            SelectedInstructor_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            SelectedInstructor_comboBox.AutoCompleteMode = AutoCompleteMode.Append;

            FormLoad = true;
            if (temp != "")
            {
                try
                {
                    SelectedInstructor_comboBox.SelectedValue = temp;
                }
                catch
                {
                    SelectedInstructor_comboBox.SelectedIndex = -1;
                }
            }
            else
            {
                SelectedInstructor_comboBox.SelectedIndex = -1;
            }
        }

        private void InstructorsScheduleForm_Load(object sender, EventArgs e)
        {
            dataSetForInstructors = BusinessLogic.ReadInstructors();
            SelectedInstructor_comboBox.DataSource = dataSetForInstructors.Instructors;
            SelectedInstructor_comboBox.DisplayMember = "FIO";
            SelectedInstructor_comboBox.ValueMember = "ID";
            SelectedInstructor_comboBox.SelectedIndex = -1;
            SelectedInstructor_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            SelectedInstructor_comboBox.AutoCompleteMode = AutoCompleteMode.Append;

            FormLoad = true;
        }
    }
}
