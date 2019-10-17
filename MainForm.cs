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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public BusinessLogic BusinessLogic = new BusinessLogic(); 
        AutoschoolDataSet dataSet;

        void ReloadStudents()
        {
            dataSet = BusinessLogic.ReadStudents();
            Students_dGV.DataSource = dataSet;
            Students_dGV.DataMember = "Students";

            Students_dGV.Columns["ID"].Visible = false;
            Students_dGV.Columns["Surname"].Visible = false;
            Students_dGV.Columns["FirstName"].Visible = false;
            Students_dGV.Columns["PatronymicName"].Visible = false;
            Students_dGV.Columns["PhoneNumber"].Visible = false;
            Students_dGV.Columns["Retraining"].Visible = false;
            Students_dGV.Columns["Group"].Visible = false;
            Students_dGV.Columns["CarrierUse"].Visible = false;
            Students_dGV.Columns["Photo"].Visible = false;

            IDColumn.DataPropertyName = "ID";
            FIOColumn.DataPropertyName = "FIO";
            PhoneNumberColumn.DataPropertyName = "PhoneNumber";
            RetrainingColumn.DataPropertyName = "Retraining";

            GroupColumn.DataSource = dataSet.Groups;
            GroupColumn.DisplayMember = "Name";
            GroupColumn.ValueMember = "ID";
            GroupColumn.DataPropertyName = "Group";

            InstructorColumn.DataPropertyName = "InstructorName";
            CarrierColumn.DataPropertyName = "CarrierName";

            PhotoColumn.DataPropertyName = "Photo";
        }

        void ReloadGroups()
        {
            Groups_treeView.Nodes.Clear();

            dataSet = BusinessLogic.ReadGroups();
            DataGridView Groups_dGV = new DataGridView();
            Groups_dGV.DataSource = dataSet;
            Groups_dGV.DataMember = "Groups";

            for (int i = 0; i < Groups_dGV.RowCount; i++)
            {
                int year = Convert.ToDateTime(Groups_dGV[2, i].ToString()).Year;

                bool Find = false;
                for (int j = 0; j < Groups_treeView.Nodes.Count; j++)
                {
                    if (Convert.ToInt32(Groups_treeView.Nodes[j].Text) == year)
                    {
                        Find = true;
                        // добавляем в уже существующую ветку

                    }
                }
                if (!Find)
                {
                    // создаем новую ветку, и добавляем в нее

                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReloadStudents();
            
        }
    }
}
