using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace P4_4_1184109
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbNama_Leave(object sender, EventArgs e)
        {
            if (tbNama.Text == "")
            {
                epWarning.SetError(tbNama, "Mohon isi Nama");
                epWrong.SetError(tbNama, "");
                epCorrect.SetError(tbNama, "");
            }
            else
            {
                if (tbNama.Text != tbNama.Text.ToUpper()) 
                {
                    epWrong.SetError(tbNama, "Mohon Gunakan Huruf Kapital");
                    epWarning.SetError(tbNama, "");
                    epCorrect.SetError(tbNama, "");
                }
                else
                if ((tbNama.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(tbNama, "");
                    epWrong.SetError(tbNama, "");
                    epCorrect.SetError(tbNama, "Betul");
                }
                else
                {
                    epWrong.SetError(tbNama, "Maaf inputan hanya boleh huruf");
                    epWarning.SetError(tbNama, "");
                    epCorrect.SetError(tbNama, "");
                }
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                epWarning.SetError(tbEmail, "Mohon isi Email");
                epWrong.SetError(tbEmail, "");
                epCorrect.SetError(tbEmail, "");
            }
            else
            {
                if (Regex.IsMatch(tbEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epCorrect.SetError(tbEmail, "Betul");
                    epWarning.SetError(tbEmail, "");
                    epWrong.SetError(tbEmail, "");

                }
                else
                {
                    epCorrect.SetError(tbEmail, "");
                    epWarning.SetError(tbEmail, "");
                    epWrong.SetError(tbEmail, "Format email salah ! \nContoh : a@b.c");
                }
            }
        }

        private void tbHP_Leave(object sender, EventArgs e)       
        {
            if (tbHP.Text.Length > 13)
            {
                epWarning.SetError(tbHP, "Maaf tidak boleh lebih dari 13 digit");
                epWrong.SetError(tbHP, "");
                epCorrect.SetError(tbHP, "");
            }
            else if ((tbHP.Text).All(Char.IsNumber)) 
            {
                epWarning.SetError(tbHP, "");
                epWrong.SetError(tbHP, "");
                epCorrect.SetError(tbHP, "Betul");
            }
            else
            {
                epWrong.SetError(tbHP, "Maaf inputan hanya boleh Angka");
                epWarning.SetError(tbHP, "");
                epCorrect.SetError(tbHP, "");
            }
            if (tbHP.Text == "")
            {
                epWarning.SetError(tbHP, "Mohon isi no telpon");
                epWrong.SetError(tbHP, "");
                epCorrect.SetError(tbHP, "");
            }
            
        }

        private void tbAng_Leave(object sender, EventArgs e)
        {
            if (tbNil.Text.Length > 1)
            {
                epWarning.SetError(tbNil, "hanya boleh beri nilai 1-9");               
                epWrong.SetError(tbNil, "");
                epCorrect.SetError(tbNil, "");
            }
            else if ((tbNil.Text).All(Char.IsNumber)) //Numeric TextBox
            {
                epWarning.SetError(tbNil, "");
                epWrong.SetError(tbNil, "");
                epCorrect.SetError(tbNil, "Betul!");
            }
            else
            {
                epWrong.SetError(tbNil, "Maaf inputan hanya boleh angka");
                epWarning.SetError(tbNil, "");
                epCorrect.SetError(tbNil, "");
            }
            if (tbNil.Text == "")
            {
                epWarning.SetError(tbNil, "Mohon isi nilai");
                epWrong.SetError(tbNil, "");
                epCorrect.SetError(tbNil, "");
            }
            if (tbNil.Text != "") //Comparison
            {
                if ((int.Parse(tbNil.Text) > 9))
                {
                    epWarning.SetError(tbNil, "");
                    epWrong.SetError(tbNil, "Maaf nilai mu terlalu besar nih");
                    epCorrect.SetError(tbNil, "");
                }
                else { }
            }
        }

        private void tbTeam_Leave(object sender, EventArgs e)
        {
            if (tbCt.Text == "")
            {
                epWarning.SetError(tbCt, "Maaf nama tidak boleh kosong");
                epWrong.SetError(tbCt, "");
                epCorrect.SetError(tbCt, "");
            }
            else
            {
                if (tbCt.Text != tbCt.Text.ToLower())
                {
                    epWrong.SetError(tbCt, "Mohon jangan gunakan Huruf Kapital");
                    epWarning.SetError(tbCt, "");
                    epCorrect.SetError(tbCt, "");
                }
                else
                if ((tbCt.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(tbCt, "");
                    epWrong.SetError(tbCt, "");
                    epCorrect.SetError(tbCt, "Betul");
                }
                else
                {
                    epWrong.SetError(tbCt, "Maaf inputan hanya boleh huruf");
                    epWarning.SetError(tbCt, "");
                    epCorrect.SetError(tbCt, "");
                }
            }
        }

        private void btKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTampil_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                    ("Nama : " + tbNama.Text +
                    "\nEmail : " + tbEmail.Text +
                    "\nNo HP : " + tbHP.Text +
                    "\nSubjek : " + cbSubjek.Text +
                    "\nNilai : " + tbNil.Text +
                    "\nCatatan : " + tbCt.Text,
                    "Berhasil",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tbAng_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

