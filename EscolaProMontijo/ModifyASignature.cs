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


        public ModifyASignature()
        {
            InitializeComponent();
        }

        private void ModifyASignature_Load(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT name FROM user";
            connectionDB.PutQueryIntoComboBox(sqlQuery, comboBoxName, "name");

        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT email FROM user WHERE name='"+comboBoxName.Text+"'";
            connectionDB.PutQueryIntoTextBox(sqlQuery, textBoxEmail, "email");

            sqlQuery = "SELECT signature FROM user WHERE name ='" + comboBoxName.Text + "'";
            connectionDB.PutQueryIntoTextBox(sqlQuery, textBoxSignature, "signature");
        }

      

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            // DO THIS
        }
    }
}
