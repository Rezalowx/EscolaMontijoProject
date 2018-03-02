using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;


namespace EscolaProMontijo
{
    class connectionMySql
    {
        private string MyconnectionString = "Server=127.0.0.1;Database=dbepm;Uid=root;Pwd="; // credentials

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
        /// Get data from a sql query into a datagridview
        /// </summary>
        /// <param name="selectCommand">string sql query</param>
        /// <param name="dgv">Datagridview you want your data in</param>
        /// <param name="bindingSource">Binding source of the datagridview</param>
        public void getData(string selectCommand, DataGridView dgv, BindingSource bindingSource) 
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
        /// Get the idSector from a sector name
        /// </summary>
        /// <param name="sectorName">string sector name</param>
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
        /// Create a new list (table) in the database and columns
        /// </summary>
        /// <param name="nameOfList">string name of the table</param>
        /// <param name="columns">params string[] name of the column</param>
        public void createNewList(string nameOfList, params string[] columns)
        {
            MySqlConnection con = ConnectionMySql();
            con.Open();

            string sqlQuery = "CREATE TABLE `list"+nameOfList+"` ( `idCompany` int(10) NOT NULL, `nameCompany` varchar(77) NOT NULL) ENGINE = InnoDB DEFAULT CHARSET = utf8;";
            var command = new MySqlCommand(sqlQuery, con);
            command.ExecuteNonQuery();

            sqlQuery = "ALTER TABLE `list"+nameOfList+"` ADD PRIMARY KEY(`idCompany`,`nameCompany`), ADD KEY `nameCompany` (`nameCompany`), ADD KEY `idCompany` (`idCompany`,`nameCompany`);";
            command = new MySqlCommand(sqlQuery, con);
            command.ExecuteNonQuery();

            sqlQuery = "ALTER TABLE `list"+nameOfList+"` ADD CONSTRAINT `"+nameOfList+"_ibfk_2` FOREIGN KEY (`idCompany`,`nameCompany`) REFERENCES `company` (`id`, `name`) ON DELETE CASCADE;";
            command = new MySqlCommand(sqlQuery, con);
            command.ExecuteNonQuery();

            

            for (int i = 0; i < columns.Length; i++)
            {
                
                if (columns[i] != "")
                {
                    sqlQuery = "ALTER TABLE `list" + nameOfList + "` ADD `" + columns[i] + "` VARCHAR(77) NULL; ";
                    command = new MySqlCommand(sqlQuery, con);
                    command.ExecuteNonQuery();

                }
            }

        }

        /// <summary>
        /// Add a company to a list (table)
        /// </summary>
        /// <param name="nameCompany">string name of the company</param>
        /// <param name="emailCompany">string email of the company</param>
        /// <param name="nameList">string name of the list (table)</param>
        public void addCompanyToList (string nameCompany, string emailCompany, string nameList)
        {
            MySqlConnection con = ConnectionMySql();
            con.Open();
            string idCompany = "";
            string sqlQuery = "SELECT id FROM Company where name ='"+nameCompany+"' AND email ='"+emailCompany+"'" ;
            using (var commandReader = new MySqlCommand(sqlQuery, con))
            {

                using (var reader = commandReader.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        idCompany = (reader.GetString("id"));
                    }      
                }
            }
            sqlQuery = "INSERT INTO `"+nameList+"` (`idCompany`,`nameCompany`) VALUES ('"+idCompany+"','"+nameCompany+"')";
            var command = new MySqlCommand(sqlQuery, con);
            command.ExecuteNonQuery();


        }

