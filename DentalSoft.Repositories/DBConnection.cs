using DentalSoft.Library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Dentalsoft.Repositories
{
    public abstract class DBConnection
    {
        protected SQLiteConnection connection;
        protected string connectionString;
        protected string database;

        private string dbFile;

        public DBConnection()
        {
            Initialize();
        }

        private void Initialize()
        {
            dbFile = Application.StartupPath + "\\dentalsoft.db";
            database = "dentalsoft";
            connectionString = String.Format("Data Source={0}", dbFile);
            connection = new SQLiteConnection(connectionString);
        }

        protected void handleException(SQLiteException ex)
        {
            MessageBox.Show("Numri i gabimit: " + ex.ErrorCode + "\n\nMesazhi i gabimit:\n" + ex.Message, 
                            "Gabim ne bazen e te dhenave", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected List<DataColumn> getSchemaTable(string tableName)
        {
            List<DataColumn> dataColumnsList = new List<DataColumn>();
            Utilities utilities = new Utilities();
            try
            {
                connection.Open();
                string query = "PRAGMA table_info(" + tableName + ")";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            DataColumn dc = new DataColumn();
                            dc.ColumnName = utilities.toUpperFirstLetter(dataReader["name"].ToString());
                            dataColumnsList.Add(dc);
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                handleException(ex);
            }
            finally
            {
                connection.Close();
            }
            return dataColumnsList;
        }
    }
}