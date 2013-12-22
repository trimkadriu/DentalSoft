using DentalSoft.Library;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Dentalsoft.Repositories
{
    public abstract class DBConnection
    {
        protected MySqlConnection connection;
        protected string connectionString;
        protected string database;

        private string server;
        private string username;
        private string password;

        public DBConnection()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "dentalsoft";
            username = "dentalsoft";
            password = "dentalsoft";
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        protected void handleException(MySqlException ex)
        {
            MessageBox.Show("MySQL numri i gabimit: " + ex.Number, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected List<DataColumn> getSchemaTable(string tableName)
        {
            List<DataColumn> dataColumnsList = new List<DataColumn>();
            Utilities utilities = new Utilities();
            try
            {
                connection.Open();
                string query = "SELECT COLUMN_NAME as `columns` FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = @Database AND TABLE_NAME=@TableName";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Database", database);
                    cmd.Parameters.AddWithValue("@TableName", tableName);

                    using (MySqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            DataColumn dc = new DataColumn();
                            dc.ColumnName = utilities.toUpperFirstLetter(dataReader.GetString("columns"));
                            dataColumnsList.Add(dc);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                handleException(ex);
            }
            finally
            {
                connection.Dispose();
            }
            return dataColumnsList;
        }
    }
}