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
            
            
            connectionDB.ConnectionMySql();
            dataGridViewCompanies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            comboBoxSector.Items.Clear();
            comboBoxSector.Items.Add("All companies");

            comboBoxCompany.Items.Clear();
            comboBoxEmail.Items.Clear();
            

            ds.Clear();


            try
            {
                string sqlQuery = "SELECT DISTINCT name FROM company";
                connectionDB.PutQueryIntoComboBox(sqlQuery, comboBoxCompany, "name");

                string sqlCommand = "SELECT name FROM sector";
                connectionDB.PutQueryIntoComboBox(sqlCommand, comboBoxSector, "name");

                sqlCommand = "SELECT * FROM company ORDER BY name";
                dataAdapter = new MySqlDataAdapter(sqlCommand, connectionDB.getMyconnectionString());
                // 3. fill in insert, update, and delete commands
                MySqlCommandBuilder cmdBldr = new MySqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(ds, "bddmontijotest");
                dataGridViewCompanies.DataSource = ds;
                dataGridViewCompanies.DataMember = "bddmontijotest";
            }
            catch (Exception)
            {

                throw;
            }


        }

  
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                dataAdapter.Update(ds, "bddmontijotest");
                MessageBox.Show("Database updated");
                MessageBox.Show(dataGridViewCompanies.ColumnCount.ToString());
                CompanyListForm_Load(sender, e);        ////// FIX THIS
            }
            catch
            {
                MessageBox.Show("Error, database is not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void comboBoxSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataGridViewCompanies.ColumnCount != 0)
            {
                ds.Tables["bddmontijotest"].Columns.Clear();   // Clear column of database
                ds.Tables["bddmontijotest"].Rows.Clear(); // Clear Rows of database

            }

            try
            {
                string sqlQuery = "";
                if (comboBoxSector.Text == "All companies")
                {
                    sqlQuery = "SELECT * FROM company";
                }
                else
                {
                    string parameter = comboBoxSector.Text;
                    sqlQuery = "SELECT company.* FROM company, sector WHERE company.idSector = sector.id AND sector.name ='" + parameter + "'";
                    
                }

                dataAdapter = new MySqlDataAdapter(sqlQuery, connectionDB.getMyconnectionString());
                // 3. fill in insert, update, and delete commands
                MySqlCommandBuilder cmdBldr = new MySqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(ds, "bddmontijotest");
                dataGridViewCompanies.DataSource = ds;
                dataGridViewCompanies.DataMember = "bddmontijotest";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        private void comboBoxEmail_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            connectionDB.ConnectionMySql();

            comboBoxEmail.Items.Clear();
            comboBoxEmail.Text = "";
            string sqlQuery = "SELECT email FROM company WHERE name='" + comboBoxCompany.Text + "'";
            connectionDB.PutQueryIntoComboBox(sqlQuery, comboBoxEmail, "email");
            comboBoxEmail.Text = comboBoxEmail.Items[0].ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            {
                
                connectionDB.ConnectionMySql();

                try
                {
                    if (comboBoxCompany.Text != null && comboBoxEmail.Text != null)
                        connectionDB.deleteCompany(comboBoxCompany.Text, comboBoxEmail.Text);
                    MessageBox.Show("Company deleted");
                    CompanyListForm_Load(null, null);
                    comboBoxCompany.Text = null;
                    comboBoxEmail.Text = null;
                }
                catch
                {
                    MessageBox.Show("Error : Can't delete from Database");
                }
            }
        }
    }
}
