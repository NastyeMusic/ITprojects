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
    public partial class WorkersForm : Form
    {
        public WorkersForm()
        {
            InitializeComponent();
        }

        WorkStatusesForm WorkStatusesForm = new WorkStatusesForm();
        static bool WorkStatusesFormOpened = false;

        private void ChangeWorkStatuses_button_Click(object sender, EventArgs e)
        {
            if (WorkStatusesFormOpened)
            {
                WorkStatusesForm.Show();
                WorkStatusesFormOpened = true;
            }
            else
            {
                WorkStatusesForm.Activate();
            }
        }
    }
}
