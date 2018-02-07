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
        connectionMySql connectionDB = new connectionMySql();

        public AddACompany()
        {
            InitializeComponent();
        }

        private void AddACompany_Load(object sender, EventArgs e)
        {
            
            connectionDB.ConnectionMySql();

            string sqlQuery = "SELECT name FROM sector";
            connectionDB.PutQueryIntoComboBox(sqlQuery, comboBoxSector, "name");  // Use method to add query into the comboBoxSector
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSaveCompany_Click(object sender, EventArgs e)
        {

            
            connectionDB.ConnectionMySql();

            try
            {
                if (textBoxNameCompany.Text != "" && comboBoxSector.Text != "")  // create the company into the database
                {
                    connectionDB.addNewCompany(connectionDB.getIdSectorFromName(comboBoxSector.Text), textBoxNameCompany.Text, textBoxEmailCompany.Text, textBoxNumero.Text, textBoxAddressCompany.Text);
                    MessageBox.Show("Database updated !");
                }
                else
                {
                    if (textBoxNameCompany.Text == "")
                    {
                        MessageBox.Show("Add at least a company name !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("You must choose a sector !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error, database is not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
