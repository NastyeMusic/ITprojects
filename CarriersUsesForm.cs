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
    public partial class CarriersUsesForm : Form
    {
        public CarriersUsesForm()
        {
            InitializeComponent();
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet dataSet;
        string LastSearchingText = "";
        int LastFoundRow = -1;
        int LastSelectionIndex;

        void ReloadCarriersUses()
        {
            dataSet = BusinessLogic.ReadCarriersUses();
            CarriersUses_dataGridView.DataSource = dataSet;
            CarriersUses_dataGridView.DataMember = "CarriersUses";

            CarriersUses_dataGridView.Columns["ID"].Visible = false;
            CarriersUses_dataGridView.Columns["Instructor"].Visible = false;
            CarriersUses_dataGridView.Columns["Carrier"].Visible = false;
            CarriersUses_dataGridView.Columns["InstructorName"].Visible = false;
            CarriersUses_dataGridView.Columns["CarrierName"].Visible = false;
            CarriersUses_dataGridView.Columns["CategoryCarrierID"].Visible = false;

            IDColumn.DataPropertyName = "ID";

            SurnameColumn.DataSource = dataSet.Instructors;
            SurnameColumn.DisplayMember = "Surname";
            SurnameColumn.ValueMember = "ID";
            SurnameColumn.DataPropertyName = "Instructor";

            FirstNameColumn.DataSource = dataSet.Instructors;
            FirstNameColumn.DisplayMember = "FirstName";
            FirstNameColumn.ValueMember = "ID";
            FirstNameColumn.DataPropertyName = "Instructor";

            PatronymicNameColumn.DataSource = dataSet.Instructors;
            PatronymicNameColumn.DisplayMember = "PatronymicName";
            PatronymicNameColumn.ValueMember = "ID";
            PatronymicNameColumn.DataPropertyName = "Instructor";

            CarrierColumn.DataSource = dataSet.Carriers;
            CarrierColumn.DisplayMember = "FinalName";
            CarrierColumn.ValueMember = "ID";
            CarrierColumn.DataPropertyName = "Carrier";

            if (LastSelectionIndex != -1)
                CarriersUses_dataGridView.CurrentCell = CarriersUses_dataGridView[1, LastSelectionIndex];
        }

        private void CarriersUsesForm_Load(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            ReloadCarriersUses();
            Edit_button.Enabled = false;
            Delete_button.Enabled = false;
            CarriersUses_dataGridView_SelectionChanged(sender, e);
        }

        private void CarriersUses_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CarriersUses_dataGridView.SelectedRows.Count == 1)
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
            SearchingInDataGridViewClass.Search(Search_textBox, ref CarriersUses_dataGridView, Direction_checkBox,
                ref LastSearchingText, ref LastFoundRow, "SurnameColumn", "FirstNameColumn", "PatronymicNameColumn", "CarrierColumn");
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

        private void ReloadCarriersUses_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            ReloadCarriersUses();
        }

        private void CarriersUsesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            MainForm.Perem(MainForm.FormsNames[18], false);
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            AddEditCarrierUseForm AddCarrierUse = new AddEditCarrierUseForm(dataSet.CarriersUses,
                dataSet.Instructors, dataSet.Carriers, null);
            AddCarrierUse.Text = "Добавление ТС инструктору";
            this.Enabled = false;
            AddCarrierUse.ShowDialog();
            if (AddCarrierUse.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteCarriersUses(dataSet);
                ReloadCarriersUses();
            }
            this.Enabled = true;
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = CarriersUses_dataGridView.SelectedRows[0].Index;
            AddEditCarrierUseForm EditCarrierUse = new AddEditCarrierUseForm(dataSet.CarriersUses,
                dataSet.Instructors, dataSet.Carriers, 
                dataSet.CarriersUses.Rows.Find(CarriersUses_dataGridView.SelectedRows[0].Cells["ID"].Value));
            EditCarrierUse.Text = "Редактирование ТС инструктора";
            this.Enabled = false;
            EditCarrierUse.ShowDialog();
            if (EditCarrierUse.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteCarriersUses(dataSet);
                ReloadCarriersUses();
            }
            this.Enabled = true;
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (CarriersUses_dataGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Не выбрана строка для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    dataSet.CarriersUses.Rows.Find(CarriersUses_dataGridView.SelectedRows[0].Cells["ID"].Value).Delete();
                    dataSet = BusinessLogic.WriteCarriersUses(dataSet);
                    ReloadCarriersUses();
                }
                catch
                {
                    MessageBox.Show("Не удалось удалить выбранную строку.\nСкорее всего, на данную строку имеются ссылки из других таблиц", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReloadCarriersUses();
                }
            }
        }
    }
}
