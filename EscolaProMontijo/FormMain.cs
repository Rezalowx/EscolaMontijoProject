using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace EscolaProMontijo
{
    public partial class FormMain : Form
    {
        connectionMySql connectionDB = new connectionMySql();
        List<string> allAttachments = new List<string>();


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

                comboBoxChooseList.Items.Clear();
                string sqlCommand = "SELECT TABLE_NAME as available FROM information_schema.TABLES WHERE TABLE_SCHEMA = 'bddmontijotest' AND TABLE_NAME LIKE 'list%'";
                connectionDB.PutQueryIntoComboBox(sqlCommand, comboBoxChooseList, "available");
                

                comboBoxSector.Items.Clear();
                comboBoxSector.Items.Add("All companies");
                sqlCommand = "SELECT name FROM sector ORDER BY name";
                connectionDB.PutQueryIntoComboBox(sqlCommand, comboBoxSector, "name");

                comboBoxCompany.Items.Clear();
                sqlCommand = "SELECT DISTINCT name from company ORDER BY name";
                connectionDB.PutQueryIntoComboBox(sqlCommand, comboBoxCompany, "name");

                comboBoxSignature.Items.Clear();
                sqlCommand = "SELECT name FROM user";
                connectionDB.PutQueryIntoComboBox(sqlCommand, comboBoxSignature, "name");
                comboBoxSignature.Text = comboBoxSignature.Items[0].ToString();

                comboBoxEmail.Visible = false;

            }
            catch ( Exception er)
            {
                MessageBox.Show(er.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

      
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connectionDB.ConnectionMySql();
                comboBoxCompany.Items.Clear();
                string sqlQuery = "SELECT DISTINCT name FROM company";
                if (comboBoxSector.Text == "All companies")
                {
                    connectionDB.PutQueryIntoComboBox(sqlQuery, comboBoxCompany, "name");
                }
                
                
                string parameter = comboBoxSector.Text;
                sqlQuery = "SELECT DISTINCT company.name FROM company, sector WHERE company.idSector = sector.id AND sector.name ='" + parameter + "'";
                connectionDB.PutQueryIntoComboBox(sqlQuery, comboBoxCompany, "name");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void bt_Add_Click(object sender, EventArgs e)  
        {

            try
            {
                if (string.IsNullOrWhiteSpace(comboBoxCompany.Text) && dataGridViewList.RowCount >0 )
                {
                    MessageBox.Show("Please check the company's name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
                else
                {


                    connectionDB.ConnectionMySql();

                    string addCompany = comboBoxCompany.Text;
                    string emailCheck = comboBoxEmail.Text;
                    string querysql = "SELECT c.name, c.email, c.numero, c.address FROM company c where name ='" + addCompany + "' AND c.email ='" + emailCheck + "'";
                    List<string[]> ListNewRow = connectionDB.getInfosinStringArrayOfQueryCompany(querysql);
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

                            connectionDB.PutListofStringIntoLastRows(dataGridViewList, bindingSourceList, ListNewRow);
                        }

                    }
                }
            }
            catch (Exception er)
            {


                MessageBox.Show(er.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            
           
            
       }
        private void bt_Delete_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(comboBoxCompany.Text))
                {
                    MessageBox.Show("Please check the company's name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    connectionDB.DeleteCompanyInDatagridView(comboBoxCompany.Text, comboBoxEmail.Text, dataGridViewList);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void comboBoxChooseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            connectionDB.ConnectionMySql();
            
            
            string parameter = comboBoxChooseList.Text;
            
            string sqlQuery = "SELECT c.name, c.email, c.numero, c.address, l.* FROM " + parameter + " l JOIN company c ON c.id = l.idCompany";
        
            connectionDB.getData(sqlQuery, dataGridViewList, bindingSourceList);
            dataGridViewList.Columns.Remove("nameCompany");
            dataGridViewList.Columns.Remove("idCompany");
        }

  

        private void viewListsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ViewList vL = new ViewList();
            vL.ShowDialog();
            Form1_Load(null, null);
            comboBoxCompany.Text = null;
            comboBoxSector.Text = null;
            comboBoxEmail.Text = null;
        }

        private void viewCompaniesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyListForm companylistform = new CompanyListForm();
            companylistform.ShowDialog();
            Form1_Load(null, null);
            comboBoxCompany.Text = null;
            comboBoxSector.Text = null;
            comboBoxEmail.Text = null;
        }

        private void addACompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddACompany addCompany = new AddACompany();
            addCompany.ShowDialog();
            Form1_Load(null, null);
            comboBoxCompany.Text = null;
            comboBoxSector.Text = null;
            comboBoxEmail.Text = null;
        }

        private void CreateListsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Create_a_list createAList = new Create_a_list();
            createAList.ShowDialog();
            Form1_Load(null, null);
            comboBoxCompany.Text = null;
            comboBoxSector.Text = null;
            comboBoxEmail.Text = null;

        }

        private void deleteACompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteACompanyForm deletecompany = new DeleteACompanyForm();
            deletecompany.ShowDialog();
            Form1_Load(null, null);
            comboBoxCompany.Text = null;
            comboBoxSector.Text = null;
            comboBoxEmail.Text = null;
        }

        private void createASignatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_a_signature createSignature = new Create_a_signature();
            createSignature.ShowDialog();
            Form1_Load(null, null);
            comboBoxCompany.Text = null;
            comboBoxSector.Text = null;
            comboBoxEmail.Text = null;
        }

        private void modifyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModifyASignature modifySignature = new ModifyASignature();
            modifySignature.ShowDialog();
            Form1_Load(null, null);
            comboBoxCompany.Text = null;
            comboBoxSector.Text = null;
            comboBoxEmail.Text = null;
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

        private void bt_Send_Click(object sender, EventArgs e)
        {
            try
            {


                string signature = comboBoxSignature.Text;
                string subject = textBoxSubjectMail.Text;                // Initialize what we need to send mails
                string emailFrom = "";
                string message = textBoxTextMail.Text;

                if (!string.IsNullOrWhiteSpace(subject) && !string.IsNullOrWhiteSpace(message))
                {
                    try
                    {
                        signature = connectionDB.getSignature(connectionDB.getUserId(comboBoxSignature.Text)); //get signature
                    }
                    catch
                    {
                        signature = "";
                    }
                    if (!string.IsNullOrWhiteSpace(signature))
                    {


                        int nbRows = dataGridViewList.RowCount;
                        progressBarSendingMail.Maximum = nbRows - 1;
                        progressBarSendingMail.Step = 1;                            // Initialize the progressBar
                        progressBarSendingMail.Value = 0;
                        progressBarSendingMail.Visible = true;


                        for (int row = 0; row < nbRows - 1; row++)
                        {

                            SendMails sendmail = new SendMails();
                            sendmail.sendAMail(message, emailFrom, dataGridViewList.Rows[row].Cells[1].Value.ToString(), subject, signature, allAttachments, progressBarSendingMail); //Sending mail and updating progressBar


                        }

                        allAttachments.Clear();
                        textBoxBrowse.Text = null;
                        pictureBoxCancelBrowse.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Signature is empty or is wrong", "Warning : email empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(message))
                    {
                        MessageBox.Show("Email is empty, please write a message.", "Warning : email empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                       
                            MessageBox.Show("subject is empty, please write a subject.", "Warning : subject empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        
                    }
                }
                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
           
           var resultFile = openFileDialog1.ShowDialog();
           int lastline = textBoxBrowse.Lines.Length;

            if (resultFile == DialogResult.OK)
            {
                allAttachments.Add(openFileDialog1.FileName);               //Add attachments to the list
                textBoxBrowse.AppendText(allAttachments.LastOrDefault());         // Append attachment to the textbox
                textBoxBrowse.AppendText(Environment.NewLine);
                
                if (allAttachments.Count > 0)
                {
                    pictureBoxCancelBrowse.Visible = true;        //if there is attachment, picturebox there is
                }
                
            }
        }

        private void pictureBoxCancelBrowse_Click(object sender, EventArgs e)
        {
            
                int chartodelete = allAttachments.LastOrDefault().Length; 
                allAttachments.RemoveAt(allAttachments.Count - 1);          //Remove attachment from list
                textBoxBrowse.Text = textBoxBrowse.Text.Substring(0, textBoxBrowse.Text.Length - chartodelete - 2); // Remove attachment from textbox

                if (allAttachments.Count < 1)
                {
                    pictureBoxCancelBrowse.Visible = false;         // No more attachments, no more pictureBox
                }
            
        }

        private void sectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sector sector = new sector();
            sector.ShowDialog();
        }

        private void releaseNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Application.StartupPath + @"\Release notes.txt");
            }
            catch
            {
                MessageBox.Show("File does not exist", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void UserDocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Application.StartupPath + @"\README.pdf");
            }
            catch
            {
                MessageBox.Show("File does not exist", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
