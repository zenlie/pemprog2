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

namespace P6_3_1184109
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            SqlConnection connectDB = new SqlConnection(@"Data Source=DESKTOP-GG3TQA3\SQLEXPRESS;Initial Catalog=P_1184109;Integrated Security=True");
            connectDB.Open();
            SqlCommand sc = new SqlCommand("SELECT * FROM msprodi", connectDB);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable tabel = new DataTable();
            tabel.Columns.Add("id_prodi", typeof(string));
            tabel.Columns.Add("singkatan", typeof(string));
            tabel.Load(reader);

            cbProstud.ValueMember = "id_prodi";
            cbProstud.DisplayMember = "singkatan";
            cbProstud.DataSource = tabel;

            connectDB.Close();
        }

        private void insertDB(string conn)
        {
            try
            {
            
                SqlConnection myConnection = new SqlConnection(@"Data Source=DESKTOP-GG3TQA3\SQLEXPRESS;Initial Catalog=P_1184109;Integrated Security=True");
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = conn;
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Basisdata berhasil diperbarui", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNPM_Leave(object sender, EventArgs e)
        {
            if (txtNPM.Text.Length > 7)
            {
                epWrong.SetError(txtNPM, "NPM tidak boleh lebih dari 7 digit ya!");
            }
            else if (txtNPM.Text == "")
            {
                epWrong.SetError(txtNPM, "NPM tidak boleh kosong ya!");
            }
            else
            {
                epWrong.SetError(txtNPM, "");
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                epWrong.SetError(txtName, "NPM tidak boleh kosong ya!");
            }
            else
            {
                epWrong.SetError(txtName, "");
            }
        }

        private void txtAlamat_Leave(object sender, EventArgs e)
        {
            if (txtAlamat.Text == "")
            {
                epWrong.SetError(txtAlamat, "NPM tidak boleh kosong ya!");
            }
            else
            {
                epWrong.SetError(txtAlamat, "");
            }
        }

        private void txtNumber_Leave(object sender, EventArgs e)
        {
            if (txtNumber.Text == "")
            {
                epWrong.SetError(txtNumber, "NPM tidak boleh kosong ya!");
            }
            else
            {
                epWrong.SetError(txtNumber, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string date = null;
            string rb = null;
            if (rbLaki.Checked)
            {
                rb = rbLaki.Text;
            }
            if (rbCewe.Checked)
            {
                rb = rbCewe.Text;
            }
            

            string myCmd = "INSERT INTO msmhs VALUES('"
                + txtNPM.Text + "','"
                + txtName.Text + "','"
                + dTanggal.Value.ToShortDateString() + "','"
                + rb + "','"
                + txtAlamat.Text + "','"
                + txtNumber.Text + "','"
                + cbProstud.SelectedValue.ToString() + "')";

            MessageBox.Show
                        ("NIM: " + txtNPM.Text +
                        "\nNama: " + txtName.Text +
                        "\nJenis Kelamin: " + rb+
                        "\nAlamat: " + txtAlamat.Text +
                        "\nProgram Studi: " + cbProstud.SelectedValue.ToString() +
                        "\nNo HP: " + txtNumber.Text, 
                        "Informasi Data Submit",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            insertDB(myCmd);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtNPM.Text = null;
            txtAlamat.Text = null;
            txtName.Text = null;
            txtNumber.Text = null;
            rbCewe.Checked = false;
            rbLaki.Checked = false;
            cbProstud.SelectedIndex = 0;
        }
    }
}
