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
    public partial class WorkersForm : Form
    {
        public WorkersForm()
        {
            InitializeComponent();
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet dataSet;
        string LastSearchingText = "";
        int LastFoundRow = -1;

        WorkStatusesForm WorkStatusesForm = new WorkStatusesForm();
        static public bool WorkStatusesFormOpened = false;

        int LastSelectionIndex;

        private void ChangeWorkStatuses_button_Click(object sender, EventArgs e)
        {
            if (!WorkStatusesFormOpened)
            {
                WorkStatusesForm.Show();
                WorkStatusesFormOpened = true;
            }
            else
            {
                WorkStatusesForm.Activate();
            }
        }

        void ReloadWorkers()
        {
            Workers_dataGridView.Rows.Clear();
            dataSet = BusinessLogic.ReadWorkers();

            // загружаем преподавателей теории
            //dataSet = BusinessLogic.ReadTheoryTeachers();;
            for (int i = 0; i < dataSet.TheoryTeachers.Rows.Count; i++)
            {
                Workers_dataGridView.Rows.Add(dataSet.TheoryTeachers.Rows[i][0].ToString(),
                    dataSet.TheoryTeachers.Rows[i][1].ToString(), dataSet.TheoryTeachers.Rows[i][2].ToString(),
                    dataSet.TheoryTeachers.Rows[i][3].ToString(), "преподаватель теории", dataSet.TheoryTeachers.Rows[i][7].ToString());
            }

            // загружаем инструкторов
            //dataSet = BusinessLogic.ReadInstructors();
            for (int i = 0; i < dataSet.Instructors.Rows.Count; i++)
            {
                Workers_dataGridView.Rows.Add(dataSet.Instructors.Rows[i][0].ToString(), dataSet.Instructors.Rows[i][1].ToString(),
                    dataSet.Instructors.Rows[i][2].ToString(), dataSet.Instructors.Rows[i][3].ToString(), "инструктор", dataSet.Instructors.Rows[i][7].ToString());
            }

            // загружаем мастеров сервиса
            //dataSet = BusinessLogic.ReadServiceMasters();
            for (int i = 0; i < dataSet.ServiceMasters.Rows.Count; i++)
            {
                Workers_dataGridView.Rows.Add(dataSet.ServiceMasters.Rows[i][0].ToString(), dataSet.ServiceMasters.Rows[i][1].ToString(),
                    dataSet.ServiceMasters.Rows[i][2].ToString(), dataSet.ServiceMasters.Rows[i][3].ToString(), "мастер сервиса", dataSet.ServiceMasters.Rows[i][6].ToString());
            }
            if (LastSelectionIndex != -1)
                Workers_dataGridView.CurrentCell = Workers_dataGridView[1, LastSelectionIndex];
        }

        private void WorkersForm_Load(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            ReloadWorkers();
            Edit_button.Enabled = false;
            Delete_button.Enabled = false;
            Workers_dataGridView_SelectionChanged(sender, e);
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            SearchingInDataGridViewClass.Search(SearchWorker_textBox, ref Workers_dataGridView, Direction_checkBox,
                ref LastSearchingText, ref LastFoundRow, "SurnameColumn", "FirstNameColumn", "PatronymicNameColumn");
        }

        private void SearchWorker_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Enter)
            {
                Search_button_Click(sender, e);
            }
            if ((char)e.KeyChar == (Char)Keys.Back)
            {
                LastSearchingText = "";
            }
        }

        private void Workers_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (Workers_dataGridView.SelectedRows.Count == 1)
            {                
                Edit_button.Enabled = true;
                Delete_button.Enabled = true;
            }
            else
            {
                Edit_button.Enabled = false;
                Delete_button.Enabled = false;
            }            
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            dataSet = BusinessLogic.ReadWorkers();
            AddEditWorkerForm AddWorker = new AddEditWorkerForm(null, null, dataSet.WorkStatuses, dataSet);
            AddWorker.Text = "Добавление сотрудника";
            this.Enabled = false;
            AddWorker.ShowDialog();
            if (AddWorker.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteTheoryTeachers(dataSet);
                dataSet = BusinessLogic.WriteInstructors(dataSet);
                dataSet = BusinessLogic.WriteServiceMasters(dataSet);
                ReloadWorkers();
            }
            this.Enabled = true;
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            dataSet = BusinessLogic.ReadWorkers();
            LastSelectionIndex = Workers_dataGridView.SelectedRows[0].Index;
            string Post = Workers_dataGridView.SelectedRows[0].Cells["PostColumn"].Value.ToString();
            AddEditWorkerForm EditWorker;
            if (Post == "преподаватель теории")
            {
                EditWorker = new AddEditWorkerForm(Post, dataSet.TheoryTeachers.Rows.Find(Workers_dataGridView.SelectedRows[0].Cells["ID"].Value), dataSet.WorkStatuses, dataSet);
            }
            else if (Post == "инструктор")
            {
                EditWorker = new AddEditWorkerForm(Post, dataSet.Instructors.Rows.Find(Workers_dataGridView.SelectedRows[0].Cells["ID"].Value), dataSet.WorkStatuses, dataSet);
            }
            else if (Post == "мастер сервиса")
            {
                EditWorker = new AddEditWorkerForm(Post, dataSet.ServiceMasters.Rows.Find(Workers_dataGridView.SelectedRows[0].Cells["ID"].Value), dataSet.WorkStatuses, dataSet);
            }
            else
            {
                EditWorker = null;
                MessageBox.Show("Произошла непредвиденная ошибка", "Ошибка редактирования");
                return;
            }            
            EditWorker.Text = "Редактирование сотрудника";
            this.Enabled = false;
            EditWorker.ShowDialog();
            if (EditWorker.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteWorkers(dataSet);              
                ReloadWorkers();
            }
            this.Enabled = true;
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            if (Workers_dataGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Не выбрана строка для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int ID = Convert.ToInt32(Workers_dataGridView.SelectedRows[0].Cells["ID"].Value);
                    string Post = Workers_dataGridView.SelectedRows[0].Cells["PostColumn"].Value.ToString();
                    if (Post == "преподаватель теории")
                    {
                        AutoschoolDataSet TempDataSet = new AutoschoolDataSet();
                        TempDataSet = BusinessLogic.ReadTheoryTeacherByID(ID);
                        dataSet.TheoryTeachers.Rows.Find(TempDataSet.TheoryTeachers.Rows[0][0].ToString()).Delete();
                        dataSet = BusinessLogic.WriteTheoryTeachers(dataSet);
                        ReloadWorkers();
                    }
                    else if (Post == "инструктор")
                    {
                        AutoschoolDataSet TempDataSet = new AutoschoolDataSet();
                        TempDataSet = BusinessLogic.ReadInstructorByID(ID);
                        dataSet.Instructors.Rows.Find(TempDataSet.Instructors.Rows[0][0].ToString()).Delete();
                        dataSet = BusinessLogic.WriteInstructors(dataSet);
                        ReloadWorkers();
                    }
                    else if (Post == "мастер сервиса")
                    {
                        AutoschoolDataSet TempDataSet = new AutoschoolDataSet();
                        TempDataSet = BusinessLogic.ReadServiceMasterByID(ID);
                        dataSet.ServiceMasters.Rows.Find(TempDataSet.ServiceMasters.Rows[0][0].ToString()).Delete();
                        dataSet = BusinessLogic.WriteServiceMasters(dataSet);
                        ReloadWorkers();
                    }
                }
                catch
                {
                    MessageBox.Show("Не удалось удалить выбранную строку.\nСкорее всего, на данную строку имеются ссылки из других таблиц", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReloadWorkers();
                }
            }
        }

        private void ReloadWorkers_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            ReloadWorkers();
        }

        private void WorkersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            MainForm.Perem(MainForm.FormsNames[3], false);
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
