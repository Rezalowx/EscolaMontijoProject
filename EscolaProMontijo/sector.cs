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
    public partial class sector : Form
    {

        DataSet ds = new DataSet();
        MySqlDataAdapter dataAdapter;
        connectionMySql connectionDB = new connectionMySql();

        public sector()
        {
            InitializeComponent();
        }

        private void sector_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxSector.Items.Clear();
                string sqlQuery = "Select name FROM sector";
                connectionDB.PutQueryIntoComboBox(sqlQuery, comboBoxSector, "name");
                
                if (dataGridViewSector.ColumnCount != 0)
                {
                    ds.Tables["bddmontijotest"].Columns.Clear();   // Clear column of database
                    ds.Tables["bddmontijotest"].Rows.Clear(); // Clear Rows of database
                    

                }
                dataGridViewSector.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                string sqlCommand = "SELECT * FROM sector";
                dataAdapter = new MySqlDataAdapter(sqlCommand, connectionDB.getMyconnectionString());
                // 3. fill in insert, update, and delete commands
                MySqlCommandBuilder cmdBldr = new MySqlCommandBuilder(dataAdapter);
                
                dataAdapter.Fill(ds, "bddmontijotest");
                dataGridViewSector.DataSource = ds;                                       // Fill the dataGridViewList
                dataGridViewSector.DataMember = "bddmontijotest";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                dataAdapter.Update(ds, "bddmontijotest");                 // Save the changes and update the database
                MessageBox.Show("Database updated");
                sector_Load(null, null);


            }
            catch (Exception er)
            {
                MessageBox.Show("Error, database is not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
                
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {

                connectionDB.createNewSector(textBoxSector.Text);
                sector_Load(null, null);
            }
            catch
            {
                MessageBox.Show("Error, database is not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    connectionDB.deleteSector(comboBoxSector.Text);
                }

                sector_Load(null, null);
            }
            catch (Exception)
            {

                MessageBox.Show("Error, database is not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
