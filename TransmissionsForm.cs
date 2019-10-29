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
    public partial class TransmissionsForm : Form
    {
        public TransmissionsForm()
        {
            InitializeComponent();
        }

        public BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet dataSet;
        string LastSearchingText = "";
        int LastFoundRow = -1;

        int LastSelectionIndex;

        void ReloadTransmissions()
        {
            dataSet = BusinessLogic.ReadTransmissions();
            Transmissions_dataGridView.DataSource = dataSet;
            Transmissions_dataGridView.DataMember = "Transmissions";

            Transmissions_dataGridView.Columns["ID"].Visible = false;
            Transmissions_dataGridView.Columns["Transmission"].Visible = false;

            IDColumn.DataPropertyName = "ID";
            NameColumn.DataPropertyName = "Transmission";

            if (LastSelectionIndex != -1)
                Transmissions_dataGridView.CurrentCell = Transmissions_dataGridView[1, LastSelectionIndex];
        }

        private void TransmissionsFrom_Load(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            ReloadTransmissions();
            Edit_button.Enabled = false;
            Delete_button.Enabled = false;
            Transmissions_dataGridView_SelectionChanged(sender, e);
        }

        private void Transmissions_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (Transmissions_dataGridView.SelectedRows.Count == 1)
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
            SearchingInDataGridViewClass.Search(SearchTransmission_textBox, ref Transmissions_dataGridView, Direction_checkBox,
                ref LastSearchingText, ref LastFoundRow, "NameColumn");
        }

        private void SearchTransmission_textBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TransmissionsFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            MainForm.Perem(MainForm.FormsNames[8], false);
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            dataSet = BusinessLogic.ReadTransmissions();
            AddEditTransmissionForm AddTransmission = new AddEditTransmissionForm(dataSet.Transmissions, null);
            AddTransmission.Text = "Добавление трансмиссии";
            this.Enabled = false;
            AddTransmission.ShowDialog();
            if (AddTransmission.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteTransmissions(dataSet);
                ReloadTransmissions();
            }
            this.Enabled = true;
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            dataSet = BusinessLogic.ReadTransmissions();
            LastSelectionIndex = Transmissions_dataGridView.SelectedRows[0].Index;
            AddEditTransmissionForm EditTransmission = new AddEditTransmissionForm(dataSet.Transmissions, dataSet.Transmissions.Rows.Find(Transmissions_dataGridView.SelectedRows[0].Cells["ID"].Value));
            EditTransmission.Text = "Редактирование трансмиссии";
            this.Enabled = false;
            EditTransmission.ShowDialog();
            if (EditTransmission.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteTransmissions(dataSet);
                ReloadTransmissions();
            }
            this.Enabled = true;
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            if (Transmissions_dataGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Не выбрана строка для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    dataSet.Transmissions.Rows.Find(Transmissions_dataGridView.SelectedRows[0].Cells["ID"].Value).Delete();
                    dataSet = BusinessLogic.WriteTransmissions(dataSet);
                    ReloadTransmissions();
                }
                catch
                {
                    MessageBox.Show("Не удалось удалить выбранную строку.\nСкорее всего, на данную строку имеются ссылки из других таблиц", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReloadTransmissions();
                }
            }
        }

        private void Reload_button_Click(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            ReloadTransmissions();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
