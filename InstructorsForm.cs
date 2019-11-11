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
    public partial class InstructorsForm : Form
    {
        public InstructorsForm()
        {
            InitializeComponent();
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet dataSet;
        string LastSearchingInstructorText = "";
        int LastFoundInstructorRow = -1;
        string LastSearchingCarrierText = "";
        int LastFoundCarrierRow = -1;

        bool FormLoad = false;
        bool FirstLoad = true;
        bool CategoriesLoad = false;

        void ReloadInstructors()
        {
            dataSet = BusinessLogic.ReadInstructors();
            Instructors_dataGridView.DataSource = dataSet;
            Instructors_dataGridView.DataMember = "Instructors";

            Instructors_dataGridView.Columns["ID"].Visible = false;
            Instructors_dataGridView.Columns["Surname"].Visible = false;
            Instructors_dataGridView.Columns["FirstName"].Visible = false;
            Instructors_dataGridView.Columns["PatronymicName"].Visible = false;
            Instructors_dataGridView.Columns["Photo"].Visible = false;
            Instructors_dataGridView.Columns["WorkStatus"].Visible = false;
            Instructors_dataGridView.Columns["FIO"].Visible = false;
            Instructors_dataGridView.Columns["WorkStatusName"].Visible = false;

            InstructorIDColumn.DataPropertyName = "ID";
            SurnameColumn.DataPropertyName = "Surname";
            FirstNameColumn.DataPropertyName = "FirstName";
            PatronymicNameColumn.DataPropertyName = "PatronymicName";
            WorkStatusColumn.DataPropertyName = "WorkStatusName";
        }

        private void InstructorsForm_Load(object sender, EventArgs e)
        {
            ReloadInstructors();
            FormLoad = true;
            Instructors_dataGridView_SelectionChanged(sender, e);
        }

        private void SearchInstructor_button_Click(object sender, EventArgs e)
        {
            SearchingInDataGridViewClass.Search(SearchInstructor_textBox, ref Instructors_dataGridView, DirectionInstructor_checkBox,
                ref LastSearchingInstructorText, ref LastFoundInstructorRow, "SurnameColumn", "FirstNameColumn", "PatronymicNameColumn", "WorkStatusColumn");
        }

        private void SearchInstructor_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Enter)
            {
                SearchInstructor_button_Click(sender, e);
            }
            if ((char)e.KeyChar == (Char)Keys.Back)
            {
                LastSearchingInstructorText = "";
            }
        }

        private void SearchCarrier_button_Click(object sender, EventArgs e)
        {
            SearchingInDataGridViewClass.Search(SearchCarrier_textBox, ref Carriers_dataGridView, DirectionCarrier_checkBox,
                ref LastSearchingCarrierText, ref LastFoundCarrierRow, "BrandColumn", "ModelColumn", "StateNumberColumn");
        }

        private void SearchCarrier_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Enter)
            {
                SearchCarrier_button_Click(sender, e);
            }
            if ((char)e.KeyChar == (Char)Keys.Back)
            {
                LastSearchingCarrierText = "";
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

        private void Instructors_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (FormLoad && Instructors_dataGridView.SelectedRows.Count == 1)
            {
                // вывод фотографии
                try
                {
                    if (Instructors_dataGridView.SelectedRows[0].Cells["Photo"].Value.ToString() != "")
                    {
                        Photo_pictureBox.Image = byteArrayToImage((byte[])Instructors_dataGridView.SelectedRows[0].Cells["Photo"].Value);
                    }
                    else
                        Photo_pictureBox.Image = null;
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Ошибка при чтении фотографии из базы");
                }
                CategoriesLoad = false;
                // загрузка категорий
                AutoschoolDataSet.CategoriesDataTable CategoriesDT = BusinessLogic.ReadCategoriesOfInstructor(Convert.ToInt32(Instructors_dataGridView.SelectedRows[0].Cells["InstructorIDColumn"].Value.ToString())).Categories;
                Categories_dataGridView.Rows.Clear();
                for (int i = 0; i < CategoriesDT.Rows.Count; i++)
                {
                    Categories_dataGridView.Rows.Add(CategoriesDT.Rows[i]["ID"], CategoriesDT.Rows[i]["Name"]);
                }
                CategoriesLoad = true;
                Categories_dataGridView_SelectionChanged(sender, e);
            }
            else
            {
                Photo_pictureBox.Image = null;
                CategoriesLoad = false;
                Categories_dataGridView.Rows.Clear();
                Carriers_dataGridView.Rows.Clear();
                CategoriesLoad = true;
            }
        }

        private void Reload_button_Click(object sender, EventArgs e)
        {
            FormLoad = false;
            ReloadInstructors();
            FormLoad = true;
            Instructors_dataGridView_SelectionChanged(sender, e);
        }

        private void InstructorsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.Perem(MainForm.FormsNames[4], false);
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InstructorsForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                if (!FirstLoad)
                    Reload_button_Click(sender, e);
                else
                    FirstLoad = false;
            }
        }

        private void Categories_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CategoriesLoad && Instructors_dataGridView.SelectedRows.Count > 0 && Categories_dataGridView.SelectedRows.Count > 0)
            {
                AutoschoolDataSet TempDS = BusinessLogic.ReadCarriersByCategoryIDANDInstructorID(
                    Convert.ToInt32(Categories_dataGridView.SelectedRows[0].Cells["CategoryIDColumn"].Value.ToString()),
                    Convert.ToInt32(Instructors_dataGridView.SelectedRows[0].Cells["InstructorIDColumn"].Value.ToString()));
                Carriers_dataGridView.Rows.Clear();
                for (int i = 0; i < TempDS.Carriers.Rows.Count; i++)
                {
                    Carriers_dataGridView.Rows.Add(
                        TempDS.Carriers.Rows[i]["ID"].ToString(),
                        TempDS.Carriers.Rows[i]["Brand"].ToString(),
                        TempDS.Carriers.Rows[i]["Model"].ToString(),
                        TempDS.Carriers.Rows[i]["StateNumber"].ToString(),
                        TempDS.Carriers.Rows[i]["Color"].ToString(),
                        TempDS.Transmissions.Rows.Find(TempDS.Carriers.Rows[i]["Transmission"].ToString())["Transmission"],
                        TempDS.Categories.Rows.Find(TempDS.Carriers.Rows[i]["Category"].ToString())["Name"],
                        TempDS.CarriersStatuses.Rows.Find(TempDS.Carriers.Rows[i]["Status"].ToString())["Name"]
                        );
                }
            }
        }
    }
}
