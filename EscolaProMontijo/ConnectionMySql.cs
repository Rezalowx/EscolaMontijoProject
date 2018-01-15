using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace EscolaProMontijo
{
    class connectionMySql
    {
        private string MyconnectionString = "Server=127.0.0.1;Database=bddmontijotest;Uid=root;Pwd=";

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public MySqlConnection ConnectionMySql()
        {
            MySqlConnection connection = new MySqlConnection(MyconnectionString);
            return connection;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ConnectionInfo"></param>
        public void DisconnectMySql(MySqlConnection ConnectionInfo)
        {
            ConnectionInfo.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectCommand"></param>
        /// <param name="dgv"></param>
        /// <param name="bindingSource"></param>
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
        /// <param name="querysql"></param>
        /// <returns></returns>
        public string[] getInfosinStringArrayOfCompany (string nameCompany)
        {
            MySqlConnection con = ConnectionMySql();
            con.Open();

            string[] row = new string[4];
            string querysql = "SELECT c.name, c.email, c.numero, c.address FROM company c where name ='" + nameCompany + "'";
            using (var command = new MySqlCommand(querysql, con))
            {
                using (var reader = command.ExecuteReader())
                {
                    //Iterate through the rows and add it to the combobox's items
                    while (reader.Read())
                    {
                        row = new string[] { reader.GetString("name"), reader.GetString("email"), reader.GetString("numero"), reader.GetString("address") };
                    }
                    return row;
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="querySql"></param>
        /// <param name="combobox"></param>
        /// <param name="column"></param>
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

        public void PutQueryIntoLastRow(DataGridView dgv, BindingSource bs, string[] array)
        {


            DataTable dataTable = (DataTable)bs.DataSource;

            DataRow newRow = dataTable.NewRow();

            newRow[0] = array[0];
            newRow[1] = array[1];
            newRow[2] = array[2];
            newRow[3] = array[3];

            dataTable.Rows.Add(newRow);




            // Resize the DataGridView columns to fit the newly loaded content.
            dgv.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

        }


    }
}
