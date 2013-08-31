using Dentalsoft.Repositories;
using DentalSoft.Domain;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DentalSoft.Repositories
{
    class DentistsRepository : Connection
    {
        private string query;

        public void insertStatement(Dentist dentist)
        {
            if (OpenConnection())
            {
                query = "INSERT INTO dentistet (id, emri, email, perdoruesi, fjalekalimi, foto_profilit) VALUES ('" + 
                        dentist.id + "', '" +
                        dentist.emri + "', '" +
                        dentist.email + "', '" +
                        dentist.perdoruesi + "', '" +
                        dentist.fjalekalimi + "', '" +
                        dentist.fotoProfilit + "', ')";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void updateStatement(Dentist dentist)
        {
            if (OpenConnection())
            {
                if (selectStatement(dentist.id).Count == 1)
                {
                    query = "UPDATE dentistet SET " +
                            "emri='" + dentist.emri + "', " +
                            "email='" + dentist.email + "', " +
                            "perdoruesi='" + dentist.perdoruesi + "', " +
                            "fjalekalimi='" + dentist.fjalekalimi + "', " +
                            "foto_profilit='" + dentist.fotoProfilit + "'" + 
                            "WHERE id='"+ dentist.id + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }
        }

        public void deleteStatement(Dentist dentist)
        {
            if (OpenConnection())
            {
                query = "DELETE FROM dentistet WHERE id='" + dentist.id + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public List<Dentist> selectStatement(string id = null, string emri = null, string email = null, string perdoruesi = null)
        {
            if (OpenConnection())
            {
                query = "SELECT * FROM dentistet WHERE 1 ";
                if (id != null)
                    query = query + "AND id='" + id + "'";
                if (emri != null)
                    query = query + "AND emri='" + emri + "'";
                if (email != null)
                    query = query + "AND email='" + email + "'";
                if (perdoruesi != null)
                    query = query + "AND perdoruesi='" + perdoruesi + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                List<Dentist> list = new List<Dentist>();
                while (dataReader.Read())
                {
                    Dentist d = new Dentist();
                    d.id = dataReader["id"].ToString();
                    d.emri = dataReader["emri"].ToString();
                    d.email = dataReader["email"].ToString();
                    d.perdoruesi = dataReader["perdoruesi"].ToString();
                    d.fjalekalimi = dataReader["fjalekalimi"].ToString();
                    d.fotoProfilit = System.Text.Encoding.UTF8.GetBytes(dataReader["foto_profilit"].ToString());
                    list.Add(d);
                }
                dataReader.Close();
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                return list;
            }
            return null;
        }
    }
}
