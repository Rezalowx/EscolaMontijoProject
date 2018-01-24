﻿using System;
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
            
            connectionDB.ConnectionMySql();
            dataGridViewCompanies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            string sqlCommand = "SELECT TABLE_NAME as available FROM information_schema.TABLES WHERE TABLE_SCHEMA = 'bddmontijotest' AND TABLE_NAME LIKE 'list%'";

            connectionDB.PutQueryIntoComboBox(sqlCommand, comboBoxListCompanies, "available");

            sqlCommand = "SELECT * FROM company ORDER BY name";
            connectionDB.getData(sqlCommand, dataGridViewCompanies, bindingSourceCompanies);

           
        }

        private void comboBoxListCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string parameter = comboBoxListCompanies.Text;
            string sqlQuery = "SELECT c.* FROM " + parameter + " l JOIN company c ON c.id = l.idCompany";
            connectionDB.getData(sqlQuery, dataGridViewCompanies, bindingSourceCompanies);

            

        }
    }
}