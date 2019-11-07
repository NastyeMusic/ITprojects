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
    public partial class ServiceMastersForm : Form
    {
        public ServiceMastersForm()
        {
            InitializeComponent();
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        AutoschoolDataSet dataSet;
        string LastSearchingText = "";
        int LastFoundRow = -1;

        bool FirstLoad = true;

        void ReloadServiceMasters()
        {
            dataSet = BusinessLogic.ReadServiceMasters();
            ServiceMasters_dataGridView.DataSource = dataSet;
            ServiceMasters_dataGridView.DataMember = "ServiceMasters";

            ServiceMasters_dataGridView.Columns["ID"].Visible = false;
            ServiceMasters_dataGridView.Columns["Surname"].Visible = false;
            ServiceMasters_dataGridView.Columns["FirstName"].Visible = false;
            ServiceMasters_dataGridView.Columns["PatronymicName"].Visible = false;;
            ServiceMasters_dataGridView.Columns["WorkStatus"].Visible = false;
            ServiceMasters_dataGridView.Columns["FIO"].Visible = false;
            ServiceMasters_dataGridView.Columns["WorkStatusName"].Visible = false;

            IDColumn.DataPropertyName = "ID";
            SurnameColumn.DataPropertyName = "Surname";
            FirstNameColumn.DataPropertyName = "FirstName";
            PatronymicNameColumn.DataPropertyName = "PatronymicName";
            WorkStatusColumn.DataPropertyName = "WorkStatusName";
        }

        private void ServiceMastersForm_Load(object sender, EventArgs e)
        {
            ReloadServiceMasters();
            ServiceMasters_dataGridView_SelectionChanged(sender, e);
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            SearchingInDataGridViewClass.Search(Search_textBox, ref ServiceMasters_dataGridView, Direction_checkBox,
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

        private void ServiceMasters_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ServiceMasters_dataGridView.SelectedRows.Count == 1)
            {
                RepairsOfMaster_button.Enabled = true;
            }
            else
            {
                RepairsOfMaster_button.Enabled = false;
            }
        }

        private void Reload_button_Click(object sender, EventArgs e)
        {
            ReloadServiceMasters();
            ServiceMasters_dataGridView_SelectionChanged(sender, e);
        }

        private void ServiceMastersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            MainForm.Perem(MainForm.FormsNames[5], false);
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ServiceMastersForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                if (!FirstLoad)
                    Reload_button_Click(sender, e);
                else
                    FirstLoad = false;
            }
        }

        private void RepairsOfMaster_button_Click(object sender, EventArgs e)
        {
            ServiceMastersRepairsForm ServiceMastersForm = new ServiceMastersRepairsForm(Convert.ToInt32(ServiceMasters_dataGridView.SelectedRows[0].Cells["ID"].Value));
            ServiceMastersForm.Text = "Отремонтированные и ремонтируемые ТС мастером сервиса: " + ServiceMasters_dataGridView.SelectedRows[0].Cells["FIO"].Value.ToString();
            ServiceMastersForm.Show();
        }
    }
}
