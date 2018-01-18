using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;


namespace EscolaProMontijo
{
    class connectionMySql
    {
        private string MyconnectionString = "Server=127.0.0.1;Database=bddmontijotest;Uid=root;Pwd=";

        /// <summary>
        /// Connect to the database
        /// </summary>
        /// <returns></returns>
        public MySqlConnection ConnectionMySql()
        {
           
            MySqlConnection connection = new MySqlConnection(MyconnectionString);
            return connection;
            
        }
        /// <summary>
        /// Disconnect sql
        /// </summary>
        /// <param name="ConnectionInfo">a valid MySqlConnection</param>
        public void DisconnectMySql(MySqlConnection ConnectionInfo)
        {
            ConnectionInfo.Close();
        }

        /// <summary>
        /// return the connection string
        /// </summary>
        /// <returns></returns>
        public string getMyconnectionString()
        {
            return MyconnectionString;
        }
       
        /// <summary>
        /// Get data of sql query in a datagridview
        /// </summary>
        /// <param name="selectCommand">Sql query</param>
        /// <param name="dgv">Datagridview you want your data in</param>
        /// <param name="bindingSource">Binding source of the datagridview</param>
        public void getData(string selectCommand, DataGridView dgv, BindingSource bindingSource) // Get et update les datas dans une dgv
        {
            try
            {
                // Create a new data adapter based on the specified query.
                var dataAdapter = new MySqlDataAdapter(selectCommand, MyconnectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource.DataSource = table;
                dgv.DataSource = bindingSource;

                // Resize the DataGridView columns to fit the newly loaded content.
                dgv.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (MySqlException sql)
            {
                MessageBox.Show(sql.ToString());
            }
        }

       
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sectorName"></param>
        /// <returns></returns>
        public string getIdSectorFromName(string sectorName)
        {
            MySqlConnection con = ConnectionMySql();
            con.Open();
            string sqlQuery = "SELECT id FROM sector WHERE name ='" + sectorName + "'";

            using (var command = new MySqlCommand(sqlQuery, con))
            {
                using (var reader = command.ExecuteReader())
                {
                    reader.Read();
                    return reader.GetString("id");
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idSector"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="numero"></param>
        /// <param name="address"></param>
        public void addNewCompany(string idSector, string name, string email, string numero, string address) // FIX THIS
        {
            MySqlConnection con = ConnectionMySql();
            con.Open();
            
            string sqlQuery = "INSERT INTO `company`( idSector, `name`, `email`, `Numero`, `address`) VALUES ( '"+idSector+"' , '" + name + "' , '" + email + "', '" + numero + "', '" + address + "')";

            var command = new MySqlCommand(sqlQuery, con);
            command.ExecuteNonQuery();
            
        }
        public void deleteCompany(string name, string email)
        {
            MySqlConnection con = ConnectionMySql();
            con.Open();

            string sqlQuery = "DELETE FROM company WHERE name ='" + name + "' AND email ='"+email+"'";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="querySql">a sql query</param>
        /// <param name="combobox">the combobox you want the result of the query in</param>
        /// <param name="column"column of the table you want in your combobox</param>
        public void PutQueryIntoComboBox(string querySql, ComboBox combobox, string column)
        {
            MySqlConnection con = ConnectionMySql();
            con.Open();

            using (var command = new MySqlCommand(querySql, con))
            {
                
                using (var reader = command.ExecuteReader())
                {
                    //Iterate through the rows and add it to the combobox's items
                    while (reader.Read())
                    {

                        combobox.Items.Add(reader.GetString(column));


                    }
                }
            }
        }

        /// <summary>
        /// Add a string[] into the last row of a datagridview
        /// </summary>
        /// <param name="dgv">datagridview you work with</param>
        /// <param name="bs">binding source of the datagridview</param>
        /// <param name="array">valid array you want to add</param>

        public void PutListofRowsIntoLastRows(DataGridView dgv, BindingSource bs, List<string[]> listofRows)
        {

            
            foreach (string[] rows in listofRows)
            {

            
            DataTable dataTable = (DataTable)bs.DataSource;

            DataRow newRow = dataTable.NewRow();

            newRow[0] = rows[0];
            newRow[1] = rows[1];
            newRow[2] = rows[2];
            newRow[3] = rows[3];

            dataTable.Rows.Add(newRow);

            }



            // Resize the DataGridView columns to fit the newly loaded content.
            dgv.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

        }
        public List<String[]> getInfosinStringArrayOfQuery(string querysql)
        {
            MySqlConnection con = ConnectionMySql();
            con.Open();
            List<string[]> rowsString = new List<string[]>();

            string[] row = new string[4];
            
            using (var command = new MySqlCommand(querysql, con))
            {
                using (var reader = command.ExecuteReader())
                {
                    //Iterate through the rows and add it to the combobox's items
                    while (reader.Read())
                    {
                        row = new string[] { reader.GetString("name"), reader.GetString("email"), reader.GetString("numero"), reader.GetString("address") };
                        rowsString.Add(row);
                    }
                    return rowsString;
                }
            }

        }

        /// <summary>
        /// Delete the company you want in the datagridview
        /// </summary>
        /// <param name="companyToDelete">Company you want to delete</param>
        /// <param name="dgv">Datagridview you work with</param>
        public void DeleteCompanyInDatagridView (string companyToDelete, DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count - 1; i++) 
            {
                string companyToCheck = dgv.Rows[i].Cells[0].Value.ToString();
                if (companyToCheck == companyToDelete)
                {
                    dgv.Rows.Remove(dgv.Rows[i]);
                }
            }
        }
        public void DeleteCompanyInDatagridView(string companyToDelete, string emailToDelete, DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                string companyToCheck = dgv.Rows[i].Cells[0].Value.ToString();
                string emailToCheck = dgv.Rows[i].Cells[1].Value.ToString();
                if (companyToCheck == companyToDelete && emailToCheck == emailToDelete)
                {
                    dgv.Rows.Remove(dgv.Rows[i]);
                }
            }
        }

        /// <summary>
        /// Add a new company in database
        /// </summary>
        /// <param name="name">Company's name</param>
        /// <param name="email">Company's email</param>
        /// <param name="numero">Company's numero</param>
        /// <param name="address">Company's address</param>


    }
}
