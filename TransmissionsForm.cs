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

        void ReloadTransmissions()
        {
            dataSet = BusinessLogic.ReadTransmissions();
            Transmissions_dataGridView.DataSource = dataSet;
            Transmissions_dataGridView.DataMember = "Transmissions";

            Transmissions_dataGridView.Columns["ID"].Visible = false;
            Transmissions_dataGridView.Columns["Transmission"].Visible = false;

            IDColumn.DataPropertyName = "ID";
            NameColumn.DataPropertyName = "Transmission";
        }

        private void TransmissionsFrom_Load(object sender, EventArgs e)
        {
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
            bool Find = false;
            string CurrentSearchingText = SearchTransmission_textBox.Text.Trim();
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
                for (int i = BeginRow; i < Transmissions_dataGridView.RowCount; i++)
                {
                    if (Transmissions_dataGridView[1, i].Value.ToString().Contains(CurrentSearchingText))
                    {
                        Transmissions_dataGridView.CurrentCell = Transmissions_dataGridView[1, i];
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
                    if (Transmissions_dataGridView[1, i].Value.ToString().Contains(CurrentSearchingText))
                    {
                        Transmissions_dataGridView.CurrentCell = Transmissions_dataGridView[1, i];
                        LastFoundRow = i;
                        return;
                    }
                }
                if (!Find)
                {
                    DialogResult result = MessageBox.Show("Поиск достиг первой строки таблицы. Продолжить поиск с конца таблицы?", "Поиск", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        BeginRow = Transmissions_dataGridView.RowCount - 1;
                        goto Search;
                    }
                }
            }
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
    }
}
