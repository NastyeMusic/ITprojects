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
    public partial class AddEditStudent : Form
    {
        public AddEditStudent(string GroupName, AutoschoolDataSet.StudentsDataTable studentsDataTable, 
            AutoschoolDataSet.GroupsDataTable groupsDataTable,  AutoschoolDataSet.InstructorsDataTable instructorsDataTable, 
            DataRow row)
        {
            InitializeComponent();
            NameOfGroup = GroupName;
            this.studentsDataTable = studentsDataTable;
            this.groupsDataTable = groupsDataTable;
            this.instructorsDataTable = instructorsDataTable;
            dataRow = row;
        }

        string NameOfGroup;
        public BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet dataSetForCarriers, dataSetForCarriersUses;
        AutoschoolDataSet.GroupsDataTable groupsDataTable;
        AutoschoolDataSet.InstructorsDataTable instructorsDataTable;
        AutoschoolDataSet.CarriersDataTable carriersDataTable;
        AutoschoolDataSet.StudentsDataTable studentsDataTable;
        AutoschoolDataSet.CarriersUsesDataTable carriersUsesDataTable;
        AutoschoolDataSet.InstructorsCategoriesDataTable instructorsForThisGroupDataTable;
        DataRow dataRow;
        int SelectedInstructorID = -1;
        int SelectedCarrierID = -1;
        int SelectedCarrierUseID = -1;

        bool FormLoad = false;

        byte[] ImageByte;
        //MemoryStream memoryStream = new MemoryStream(); // Поток в который запишем изображение

        private void AddEditStudent_Load(object sender, EventArgs e)
        {
            Group_comboBox.DataSource = groupsDataTable;
            Group_comboBox.DisplayMember = "Name";
            Group_comboBox.ValueMember = "ID";
            if (NameOfGroup != null && NameOfGroup != "")
                Group_comboBox.DataBindings.Add("SelectedText", dataRow, NameOfGroup);
            //Group_comboBox.SelectedItem = NameOfGroup;
            else
                Group_comboBox.SelectedIndex = -1;
            Group_comboBox.AutoCompleteMode = AutoCompleteMode.Append;

            Instructor_comboBox.DataSource = instructorsDataTable;
            Instructor_comboBox.DisplayMember = "FIO";
            Instructor_comboBox.ValueMember = "ID";
            Instructor_comboBox.AutoCompleteMode = AutoCompleteMode.Append;

            if (dataRow != null)
            {
                Surname_textBox.Text = dataRow["Surname"].ToString();
                FirstName_textBox.Text = dataRow["FirstName"].ToString();
                PatronymicName_textBox.Text = dataRow["PatronymicName"].ToString();
                PhoneNumber_maskedTextBox.Text = dataRow["PhoneNumber"].ToString();
                Retraining_checkBox.Checked = Convert.ToBoolean(dataRow["Retraining"].ToString());
                Group_comboBox.SelectedValue = dataRow["Group"].ToString();
                Instructor_comboBox.SelectedItem = dataRow["InstructorName"].ToString();
                ChoosenCarrier_label.Text = dataRow["CarrierName"].ToString();
                InstructorChanged();
                if (CarriersUses_dataGridView.Rows.Count > 1)
                {
                    for (int i = 0; i < CarriersUses_dataGridView.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(dataRow["CarrierUse"].ToString()) == Convert.ToInt32(CarriersUses_dataGridView[4, i].Value))
                        {
                            CarriersUses_dataGridView.Rows[i].Selected = true;
                            ChangeSelectedCarrier();
                            break;
                        }
                    }
                }
                if (dataRow["Photo"].ToString() != "")
                    Photo_pictureBox.Image = byteArrayToImage((byte[])dataRow["Photo"]);
                /*System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                Image img = (Image)converter.ConvertFromString(dataRow["Photo"].ToString());
                Photo_pictureBox.Image = img;*/
            }
            else
            {
                Surname_textBox.Text = "";
                FirstName_textBox.Text = "";
                PatronymicName_textBox.Text = "";
                PhoneNumber_maskedTextBox.Text = "";
                Retraining_checkBox.Checked = false;
                Instructor_comboBox.SelectedIndex = -1;
                InstructorChanged();
                Photo_pictureBox.Image = null;
            }
            FormLoad = true;
        }

        private void AddEditStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            // проверку следует проводить только при нажатии кнопки "Сохранить"
            if (DialogResult == DialogResult.OK)
            {
                // используем обработку исключительных ситуаций для проверки
                // на правильность ввода и вывода информации об ошибках
                try
                {
                    if (Group_comboBox.SelectedIndex == -1)
                    {
                        Group_comboBox.Focus();
                        throw new Exception("Не выбрана группа курсанта");
                    }
                    if (Surname_textBox.Text == "")
                    {
                        Surname_textBox.Focus();
                        throw new Exception("Не указана фамилия студента");
                    }
                    if (FirstName_textBox.Text == "")
                    {
                        FirstName_textBox.Focus();
                        throw new Exception("Не указано имя студента");
                    }
                    if (PatronymicName_textBox.Text == "")
                    {
                        PatronymicName_textBox.Focus();
                        throw new Exception("Не указано отчество студента");
                    }
                    if (PhoneNumber_maskedTextBox.Text == "")
                    {
                        PhoneNumber_maskedTextBox.Focus();
                        throw new Exception("Не указан номер телефона студента");
                    }                    
                    if (SelectedCarrierUseID == -1)
                    {
                        throw new Exception("Не выбрана связка инструктора с транспортным средством. \nСначала выберите инструктора из списка, а затем выберите одну из его ТС в таблице ниже. ");
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Ошибка");
                    e.Cancel = true;
                    return;
                }
                // редактирование
                if (dataRow != null)
                {
                    dataRow["Surname"] = Surname_textBox.Text;
                    dataRow["FirstName"] = FirstName_textBox.Text;
                    dataRow["PatronymicName"] = PatronymicName_textBox.Text;
                    dataRow["PhoneNumber"] = PhoneNumber_maskedTextBox.Text;
                    dataRow["Retraining"] = Retraining_checkBox.Checked;
                    dataRow["Group"] = Group_comboBox.SelectedValue;
                    dataRow["CarrierUse"] = SelectedCarrierUseID;
                    dataRow["Photo"] = ImageByte /*memoryStream.ToArray()*/;
                }
                else //добавление
                {
                    dataSetForCarriersUses = BusinessLogic.ReadCarriersUsesByID(SelectedCarrierUseID);
                    carriersUsesDataTable = dataSetForCarriersUses.CarriersUses;
                    studentsDataTable.AddStudentsRow(Surname_textBox.Text, FirstName_textBox.Text,
                        PatronymicName_textBox.Text, PhoneNumber_maskedTextBox.Text, Retraining_checkBox.Checked,
                        groupsDataTable[Group_comboBox.SelectedIndex], carriersUsesDataTable[0], /*memoryStream.ToArray()*/ ImageByte);
                }
            }            
        }

        void ControlEnterTextOneWord(object sender, ref KeyPressEventArgs e)
        {
            if ((((TextBox)sender).TextLength - ((TextBox)sender).SelectionLength) >= 50 && (char)e.KeyChar != (Char)Keys.Back)
                e.Handled = true;
            else
            {
                if ((char)e.KeyChar == (Char)Keys.Back) return;
                if ((char)e.KeyChar == (Char)Keys.ControlKey) return;
                if (char.IsLetter(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void Surname_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlEnterTextOneWord(sender, ref e);
        }

        private void FirstName_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlEnterTextOneWord(sender, ref e);
        }

        private void PatronymicName_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlEnterTextOneWord(sender, ref e);
        }

        void ControlEnterNumber(object sender, ref KeyPressEventArgs e)
        {
            if ((((TextBox)sender).TextLength - ((TextBox)sender).SelectionLength) >= 20 && (char)e.KeyChar != (Char)Keys.Back)
                e.Handled = true;
            else
            {
                char number = e.KeyChar;
                if (!Char.IsDigit(number) && ((char)e.KeyChar == (Char)Keys.Back))
                    e.Handled = true;
            }
        }

        private void Instructor_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InstructorChanged();
        }

        private void CarriersUses_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            ChangeSelectedCarrier();
        }

        private void ChangePhoto_button_Click(object sender, EventArgs e)
        {
            if (SelectPicture_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap image = new Bitmap(SelectPicture_openFileDialog.FileName.ToString());
                    ImageByte = imageToByteArray(image, SelectPicture_openFileDialog.FileName.ToString());
                    //Image image = Image.FromFile(SelectPicture_openFileDialog.FileName.ToString());
                    Photo_pictureBox.Image = image;
                    //image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg); //Сохраняем изображение в поток.
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка при загрузке картинки", "Ошибка");
                }
            }
        }

        void ChangeSelectedCarrier()
        {
            int CurRow = CarriersUses_dataGridView.SelectedRows[0].Index;
            SelectedCarrierID = Convert.ToInt32(CarriersUses_dataGridView[3, CurRow].Value);
            SelectedCarrierUseID = Convert.ToInt32(CarriersUses_dataGridView[4, CurRow].Value);
            ChoosenCarrier_label.Text = CarriersUses_dataGridView[1, CurRow].Value.ToString();
        }

        private void PhoneNumber_maskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlEnterNumber(sender, ref e);
        }

        private void ReloadGroups_button_Click(object sender, EventArgs e)
        {
            groupsDataTable = BusinessLogic.ReadGroups().Groups;
        }

        private void ReloadInstructors_button_Click(object sender, EventArgs e)
        {
            instructorsDataTable = BusinessLogic.ReadInstructors().Instructors;
        }

        void InstructorChanged()
        {
            if (Instructor_comboBox.SelectedIndex != -1 && FormLoad)
            {
                if (CarriersUses_dataGridView.RowCount > 0)
                {
                    ChoosenInstructor_label.Text = Instructor_comboBox.DisplayMember.ToString();
                    SelectedInstructorID = Convert.ToInt32(Instructor_comboBox.SelectedValue);
                    dataSetForCarriers = BusinessLogic.ReadCarriersUsesByInstructorID(Convert.ToInt32(Instructor_comboBox.SelectedValue));
                    carriersDataTable = dataSetForCarriers.Carriers;
                    for (int i = 0; i < carriersDataTable.Rows.Count; i++)
                    {
                        CarriersUses_dataGridView[0, i].Value = carriersDataTable[i][3];
                        CarriersUses_dataGridView[2, i].Value = carriersDataTable[i][1];
                        CarriersUses_dataGridView[1, i].Value = carriersDataTable[i][4];
                        CarriersUses_dataGridView[3, i].Value = carriersDataTable[i][2];
                        CarriersUses_dataGridView[4, i].Value = carriersDataTable[i][0];
                    }
                }
            }
            else
            {
                CarriersUses_dataGridView.Rows.Clear();
                ChoosenInstructor_label.Text = "";
                SelectedInstructorID = -1;
            }
            ChoosenCarrier_label.Text = "";
            SelectedCarrierID = -1;
            SelectedCarrierUseID = -1;
            if (CarriersUses_dataGridView.RowCount == 1)
            {
                CarriersUses_dataGridView.Rows[0].Selected = true;
                ChangeSelectedCarrier();
            }
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn, string FileName)
        {
            byte[] bytes = File.ReadAllBytes(FileName);
            return bytes;
            /*MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();*/
        }

        private void Group_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Group_comboBox.SelectedIndex != -1 && FormLoad)
            {
                int CategoryID = groupsDataTable[Group_comboBox.SelectedIndex].Category;
                instructorsForThisGroupDataTable = BusinessLogic.ReadInstructorsCategoriesByCategoryID(CategoryID).InstructorsCategories;

                Instructor_comboBox.DataSource = instructorsForThisGroupDataTable;
                Instructor_comboBox.DisplayMember = "InstructorFIO";
                Instructor_comboBox.ValueMember = "Instructor";
                Instructor_comboBox.AutoCompleteMode = AutoCompleteMode.Append;
                Instructor_comboBox.SelectedIndex = -1;
            }
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при загрузке изображения", "Ошибка");
                return null;
            }
        }
    }
}
