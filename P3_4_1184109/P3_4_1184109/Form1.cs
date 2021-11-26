using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_4_1184109
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

        private void btnTampil_Click(object sender, EventArgs e)
        {
            string kelas = "";
            string jadwal = "";

            if (rbJadwal1.Checked)
            {
                jadwal = "Senin & Rabu, 14.00 - 16.00";
            }
            else if (rbJadwal2.Checked)
            {
                jadwal = "Selasa & Kamis, 14.00 - 16.00";
            }
            else if (rbJadwal3.Checked)
            {
                jadwal = "Jumat & Sabtu, 09.00 - 11.00";
            }
            else if (rbJadwal4.Checked)
            {
                jadwal = "Minggu, 13.00 - 17.00";
            }

            if (Biola.Checked)
            {
                kelas = kelas + "Biola, ";
            }
            if (gitar.Checked)
            {
                kelas = kelas + "Gitar, ";
            }
            if (saxophone.Checked)
            {
                kelas = kelas + "saxophone, ";
            }
            if (konduktor.Checked)
            {
                kelas = kelas + "konduktor, ";
            }
            if (piano.Checked)
            {
                kelas = kelas + "piano, ";
            }
            if (drum.Checked)
            {
                kelas = kelas + "drum, ";
            }
            if (vokal.Checked)
            {
                kelas = kelas + "vokal, ";
            }
            if (komposer.Checked)
            {
                kelas = kelas + "komposer, ";
            }
            if (kelas == "")
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan Group", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            MessageBox.Show
                ("Nama : " + tbNama.Text +
                "\nJenis Kelamin : " + cbJK.Text +
                "\nTanggal Lahir: " + dtpTTL.Text +
                "\nPilihan Kelas : " + kelas +
                "\nPilihan Jadwal: " + jadwal,
                "Informasi Pendaftaran",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }   
}
