using Dentalsoft.Repositories;
using DentalSoft.Domain;
using DentalSoft.Library;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DentalSoft.Repositories
{
    public class DentistsRepository : Connection
    {
        private string query;
        private const string tableName = "dentistet";
        
        public void insertStatement(Dentist dentist)
        {
            if (OpenConnection())
            {
                query = "INSERT INTO " + tableName + " (id, emri, email, perdoruesi, fjalekalimi, foto_profilit) VALUES ('" +
                        dentist.getId() + "', '" +
                        dentist.getEmri() + "', '" +
                        dentist.getEmail() + "', '" +
                        dentist.getPerdoruesi() + "', '" +
                        dentist.getFjalekalimi() + "', '" +
                        dentist.getFotoProfilit() + "')";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                query = string.Empty;
            }
        }

        public void updateStatement(Dentist dentist)
        {
            if (OpenConnection())
            {
                Encryptor encryptor = new Encryptor();
                Utilities utilities = new Utilities();
                query = "UPDATE " + tableName + " SET " +
                        "emri='" + dentist.getEmri() + "', " +
                        "email='" + dentist.getEmail() + "', " +
                        "perdoruesi='" + dentist.getPerdoruesi() + "', " +
                        "fjalekalimi='" + encryptor.encryptMd5(dentist.getFjalekalimi()) + "', " +
                        "foto_profilit=" + utilities.convertProfilePicForDB(dentist.getFotoProfilit()) + ", " +
                        "qasja_fundit='" + utilities.convertDateForDB(dentist.getQasjaFundit()) + "' " +
                        "WHERE id='" + dentist.getId() + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                query = string.Empty;
            }
        }

        public void deleteStatement(Dentist dentist)
        {
            if (OpenConnection())
            {
                query = "DELETE FROM " + tableName + " WHERE id='" + dentist.getId() + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                query = string.Empty;
            }
        }

        public List<Dentist> selectStatement(string id = null, string emri = null, string email = null, string perdoruesi = null, string fjalekalimi = null)
        {
            if (OpenConnection())
            {
                query = "SELECT * FROM " + tableName + " WHERE 1 ";
                if (id != null)
                    query = query + "AND id='" + id + "' ";
                if (emri != null)
                    query = query + "AND emri='" + emri + "' ";
                if (email != null)
                    query = query + "AND email='" + email + "' ";
                if (perdoruesi != null)
                    query = query + "AND perdoruesi='" + perdoruesi + "'";
                if (fjalekalimi != null)
                    query = query + "AND fjalekalimi='" + fjalekalimi + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                List<Dentist> list = new List<Dentist>();
                while (dataReader.Read())
                {
                    Dentist d = new Dentist();
                    d.setId(dataReader["id"].ToString());
                    d.setEmri(dataReader["emri"].ToString());
                    d.setEmail(dataReader["email"].ToString());
                    d.setPerdoruesi(dataReader["perdoruesi"].ToString());
                    d.setFjalekalimi(dataReader["fjalekalimi"].ToString());
                    string fotoProfilit = dataReader["foto_profilit"].ToString();
                    if (string.IsNullOrEmpty(fotoProfilit))
                        d.setFotoProfilit(null);
                    else
                        d.setFotoProfilit(System.Text.Encoding.UTF8.GetBytes(fotoProfilit));
                    string qasjaFundit = dataReader["qasja_fundit"].ToString();
                    if (string.IsNullOrEmpty(qasjaFundit))
                        d.setQasjaFundit(DateTime.Now);
                    else
                        d.setQasjaFundit(DateTime.Parse(dataReader["qasja_fundit"].ToString()));
                    list.Add(d);
                }
                dataReader.Close();
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                query = string.Empty;
                return list;
            }
            return null;
        }
    }
}
