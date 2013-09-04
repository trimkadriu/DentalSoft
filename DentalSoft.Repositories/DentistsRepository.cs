using Dentalsoft.Repositories;
using DentalSoft.Domain;
using DentalSoft.Library;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DentalSoft.Repositories
{
    public class DentistsRepository : Connection
    {
        private string query;
        private const string tableName = "dentistet";
        private Utilities utilities;
        MySqlCommand cmd;

        public DentistsRepository()
        {
            utilities = new Utilities();
        }
        
        public void insertStatement(Dentist dentist)
        {
            if (OpenConnection())
            {
                query = "INSERT INTO " + tableName + " (id, emri, email, perdoruesi, fjalekalimi, foto_profilit) VALUES ('" +
                        dentist.getId() + "', '" +
                        dentist.getEmri() + "', '" +
                        dentist.getEmail() + "', '" +
                        dentist.getPerdoruesi() + "', '" +
                        dentist.getFjalekalimi() + "', " +
                        utilities.convertProfilePicForDB(dentist.getFotoProfilit()) + ")";
                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                clean();
            }
        }

        public void updateStatement(Dentist dentist)
        {
            if (OpenConnection())
            {
                query = "UPDATE " + tableName + " SET " +
                        "emri='" + dentist.getEmri() + "', " +
                        "email='" + dentist.getEmail() + "', " +
                        "perdoruesi='" + dentist.getPerdoruesi() + "', " +
                        "fjalekalimi='" + dentist.getFjalekalimi() + "', " +
                        "foto_profilit=" + utilities.convertProfilePicForDB(dentist.getFotoProfilit()) + ", " +
                        "qasja_fundit='" + utilities.convertDateForDB(dentist.getQasjaFundit()) + "' " +
                        "WHERE id='" + dentist.getId() + "'";
                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                clean();
            }
        }

        public void deleteStatement(Dentist dentist)
        {
            if (OpenConnection())
            {
                query = "DELETE FROM " + tableName + " WHERE id='" + dentist.getId() + "'";
                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                clean();
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
                cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                List<Dentist> list = new List<Dentist>();
                while (dataReader.Read())
                {
                    Dentist d = new Dentist();
                    d.setId(dataReader.GetString("id"));
                    d.setEmri(dataReader.GetString("emri"));
                    d.setEmail(dataReader.GetString("email"));
                    d.setPerdoruesi(dataReader.GetString("perdoruesi"));
                    d.setFjalekalimi(dataReader.GetString("fjalekalimi"));
                    if (!string.IsNullOrEmpty(dataReader["foto_profilit"].ToString()))
                        d.setFotoProfilit(utilities.convertProfilePicFromDB(dataReader.GetString("foto_profilit")));
                    else
                        d.setFotoProfilit(null);
                    d.setQasjaFundit(utilities.convertDateFromDb(dataReader["qasja_fundit"].ToString()));
                    list.Add(d);dataReader.GetSchemaTable
                }
                dataReader.Close();
                clean();
                return list;
            }
            return null;
        }

        public DataColumn getSchemaTable()
        {
            query = "SELECT columns FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '" + this.database + "' AND TABLE_NAME = '" + tableName + "'";
            cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            List<DataColumn> columns = new List<DataColumn>();
            while (dataReader.Read())
            {
                columns.Add(dataReader.GetString("columns"));
            }
            return columns;
        }

        private void clean()
        {
            cmd.Dispose();
            this.CloseConnection();
            query = string.Empty;
        }
    }
}
