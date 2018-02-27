using System;
using System.Windows.Forms;

namespace EscolaProMontijo
{
    public partial class DeleteACompanyForm : Form
    {
        public DeleteACompanyForm()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            connectionMySql connectionDB = new connectionMySql();
            connectionDB.ConnectionMySql();

            try
            {
                if (comboBoxCompany.Text != null && comboBoxEmail.Text != null)
                connectionDB.deleteCompany(comboBoxCompany.Text, comboBoxEmail.Text);    
                MessageBox.Show("Company deleted");
                DeleteACompanyForm_Load(null, null);
                comboBoxCompany.Text = null;
                comboBoxEmail.Text = null; 
            }
            catch
            {
                MessageBox.Show("Error : Can't delete from Database");
            }
        }

        private void DeleteACompanyForm_Load(object sender, EventArgs e)
        {
            connectionMySql connectionDB = new connectionMySql();
            connectionDB.ConnectionMySql();

            comboBoxCompany.Items.Clear();
            comboBoxEmail.Items.Clear();
            string sqlQuery = "SELECT DISTINCT name FROM company";
            connectionDB.PutQueryIntoComboBox(sqlQuery, comboBoxCompany, "name");
        }

        private void comboBoxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            connectionMySql connectionDB = new connectionMySql();
            connectionDB.ConnectionMySql();

            comboBoxEmail.Items.Clear();
            comboBoxEmail.Text = "";
            string sqlQuery = "SELECT email FROM company WHERE name='" + comboBoxCompany.Text + "'";
            connectionDB.PutQueryIntoComboBox(sqlQuery, comboBoxEmail, "email");
            comboBoxEmail.Text = comboBoxEmail.Items[0].ToString(); 
        }
    }
}
