using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EscolaProMontijo
{
    public partial class ViewList : Form
    {

        DataSet ds = new DataSet();
        MySqlDataAdapter dataAdapter;
        connectionMySql connectionDB = new connectionMySql();


        public ViewList()
        {
            InitializeComponent();
        }

        private void ViewList_Load(object sender, EventArgs e)
        {

            dataGridViewList.DataSource = bindingSourceList;
            try
            {
                
                connectionDB.ConnectionMySql();
                comboBoxList.Items.Clear();
                

                dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                string sqlCommand = "SELECT TABLE_NAME as available FROM information_schema.TABLES WHERE TABLE_SCHEMA = 'dbepm' AND TABLE_NAME LIKE 'list%'";
                connectionDB.PutQueryIntoComboBox(sqlCommand, comboBoxList, "available");  // Use method to add the query to the comboBoxList

                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            connectionDB.ConnectionMySql();
            comboBoxCompany.Items.Clear();

            
            string sqlCommand = "SELECT DISTINCT name FROM company";
            connectionDB.PutQueryIntoComboBox(sqlCommand, comboBoxCompany, "name"); // Use method to add the query into the comboBoxCompany

            if (dataGridViewList.ColumnCount != 0) 
            {
                ds.Tables["dbepm"].Columns.Clear();   // Clear column of database
                ds.Tables["dbepm"].Rows.Clear(); // Clear Rows of database
                
            }

            try
            {
                
                sqlCommand = "SELECT l.* FROM " + comboBoxList.Text + " l JOIN company c ON c.id = l.idCompany";
                dataAdapter = new MySqlDataAdapter(sqlCommand, connectionDB.getMyconnectionString()); 
                // 3. fill in insert, update, and delete commands
                MySqlCommandBuilder cmdBldr = new MySqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(ds, "dbepm"); 
                dataGridViewList.DataSource = ds;                                       // Fill the dataGridViewList
                dataGridViewList.DataMember = "dbepm";

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                dataAdapter.Update(ds, "dbepm");                 // Save the changes and update the database
                MessageBox.Show("Database updated");
                comboBox1_SelectedIndexChanged(sender, e);
            }
            catch
            {
                MessageBox.Show("Error, database is not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void dataGridViewList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDeleteList_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.OKCancel);
                
                if (result == DialogResult.OK)
                {
                    connectionDB.deleteList(comboBoxList.Text);       // Use method to delete the list from database
                    MessageBox.Show("List deleted successfully");
                    
   
                }
                ViewList_Load(null, null);
            }
           
            catch
            {
                MessageBox.Show("ERROR : can't update the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            connectionDB.ConnectionMySql();

            
            comboBoxEmail.Items.Clear();
            comboBoxEmail.Visible = false;
            labelEmail.Visible = false;

            string sqlQuery = "SELECT email from company WHERE name='" + comboBoxCompany.Text + "'";
            connectionDB.PutQueryIntoComboBox(sqlQuery, comboBoxEmail, "email"); // Use method to put the query into the comboBoxEmail
            comboBoxEmail.Text = Convert.ToString(comboBoxEmail.Items[0]);

            if (comboBoxEmail.Items.Count > 1)
            {
                comboBoxEmail.Visible = true;
                labelEmail.Visible = true;
            }
        }

        private void buttonAddCompany_Click(object sender, EventArgs e)
        {

            try
            {
                connectionDB.addCompanyToList(comboBoxCompany.Text, comboBoxEmail.Text, comboBoxList.Text); // Use method to add a company in the list
                comboBox1_SelectedIndexChanged(null, null);
            }
            catch (Exception er)
            {
                MessageBox.Show("Error, the list is not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(er.ToString());

            }

        }

        private void buttonDeleteCompany_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    connectionDB.deleteCompanyFromList(comboBoxCompany.Text, comboBoxEmail.Text, comboBoxList.Text); // Use method to delete a company in the list
                    comboBox1_SelectedIndexChanged(null, null);
                }
            }
            catch
            {
                MessageBox.Show("Error, the list is not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
