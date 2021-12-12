using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P4_3_1184109
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

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                epWarning.SetError(textBox1, "Textbox huruf tidak boleh kosong");
                epWrong.SetError(textBox1, "");
                epCorrect.SetError(textBox1, "");
            }
            else
            {
                if ((textBox1.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(textBox1, "");
                    epWrong.SetError(textBox1, "");
                    epCorrect.SetError(textBox1, "Betul!");
                }
                else
                {
                    epWrong.SetError(textBox1, "Inputan hanya boleh huruf!");
                    epWarning.SetError(textBox1, "");
                    epCorrect.SetError(textBox1, "");
                }
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if ((textBox2.Text).All(Char.IsNumber))
            {
                epCorrect.SetError(textBox2, "Betul!");
                epWarning.SetError(textBox2, "");
                epWrong.SetError(textBox2, "");
            }
            else
            {
                epCorrect.SetError(textBox2, "");
                epWarning.SetError(textBox2, "");
                epWrong.SetError(textBox2, "Inputan hanya boleh angka!");
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox3.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epWarning.SetError(textBox3, "");
                epWrong.SetError(textBox3, "");
                epCorrect.SetError(textBox3, "Betul!");
            }
            else
            {
                epWrong.SetError(textBox3, "Format email salah! \nContoh a@b.c");
                epWarning.SetError(textBox3, "");
                epCorrect.SetError(textBox3, "");
            }
        }

        int value;
        int value1;
        private void textBox4_Leave(object sender, EventArgs e)
        {

            if (Int32.TryParse(textBox4.Text, out value))
            {
                if (value > value1)
                {
                    epWarning.SetError(textBox4, "");
                    epCorrect.SetError(textBox4, "Betul!");
                }
                else
                {
                    epWarning.SetError(textBox4, "Angka 2 lebih besar daripada Angka 1");
                    epCorrect.SetError(textBox4, "");
                }
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox5.Text, out value1))
            {
                if (value > value1)
                {
                    epWarning.SetError(textBox5, "");
                    epCorrect.SetError(textBox5, "Betul!");
                }
                else
                {
                    epWarning.SetError(textBox5, "Angka 2 lebih besar daripada Angka 1");
                    epCorrect.SetError(textBox5, "");
                }
            }
        }
    }
}
