using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaProMontijo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;      
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            dataGridViewList.DataSource = bindingSourceList;
            
            try
            {
                connectionMySql connectionDB = new connectionMySql();
                connectionDB.ConnectionMySql();

                

                dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                string sqlCommand = "SELECT name FROM list";
                connectionDB.PutQueryIntoComboBox(sqlCommand, comboBoxChooseList, "name");

                sqlCommand = "SELECT name FROM sector";
                connectionDB.PutQueryIntoComboBox(sqlCommand, comboBoxSector, "name");

                sqlCommand = "SELECT name from company";
                connectionDB.PutQueryIntoComboBox(sqlCommand, comboBoxCompany, "name");

            }
            catch ( Exception er)
            {
                MessageBox.Show(er.ToString());
            }

            

        }

      
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            connectionMySql connectionDB = new connectionMySql();
            connectionDB.ConnectionMySql();
            comboBoxCompany.Items.Clear();
            string parameter = comboBoxSector.Text;
            string sqlQuery = "SELECT company.name FROM company, sector WHERE company.idSector = sector.id AND sector.name ='"+parameter+"'";
            connectionDB.PutQueryIntoComboBox(sqlQuery, comboBoxCompany, "name");
        }
        private void bt_Add_Click(object sender, EventArgs e)  
        {

            connectionMySql connectionDB = new connectionMySql();
            connectionDB.ConnectionMySql();

            string addCompany = comboBoxCompany.Text;
            string sqlQuery = "SELECT company.name, company.email, company.numero, company.address FROM company where company.name ='" + addCompany + "'";
        


            connectionDB.PutQueryIntoLastRow(dataGridViewList, bindingSourceList, connectionDB.getInfosinStringArrayOfCompany(addCompany));
            
            
            
           
            
       }
        private void bt_Delete_Click(object sender, EventArgs e)
        {

        }


        private void comboBoxChooseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            connectionMySql connectionDB = new connectionMySql();
            connectionDB.ConnectionMySql();
            
            
            
            
            string parameter = comboBoxChooseList.Text;
            string sqlQuery = "SELECT c.name, c.email, c.numero, address FROM list l JOIN listcompany lc ON l.id = lc.idList JOIN company c ON c.id = lc.idCompany WHERE l.name ='" + parameter + "'"; 
            connectionDB.getData(sqlQuery, dataGridViewList, bindingSourceList);
        }

        private void addAListToolStripMenuCreateList_Click(object sender, EventArgs e)
        {
            Create_a_list cl = new Create_a_list();
            cl.ShowDialog();
        }

       
       
    }
}
