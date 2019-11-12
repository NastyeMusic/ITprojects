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
        AutoschoolDataSet dataSetForPracticeLessons, dataSetForInstructors;

        bool FormLoad = false;

        void ReloadInstructorsSchedule(int InstructorID)
        {
            InstructorsSchedule_dGV.Rows.Clear();
            // берем все занятия, связанные с инструктором
            dataSetForPracticeLessons = BusinessLogic.GetInstructorSchedule(InstructorID);
            // для каждого практического занятия ищем замены ТС по дате
            // сначала смотрим фактическую дату, если она пустая - то назначенную
            // если замены есть - берем машину из замены, иначе - из CarrierUse
            for (int i = 0; i < dataSetForPracticeLessons.PracticeLessons.Rows.Count; i++)
            {
                DateTime LessonTime = Convert.ToDateTime((dataSetForPracticeLessons.PracticeLessons.Rows[i]["FactDate"].ToString() != "01.01.0001 0:00:00") ?
                        dataSetForPracticeLessons.PracticeLessons.Rows[i]["FactDate"].ToString() :
                        dataSetForPracticeLessons.PracticeLessons.Rows[i]["AppointedDate"].ToString()).Date;
                int CarrierUseID = Convert.ToInt32(dataSetForPracticeLessons.Students.Rows.Find(dataSetForPracticeLessons.PracticeLessons.Rows[i]["Student"].ToString())["CarrierUse"].ToString());
                AutoschoolDataSet TempDS = BusinessLogic.ReadReplacementsCarriersByLessonDateANDCarrierUseID(LessonTime, CarrierUseID);
                if (TempDS.ReplacementsCarriers.Rows.Count == 0)
                {
                    InstructorsSchedule_dGV.Rows.Add(
                        dataSetForPracticeLessons.PracticeLessons.Rows[i]["ID"],
                        Convert.ToDateTime(dataSetForPracticeLessons.PracticeLessons.Rows[i]["AppointedDate"]).ToShortDateString(),
                        dataSetForPracticeLessons.PracticeLessons.Rows[i]["AppointedTime"],
                        (dataSetForPracticeLessons.PracticeLessons.Rows[i]["FactDate"].ToString() != "01.01.0001 0:00:00"
                        ? Convert.ToDateTime(dataSetForPracticeLessons.PracticeLessons.Rows[i]["FactDate"].ToString()).ToShortDateString() : ""),
                        (dataSetForPracticeLessons.PracticeLessons.Rows[i]["FactDate"].ToString() != "01.01.0001 0:00:00"
                        ? dataSetForPracticeLessons.PracticeLessons.Rows[i]["FactTime"] : ""),
                        dataSetForPracticeLessons.PracticeLessons.Rows[i]["StudentFIO"],
                        dataSetForPracticeLessons.PracticeLessons.Rows[i]["CarrierName"]                        
                        );
                }
                else
                {
                    InstructorsSchedule_dGV.Rows.Add(
                        dataSetForPracticeLessons.PracticeLessons.Rows[i]["ID"],
                        Convert.ToDateTime(dataSetForPracticeLessons.PracticeLessons.Rows[i]["AppointedDate"]).ToShortDateString(),
                        dataSetForPracticeLessons.PracticeLessons.Rows[i]["AppointedTime"],
                        (dataSetForPracticeLessons.PracticeLessons.Rows[i]["FactDate"].ToString() != "01.01.0001 0:00:00"
                        ? Convert.ToDateTime(dataSetForPracticeLessons.PracticeLessons.Rows[i]["FactDate"].ToString()).ToShortDateString() : ""),
                        (dataSetForPracticeLessons.PracticeLessons.Rows[i]["FactDate"].ToString() != "01.01.0001 0:00:00"
                        ? dataSetForPracticeLessons.PracticeLessons.Rows[i]["FactTime"] : ""),
                        dataSetForPracticeLessons.PracticeLessons.Rows[i]["StudentFIO"],
                        dataSetForPracticeLessons.Carriers.Rows.Find(TempDS.ReplacementsCarriers.Rows[0]["CarrierReplacement"])["FinalName"].ToString()                        
                        );
                }
            }


            /*dataSetForPracticeLessons = BusinessLogic.GetInstructorSchedule(InstructorID);
            InstructorsSchedule_dGV.DataSource = dataSetForPracticeLessons;
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
            CarrierNameColumn.DataPropertyName = "CarrierName";*/
        }

        private void InstructorsScheduleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
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