        /// <summary>
        /// Delete a company in a table
        /// </summary>
        /// <param name="nameCompany">string name of the company</param>
        /// <param name="emailCompany">string email of the company</param>
        /// <param name="nameList">string name of the table</param>
        public void deleteCompanyFromList (string nameCompany, string emailCompany, string nameList)
        {
            MySqlConnection con = ConnectionMySql();
            con.Open();

            string idCompany = "";
            string sqlQuery = "SELECT id FROM Company WHERE name ='" + nameCompany + "' AND email ='"+emailCompany+"'";
            using (var commandReader = new MySqlCommand(sqlQuery, con))
            {

                using (var reader = commandReader.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        idCompany = (reader.GetString("id"));
                    }
                }
            }
            sqlQuery = "DELETE FROM `"+nameList+"` WHERE `idCompany` ='"+idCompany+"' AND `nameCompany` = '"+nameCompany+"'";
            var command = new MySqlCommand(sqlQuery, con);
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Delete a "list" (table) in database
        /// </summary>
        /// <param name="nameTable">string name of the table you want to delete</param>
        public void deleteList (string nameTable)
        {
            MySqlConnection con = ConnectionMySql();
            con.Open();

            string sqlQuery = "DROP table " + nameTable;

            var command = new MySqlCommand(sqlQuery, con);
            command.ExecuteNonQuery();

        }

        /// <summary>
        /// Get the userid of a user
        /// </summary>
        /// <param name="name">name of a user you want the id</param>
        /// <returns></returns>
        public string getUserId(string name)
        {
            MySqlConnection con = ConnectionMySql();
            con.Open();

            string userId = "";
            string sqlQuery = "SELECT id FROM user WHERE name ='" + name + "'";
            {
                using (var command = new MySqlCommand(sqlQuery, con))
                {

                    using (var reader = command.ExecuteReader())
                    {
                        //Iterate through the rows and add it to the combobox's items
                        while (reader.Read())
                        {

                            userId = (reader.GetString("id"));


                        }
                    }
                }

                return userId;
            }
            
        }

        /// <summary>
        /// Update table user with parameters
        /// </summary>
        /// <param name="name">string you want in the column name</param>
        /// <param name="email">string you want in the column email</param>
        /// <param name="signature">string you want in the column signature</param>
        /// <param name="idUser">string you need to know which user you are updating</param>
        public void modifySignature(string name, string signature, string idUser)
        {
            MySqlConnection con = ConnectionMySql();
            con.Open();

            string sqlQuery = "UPDATE `user` SET `name` ='" + name + "', `signature` = '" + signature + "' WHERE `user`.`id` = " + idUser + ";";

            var command = new MySqlCommand(sqlQuery, con);
            command.ExecuteNonQuery();


        }
        /// <summary>
        /// Create a new sector in the database
        /// </summary>
        /// <param name="name">Sector's name</param>
        public void createNewSector(string name)
        {
            MySqlConnection con = ConnectionMySql();
            con.Open();

            string sqlQuery = "INSERT INTO sector (name) VALUES ('" + name + "');";

            var command = new MySqlCommand(sqlQuery, con);
            command.ExecuteNonQuery();

        }

