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

            if (dataRow != null)
            {
                SelectedStudent_comboBox.SelectedValue = dataRow["Student"].ToString();

                AutoschoolDataSet TempDS = BusinessLogic.ReadStudentByID(Convert.ToInt32(SelectedStudent_comboBox.SelectedValue));
                int GroupID = Convert.ToInt32(TempDS.Students[0][6].ToString());
                Group_label.Text = BusinessLogic.ReadGroupByID(GroupID).Groups[0][1].ToString();

                AppointedDate_dateTimePicker.Text = dataRow["AppointedDate"].ToString();
                AppointedTime_dateTimePicker.Text = dataRow["AppointedTime"].ToString();
                FactDate_dateTimePicker.Text = dataRow["FactDate"].ToString();
                FactTime_dateTimePicker.Text = dataRow["FactTime"].ToString();
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
                    AutoschoolDataSet TempDS = new AutoschoolDataSet();
                    TempDS = BusinessLogic.ReadPracticeLessonsByStudentID(Convert.ToInt32(SelectedStudent_comboBox.SelectedValue));
                    for (int i = 0; i < TempDS.PracticeLessons.Rows.Count; i++)
                    {
                        if (dataRow != null && dataRow["ID"] == TempDS.PracticeLessons[i][0])
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

                    int InstructorID = Convert.ToInt32(BusinessLogic.ReadCarriersUsesByID(studentsDataTable[SelectedStudent_comboBox.SelectedIndex].CarrierUse).CarriersUses[0][1]);
                    TempDS = BusinessLogic.GetInstructorSchedule(InstructorID);
                    for (int i = 0; i < TempDS.PracticeLessons.Rows.Count; i++)
                    {
                        if (dataRow != null && dataRow["ID"] == TempDS.PracticeLessons[i][0])
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

                    int CarrierID = Convert.ToInt32(BusinessLogic.ReadCarriersUsesByID(studentsDataTable[SelectedStudent_comboBox.SelectedIndex].CarrierUse).CarriersUses[0][2]);
                    TempDS = BusinessLogic.GetPracticeLessonsForCarrier(CarrierID);
                    for (int i = 0; i < TempDS.PracticeLessons.Rows.Count; i++)
                    {
                        if (dataRow != null && dataRow["ID"] == TempDS.PracticeLessons[i][0])
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
                    dataRow["FactDate"] = Convert.ToDateTime(FactDate_dateTimePicker.Text).Date;
                    dataRow["FactTime"] = Convert.ToDateTime(FactTime_dateTimePicker.Text).TimeOfDay;
                }
                else
                {
                    practiceLessonsDataTable.AddPracticeLessonsRow(studentsDataTable[SelectedStudent_comboBox.SelectedIndex],
                        Convert.ToDateTime(AppointedDate_dateTimePicker.Text).Date,
                        Convert.ToDateTime(AppointedTime_dateTimePicker.Text).TimeOfDay,
                        Convert.ToDateTime(FactDate_dateTimePicker.Text).Date,
                        Convert.ToDateTime(FactTime_dateTimePicker.Text).TimeOfDay);
                }
            }
        }
    }
}
