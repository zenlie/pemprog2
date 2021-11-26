﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_2_1184109
{
    public partial class ChildForm : Form
    {
        private string outputText = DateTime.Now.ToString("d");
        public ChildForm()
        {
            InitializeComponent();
        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = outputText;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DateOption_CheckedChanged(object sender, EventArgs e)
        {
            outputText = DateTime.Now.ToString("d");
        }

        private void TimeOption_CheckedChanged(object sender, EventArgs e)
        {
            outputText = DateTime.Now.ToString("t");
        }
    }
}
