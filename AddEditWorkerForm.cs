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
    public partial class AddEditWorkerForm : Form
    {
        public AddEditWorkerForm(string Post, DataRow row, AutoschoolDataSet.WorkStatusesDataTable workStatusesDataTable, AutoschoolDataSet dataSet)
        {
            InitializeComponent();
            this.Post = Post;
            theoryTeachersDataTable = dataSet.TheoryTeachers;
            instructorsDataTable = dataSet.Instructors;
            serviceMastersDataTable = dataSet.ServiceMasters;
            this.workStatusesDataTable = workStatusesDataTable;
            dataRow = row;            
        }

        BusinessLogic BusinessLogic = new BusinessLogic();

        AutoschoolDataSet.TheoryTeachersDataTable theoryTeachersDataTable;
        AutoschoolDataSet.InstructorsDataTable instructorsDataTable;       
        AutoschoolDataSet.ServiceMastersDataTable serviceMastersDataTable;

        AutoschoolDataSet.WorkStatusesDataTable workStatusesDataTable;

        string Post = "";
        string NewPost = "";

        DataRow dataRow;

        byte[] ImageByte;

        MemoryStream memoryStream = new MemoryStream(); // Поток в который запишем изображение

        private void AddEditWorkerForm_Load(object sender, EventArgs e)
        {
            WorkStatus_comboBox.DataSource = workStatusesDataTable;
            WorkStatus_comboBox.DisplayMember = "Name";
            WorkStatus_comboBox.ValueMember = "ID";
            WorkStatus_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            WorkStatus_comboBox.AutoCompleteMode = AutoCompleteMode.Append;

            DataSet ds = new DataSet();
            ds.Tables.Add("Post");
            ds.Tables["Post"].Columns.Add("Name");
            ds.Tables["Post"].Rows.Add("преподаватель теории");
            ds.Tables["Post"].Rows.Add("инструктор");
            ds.Tables["Post"].Rows.Add("мастер сервиса");
            Post_comboBox.DataSource = ds.Tables["Post"];
            Post_comboBox.DisplayMember = "Name";
            Post_comboBox.ValueMember = "Name";
            Post_comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            Post_comboBox.AutoCompleteMode = AutoCompleteMode.Append;

            if (dataRow != null)
            {
                Surname_textBox.Text = dataRow["Surname"].ToString();
                FirstName_textBox.Text = dataRow["FirstName"].ToString();
                PatronymicName_textBox.Text = dataRow["PatronymicName"].ToString();
                WorkStatus_comboBox.SelectedValue = dataRow["WorkStatus"].ToString();
                Post_comboBox.SelectedValue = Post;

                if (Post == "преподаватель теории" || Post == "инструктор")
                {
                    /*Image img;
                    if (dataRow["Photo"].ToString() != "")
                    {
                        MemoryStream image_stream = new MemoryStream((byte[])dataRow["Photo"]);
                        img = Image.FromStream(image_stream);

                        /*System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                        img = (Image)converter.ConvertFromString(dataRow["Photo"].ToString());*/
                    //}
                    /*else
                        img = null;
                    Photo_pictureBox.Image = img;*/
                    if (dataRow["Photo"].ToString() != "")
                        Photo_pictureBox.Image = byteArrayToImage((byte[])dataRow["Photo"]);
                }
                else if (Post == "мастер сервиса")
                {
                    Photo_pictureBox.Enabled = false;
                    ChangePhoto_button.Enabled = false;
                }
            }
            else
            {
                Surname_textBox.Text = "";
                FirstName_textBox.Text = "";
                PatronymicName_textBox.Text = "";
                WorkStatus_comboBox.SelectedIndex = -1;
                Post_comboBox.SelectedIndex = -1;
                Photo_pictureBox.Image = null;
                if (Post == "мастер сервиса")
                {                    
                    Photo_pictureBox.Enabled = false;
                    ChangePhoto_button.Enabled = false;
                }
            }
        }

        private void AddEditWorkerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    if (Surname_textBox.Text == "")
                    {
                        Surname_textBox.Focus();
                        throw new Exception("Не указана фамилия сотрудника");
                    }
                    if (FirstName_textBox.Text == "")
                    {
                        FirstName_textBox.Focus();
                        throw new Exception("Не указано имя сотрудника");
                    }
                    if (PatronymicName_textBox.Text == "")
                    {
                        PatronymicName_textBox.Focus();
                        throw new Exception("Не указано отчество сотрудника");
                    }
                    if (Post_comboBox.SelectedIndex == -1)
                    {
                        Post_comboBox.Focus();
                        throw new Exception("Не выбрана должность сотрудника");
                    }
                    if (WorkStatus_comboBox.SelectedIndex == -1)
                    {
                        WorkStatus_comboBox.Focus();
                        throw new Exception("Не выбран рабочий статус сотрудника");
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Ошибка");
                    e.Cancel = true;
                    return;
                }
                if (dataRow != null)
                {
                    NewPost = Post_comboBox.SelectedValue.ToString();
                    if (Post == NewPost)
                    {
                        dataRow["Surname"] = Surname_textBox.Text;
                        dataRow["FirstName"] = FirstName_textBox.Text;
                        dataRow["PatronymicName"] = PatronymicName_textBox.Text;
                        dataRow["WorkStatus"] = WorkStatus_comboBox.SelectedValue.ToString();
                        if (Post == "преподаватель теории" || Post == "инструктор")
                        {
                            dataRow["Photo"] = ImageByte;
                        }
                    }
                    else
                    {
                        // удаляем сотрудника из той таблицы, где он был ранее
                        int ID = Convert.ToInt32(dataRow["ID"].ToString());
                        if (Post == "преподаватель теории")
                        {
                            AutoschoolDataSet TempDataSet = new AutoschoolDataSet();
                            TempDataSet = BusinessLogic.ReadTheoryTeacherByID(ID);
                            theoryTeachersDataTable.Rows.Find(TempDataSet.TheoryTeachers.Rows[0][0].ToString()).Delete();
                        }
                        else if (Post == "инструктор")
                        {
                            AutoschoolDataSet TempDataSet = new AutoschoolDataSet();
                            TempDataSet = BusinessLogic.ReadInstructorByID(ID);
                            instructorsDataTable.Rows.Find(TempDataSet.Instructors.Rows[0][0].ToString()).Delete();
                        }
                        else if (Post == "мастер сервиса")
                        {
                            AutoschoolDataSet TempDataSet = new AutoschoolDataSet();
                            TempDataSet = BusinessLogic.ReadServiceMasterByID(ID);
                            serviceMastersDataTable.Rows.Find(TempDataSet.ServiceMasters.Rows[0][0].ToString()).Delete();
                        }

                        // добавляем сотрудника в таблицу по его новой должности
                        if (NewPost == "преподаватель теории")
                        {
                            if (Photo_pictureBox.Image != null)
                                theoryTeachersDataTable.AddTheoryTeachersRow(Surname_textBox.Text, FirstName_textBox.Text,
                                    PatronymicName_textBox.Text, /*memoryStream.ToArray()*/ ImageByte, 
                                    workStatusesDataTable[WorkStatus_comboBox.SelectedIndex]);
                            else
                                theoryTeachersDataTable.AddTheoryTeachersRow(Surname_textBox.Text, FirstName_textBox.Text,
                                    PatronymicName_textBox.Text, null,
                                    workStatusesDataTable[WorkStatus_comboBox.SelectedIndex]);
                        }
                        else if (NewPost == "инструктор")
                        {
                            if (Photo_pictureBox.Image != null)
                                instructorsDataTable.AddInstructorsRow(Surname_textBox.Text, FirstName_textBox.Text,
                                    PatronymicName_textBox.Text, /*memoryStream.ToArray()*/ ImageByte, 
                                    workStatusesDataTable[WorkStatus_comboBox.SelectedIndex]);
                            else
                                instructorsDataTable.AddInstructorsRow(Surname_textBox.Text, FirstName_textBox.Text,
                                    PatronymicName_textBox.Text, null,
                                    workStatusesDataTable[WorkStatus_comboBox.SelectedIndex]);
                        }
                        else if (NewPost == "мастер сервиса")
                        {
                            serviceMastersDataTable.AddServiceMastersRow(Surname_textBox.Text, FirstName_textBox.Text,
                                PatronymicName_textBox.Text, workStatusesDataTable[WorkStatus_comboBox.SelectedIndex]);
                        }
                    }
                }
                else
                {
                    if (NewPost == "преподаватель теории")
                    {
                        if (Photo_pictureBox.Image != null)
                            theoryTeachersDataTable.AddTheoryTeachersRow(Surname_textBox.Text, FirstName_textBox.Text,
                                PatronymicName_textBox.Text, /*memoryStream.ToArray()*/ ImageByte,
                                workStatusesDataTable[WorkStatus_comboBox.SelectedIndex]);
                        else
                            theoryTeachersDataTable.AddTheoryTeachersRow(Surname_textBox.Text, FirstName_textBox.Text,
                                PatronymicName_textBox.Text, null,
                                workStatusesDataTable[WorkStatus_comboBox.SelectedIndex]);
                    }
                    else if (NewPost == "инструктор")
                    {                        
                        if (Photo_pictureBox.Image != null)
                            instructorsDataTable.AddInstructorsRow(Surname_textBox.Text, FirstName_textBox.Text,
                                PatronymicName_textBox.Text, /*memoryStream.ToArray()*/ ImageByte,
                                workStatusesDataTable[WorkStatus_comboBox.SelectedIndex]);
                        else
                            instructorsDataTable.AddInstructorsRow(Surname_textBox.Text, FirstName_textBox.Text,
                                PatronymicName_textBox.Text, null,
                                workStatusesDataTable[WorkStatus_comboBox.SelectedIndex]);
                    }
                    else if (NewPost == "мастер сервиса")
                    {
                        serviceMastersDataTable.AddServiceMastersRow(Surname_textBox.Text, FirstName_textBox.Text,
                            PatronymicName_textBox.Text, workStatusesDataTable[WorkStatus_comboBox.SelectedIndex]);
                    }
                }
            }
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

        private void Post_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Post_comboBox.SelectedIndex != -1)
            {
                NewPost = Post_comboBox.SelectedValue.ToString();
                if (NewPost == "мастер сервиса")
                {
                    Photo_pictureBox.Image = null;
                    Photo_pictureBox.Enabled = false;
                    ChangePhoto_button.Enabled = false;
                }
                else
                {
                    Photo_pictureBox.Enabled = true;
                    ChangePhoto_button.Enabled = true;
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

        public byte[] imageToByteArray(System.Drawing.Image imageIn, string FileName)
        {
            byte[] bytes = File.ReadAllBytes(FileName);
            return bytes;
            /*MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();*/
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
