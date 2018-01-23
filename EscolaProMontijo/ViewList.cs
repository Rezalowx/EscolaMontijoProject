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

                string sqlCommand = "SELECT TABLE_NAME as available FROM information_schema.TABLES WHERE TABLE_SCHEMA = 'bddmontijotest' AND TABLE_NAME LIKE 'list%'";
                connectionDB.PutQueryIntoComboBox(sqlCommand, comboBoxList, "available");


            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            connectionDB.ConnectionMySql();

            

            if (dataGridViewList.ColumnCount != 0)
            {
                ds.Tables["bddmontijotest"].Columns.Clear();   // Clear column of database
                ds.Tables["bddmontijotest"].Rows.Clear(); // Clear Rows of database
                //ds.Clear();
            }


            // FIX THIS 

           
         
            try
            {
                
                string sqlCommand = "SELECT l.* FROM " + comboBoxList.Text + " l JOIN company c ON c.id = l.idCompany";
                dataAdapter = new MySqlDataAdapter(sqlCommand, connectionDB.getMyconnectionString());
                // 3. fill in insert, update, and delete commands
                MySqlCommandBuilder cmdBldr = new MySqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(ds, "bddmontijotest");
                dataGridViewList.DataSource = ds;
                dataGridViewList.DataMember = "bddmontijotest";

                

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
                dataAdapter.Update(ds, "bddmontijotest");
                MessageBox.Show("Database updated");
            }
            catch
            {
                MessageBox.Show("Error, database is not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1_SelectedIndexChanged(sender, e);
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
                    connectionDB.deleteList(comboBoxList.Text);
                    MessageBox.Show("List deleted successfully");
                    comboBoxList.Text = null;
   
                }
                ViewList_Load(null, null);
            }
           
            catch
            {
                MessageBox.Show("ERROR : can't update the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
