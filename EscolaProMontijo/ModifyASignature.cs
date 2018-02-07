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
    public partial class ModifyASignature : Form
    {
        connectionMySql connectionDB = new connectionMySql();
        string idUser = "";


        public ModifyASignature()
        {
            InitializeComponent();
        }

        private void ModifyASignature_Load(object sender, EventArgs e)
        {
            comboBoxName.Text = null;
            textBoxSignature.Text = null;
            textBoxEmail.Text = null;
            comboBoxName.Items.Clear();

            string sqlQuery = "SELECT name FROM user";
            connectionDB.PutQueryIntoComboBox(sqlQuery, comboBoxName, "name");        // Put infos in combobox

        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT email FROM user WHERE name='"+comboBoxName.Text+"'";
            connectionDB.PutQueryIntoTextBox(sqlQuery, textBoxEmail, "email");

            sqlQuery = "SELECT signature FROM user WHERE name ='" + comboBoxName.Text + "'";    // Put infos in textboxes
            connectionDB.PutQueryIntoTextBox(sqlQuery, textBoxSignature, "signature");

            sqlQuery = "SELECT id FROM user WHERE name = '" + comboBoxName.Text + "'";
            idUser = connectionDB.getUserId(comboBoxName.Text);                         // Get the id of the user (in order to update later)
            
        }

      

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    connectionDB.modifySignature(comboBoxName.Text, textBoxEmail.Text, textBoxSignature.Text, idUser);  // Update database
                    MessageBox.Show("Signature updated successfully !");
                }

            }
            catch
            {
                MessageBox.Show("Error : couldn't update the database");
            }
        }

        private void buttonDeleteSignature_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    connectionDB.deleteSignature(idUser);  // Delete signature from database
                    MessageBox.Show("Signature deleted successfully !");
                    ModifyASignature_Load(null, null);
                }

            }
            catch
            {
                MessageBox.Show("Error : couldn't update the database");
            }
        }
    
    }
}
