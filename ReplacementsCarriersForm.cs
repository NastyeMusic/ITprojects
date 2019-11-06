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
    public partial class ReplacementsCarriersForm : Form
    {
        public ReplacementsCarriersForm()
        {
            InitializeComponent();
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet dataSet;
        string LastSearchingText = "";
        int LastFoundRow = -1;
        int LastSelectionIndex;
        bool FirstLoad = true;

        void ReloadReplacementsCarriers()
        {
            dataSet = BusinessLogic.ReadReplacementsCarriers();
            ReplacementsCarriers_dataGridView.DataSource = dataSet;
            ReplacementsCarriers_dataGridView.DataMember = "ReplacementsCarriers";

            ReplacementsCarriers_dataGridView.Columns["ID"].Visible = false;
            ReplacementsCarriers_dataGridView.Columns["CarrierUse"].Visible = false;
            ReplacementsCarriers_dataGridView.Columns["CarrierReplacement"].Visible = false;
            ReplacementsCarriers_dataGridView.Columns["DateBeginReplacement"].Visible = false;
            ReplacementsCarriers_dataGridView.Columns["DateEndReplacement"].Visible = false;

            IDColumn.DataPropertyName = "ID";

            FIOColumn.DataSource = dataSet.CarriersUses;
            FIOColumn.DisplayMember = "InstructorName";
            FIOColumn.ValueMember = "ID";
            FIOColumn.DataPropertyName = "CarrierUse";

            ReplaceableCarrierColumn.DataSource = dataSet.CarriersUses;
            ReplaceableCarrierColumn.DisplayMember = "CarrierName";
            ReplaceableCarrierColumn.ValueMember = "ID";
            ReplaceableCarrierColumn.DataPropertyName = "CarrierUse";

            ReplacingCarrierColumn.DataSource = dataSet.Carriers;
            ReplacingCarrierColumn.DisplayMember = "FinalName";
            ReplacingCarrierColumn.ValueMember = "ID";
            ReplacingCarrierColumn.DataPropertyName = "CarrierReplacement";

            DateBeginColumn.DataPropertyName = "DateBeginReplacement";
            DateEndColumn.DataPropertyName = "DateEndReplacement";

            if (LastSelectionIndex != -1)
                ReplacementsCarriers_dataGridView.CurrentCell = ReplacementsCarriers_dataGridView[1, LastSelectionIndex];
        }

        private void ReplacementsCarriersForm_Load(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            ReloadReplacementsCarriers();
            Edit_button.Enabled = false;
            Delete_button.Enabled = false;
            ReplacementsCarriers_dataGridView_SelectionChanged(sender, e);
        }

        private void ReplacementsCarriers_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ReplacementsCarriers_dataGridView.SelectedRows.Count == 1)
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
            SearchingInDataGridViewClass.Search(Search_textBox, ref ReplacementsCarriers_dataGridView, Direction_checkBox,
                ref LastSearchingText, ref LastFoundRow, "FIOColumn", "ReplaceableCarrierColumn", "ReplacingCarrierColumn");
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

        private void ReloadReplacementsCarriers_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            ReloadReplacementsCarriers();
        }

        private void ReplacementsCarriersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            MainForm.Perem(MainForm.FormsNames[19], false);
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            ReloadReplacementsCarriers();
            //dataSet = BusinessLogic.ReadReplacementsCarriers();
            AddEditReplacementCarrierForm AddReplacementCarrier = new AddEditReplacementCarrierForm(dataSet.ReplacementsCarriers,
                dataSet.CarriersUses, dataSet.Carriers, dataSet.Instructors, null);
            AddReplacementCarrier.Text = "Добавление замены ТС инструктора";
            this.Enabled = false;
            AddReplacementCarrier.ShowDialog();
            if (AddReplacementCarrier.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteReplacementsCarriers(dataSet);
                ReloadReplacementsCarriers();
            }
            this.Enabled = true;
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            ReloadReplacementsCarriers();
            //dataSet = BusinessLogic.ReadReplacementsCarriers();
            AddEditReplacementCarrierForm EditReplacementCarrier = new AddEditReplacementCarrierForm(dataSet.ReplacementsCarriers,
                dataSet.CarriersUses, dataSet.Carriers, dataSet.Instructors,
                dataSet.ReplacementsCarriers.Rows.Find(ReplacementsCarriers_dataGridView.SelectedRows[0].Cells["ID"].Value));
            EditReplacementCarrier.Text = "Редактирование замены ТС инструктора";
            this.Enabled = false;
            EditReplacementCarrier.ShowDialog();
            if (EditReplacementCarrier.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteReplacementsCarriers(dataSet);
                ReloadReplacementsCarriers();
            }
            this.Enabled = true;
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            if (ReplacementsCarriers_dataGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Не выбрана строка для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    dataSet.ReplacementsCarriers.Rows.Find(ReplacementsCarriers_dataGridView.SelectedRows[0].Cells["ID"].Value).Delete();
                    dataSet = BusinessLogic.WriteReplacementsCarriers(dataSet);
                    ReloadReplacementsCarriers();
                }
                catch
                {
                    MessageBox.Show("Не удалось удалить выбранную строку.\nСкорее всего, на данную строку имеются ссылки из других таблиц", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReloadReplacementsCarriers();
                }
            }
        }

        private void ReplacementsCarriersForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                if (!FirstLoad)
                    ReloadReplacementsCarriers_button_Click(sender, e);
                else
                    FirstLoad = false;
            }
        }
    }
}
