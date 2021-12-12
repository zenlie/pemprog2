using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_1_1184109
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vbButton_Click(object sender, EventArgs e)
        {

        }

        private void csButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct!");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vbButton_MouseMove(object sender, MouseEventArgs e)
        {
            vbButton.Top -= e.X;
            vbButton.Left += e.Y;
            if (vbButton.Top < -16 || vbButton.Top > 160)
                vbButton.Top = 73;
            if (vbButton.Left < -64 || vbButton.Left > 384)
                vbButton.Left = 160;
        }
    }
}
