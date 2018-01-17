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
    public partial class AddACompany : Form
    {
        public AddACompany()
        {
            InitializeComponent();
        }

        private void AddACompany_Load(object sender, EventArgs e)
        {
            connectionMySql connectionDB = new connectionMySql();
            connectionDB.ConnectionMySql();

            string sqlQuery = "SELECT name FROM sector";
            connectionDB.PutQueryIntoComboBox(sqlQuery, comboBoxSector, "name");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSaveCompany_Click(object sender, EventArgs e)
        {

            connectionMySql connectionDB = new connectionMySql();
            connectionDB.ConnectionMySql();

            try
            {
                connectionDB.addNewCompany(connectionDB.getIdSectorFromName(comboBoxSector.Text), textBoxNameCompany.Text, textBoxEmailCompany.Text, textBoxNumero.Text, textBoxAddressCompany.Text);
                MessageBox.Show("Database updated !");
            }
            catch
            {
                MessageBox.Show("Error, database is not updated");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
