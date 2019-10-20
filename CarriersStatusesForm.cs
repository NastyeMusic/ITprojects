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
    public partial class CarriersStatusesForm : Form
    {
        public CarriersStatusesForm()
        {
            InitializeComponent();
        }

        public BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet dataSet;

        void ReloadCarriersStatuses()
        {
            dataSet = BusinessLogic.ReadCarriersStatuses();
            CarriersStatuses_dataGridView.DataSource = dataSet;
            CarriersStatuses_dataGridView.DataMember = "CarriersStatuses";

            CarriersStatuses_dataGridView.Columns["ID"].Visible = false;
            CarriersStatuses_dataGridView.Columns["Name"].Visible = false;

            IDColumn.DataPropertyName = "ID";
            NameColumn.DataPropertyName = "Name";
        }

        private void CarriersStatusesForm_Load(object sender, EventArgs e)
        {
            ReloadCarriersStatuses();
            Edit_button.Enabled = false;
            Delete_button.Enabled = false;
            CarriersStatuses_dataGridView_SelectionChanged(sender, e);
        }

        private void CarriersStatuses_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CarriersStatuses_dataGridView.SelectedRows.Count == 1)
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

        private void CarriersStatusesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            MainForm.Perem(MainForm.FormsNames[9], false);
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            AddEditCarriersStatusesForm AddCarriersStatus = new AddEditCarriersStatusesForm(dataSet.CarriersStatuses, null);
            AddCarriersStatus.Text = "Добавление статуса ТС";
            this.Enabled = false;
            AddCarriersStatus.ShowDialog();
            if (AddCarriersStatus.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteCarriersStatuses(dataSet);
                ReloadCarriersStatuses();
            }
            this.Enabled = true;
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            AddEditCarriersStatusesForm EditCarriersStatus = new AddEditCarriersStatusesForm(dataSet.CarriersStatuses, dataSet.CarriersStatuses.Rows.Find(CarriersStatuses_dataGridView.SelectedRows[0].Cells["ID"].Value));
            EditCarriersStatus.Text = "Редактирование статуса ТС";
            this.Enabled = false;
            EditCarriersStatus.ShowDialog();
            if (EditCarriersStatus.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteCarriersStatuses(dataSet);
                ReloadCarriersStatuses();
            }
            this.Enabled = true;
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (CarriersStatuses_dataGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Не выбрана строка для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    dataSet.CarriersStatuses.Rows.Find(CarriersStatuses_dataGridView.SelectedRows[0].Cells["ID"].Value).Delete();
                    dataSet = BusinessLogic.WriteCarriersStatuses(dataSet);
                    ReloadCarriersStatuses();
                }
                catch
                {
                    MessageBox.Show("Не удалось удалить выбранную строку.\nСкорее всего, на данную строку имеются ссылки из других таблиц", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReloadCarriersStatuses();
                }
            }
        }
    }
}
