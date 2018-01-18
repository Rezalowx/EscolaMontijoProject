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
            dataGridView1.DataSource = bindingSourceList;
            connectionDB.ConnectionMySql();
            dataGridViewCompanies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            string sqlCommand = "SELECT name FROM list";

            connectionDB.PutQueryIntoComboBox(sqlCommand, comboBoxListCompanies, "name");

            sqlCommand = "SELECT * FROM company ORDER BY name";
            connectionDB.getData(sqlCommand, dataGridViewCompanies, bindingSourceCompanies);

           
        }

        private void comboBoxListCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string parameter = comboBoxListCompanies.Text;
            string sqlQuery = "SELECT c.* FROM list l JOIN listcompany lc ON l.id = lc.idList JOIN company c ON c.id = lc.idCompany WHERE l.name ='" + parameter + "'";
            connectionDB.getData(sqlQuery, dataGridViewCompanies, bindingSourceCompanies);

            sqlQuery = "SELECT lc.* FROM list l JOIN listcompany lc ON l.id = lc.idList JOIN company c ON c.id = lc.idCompany WHERE l.name ='" + parameter + "'";
            connectionDB.getData(sqlQuery, dataGridView1, bindingSourceList);

        }
    }
}
