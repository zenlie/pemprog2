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

namespace P5_3_1184109
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(887, 376);
        }
        string kelamin = "";
        private void tbTahunAkademik_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbTahunAkademik.Text, @"^\d{4}/\d{4}$"))
            {
                epCorrect.SetError(tbTahunAkademik, "Betul!");
            }
            else
            {
                epError.SetError(tbTahunAkademik, "Format Tahun Akademik Salah ! \nContoh : 2015/2016");
            }
        }

        private void btnMataKuliah_Click(object sender, EventArgs e)
        {
            
            
            if (tbNIM.Text == "")
            {
                epWarning.SetError(tbNIM, "Kolom NIM tidak boleh kosong!");
            }
            else 
            {
                epCorrect.SetError(tbNIM, "Betul");
            }
            
            if (tbNama.Text == "")
            {
                epWarning.SetError(tbNama, "Kolom Nama tidak boleh kosong!");
            }
            else 
            {
                epCorrect.SetError(tbNama, "Betul!");
            }
            
            if (rbLakiLaki.Checked)
            {
                kelamin = "Laki - Laki";
            }
            if (rbPerempuan.Checked)
            {
                kelamin = "Perempuan";
            }
            if (kelamin == "")
            {
                MessageBox.Show("Harus memilih salah satu dari Jenis Kelamin!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (tbAlamat.Text == "")
            {
                epWarning.SetError(tbAlamat, "Kolom Alamat tidak boleh kosong!");
            }
            else
            {
                epCorrect.SetError(tbAlamat, "Betul");
            }
            
            if (cbProdi.Text != "- Pilihan Program Studi -")
            {
                epCorrect.SetError(cbProdi, "Betul!");
            }
            else if (cbProdi.Text == "- Pilihan Program Studi -")
            {
                epWarning.SetError(cbProdi, "Harap pilih Salah satu dari Program Studi!");
            }
            else if (cbProdi.Text == "")
            {
                epWarning.SetError(cbProdi, "Harap pilih Salah satu dari Program Studi!");
            }

            if (Regex.IsMatch(tbTahunAkademik.Text, @"^\d{4}/\d{4}$"))
            {
                epCorrect.SetError(tbTahunAkademik, "Betul!");
            }           
            else if (tbTahunAkademik.Text == "")
            {
                epWarning.SetError(tbTahunAkademik, "Kolom Tahun Akademik tidak boleh kosong!");
            }
            else if (!Regex.IsMatch(tbTahunAkademik.Text, @"^\d{4}/\d{4}$"))
            {
                epError.SetError(tbTahunAkademik, "Format Tahun Akademik Salah ! \nContoh : 2015/2016");
            }
            if (ntbSemester.Text != "")
            {
                epCorrect.SetError(ntbSemester, "Betul!");
                MessageBox.Show
                ("Data Sudah Terisi!", "Submit Data",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Size = new Size(886, 664);
            }
            else
            {
                epWarning.SetError(ntbSemester, "Kolom Semester tidak boleh kosong!");
                MessageBox.Show
                ("Kolom Semester belum diisi!",
                "Submit Data",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            

        }

        private void rbKur06_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKur06.Checked)
            {
                cbMtk.Enabled = true;  cbMtk.Checked = false;
                cbPemrog1.Enabled = true; cbPemrog1.Checked = false;
                cbPemrog2.Enabled = true; cbPemrog2.Checked = false;
                cbPemrog3.Enabled = true; cbPemrog3.Checked = false; 
                cbPemrog4.Enabled = true; cbPemrog4.Checked = false;
                cbPemrog5.Enabled = true; cbPemrog5.Checked = false;
                cbPemrog6.Enabled = true; cbPemrog6.Checked = false;
                cbPemrog7.Enabled = true; cbPemrog7.Checked = false;
                cbLogistik.Enabled = false; cbLogistik.Checked = false;
                cbJarkom.Enabled = true; cbJarkom.Checked = false;
                cbSisop.Enabled = true; cbSisop.Checked = false;
                cbMRP.Enabled = false; cbMRP.Checked = false;
            }
        }

        private void rbKur10_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKur10.Checked)
            {
                cbMtk.Enabled = false; cbMtk.Checked = false;
                cbPemrog1.Enabled = true; cbPemrog1.Checked = false;
                cbPemrog2.Enabled = true; cbPemrog2.Checked = false;
                cbPemrog3.Enabled = true; cbPemrog3.Checked = false;
                cbPemrog4.Enabled = true; cbPemrog4.Checked = false;
                cbPemrog5.Enabled = true; cbPemrog5.Checked = false;
                cbPemrog6.Enabled = true; cbPemrog6.Checked = false;
                cbPemrog7.Enabled = true; cbPemrog7.Checked = false;
                cbLogistik.Enabled = false; cbLogistik.Checked = false;
                cbJarkom.Enabled = true; cbJarkom.Checked = false;
                cbSisop.Enabled = true; cbSisop.Checked = false;
                cbMRP.Enabled = true; cbMRP.Checked = false;
            }
        }

        private void rbKur14_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKur14.Checked)
            {
                cbMtk.Enabled = false; cbMtk.Checked = false;
                cbPemrog1.Enabled = true; cbPemrog1.Checked = false;
                cbPemrog2.Enabled = true; cbPemrog2.Checked = false;
                cbPemrog3.Enabled = true; cbPemrog3.Checked = false;
                cbPemrog4.Enabled = true; cbPemrog4.Checked = false;
                cbPemrog5.Enabled = true; cbPemrog5.Checked = false;
                cbPemrog6.Enabled = true; cbPemrog6.Checked = false;
                cbPemrog7.Enabled = true; cbPemrog7.Checked = false;
                cbLogistik.Enabled = true; cbLogistik.Checked = false;
                cbJarkom.Enabled = true; cbJarkom.Checked = false;
                cbSisop.Enabled = true; cbSisop.Checked = false;
                cbMRP.Enabled = false; cbMRP.Checked = false;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            //string jKelamin = null;
            //if (rbLakiLaki.Checked)
            //{
            //    jKelamin = rbLakiLaki.Text;
            //} 
            //else if (rbPerempuan.Checked)
            //{
            //    jKelamin= rbPerempuan.Text;
            //}

            string kurikul = null;
            if (rbKur06.Checked)
            {
                kurikul = rbKur06.Text;
            }
            else if (rbKur10.Checked)
            {
                kurikul = rbKur10.Text;
            }
            else if (rbKur14.Checked)
            {
                kurikul = rbKur14.Text;
            }

            string matakuliah = null;
            if (cbMtk.Checked)
            {
                matakuliah += cbMtk.Text + ",";
            }
            if (cbPemrog1.Checked)
            {
                matakuliah += cbPemrog1.Text + ",";
            }
            if (cbPemrog2.Checked)
            {
                matakuliah += cbPemrog2.Text + ",";
            }
            if (cbPemrog3.Checked)
            {
                matakuliah += cbPemrog3.Text + ",";
            }
            if (cbPemrog4.Checked)
            {
                matakuliah += cbPemrog4.Text + ",";
            }
            if (cbPemrog5.Checked)
            {
                matakuliah += cbPemrog5.Text + ",";
            }
            if (cbPemrog6.Checked)
            {
                matakuliah += cbPemrog6.Text + ",";
            }
            if (cbPemrog7.Checked)
            {
                matakuliah += cbPemrog7.Text + ",";
            }
            if (cbLogistik.Checked)
            {
                matakuliah += cbLogistik.Text + ",";
            }
            if (cbJarkom.Checked)
            {
                matakuliah += cbJarkom.Text + ",";
            }
            if (cbSisop.Checked)
            {
                matakuliah += cbSisop.Text + ",";
            }
            if (cbMRP.Checked)
            {
                matakuliah += cbMRP.Text + ",";
            }

            MessageBox.Show
                        ("NIM: " + tbNIM.Text +
                        "\nNama: " + tbNama.Text +
                        "\nJenis Kelamin: " + kelamin +
                        "\nAlamat: " + tbAlamat.Text +
                        "\nProgram Studi: " + cbProdi.Text +
                        "\nTahun Akademik: " + tbTahunAkademik.Text +
                        "\nSemester: " + ntbSemester.Text +
                        "\n==================================" +
                        "\nKurikulum: " + kurikul +
                        "\nMata Kuliah: " + matakuliah,
                        "Submit Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            tbNIM.Text = null;
            tbNama.Text = null;
            rbLakiLaki.Checked = false;
            rbPerempuan.Checked = false;
            tbAlamat.Text = null;
            cbProdi.Text = null;
            tbTahunAkademik.Text = null;
            ntbSemester.Text = null;

            rbKur06.Checked = false;
            rbKur10.Checked = false;
            rbKur14.Checked = false;

            cbMtk.Enabled = false; cbMtk.Checked = false;
            cbPemrog1.Enabled = false; cbPemrog1.Checked = false;
            cbPemrog2.Enabled = false; cbPemrog2.Checked = false;
            cbPemrog3.Enabled = false; cbPemrog3.Checked = false;
            cbPemrog4.Enabled = false; cbPemrog4.Checked = false;
            cbPemrog5.Enabled = false; cbPemrog5.Checked = false;
            cbPemrog6.Enabled = false; cbPemrog6.Checked = false;
            cbPemrog7.Enabled = false; cbPemrog7.Checked = false;
            cbLogistik.Enabled = false; cbLogistik.Checked = false;
            cbJarkom.Enabled = false; cbJarkom.Checked = false;
            cbSisop.Enabled = false; cbSisop.Checked = false;
            cbMRP.Enabled = false; cbMRP.Checked = false;

            this.Size = new Size(887, 376);

            MessageBox.Show
                        ("Semua isi data telah direset",
                        "Submit Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
    