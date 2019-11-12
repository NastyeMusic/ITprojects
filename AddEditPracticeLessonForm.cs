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
    public partial class AddEditPracticeLessonForm : Form
    {
        public AddEditPracticeLessonForm(AutoschoolDataSet.PracticeLessonsDataTable practiceLessonsDataTable, 
            AutoschoolDataSet.StudentsDataTable studentsDataTable, 
            DataRow SelectedStudent,
            DataRow row)
        {
            InitializeComponent();
            this.practiceLessonsDataTable = practiceLessonsDataTable;
            this.studentsDataTable = studentsDataTable;
            this.SelectedStudent = SelectedStudent;
            dataRow = row;
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet.PracticeLessonsDataTable practiceLessonsDataTable;
        AutoschoolDataSet.StudentsDataTable studentsDataTable;
        DataRow SelectedStudent;
        DataRow dataRow;

        bool FormLoad = false;

        private void AddEditPracticeLessonForm_Load(object sender, EventArgs e)
        {
            SelectedStudent_comboBox.DataSource = studentsDataTable;
            SelectedStudent_comboBox.DisplayMember = "FIO";
            SelectedStudent_comboBox.ValueMember = "ID";
            SelectedStudent_comboBox.AutoCompleteMode = AutoCompleteMode.Append;
            SelectedStudent_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            FactDate_dateTimePicker.Checked = false;
            FactTime_dateTimePicker.Checked = false;

            if (dataRow != null)
            {
                SelectedStudent_comboBox.SelectedValue = dataRow["Student"].ToString();

                AutoschoolDataSet TempDS = BusinessLogic.ReadStudentByID(Convert.ToInt32(SelectedStudent_comboBox.SelectedValue));
                int GroupID = Convert.ToInt32(TempDS.Students[0][6].ToString());
                Group_label.Text = BusinessLogic.ReadGroupByID(GroupID).Groups[0][1].ToString();

                AppointedDate_dateTimePicker.Text = dataRow["AppointedDate"].ToString();
                AppointedTime_dateTimePicker.Text = dataRow["AppointedTime"].ToString();
                if (dataRow["FactDate"].ToString() != "01.01.0001 0:00:00")
                {
                    FactDate_dateTimePicker.Text = dataRow["FactDate"].ToString();
                    FactDate_dateTimePicker.Checked = true;
                    FactTime_dateTimePicker.Text = dataRow["FactTime"].ToString();
                    FactTime_dateTimePicker.Checked = true;
                }
            }
            else
            {
                if (SelectedStudent != null)
                {
                    SelectedStudent_comboBox.SelectedValue = SelectedStudent["ID"].ToString();
                    Group_label.Text = BusinessLogic.ReadGroupByID(Convert.ToInt32(SelectedStudent["Group"].ToString())).Groups[0][1].ToString();
                }
                else
                    SelectedStudent_comboBox.SelectedIndex = -1;
            }

            FormLoad = true;
        }

        private void SelectedStudent_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedStudent_comboBox.SelectedIndex != -1 && FormLoad)
            {
                AutoschoolDataSet TempDS = BusinessLogic.ReadStudentByID(Convert.ToInt32(SelectedStudent_comboBox.SelectedValue));
                int GroupID = Convert.ToInt32(TempDS.Students[0][6].ToString());
                Group_label.Text = BusinessLogic.ReadGroupByID(GroupID).Groups[0][1].ToString();
            }
        }

        private void AddEditPracticeLessonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    if (SelectedStudent_comboBox.SelectedIndex == -1)
                    {
                        SelectedStudent_comboBox.Focus();
                        throw new Exception("Не выбран курсант");
                    }
                    if (AppointedDate_dateTimePicker.Text.Trim() == "")
                    {
                        AppointedDate_dateTimePicker.Focus();
                        throw new Exception("Не указана назначенная дата занятия");
                    }
                    if (AppointedTime_dateTimePicker.Text.Trim() == "")
                    {
                        AppointedTime_dateTimePicker.Focus();
                        throw new Exception("Не указано назначенное время занятия");
                    }
                    if (FactDate_dateTimePicker.Checked && !FactTime_dateTimePicker.Checked)
                    {
                        throw new Exception("Вы указали фактическую дату занятия, но не указали фактическое время занятия. Либо укажите фактическое время, либо снимите галочку с элемента выбора фактической даты");
                    }
                    if (FactTime_dateTimePicker.Checked && !FactDate_dateTimePicker.Checked)
                    {
                        throw new Exception("Вы указали фактическое время занятия, но не указали фактическую дату занятия. Либо укажите фактическую дату, либо снимите галочку с элемента выбора фактического времени");
                    }
                    AutoschoolDataSet TempDS = new AutoschoolDataSet();
                    TempDS = BusinessLogic.ReadPracticeLessonsByStudentID(Convert.ToInt32(SelectedStudent_comboBox.SelectedValue));
                    for (int i = 0; i < TempDS.PracticeLessons.Rows.Count; i++)
                    {
                        if (dataRow != null && dataRow["ID"].ToString() == TempDS.PracticeLessons[i][0].ToString())
                            continue;
                        if (Convert.ToDateTime(TempDS.PracticeLessons[i][2]) == Convert.ToDateTime(AppointedDate_dateTimePicker.Text).Date)
                        {
                            if (Convert.ToDateTime(TempDS.PracticeLessons[i][3].ToString()).TimeOfDay <= 
                                Convert.ToDateTime(AppointedTime_dateTimePicker.Text).TimeOfDay &&
                                Convert.ToDateTime(TempDS.PracticeLessons[i][3].ToString()).AddMinutes(45).TimeOfDay >
                                Convert.ToDateTime(AppointedTime_dateTimePicker.Text).TimeOfDay)
                            {
                                throw new Exception("У выбранного курсанта в это время уже назначено занятие");
                            }
                        }
                        if (FactDate_dateTimePicker.Checked)
                        {
                            if (Convert.ToDateTime(TempDS.PracticeLessons[i][4]) == Convert.ToDateTime(FactDate_dateTimePicker.Text).Date)
                            {
                                if (Convert.ToDateTime(TempDS.PracticeLessons[i][5].ToString()).TimeOfDay <=
                                    Convert.ToDateTime(FactTime_dateTimePicker.Text).TimeOfDay &&
                                    Convert.ToDateTime(TempDS.PracticeLessons[i][5].ToString()).AddMinutes(45).TimeOfDay >
                                    Convert.ToDateTime(FactTime_dateTimePicker.Text).TimeOfDay)
                                {
                                    throw new Exception("У выбранного курсанта в это время уже произошло занятие");
                                }
                            }
                        }
                    }

                    int InstructorID = Convert.ToInt32(BusinessLogic.ReadCarriersUsesByID(studentsDataTable[SelectedStudent_comboBox.SelectedIndex].CarrierUse).CarriersUses[0][1]);
                    TempDS = BusinessLogic.GetInstructorSchedule(InstructorID);
                    for (int i = 0; i < TempDS.PracticeLessons.Rows.Count; i++)
                    {
                        if (dataRow != null && dataRow["ID"].ToString() == TempDS.PracticeLessons[i][0].ToString())
                            continue;
                        if (Convert.ToDateTime(TempDS.PracticeLessons[i][2]) == Convert.ToDateTime(AppointedDate_dateTimePicker.Text).Date)
                        {
                            if (Convert.ToDateTime(TempDS.PracticeLessons[i][3].ToString()).TimeOfDay <=
                                Convert.ToDateTime(AppointedTime_dateTimePicker.Text).TimeOfDay &&
                                Convert.ToDateTime(TempDS.PracticeLessons[i][3].ToString()).AddMinutes(45).TimeOfDay >
                                Convert.ToDateTime(AppointedTime_dateTimePicker.Text).TimeOfDay)
                            {
                                throw new Exception("У инструктора выбранного курсанта в это время уже назначено занятие");
                            }
                        }
                        if (FactDate_dateTimePicker.Checked)
                        {
                            if (Convert.ToDateTime(TempDS.PracticeLessons[i][4]) == Convert.ToDateTime(FactDate_dateTimePicker.Text).Date)
                            {
                                if (Convert.ToDateTime(TempDS.PracticeLessons[i][5].ToString()).TimeOfDay <=
                                    Convert.ToDateTime(FactTime_dateTimePicker.Text).TimeOfDay &&
                                    Convert.ToDateTime(TempDS.PracticeLessons[i][5].ToString()).AddMinutes(45).TimeOfDay >
                                    Convert.ToDateTime(FactTime_dateTimePicker.Text).TimeOfDay)
                                {
                                    throw new Exception("У инструктора выбранного курсанта в это время уже произошло занятие");
                                }
                            }
                        }
                    }

                    int CarrierID = Convert.ToInt32(BusinessLogic.ReadCarriersUsesByID(studentsDataTable[SelectedStudent_comboBox.SelectedIndex].CarrierUse).CarriersUses[0][2]);
                    TempDS = BusinessLogic.GetPracticeLessonsForCarrier(CarrierID);
                    for (int i = 0; i < TempDS.PracticeLessons.Rows.Count; i++)
                    {
                        if (dataRow != null && dataRow["ID"].ToString() == TempDS.PracticeLessons[i][0].ToString())
                            continue;
                        if (Convert.ToDateTime(TempDS.PracticeLessons[i][2]) == Convert.ToDateTime(AppointedDate_dateTimePicker.Text).Date)
                        {
                            if (Convert.ToDateTime(TempDS.PracticeLessons[i][3].ToString()).TimeOfDay <=
                                Convert.ToDateTime(AppointedTime_dateTimePicker.Text).TimeOfDay &&
                                Convert.ToDateTime(TempDS.PracticeLessons[i][3].ToString()).AddMinutes(45).TimeOfDay >
                                Convert.ToDateTime(AppointedTime_dateTimePicker.Text).TimeOfDay)
                            {
                                throw new Exception("ТС инструктора выбранного курсанта в это время уже используется");
                            }
                        }
                        if (FactDate_dateTimePicker.Checked)
                        {
                            if (Convert.ToDateTime(TempDS.PracticeLessons[i][4]) == Convert.ToDateTime(FactDate_dateTimePicker.Text).Date)
                            {
                                if (Convert.ToDateTime(TempDS.PracticeLessons[i][5].ToString()).TimeOfDay <=
                                    Convert.ToDateTime(FactTime_dateTimePicker.Text).TimeOfDay &&
                                    Convert.ToDateTime(TempDS.PracticeLessons[i][5].ToString()).AddMinutes(45).TimeOfDay >
                                    Convert.ToDateTime(FactTime_dateTimePicker.Text).TimeOfDay)
                                {
                                    throw new Exception("ТС инструктора выбранного курсанта в это время уже использовалось");
                                }
                            }
                        }
                    }

                    int CarrierUseID = Convert.ToInt32(studentsDataTable[SelectedStudent_comboBox.SelectedIndex].CarrierUse.ToString());
                    DateTime LessonDate;
                    if (FactDate_dateTimePicker.Checked)
                        LessonDate = Convert.ToDateTime(FactDate_dateTimePicker.Text).Date;
                    else
                        LessonDate = Convert.ToDateTime(AppointedDate_dateTimePicker.Text).Date;
                    // смотрим, находится ли ТС в это время в ремонте
                    // если да, то проверяем, есть ли ему замена
                    TempDS = BusinessLogic.ReadCarriersRepairsByCarrierID_AND_LessonDate(CarrierID, LessonDate);
                    if (TempDS.CarriersRepairs.Rows.Count > 0)
                    {
                        AutoschoolDataSet TempDS2 = BusinessLogic.ReadReplacementsCarriersByLessonDateANDCarrierUseID(LessonDate, CarrierUseID);
                        if (TempDS2.ReplacementsCarriers.Rows.Count == 0)
                        {
                            if (FactDate_dateTimePicker.Checked)
                                throw new Exception("ТС инструктора выбранного курсанта в это время находилось в ремонте и ему не была назначена замена");
                            else
                                throw new Exception("ТС инструктора выбранного курсанта в это время находится в ремонте и ему не назначена замена");
                        }
                    }                    

                    TempDS = BusinessLogic.ReadStudentByID(Convert.ToInt32(SelectedStudent_comboBox.SelectedValue));
                    int GroupID = Convert.ToInt32(TempDS.Students[0][6].ToString());
                    TempDS = BusinessLogic.ReadTheoryLessonsByGroupID(GroupID);
                    for (int i = 0; i < TempDS.TheoryLessons.Rows.Count; i++)
                    {
                        if (Convert.ToDateTime(TempDS.TheoryLessons[i][1]) == Convert.ToDateTime(AppointedDate_dateTimePicker.Text).Date)
                        {
                            if (Convert.ToDateTime(TempDS.TheoryLessons[i][2].ToString()).TimeOfDay <=
                                Convert.ToDateTime(AppointedTime_dateTimePicker.Text).TimeOfDay &&
                                Convert.ToDateTime(TempDS.TheoryLessons[i][2].ToString()).AddMinutes(45).TimeOfDay >
                                Convert.ToDateTime(AppointedTime_dateTimePicker.Text).TimeOfDay)
                            {
                                throw new Exception("У выбранного курсанта в это время назначено теоретическое занятие");
                            }
                        }
                        if (FactDate_dateTimePicker.Checked)
                        {
                            if (Convert.ToDateTime(TempDS.TheoryLessons[i][1]) == Convert.ToDateTime(FactDate_dateTimePicker.Text).Date)
                            {
                                if (Convert.ToDateTime(TempDS.TheoryLessons[i][2].ToString()).TimeOfDay <=
                                    Convert.ToDateTime(FactTime_dateTimePicker.Text).TimeOfDay &&
                                    Convert.ToDateTime(TempDS.TheoryLessons[i][2].ToString()).AddMinutes(45).TimeOfDay >
                                    Convert.ToDateTime(FactTime_dateTimePicker.Text).TimeOfDay)
                                {
                                    throw new Exception("У выбранного курсанта в это время происходило теоретическое занятие");
                                }
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
                    dataRow["Student"] = SelectedStudent_comboBox.SelectedValue;
                    dataRow["AppointedDate"] = Convert.ToDateTime(AppointedDate_dateTimePicker.Text).Date;
                    dataRow["AppointedTime"] = Convert.ToDateTime(AppointedTime_dateTimePicker.Text).TimeOfDay;
                    if (FactDate_dateTimePicker.Checked)
                    {
                        dataRow["FactDate"] = Convert.ToDateTime(FactDate_dateTimePicker.Text).Date;
                        dataRow["FactTime"] = Convert.ToDateTime(FactTime_dateTimePicker.Text).TimeOfDay;
                    }
                    else
                    {
                        dataRow["FactDate"] = Convert.ToDateTime(null);
                        dataRow["FactTime"] = Convert.ToDateTime(null).TimeOfDay;
                    }
                }
                else
                {
                    if (FactDate_dateTimePicker.Checked)
                    {
                        practiceLessonsDataTable.AddPracticeLessonsRow(studentsDataTable[SelectedStudent_comboBox.SelectedIndex],
                        Convert.ToDateTime(AppointedDate_dateTimePicker.Text).Date,
                        Convert.ToDateTime(AppointedTime_dateTimePicker.Text).TimeOfDay,
                        Convert.ToDateTime(FactDate_dateTimePicker.Text).Date,
                        Convert.ToDateTime(FactTime_dateTimePicker.Text).TimeOfDay);
                    }
                    else
                    {
                        practiceLessonsDataTable.AddPracticeLessonsRow(studentsDataTable[SelectedStudent_comboBox.SelectedIndex],
                        Convert.ToDateTime(AppointedDate_dateTimePicker.Text).Date,
                        Convert.ToDateTime(AppointedTime_dateTimePicker.Text).TimeOfDay,
                        Convert.ToDateTime(null),
                        Convert.ToDateTime(null).TimeOfDay);
                    }
                }
            }
        }
    }
}
