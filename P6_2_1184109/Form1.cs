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

namespace P6_2_1184109
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataSet dsProdi;

        public DataSet CreateProdiDataSet()
        {
            DataSet myDataSet = new DataSet();

            try
            {
                //string myConnectionString = "Data Source=LAPTOP-4Q4UGOSK\P6_1204055;Initial Catalog=P6_1204055;Integrated Security=True";

                SqlConnection myConnection = new SqlConnection(@"Data Source=DESKTOP-GG3TQA3\SQLEXPRESS;Initial Catalog=P_1184109;Integrated Security=True");

                SqlCommand myCommand = new SqlCommand();

                myCommand.Connection = myConnection;

                myCommand.CommandText = "SELECT * FROM msprodi";
                myCommand.CommandType = CommandType.Text;

                SqlDataAdapter myDataAdapter = new SqlDataAdapter();
                myDataAdapter.SelectCommand = myCommand;
                myDataAdapter.TableMappings.Add("Table", "Prodi");

                myDataAdapter.Fill(myDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return myDataSet;

        }

        private void RefreshDataset()
        {
            dsProdi = CreateProdiDataSet();

            dgProdi.DataSource = dsProdi.Tables["Prodi"];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //string myConnectionstring = "Data Source=LAPTOP-4Q4UGOSK\P6_1204055;Initial Catalog=P6_1204055;Integrated Security=True";
            SqlConnection myConnection = new SqlConnection(@"Data Source=DESKTOP-GG3TQA3\SQLEXPRESS;Initial Catalog=P_1184109;Integrated Security=True");

            myConnection.Open();

            SqlDataAdapter myAdapter = new SqlDataAdapter("SELECT * FROM msprodi", myConnection);
            SqlCommandBuilder myCmdBuilder = new SqlCommandBuilder(myAdapter);

            myAdapter.InsertCommand = myCmdBuilder.GetInsertCommand();
            myAdapter.UpdateCommand = myCmdBuilder.GetUpdateCommand();
            myAdapter.DeleteCommand = myCmdBuilder.GetDeleteCommand();

            SqlTransaction myTransaction;
            myTransaction = myConnection.BeginTransaction();
            myAdapter.InsertCommand.Transaction = myTransaction;
            myAdapter.UpdateCommand.Transaction = myTransaction;
            myAdapter.DeleteCommand.Transaction = myTransaction;

            try
            {
                int rowsUpdated = myAdapter.Update(dsProdi, "Prodi");

                myTransaction.Commit();

                MessageBox.Show(rowsUpdated.ToString() + " baris diperbarui", "informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshDataset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update: ", ex.Message);

                myTransaction.Rollback();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataset();
        }
    }
}
