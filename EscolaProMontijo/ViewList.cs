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
        
        public ViewList()
        {
            InitializeComponent();
        }

        private void ViewList_Load(object sender, EventArgs e)
        {

            dataGridViewList.DataSource = bindingSourceList;
            try
            {
                connectionMySql connectionDB = new connectionMySql();
                connectionDB.ConnectionMySql();



                dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                string sqlCommand = "SELECT TABLE_NAME as available FROM information_schema.TABLES WHERE TABLE_SCHEMA = 'bddmontijotest' AND TABLE_NAME LIKE 'list%'";
                connectionDB.PutQueryIntoComboBox(sqlCommand, comboBoxList, "available");


            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            connectionMySql connectionDB = new connectionMySql();
            connectionDB.ConnectionMySql();

            ds.Clear();
            
            
          

         
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
                MessageBox.Show(ex.ToString());
            }



        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                dataAdapter.Update(ds, "bddmontijotest");
                MessageBox.Show("Datase updated");
            }
            catch
            {
                MessageBox.Show("Error, database is not updated");
                comboBox1_SelectedIndexChanged(sender, e);
            }

        }

        private void dataGridViewList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
