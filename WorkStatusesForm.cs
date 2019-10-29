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
    public partial class WorkStatusesForm : Form
    {
        public WorkStatusesForm()
        {
            InitializeComponent();
        }

        public BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet dataSet;

        int LastSelectionIndex;

        void ReloadWorkStatuses()
        {
            dataSet = BusinessLogic.ReadWorkStatuses();
            WorkStatuses_dataGridView.DataSource = dataSet;
            WorkStatuses_dataGridView.DataMember = "WorkStatuses";

            WorkStatuses_dataGridView.Columns["ID"].Visible = false;
            WorkStatuses_dataGridView.Columns["Name"].Visible = false;

            IDColumn.DataPropertyName = "ID";
            NameColumn.DataPropertyName = "Name";

            if (LastSelectionIndex != -1)
                WorkStatuses_dataGridView.CurrentCell = WorkStatuses_dataGridView[1, LastSelectionIndex];
        }

        private void WorkStatusesForm_Load(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            ReloadWorkStatuses();
            Edit_button.Enabled = false;
            Delete_button.Enabled = false;
            WorkStatuses_dataGridView_SelectionChanged(sender, e);
        }

        private void WorkStatuses_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (WorkStatuses_dataGridView.SelectedRows.Count == 1)
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
            dataSet = BusinessLogic.ReadWorkStatuses();
            AddEditWorkStatusesForm AddWorkStatus = new AddEditWorkStatusesForm(dataSet.WorkStatuses, null);
            AddWorkStatus.Text = "Добавление рабочего статуса";
            this.Enabled = false;
            AddWorkStatus.ShowDialog();
            if (AddWorkStatus.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteWorkStatuses(dataSet);
                ReloadWorkStatuses();
            }
            this.Enabled = true;
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            dataSet = BusinessLogic.ReadWorkStatuses();
            LastSelectionIndex = WorkStatuses_dataGridView.SelectedRows[0].Index;
            AddEditWorkStatusesForm EditWorkStatus = new AddEditWorkStatusesForm(dataSet.WorkStatuses, dataSet.WorkStatuses.Rows.Find(WorkStatuses_dataGridView.SelectedRows[0].Cells["ID"].Value));
            EditWorkStatus.Text = "Редактирование рабочего статуса";
            this.Enabled = false;
            EditWorkStatus.ShowDialog();
            if (EditWorkStatus.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteWorkStatuses(dataSet);
                ReloadWorkStatuses();
            }
            this.Enabled = true;
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            if (WorkStatuses_dataGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Не выбрана строка для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    dataSet.WorkStatuses.Rows.Find(WorkStatuses_dataGridView.SelectedRows[0].Cells["ID"].Value).Delete();
                    dataSet = BusinessLogic.WriteWorkStatuses(dataSet);
                    ReloadWorkStatuses();
                }
                catch
                {
                    MessageBox.Show("Не удалось удалить выбранную строку.\nСкорее всего, на данную строку имеются ссылки из других таблиц", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReloadWorkStatuses();
                }
            }
        }

        private void WorkStatusesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            WorkersForm.WorkStatusesFormOpened = false;
        }

        private void Reload_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            ReloadWorkStatuses();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
