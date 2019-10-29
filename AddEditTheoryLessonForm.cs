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
    public partial class AddEditTheoryLessonForm : Form
    {
        public AddEditTheoryLessonForm(AutoschoolDataSet.TheoryLessonsDataTable theoryLessonsDataTable,
            AutoschoolDataSet.GroupsDataTable groupsDataTable,
            AutoschoolDataSet.AuditoriumsDataTable auditoriumsDataTable,
            DataRow SelectedGroup,
            DataRow row)
        {
            InitializeComponent();
            this.theoryLessonsDataTable = theoryLessonsDataTable;
            this.groupsDataTable = groupsDataTable;
            this.auditoriumsDataTable = auditoriumsDataTable;
            this.SelectedGroup = SelectedGroup;
            dataRow = row;
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet.TheoryLessonsDataTable theoryLessonsDataTable;
        AutoschoolDataSet.GroupsDataTable groupsDataTable;
        AutoschoolDataSet.AuditoriumsDataTable auditoriumsDataTable;
        DataRow SelectedGroup;
        DataRow dataRow;

        bool FormLoad = false;

        private void AddEditTheoryLessonForm_Load(object sender, EventArgs e)
        {
            SelectedGroup_comboBox.DataSource = groupsDataTable;
            SelectedGroup_comboBox.DisplayMember = "Name";
            SelectedGroup_comboBox.ValueMember = "ID";
            SelectedGroup_comboBox.AutoCompleteMode = AutoCompleteMode.Append;
            SelectedGroup_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            Auditorium_comboBox.DataSource = auditoriumsDataTable;
            Auditorium_comboBox.DisplayMember = "Name";
            Auditorium_comboBox.ValueMember = "ID";
            Auditorium_comboBox.AutoCompleteMode = AutoCompleteMode.Append;
            Auditorium_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            if (dataRow != null)
            {
                SelectedGroup_comboBox.SelectedValue = dataRow["Group"].ToString();

                Date_dateTimePicker.Text = dataRow["Date"].ToString();
                Time_dateTimePicker.Text = dataRow["Time"].ToString();

                Auditorium_comboBox.SelectedValue = dataRow["Auditorium"].ToString();
            }
            else
            {
                if (SelectedGroup != null)
                    SelectedGroup_comboBox.SelectedItem = SelectedGroup["Name"].ToString();
                else
                    SelectedGroup_comboBox.SelectedIndex = -1;
                Auditorium_comboBox.SelectedIndex = -1;
            }

            FormLoad = true;
        }

        private void AddEditTheoryLessonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    if (SelectedGroup_comboBox.SelectedIndex == -1)
                    {
                        SelectedGroup_comboBox.Focus();
                        throw new Exception("Не выбрана группа");
                    }
                    if (Date_dateTimePicker.Text.Trim() == "")
                    {
                        Date_dateTimePicker.Focus();
                        throw new Exception("Не указана назначенная дата занятия");
                    }
                    if (Time_dateTimePicker.Text.Trim() == "")
                    {
                        Time_dateTimePicker.Focus();
                        throw new Exception("Не указано назначенное время занятия");
                    }
                    if (Auditorium_comboBox.SelectedIndex == -1)
                    {
                        Auditorium_comboBox.Focus();
                        throw new Exception("Не выбрана аудитория");
                    }
                    AutoschoolDataSet TempDS = new AutoschoolDataSet();
                    TempDS = BusinessLogic.ReadTheoryLessonsByAuditoriumID(Convert.ToInt32(Auditorium_comboBox.SelectedValue));
                    for (int i = 0; i < TempDS.TheoryLessons.Rows.Count; i++)
                    {
                        if (dataRow != null && dataRow["ID"] == TempDS.TheoryLessons[i][0])
                            continue;
                        if (Convert.ToDateTime(TempDS.TheoryLessons[i][1]) == Convert.ToDateTime(Date_dateTimePicker.Text).Date)
                        {
                            if (Convert.ToDateTime(TempDS.TheoryLessons[i][2].ToString()).TimeOfDay <=
                                Convert.ToDateTime(Time_dateTimePicker.Text).TimeOfDay &&
                                Convert.ToDateTime(TempDS.TheoryLessons[i][2].ToString()).AddMinutes(45).TimeOfDay >
                                Convert.ToDateTime(Time_dateTimePicker.Text).TimeOfDay)
                            {
                                throw new Exception("Выбранная аудитория в это время в течении 45 минут уже занята");
                            }
                        }
                    }

                    TempDS = BusinessLogic.ReadTheoryLessonsByGroupID(Convert.ToInt32(SelectedGroup_comboBox.SelectedValue));
                    for (int i = 0; i < TempDS.TheoryLessons.Rows.Count; i++)
                    {
                        if (dataRow != null && dataRow["ID"] == TempDS.TheoryLessons[i][0])
                            continue;
                        if (Convert.ToDateTime(TempDS.TheoryLessons[i][1]) == Convert.ToDateTime(Date_dateTimePicker.Text).Date)
                        {
                            if (Convert.ToDateTime(TempDS.TheoryLessons[i][2].ToString()).TimeOfDay <=
                                Convert.ToDateTime(Time_dateTimePicker.Text).TimeOfDay &&
                                Convert.ToDateTime(TempDS.TheoryLessons[i][2].ToString()).AddMinutes(45).TimeOfDay >
                                Convert.ToDateTime(Time_dateTimePicker.Text).TimeOfDay)
                            {
                                throw new Exception("Выбранной группе в это время в течении 45 минут уже назначено теоретическое занятие");
                            }
                        }
                    }

                    int TeacherID = Convert.ToInt32(BusinessLogic.ReadGroupByID(groupsDataTable[SelectedGroup_comboBox.SelectedIndex].Teacher).Groups[0][5]);
                    TempDS = BusinessLogic.GetTheoryTeacherSchedule(TeacherID);
                    for (int i = 0; i < TempDS.TheoryLessons.Rows.Count; i++)
                    {
                        if (dataRow != null && dataRow["ID"] == TempDS.TheoryLessons[i][0])
                            continue;
                        if (Convert.ToDateTime(TempDS.TheoryLessons[i][1]) == Convert.ToDateTime(Date_dateTimePicker.Text).Date)
                        {
                            if (Convert.ToDateTime(TempDS.TheoryLessons[i][2].ToString()).TimeOfDay <=
                                Convert.ToDateTime(Time_dateTimePicker.Text).TimeOfDay &&
                                Convert.ToDateTime(TempDS.TheoryLessons[i][2].ToString()).AddMinutes(45).TimeOfDay >
                                Convert.ToDateTime(Time_dateTimePicker.Text).TimeOfDay)
                            {
                                throw new Exception("У преподавателя теории выбранной группы в это время в течении 45 минут уже назначено теоретическое занятие");
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
                    dataRow["Date"] = Convert.ToDateTime(Date_dateTimePicker.Text).Date;
                    dataRow["Time"] = Convert.ToDateTime(Time_dateTimePicker.Text).TimeOfDay;
                    dataRow["Auditorium"] = Auditorium_comboBox.SelectedValue;
                    dataRow["Group"] = SelectedGroup_comboBox.SelectedValue;
                }
                else
                {
                    theoryLessonsDataTable.AddTheoryLessonsRow(Convert.ToDateTime(Date_dateTimePicker.Text).Date,
                        Convert.ToDateTime(Time_dateTimePicker.Text).TimeOfDay,
                        auditoriumsDataTable[Auditorium_comboBox.SelectedIndex],
                        groupsDataTable[SelectedGroup_comboBox.SelectedIndex]);
                }
            }
        }
    }
}
