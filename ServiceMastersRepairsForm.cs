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
    public partial class ServiceMastersRepairsForm : Form
    {
        public ServiceMastersRepairsForm(int ServiceMasterID)
        {
            InitializeComponent();
            this.ServiceMasterID = ServiceMasterID;
        }

        BusinessLogic BusinessLogic = new BusinessLogic();
        string LastSearchingText = "";
        int LastFoundRow = -1;
        int ServiceMasterID;

        bool FirstLoad = true;

        void ReloadCarriers(int ServiceMasterID)
        {
            DataSet ds = new DataSet();

            ds = BusinessLogic.ReadCarriersByServiceMasterID(ServiceMasterID);
            Carriers_dataGridView.DataSource = ds;
            Carriers_dataGridView.DataMember = "RepairsOfServiceMaster";

            Carriers_dataGridView.Columns["ID"].Visible = false;
            Carriers_dataGridView.Columns["Brand"].Visible = false;
            Carriers_dataGridView.Columns["Model"].Visible = false;
            Carriers_dataGridView.Columns["StateNumber"].Visible = false;
            Carriers_dataGridView.Columns["Color"].Visible = false;
            Carriers_dataGridView.Columns["Transmission"].Visible = false;
            Carriers_dataGridView.Columns["Category"].Visible = false;
            Carriers_dataGridView.Columns["Status"].Visible = false;
            Carriers_dataGridView.Columns["Work"].Visible = false;
            Carriers_dataGridView.Columns["BeginDate"].Visible = false;
            Carriers_dataGridView.Columns["EndDate"].Visible = false;

            IDColumn.DataPropertyName = "ID";
            BrandColumn.DataPropertyName = "Brand";
            ModelColumn.DataPropertyName = "Model";
            StateNumberColumn.DataPropertyName = "StateNumber";
            ColorColumn.DataPropertyName = "Color";
            TransmissionColumn.DataPropertyName = "Transmission";
            CategoryColumn.DataPropertyName = "Category";
            StatusColumn.DataPropertyName = "Status";
            WorkColumn.DataPropertyName = "Work";
            BeginDateColumn.DataPropertyName = "BeginDate";
            EndDateColumn.DataPropertyName = "EndDate";
        }

        private void ServiceMastersRepairsForm_Load(object sender, EventArgs e)
        {
            ReloadCarriers(ServiceMasterID);
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            SearchingInDataGridViewClass.Search(SearchCarrier_textBox, ref Carriers_dataGridView, Direction_checkBox,
                ref LastSearchingText, ref LastFoundRow, "BrandColumn", "ModelColumn", "StateNumberColumn", "WorkColumn");
        }

        private void SearchCarrier_textBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ReloadCarriers_button_Click(object sender, EventArgs e)
        {
            ReloadCarriers(ServiceMasterID);
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ServiceMastersRepairsForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                if (!FirstLoad)
                    ReloadCarriers_button_Click(sender, e);
                else
                    FirstLoad = false;
            }
        }
    }
}
