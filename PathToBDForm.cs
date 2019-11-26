using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Автошкола
{
    public partial class PathToBDForm : Form
    {
        public PathToBDForm()
        {
            InitializeComponent();
        }

        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(GetConnectionString());

        private static string GetConnectionString()
        {
            return Properties.Settings.Default.ConnectionString;
        }

        private void SetConnectionString()
        {
            Properties.Settings.Default.ConnectionString = builder.ConnectionString;
            Properties.Settings.Default.Save();
            //Properties.Settings.Default.Upgrade();
            Properties.Settings.Default.Reload();
        }

        private void PathToBDForm_Load(object sender, EventArgs e)
        {
            DataSource_textBox.Text = builder.DataSource;
            InitialCatalog_textBox.Text = builder.InitialCatalog;
            Pooling_checkBox.Checked = builder.Pooling;
            IntegratedSecurity_checkBox.Checked = builder.IntegratedSecurity;
            User_textBox.Text = builder.UserID;
            Password_textBox.Text = builder.Password;
        }

        private void IntegratedSecurity_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IntegratedSecurity_checkBox.Checked)
            {
                User_textBox.Enabled = false;
                User_textBox.ReadOnly = true;
                Password_textBox.Enabled = false;
                Password_textBox.ReadOnly = true;
            }
            else
            {
                User_textBox.Enabled = true;
                User_textBox.ReadOnly = false;
                Password_textBox.Enabled = true;
                Password_textBox.ReadOnly = false;
            }
        }

        private void PathToBDForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (DialogResult == DialogResult.OK)
                {
                    builder.DataSource = DataSource_textBox.Text;
                    builder.InitialCatalog = InitialCatalog_textBox.Text;
                    builder.Pooling = Pooling_checkBox.Checked;
                    builder.IntegratedSecurity = IntegratedSecurity_checkBox.Checked;
                    if (!IntegratedSecurity_checkBox.Checked)
                    {
                        builder.UserID = User_textBox.Text;
                        builder.Password = Password_textBox.Text;
                    }
                    SetConnectionString();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка при настройке подключения БД");
            }
        }
    }
}
