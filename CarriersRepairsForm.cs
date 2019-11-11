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
    public partial class CarriersRepairsForm : Form
    {
        public CarriersRepairsForm()
        {
            InitializeComponent();
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet dataSet;
        string LastSearchingText = "";
        int LastFoundRow = -1;
        int LastSelectionIndex;
        bool FirstLoad = true;

        void ReloadCarriersRepairs()
        {
            dataSet = BusinessLogic.ReadCarriersRepairs();
            CarriersRepairs_dataGridView.DataSource = dataSet;
            CarriersRepairs_dataGridView.DataMember = "CarriersRepairs";

            CarriersRepairs_dataGridView.Columns["ID"].Visible = false;
            CarriersRepairs_dataGridView.Columns["Carrier"].Visible = false;
            CarriersRepairs_dataGridView.Columns["Master"].Visible = false;
            CarriersRepairs_dataGridView.Columns["Work"].Visible = false;
            CarriersRepairs_dataGridView.Columns["BeginDate"].Visible = false;
            CarriersRepairs_dataGridView.Columns["EndDate"].Visible = false;

            IDColumn.DataPropertyName = "ID";

            CarrierColumn.DataSource = dataSet.Carriers;
            CarrierColumn.DisplayMember = "FinalName";
            CarrierColumn.ValueMember = "ID";
            CarrierColumn.DataPropertyName = "Carrier";

            MasterColumn.DataSource = dataSet.ServiceMasters;
            MasterColumn.DisplayMember = "FIO";
            MasterColumn.ValueMember = "ID";
            MasterColumn.DataPropertyName = "Master";

            WorkColumn.DataPropertyName = "Work";
            BeginDateColumn.DataPropertyName = "BeginDate";
            EndDateColumn.DataPropertyName = "EndDate";

            if (LastSelectionIndex != -1)
                CarriersRepairs_dataGridView.CurrentCell = CarriersRepairs_dataGridView[1, LastSelectionIndex];
        }

        private void CarriersRepairsForm_Load(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            ReloadCarriersRepairs();
            Edit_button.Enabled = false;
            Delete_button.Enabled = false;
            CarriersRepairs_dataGridView_SelectionChanged(sender, e);
        }

        private void CarriersRepairs_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CarriersRepairs_dataGridView.SelectedRows.Count == 1)
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

        private void Search_button_Click(object sender, EventArgs e)
        {
            SearchingInDataGridViewClass.Search(Search_textBox, ref CarriersRepairs_dataGridView, Direction_checkBox,
                ref LastSearchingText, ref LastFoundRow, "MasterColumn", "CarrierColumn", "WorkColumn");
        }

        private void Search_textBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ReloadCarriersRepairs_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            ReloadCarriersRepairs();
        }

        private void CarriersRepairsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.Perem(MainForm.FormsNames[10], false);
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            ReloadCarriersRepairs();
            AddEditCarrierRepairForm AddCarrierRepair = new AddEditCarrierRepairForm(dataSet.CarriersRepairs,
                dataSet.ServiceMasters, dataSet.Carriers, null);
            AddCarrierRepair.Text = "Добавление ремонта ТС";
            this.Enabled = false;
            AddCarrierRepair.ShowDialog();
            if (AddCarrierRepair.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteCarriersRepairs(dataSet);
                ReloadCarriersRepairs();
            }
            this.Enabled = true;
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = CarriersRepairs_dataGridView.SelectedRows[0].Index;
            ReloadCarriersRepairs();
            AddEditCarrierRepairForm EditCarrierRepair = new AddEditCarrierRepairForm(dataSet.CarriersRepairs,
                dataSet.ServiceMasters, dataSet.Carriers,
                dataSet.CarriersRepairs.Rows.Find(CarriersRepairs_dataGridView.SelectedRows[0].Cells["ID"].Value));
            EditCarrierRepair.Text = "Редактирование ремонта ТС";
            this.Enabled = false;
            EditCarrierRepair.ShowDialog();
            if (EditCarrierRepair.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteCarriersRepairs(dataSet);
                ReloadCarriersRepairs();
            }
            this.Enabled = true;
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            if (CarriersRepairs_dataGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Не выбрана строка для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    dataSet.CarriersRepairs.Rows.Find(CarriersRepairs_dataGridView.SelectedRows[0].Cells["ID"].Value).Delete();
                    dataSet = BusinessLogic.WriteCarriersRepairs(dataSet);
                    ReloadCarriersRepairs();
                }
                catch
                {
                    MessageBox.Show("Не удалось удалить выбранную строку.\nСкорее всего, на данную строку имеются ссылки из других таблиц", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReloadCarriersRepairs();
                }
            }
        }

        private void CarriersRepairsForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                if (!FirstLoad)
                    ReloadCarriersRepairs_button_Click(sender, e);
                else
                    FirstLoad = false;
            }
        }
    }
}
