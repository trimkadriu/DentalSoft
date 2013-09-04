using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dentalsoft.Repositories
{
    public abstract class Connection
    {
        protected MySqlConnection connection;
        protected string server;
        protected string database;
        private string username;
        private string password;

        public Connection()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "dentalsoft";
            username = "dentalsoft";
            password = "dentalsoft";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        protected bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Nuk mund te kyqet ne bazen e te dhenave.", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    case 1045:
                        MessageBox.Show("Qasja ne bazen e te dhenave nuk eshte ne rregull.", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    default:
                        MessageBox.Show("MySQL numri i gabimit: " + ex.Number, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                return false;
            }
        }

        protected bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        protected void testConnection()
        {
            if (OpenConnection())
                MessageBox.Show("Lidhja ne rregull");
            else
                MessageBox.Show("Lidhja nuk eshte ne rregull");
        }
    }
}