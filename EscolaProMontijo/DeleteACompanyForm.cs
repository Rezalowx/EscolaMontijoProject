﻿using System;
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
                connectionDB.deleteCompany(comboBoxCompany.Text, comboBoxEmail.Text);
                MessageBox.Show("Company deleted");
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
        }
    }
}