using Dentalsoft.Repositories;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DentalSoft.Repositories
{
    class DentistsRepository : Connection
    {
        string query;

        public DentistsRepository()
        {
            
        }

        override public void insertStatement()
        {
            if (base.OpenConnection())
            {
                query = "";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        override public void updateStatement()
        {
            if (base.OpenConnection())
            {
                query = "";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        override public void deleteStatement()
        {
            if (base.OpenConnection())
            {
                query = "";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        override public List<object>[] selectStatement()
        {
            if (base.OpenConnection())
            {
                query = "";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {

                }
                dataReader.Close();
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                return null;
            }
            return null;
        }
    }
}
