﻿using System;
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
    public partial class AboutProgramForm : Form
    {
        public AboutProgramForm()
        {
            InitializeComponent();
        }

        private void AboutProgramForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.AboutProgramFormOpened = false;
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
