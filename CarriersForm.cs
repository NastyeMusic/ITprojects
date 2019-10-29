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
    public partial class CarriersForm : Form
    {
        public CarriersForm()
        {
            InitializeComponent();
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet dataSet;
        string LastSearchingText = "";
        int LastFoundRow = -1;

        int LastSelectionIndex;

        //AddRepairFromFormCarriers AddRepairFromFormCarriersForm = new AddRepairFromFormCarriers();
        //static bool AddRepairFromFormCarriersFormOpened = false;

        private void AddRepairSelectedCarrier_button_Click(object sender, EventArgs e)
        {

        }

        void ReloadCarriers()
        {
            dataSet = BusinessLogic.ReadCarriers();
            Carriers_dataGridView.DataSource = dataSet;
            Carriers_dataGridView.DataMember = "Carriers";

            Carriers_dataGridView.Columns["ID"].Visible = false;
            Carriers_dataGridView.Columns["Brand"].Visible = false;
            Carriers_dataGridView.Columns["Model"].Visible = false;
            Carriers_dataGridView.Columns["StateNumber"].Visible = false;
            Carriers_dataGridView.Columns["Color"].Visible = false;
            Carriers_dataGridView.Columns["Transmission"].Visible = false;
            Carriers_dataGridView.Columns["Category"].Visible = false;
            Carriers_dataGridView.Columns["Status"].Visible = false;
            Carriers_dataGridView.Columns["FinalName"].Visible = false;

            IDColumn.DataPropertyName = "ID";
            BrandColumn.DataPropertyName = "Brand";
            ModelColumn.DataPropertyName = "Model";
            StateNumberColumn.DataPropertyName = "StateNumber";
            ColorColumn.DataPropertyName = "Color";

            TransmissionColumn.DataSource = dataSet.Transmissions;
            TransmissionColumn.DisplayMember = "Transmission";
            TransmissionColumn.ValueMember = "ID";
            TransmissionColumn.DataPropertyName = "Transmission";

            CategoryColumn.DataSource = dataSet.Categories;
            CategoryColumn.DisplayMember = "Name";
            CategoryColumn.ValueMember = "ID";
            CategoryColumn.DataPropertyName = "Category";

            StatusColumn.DataSource = dataSet.CarriersStatuses;
            StatusColumn.DisplayMember = "Name";
            StatusColumn.ValueMember = "ID";
            StatusColumn.DataPropertyName = "Status";

            if (LastSelectionIndex != -1)
                Carriers_dataGridView.CurrentCell = Carriers_dataGridView[1, LastSelectionIndex];
        }

        private void CarriersForm_Load(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            ReloadCarriers();
            Edit_button.Enabled = false;
            Delete_button.Enabled = false;
            Carriers_dataGridView_SelectionChanged(sender, e);
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            SearchingInDataGridViewClass.Search(SearchCarrier_textBox, ref Carriers_dataGridView, Direction_checkBox,
                ref LastSearchingText, ref LastFoundRow, "BrandColumn", "ModelColumn", "StateNumberColumn");
        }

        private void SearchCarrier_textBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Carriers_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (Carriers_dataGridView.SelectedRows.Count == 1)
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
            AddEditCarrierForm AddCarrier = new AddEditCarrierForm(dataSet.Carriers, dataSet.Categories, dataSet.CarriersStatuses, 
                dataSet.Transmissions, null);
            AddCarrier.Text = "Добавление ТС";
            this.Enabled = false;
            AddCarrier.ShowDialog();
            if (AddCarrier.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteCarriers(dataSet);
                ReloadCarriers();
            }
            this.Enabled = true;
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = Carriers_dataGridView.SelectedRows[0].Index;
            AddEditCarrierForm EditCarrier = new AddEditCarrierForm(dataSet.Carriers, dataSet.Categories, dataSet.CarriersStatuses,
                dataSet.Transmissions, dataSet.Carriers.Rows.Find(Carriers_dataGridView.SelectedRows[0].Cells["ID"].Value));
            EditCarrier.Text = "Редактирование ТС";
            this.Enabled = false;
            EditCarrier.ShowDialog();
            if (EditCarrier.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteCarriers(dataSet);
                ReloadCarriers();
            }
            this.Enabled = true;
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = 0;
            if (Carriers_dataGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Не выбрана строка для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    dataSet.Carriers.Rows.Find(Carriers_dataGridView.SelectedRows[0].Cells["ID"].Value).Delete();
                    dataSet = BusinessLogic.WriteCarriers(dataSet);
                    ReloadCarriers();
                }
                catch
                {
                    MessageBox.Show("Не удалось удалить выбранную строку.\nСкорее всего, на данную строку имеются ссылки из других таблиц", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReloadCarriers();
                }
            }
        }

        private void ReloadCarriers_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            ReloadCarriers();
        }

        private void CarriersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            MainForm.Perem(MainForm.FormsNames[6], false);
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
