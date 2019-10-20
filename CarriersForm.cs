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

        public BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet dataSet;
        string LastSearchingText = "";
        int LastFoundRow = -1;

        //WorkStatusesForm WorkStatusesForm = new WorkStatusesForm();
        //static bool WorkStatusesFormOpened = false;

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
        }

        private void CarriersForm_Load(object sender, EventArgs e)
        {
            ReloadCarriers();
            Edit_button.Enabled = false;
            Delete_button.Enabled = false;
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            bool Find = false;
            string CurrentSearchingText = SearchCarrier_textBox.Text.Trim();
            int BeginRow = 0;
            if (LastSearchingText == CurrentSearchingText)
            {
                if (Direction_checkBox.Checked)
                    BeginRow = LastFoundRow + 1;
                else
                    BeginRow = LastFoundRow - 1;
            }
            else
                LastSearchingText = CurrentSearchingText;
            Search:
            if (Direction_checkBox.Checked)
            {
                for (int i = BeginRow; i < Carriers_dataGridView.RowCount; i++)
                {
                    if (Carriers_dataGridView[1, i].Value.ToString().Contains(CurrentSearchingText))
                    {
                        Carriers_dataGridView.CurrentCell = Carriers_dataGridView[1, i];
                        LastFoundRow = i;
                        return;
                    }
                    if (Carriers_dataGridView[2, i].Value.ToString().Contains(CurrentSearchingText))
                    {
                        Carriers_dataGridView.CurrentCell = Carriers_dataGridView[2, i];
                        LastFoundRow = i;
                        return;
                    }
                    if (Carriers_dataGridView[3, i].Value.ToString().Contains(CurrentSearchingText))
                    {
                        Carriers_dataGridView.CurrentCell = Carriers_dataGridView[3, i];
                        LastFoundRow = i;
                        return;
                    }
                }
                if (!Find)
                {
                    DialogResult result = MessageBox.Show("Поиск достиг последней строки таблицы. Продолжить поиск с начала таблицы?", "Поиск", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        BeginRow = 0;
                        goto Search;
                    }
                }
            }
            else
            {
                for (int i = BeginRow; i >= 0; i--)
                {
                    if (Carriers_dataGridView[1, i].Value.ToString().Contains(CurrentSearchingText))
                    {
                        Carriers_dataGridView.CurrentCell = Carriers_dataGridView[1, i];
                        LastFoundRow = i;
                        return;
                    }
                    if (Carriers_dataGridView[2, i].Value.ToString().Contains(CurrentSearchingText))
                    {
                        Carriers_dataGridView.CurrentCell = Carriers_dataGridView[2, i];
                        LastFoundRow = i;
                        return;
                    }
                    if (Carriers_dataGridView[3, i].Value.ToString().Contains(CurrentSearchingText))
                    {
                        Carriers_dataGridView.CurrentCell = Carriers_dataGridView[3, i];
                        LastFoundRow = i;
                        return;
                    }
                }
                if (!Find)
                {
                    DialogResult result = MessageBox.Show("Поиск достиг первой строки таблицы. Продолжить поиск с конца таблицы?", "Поиск", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        BeginRow = Carriers_dataGridView.RowCount - 1;
                        goto Search;
                    }
                }
            }
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
            ReloadCarriers();
        }

        private void CarriersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            MainForm.Perem(MainForm.FormsNames[6], false);
        }
    }
}
