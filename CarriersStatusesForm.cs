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

        int LastSelectionIndex;

        bool FormLoad = false;
        bool FirstLoad = true;

        void ReloadCarriersStatuses()
        {
            dataSet = BusinessLogic.ReadCarriersStatuses();
            CarriersStatuses_dataGridView.DataSource = dataSet;
            CarriersStatuses_dataGridView.DataMember = "CarriersStatuses";

            CarriersStatuses_dataGridView.Columns["ID"].Visible = false;
            CarriersStatuses_dataGridView.Columns["Name"].Visible = false;

            IDColumn.DataPropertyName = "ID";
            NameColumn.DataPropertyName = "Name";

            if (LastSelectionIndex != -1)
                CarriersStatuses_dataGridView.CurrentCell = CarriersStatuses_dataGridView[1, LastSelectionIndex];
        }

        private void CarriersStatusesForm_Load(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            ReloadCarriersStatuses();
            FormLoad = true;
            Edit_button.Enabled = false;
            Delete_button.Enabled = false;
            CarriersStatuses_dataGridView_SelectionChanged(sender, e);
        }

        private void CarriersStatuses_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (FormLoad && CarriersStatuses_dataGridView.SelectedRows.Count == 1 && CarriersStatuses_dataGridView.SelectedRows[0].Cells["NameColumn"].Value.ToString() != "Резерв")
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
            dataSet = BusinessLogic.ReadCarriersStatuses();
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
            dataSet = BusinessLogic.ReadCarriersStatuses();
            LastSelectionIndex = CarriersStatuses_dataGridView.SelectedRows[0].Index;
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
            LastSelectionIndex = -1;
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

        private void Reload_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = 1;
            ReloadCarriersStatuses();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CarriersStatusesForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                if (!FirstLoad)
                    Reload_button_Click(sender, e);
                else
                    FirstLoad = false;
            }
        }
    }
}