        /// <summary>
        /// Delete a sector in the database
        /// </summary>
        /// <param name="name">Sector's name</param>
        public void deleteSector(string name)
        {
            MySqlConnection con = ConnectionMySql();
            con.Open();

            string sqlQuery = "DELETE from sector where name ='" + name + "'";

            var command = new MySqlCommand(sqlQuery, con);
            command.ExecuteNonQuery();
        }
        /// <summary>
        /// Insert into user in the database.
        /// </summary>
        /// <param name="name">string you want in the column name</param>
        /// <param name="email">string you want in the column email</param>
        /// <param name="signature">string you want in the the column signature</param>
        public void createNewSignature(string name, string signature)
        {
            MySqlConnection con = ConnectionMySql();
            con.Open();

            string sqlQuery = "INSERT INTO user (name, signature) VALUES ( '" + name + "' , '" + signature + "');";

            var command = new MySqlCommand(sqlQuery, con);
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Delete a signature from database
        /// </summary>
        /// <param name="userId">id of the signature/user</param>
        public void deleteSignature(string userId)
        {
            MySqlConnection con = ConnectionMySql();
            con.Open();

            
            string sqlQuery = "DELETE FROM user WHERE id =" + userId+";";

            var command = new MySqlCommand(sqlQuery, con);
            command.ExecuteNonQuery();
        }

        
        /// <summary>
        /// Get the signature
        /// </summary>
        /// <param name="userId">string userID in the database</param>
        /// <returns></returns>
        public string getSignature(string userId)
        {

            MySqlConnection con = ConnectionMySql();
            con.Open();
            string signature = "";
            
            string sqlQuery = "SELECT signature FROM user WHERE id=" + userId;

            using (var command = new MySqlCommand(sqlQuery, con))
            {

                using (var reader = command.ExecuteReader())
                {                                  
                    while (reader.Read())
                    {
                       signature = reader.GetString("signature");
                    }
                }
            }

            return signature;
        }
        /// <summary>
        /// Insert into company in the database.
        /// </summary>
        /// <param name="idSector">string you want in the column idSector</param>
        /// <param name="name">string you want in the column name</param>
        /// <param name="email">string you want in the column email</param>
        /// <param name="numero">string you want in the column numero</param>
        /// <param name="address">string you want in the column address</param>
        public void addNewCompany(string idSector, string name, string email, string numero, string address) // FIX THIS
        {
            MySqlConnection con = ConnectionMySql();
            con.Open();
            
            string sqlQuery = "INSERT INTO `company`( idSector, `name`, `email`, `Numero`, `address`) VALUES ( '"+idSector+"' , '" + name + "' , '" + email + "', '" + numero + "', '" + address + "')";

            var command = new MySqlCommand(sqlQuery, con);
            command.ExecuteNonQuery();
            
        }

        /// <summary>
        /// Delete a company in database
        /// </summary>
        /// <param name="name">string of the company name you want to delete</param>
        /// <param name="email">string of the company email you want to delete</param>
        public void deleteCompany(string name, string email)
        {
            MySqlConnection con = ConnectionMySql();
            con.Open();
            string sqlQuery = "";
           
                   sqlQuery = "DELETE FROM company WHERE name ='" + name + "' AND email ='" + email + "'";
            
           
            var command = new MySqlCommand(sqlQuery, con);
            command.ExecuteNonQuery();

        }

        /// <summary>
        /// Put the result of a query into a combobox
        /// </summary>
        /// <param name="querySql">a sql query</param>
        /// <param name="combobox">the combobox you want the result of the query in</param>
        /// <param name="column">column of the table you want in your combobox</param>
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
        /// Put the result of a query into a textbox
        /// </summary>
        /// <param name="querySql">a sql query</param>
        /// <param name="textBox">the textbox you want the result of the query in</param>
        /// <param name="column">column of the table you want in your textbox</param>
        public void PutQueryIntoTextBox(string querySql, TextBox textBox, string column)
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
                       textBox.Text =(reader.GetString(column));

                    }
                }
            }
        }

        /// <summary>
        /// Add a List<string> from method PutListofStringIntoLastRows into the last row of a datagridview
        /// </summary>
        /// <param name="dgv">datagridview you work with</param>
        /// <param name="bs">binding source of the datagridview</param>
        /// <param name="listofRows">list you want to add</param>
        public void PutListofStringIntoLastRows(DataGridView dgv, BindingSource bs, List<string[]> listofRows)
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

        /// <summary>
        /// Get a list<string[]> as index [0],[1],[2],[3] = [name], [email], [numero], [address] (columns from company)
        /// </summary>
        /// <param name="querysql">string sql query (select from company)</param>
        /// <returns></returns>
        public List<String[]> getInfosinStringArrayOfQueryCompany(string querysql)
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

        /// <summary>
        /// Delete the company you want in a datagridview
        /// </summary>
        /// <param name="companyToDelete">string of the name of the company you want to delete</param>
        /// <param name="emailToDelete">string of the name of the company you want to delete</param>
        /// <param name="dgv">datagridview you are working with</param>
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


    }
}
