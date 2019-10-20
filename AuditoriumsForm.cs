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
    public partial class AuditoriumsForm : Form
    {
        public AuditoriumsForm()
        {
            InitializeComponent();
        }

        public BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet dataSet;
        string LastSearchingText = "";
        int LastFoundRow = -1;

        void ReloadAuditoriums()
        {
            dataSet = BusinessLogic.ReadAuditoriums();
            Auditoriums_dataGridView.DataSource = dataSet;
            Auditoriums_dataGridView.DataMember = "Auditoriums";

            Auditoriums_dataGridView.Columns["ID"].Visible = false;
            Auditoriums_dataGridView.Columns["Name"].Visible = false;

            IDColumn.DataPropertyName = "ID";
            NameColumn.DataPropertyName = "Name";
        }

        private void AuditoriumsForm_Load(object sender, EventArgs e)
        {
            ReloadAuditoriums();
            Edit_button.Enabled = false;
            Delete_button.Enabled = false;
            Auditoriums_dataGridView_SelectionChanged(sender, e);
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            bool Find = false;
            string CurrentSearchingText = SearchAuditorium_textBox.Text.Trim();
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
                for (int i = BeginRow; i < Auditoriums_dataGridView.RowCount; i++)
                {
                    if (Auditoriums_dataGridView[1, i].Value.ToString().Contains(CurrentSearchingText))
                    {
                        Auditoriums_dataGridView.CurrentCell = Auditoriums_dataGridView[1, i];
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
                    if (Auditoriums_dataGridView[1, i].Value.ToString().Contains(CurrentSearchingText))
                    {
                        Auditoriums_dataGridView.CurrentCell = Auditoriums_dataGridView[1, i];
                        LastFoundRow = i;
                        return;
                    }
                }
                if (!Find)
                {
                    DialogResult result = MessageBox.Show("Поиск достиг первой строки таблицы. Продолжить поиск с конца таблицы?", "Поиск", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        BeginRow = Auditoriums_dataGridView.RowCount - 1;
                        goto Search;
                    }
                }
            }
        }

        private void SearchAuditorium_textBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Auditoriums_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (Auditoriums_dataGridView.SelectedRows.Count == 1)
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
            AddEditAuditoriumsForm AddAuditorium = new AddEditAuditoriumsForm(dataSet.Auditoriums, null);
            AddAuditorium.Text = "Добавление аудитории";
            this.Enabled = false;
            AddAuditorium.ShowDialog();
            if (AddAuditorium.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteAuditoriums(dataSet);
                ReloadAuditoriums();
            }
            this.Enabled = true;
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            AddEditAuditoriumsForm EditAuditorium = new AddEditAuditoriumsForm(dataSet.Auditoriums, dataSet.Auditoriums.Rows.Find(Auditoriums_dataGridView.SelectedRows[0].Cells["ID"].Value));
            EditAuditorium.Text = "Редактирование аудитории";
            this.Enabled = false;
            EditAuditorium.ShowDialog();
            if (EditAuditorium.DialogResult == DialogResult.OK)
            {
                dataSet = BusinessLogic.WriteAuditoriums(dataSet);
                ReloadAuditoriums();
            }
            this.Enabled = true;
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (Auditoriums_dataGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Не выбрана строка для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    dataSet.Auditoriums.Rows.Find(Auditoriums_dataGridView.SelectedRows[0].Cells["ID"].Value).Delete();
                    dataSet = BusinessLogic.WriteAuditoriums(dataSet);
                    ReloadAuditoriums();
                }
                catch
                {
                    MessageBox.Show("Не удалось удалить выбранную строку.\nСкорее всего, на данную строку имеются ссылки из других таблиц", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReloadAuditoriums();
                }
            }
        }

        private void AuditoriumsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            MainForm.Perem(MainForm.FormsNames[2], false);
        }
    }
}
