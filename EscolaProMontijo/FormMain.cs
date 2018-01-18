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
    public partial class FormMain : Form
    {
        connectionMySql connectionDB = new connectionMySql();
        

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
                
                connectionDB.ConnectionMySql();

                

                dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                string sqlCommand = "SELECT name FROM list";
                connectionDB.PutQueryIntoComboBox(sqlCommand, comboBoxChooseList, "name");

                sqlCommand = "SELECT name FROM sector";
                connectionDB.PutQueryIntoComboBox(sqlCommand, comboBoxSector, "name");

                sqlCommand = "SELECT DISTINCT name from company";
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
            
            connectionDB.ConnectionMySql();
            comboBoxCompany.Items.Clear();
            string parameter = comboBoxSector.Text;
            string sqlQuery = "SELECT DISTINCT company.name FROM company, sector WHERE company.idSector = sector.id AND sector.name ='"+parameter+"'";
            connectionDB.PutQueryIntoComboBox(sqlQuery, comboBoxCompany, "name");
        }
        private void bt_Add_Click(object sender, EventArgs e)  
        {

            try
            {

                connectionDB.ConnectionMySql();

                string addCompany = comboBoxCompany.Text;
                string emailCheck = comboBoxEmail.Text;
                string querysql = "SELECT c.name, c.email, c.numero, c.address FROM company c where name ='" + addCompany + "' AND c.email ='" + emailCheck + "'";
                List<string[]> ListNewRow = connectionDB.getInfosinStringArrayOfQuery(querysql);
                bool identicals = false;

                if (dataGridViewList.RowCount == 0)
                {
                    string sqlQuery = "SELECT company.name, company.email, company.numero, company.address FROM company where company.name ='" + addCompany + "'AND company.email ='" + emailCheck + "'";
                    connectionDB.getData(sqlQuery, dataGridViewList, bindingSourceList);
                }


                else
                {
                    for (int i = 0; i < dataGridViewList.Rows.Count - 1; i++)
                    {
                        int nbNewRows = ListNewRow.Count;
                        MessageBox.Show(nbNewRows.ToString());
                        string emailtocheck = dataGridViewList.Rows[i].Cells[1].Value.ToString();
                        if (emailtocheck == ListNewRow[0][1])
                        {
                            MessageBox.Show("2 emails are identicals, check it please");
                            identicals = true;
                            break;

                        }
                    }
                    if (identicals == false)
                    {

                        connectionDB.PutListofRowsIntoLastRows(dataGridViewList, bindingSourceList, ListNewRow);
                    }

                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
            
           
            
       }
        private void bt_Delete_Click(object sender, EventArgs e)
        {
            

            connectionDB.DeleteCompanyInDatagridView(comboBoxCompany.Text, comboBoxEmail.Text, dataGridViewList);

        }


        private void comboBoxChooseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            connectionDB.ConnectionMySql();
            
 
            string parameter = comboBoxChooseList.Text;
            string sqlQuery = "SELECT c.name, c.email, c.numero, address FROM list l JOIN listcompany lc ON l.id = lc.idList JOIN company c ON c.id = lc.idCompany WHERE l.name ='" + parameter + "'"; 
            connectionDB.getData(sqlQuery, dataGridViewList, bindingSourceList);
        }

        private void viewListsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void viewListsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ViewList vL = new ViewList();
            vL.ShowDialog();
        }

        private void viewCompaniesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyListForm companylistform = new CompanyListForm();
            companylistform.ShowDialog();
        }

        private void addACompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddACompany addCompany = new AddACompany();
            addCompany.ShowDialog();
        }

        private void CreateListsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Create_a_list createAList = new Create_a_list();
            createAList.ShowDialog();

        }

        private void deleteACompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteACompanyForm deletecompany = new DeleteACompanyForm();
            deletecompany.ShowDialog();
        }

        private void comboBoxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
      
            connectionDB.ConnectionMySql();

            comboBoxEmail.Items.Clear();
            comboBoxEmail.Visible = false;
            labelEmail.Visible = false;

            string sqlQuery = "SELECT email from company WHERE name='" + comboBoxCompany.Text + "'";
            connectionDB.PutQueryIntoComboBox(sqlQuery, comboBoxEmail, "email");
            comboBoxEmail.Text = Convert.ToString(comboBoxEmail.Items[0]);

            if (comboBoxEmail.Items.Count > 1)
            {
                comboBoxEmail.Visible = true;
                labelEmail.Visible = true;
            }
        }
    }
}
