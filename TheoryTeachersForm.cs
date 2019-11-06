using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Автошкола
{
    public partial class TheoryTeachersForm : Form
    {
        public TheoryTeachersForm()
        {
            InitializeComponent();
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet dataSet;
        string LastSearchingText = "";
        int LastFoundRow = -1;

        WorkStatusesForm WorkStatusesForm = new WorkStatusesForm();
        static public bool WorkStatusesFormOpened = false;

        bool FormLoad = false;
        bool FirstLoad = true;

        void ReloadTheoryTeachers()
        {
            dataSet = BusinessLogic.ReadWorkers();
            TheoryTeachers_dataGridView.DataSource = dataSet;
            TheoryTeachers_dataGridView.DataMember = "TheoryTeachers";

            TheoryTeachers_dataGridView.Columns["ID"].Visible = false;
            TheoryTeachers_dataGridView.Columns["Surname"].Visible = false;
            TheoryTeachers_dataGridView.Columns["FirstName"].Visible = false;
            TheoryTeachers_dataGridView.Columns["PatronymicName"].Visible = false;
            TheoryTeachers_dataGridView.Columns["Photo"].Visible = false;
            TheoryTeachers_dataGridView.Columns["WorkStatus"].Visible = false;
            TheoryTeachers_dataGridView.Columns["FIO"].Visible = false;
            TheoryTeachers_dataGridView.Columns["WorkStatusName"].Visible = false;

            IDColumn.DataPropertyName = "ID";
            SurnameColumn.DataPropertyName = "Surname";
            FirstNameColumn.DataPropertyName = "FirstName";
            PatronymicNameColumn.DataPropertyName = "PatronymicName";
            WorkStatusColumn.DataPropertyName = "WorkStatusName";
        }

        private void TheoryTeachersForm_Load(object sender, EventArgs e)
        {
            ReloadTheoryTeachers();
            FormLoad = true;
            TheoryTeachers_dataGridView_SelectionChanged(sender, e);
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            SearchingInDataGridViewClass.Search(Search_textBox, ref TheoryTeachers_dataGridView, Direction_checkBox,
                ref LastSearchingText, ref LastFoundRow, "SurnameColumn", "FirstNameColumn", "PatronymicNameColumn", "WorkStatusColumn");
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

        private void TheoryTeachers_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (FormLoad && TheoryTeachers_dataGridView.SelectedRows.Count == 1)
            {
                try
                {
                    if (TheoryTeachers_dataGridView.SelectedRows[0].Cells["Photo"].Value.ToString() != "")
                    {
                        Photo_pictureBox.Image = byteArrayToImage((byte[])TheoryTeachers_dataGridView.SelectedRows[0].Cells["Photo"].Value);
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Ошибка при чтении фотографии из базы");
                }
            }
            else
            {
                Photo_pictureBox.Image = null;
            }
        }

        Image byteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Произошла ошибка при конвертации массива байтов в изображение");
                return null;
            }
        }

        private void Reload_button_Click(object sender, EventArgs e)
        {
            FormLoad = false;
            ReloadTheoryTeachers();
            FormLoad = true;
            TheoryTeachers_dataGridView_SelectionChanged(sender, e);
        }

        private void TheoryTeachersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            MainForm.Perem(MainForm.FormsNames[4], false);
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TheoryTeachersForm_VisibleChanged(object sender, EventArgs e)
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
