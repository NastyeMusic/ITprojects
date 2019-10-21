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

        int LastSelectionIndex;

        void ReloadAuditoriums()
        {
            dataSet = BusinessLogic.ReadAuditoriums();
            Auditoriums_dataGridView.DataSource = dataSet;
            Auditoriums_dataGridView.DataMember = "Auditoriums";

            Auditoriums_dataGridView.Columns["ID"].Visible = false;
            Auditoriums_dataGridView.Columns["Name"].Visible = false;

            IDColumn.DataPropertyName = "ID";
            NameColumn.DataPropertyName = "Name";

            if (LastSelectionIndex != -1)
                Auditoriums_dataGridView.CurrentCell = Auditoriums_dataGridView[1, LastSelectionIndex];
        }

        private void AuditoriumsForm_Load(object sender, EventArgs e)
        {
            LastSelectionIndex = -1;
            ReloadAuditoriums();
            Edit_button.Enabled = false;
            Delete_button.Enabled = false;
            Auditoriums_dataGridView_SelectionChanged(sender, e);
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            SearchingInDataGridViewClass.Search(SearchAuditorium_textBox, ref Auditoriums_dataGridView, Direction_checkBox,
                ref LastSearchingText, ref LastFoundRow, 1);            
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
            LastSelectionIndex = Auditoriums_dataGridView.SelectedRows[0].Index;
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
