using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EscolaProMontijo
{
    public partial class CompanyListForm : Form
    {
        DataSet ds = new DataSet();
        MySqlDataAdapter dataAdapter;
        connectionMySql connectionDB = new connectionMySql();
        


        public CompanyListForm()
        {
            InitializeComponent();
        }

        private void CompanyListForm_Load(object sender, EventArgs e)
        {
            dataGridViewCompanies.DataSource = bindingSourceCompanies;
            
            connectionDB.ConnectionMySql();
            dataGridViewCompanies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            string sqlCommand = "SELECT TABLE_NAME as available FROM information_schema.TABLES WHERE TABLE_SCHEMA = 'bddmontijotest' AND TABLE_NAME LIKE 'list%'";

            connectionDB.PutQueryIntoComboBox(sqlCommand, comboBoxListCompanies, "available");

            sqlCommand = "SELECT * FROM company ORDER BY name";
            dataAdapter = new MySqlDataAdapter(sqlCommand, connectionDB.getMyconnectionString());
            // 3. fill in insert, update, and delete commands
            MySqlCommandBuilder cmdBldr = new MySqlCommandBuilder(dataAdapter);
            dataAdapter.Fill(ds, "bddmontijotest");
            dataGridViewCompanies.DataSource = ds;
            dataGridViewCompanies.DataMember = "bddmontijotest";


        }

        private void comboBoxListCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (dataGridViewCompanies.ColumnCount != 0)
            {
                ds.Tables["bddmontijotest"].Columns.Clear();   // Clear column of database
                ds.Tables["bddmontijotest"].Rows.Clear(); // Clear Rows of database

            }

            try
            {


                string parameter = comboBoxListCompanies.Text;
                string sqlQuery = "SELECT c.* FROM " + parameter + " l JOIN company c ON c.id = l.idCompany";
                dataAdapter = new MySqlDataAdapter(sqlQuery, connectionDB.getMyconnectionString());
                // 3. fill in insert, update, and delete commands
                MySqlCommandBuilder cmdBldr = new MySqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(ds, "bddmontijotest");
                dataGridViewCompanies.DataSource = ds;
                dataGridViewCompanies.DataMember = "bddmontijotest";

            }
            catch
            {

            }
            



        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                dataAdapter.Update(ds, "bddmontijotest");
                MessageBox.Show("Database updated");
                CompanyListForm_Load(null, null);        ////// FIX THIS
            }
            catch
            {
                MessageBox.Show("Error, database is not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
