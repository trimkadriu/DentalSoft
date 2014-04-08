using Dentalsoft.Repositories;
using DentalSoft.Domain;
using DentalSoft.Library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DentalSoft.Repositories
{
    public class DentistsRepository : DBConnection
    {
        private const string tableName = "dentistet";
        private Utilities utilities;

        public DentistsRepository()
        {
            utilities = new Utilities();
        }
        
        public void insertStatement(Dentist dentist)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO " + tableName + " (id, emri, email, perdoruesi, fjalekalimi, foto_profilit) VALUES (" +
                               "@Id, @Emri, @Email, @Perdoruesi, @Fjalekalimi, @FotoProfilit)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", dentist.getId());
                    cmd.Parameters.AddWithValue("@Emri", dentist.getEmri());
                    cmd.Parameters.AddWithValue("@Email", dentist.getEmail());
                    cmd.Parameters.AddWithValue("@Perdoruesi", dentist.getPerdoruesi());
                    cmd.Parameters.AddWithValue("@Fjalekalimi", dentist.getFjalekalimi());
                    cmd.Parameters.AddWithValue("@FotoProfilit", utilities.convertProfilePicForDB(dentist.getFotoProfilit()));
                    cmd.ExecuteNonQuery();
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
        }

        public void updateStatement(Dentist dentist)
        {
            try
            {
                connection.Open();
                string query = "UPDATE " + tableName + " SET emri=@Emri, email=@Email, perdoruesi=@Perdoruesi, fjalekalimi=@Fjalekalimi, " +
                               "foto_profilit=@FotoProfilit, qasja_fundit=@QasjaFundit WHERE id=@Id";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", dentist.getId());
                    cmd.Parameters.AddWithValue("@Emri", dentist.getEmri());
                    cmd.Parameters.AddWithValue("@Email", dentist.getEmail());
                    cmd.Parameters.AddWithValue("@Perdoruesi", dentist.getPerdoruesi());
                    cmd.Parameters.AddWithValue("@Fjalekalimi", dentist.getFjalekalimi());
                    cmd.Parameters.AddWithValue("@FotoProfilit", utilities.convertProfilePicForDB(dentist.getFotoProfilit()));
                    cmd.Parameters.AddWithValue("@QasjaFundit", utilities.convertDateForDB(dentist.getQasjaFundit()));
                    cmd.ExecuteNonQuery();
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
        }

        public void deleteStatement(Dentist dentist)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM " + tableName + " WHERE id=@Id";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", dentist.getId());
                    cmd.ExecuteNonQuery();
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
        }

        public List<Dentist> selectStatement(string id = null, string emri = null, string email = null, string perdoruesi = null, string fjalekalimi = null, 
                                            int limit = 0, string forDashboard = null)
        {
            List<Dentist> dentistList = new List<Dentist>();
            try
            {
                connection.Open();
                string query = "SELECT id, emri, email, perdoruesi, fjalekalimi, foto_profilit, datetime(qasja_fundit) as qasja_fundit FROM " + tableName + " WHERE 1 ";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    if (id != null)
                    {
                        cmd.CommandText += "AND id=@Id ";
                        cmd.Parameters.AddWithValue("@Id", id);
                    }
                    if (emri != null)
                    {
                        cmd.CommandText += "AND emri=@Emri ";
                        cmd.Parameters.AddWithValue("@Emri", emri);
                    }
                    if (email != null)
                    {
                        cmd.CommandText += "AND email=@Email ";
                        cmd.Parameters.AddWithValue("@Email", email);
                    }
                    if (perdoruesi != null)
                    {
                        cmd.CommandText += "AND perdoruesi=@Perdoruesi ";
                        cmd.Parameters.AddWithValue("@Perdoruesi", perdoruesi);
                    }
                    if (fjalekalimi != null)
                    {
                        cmd.CommandText += "AND fjalekalimi=@Fjalekalimi ";
                        cmd.Parameters.AddWithValue("@Fjalekalimi", fjalekalimi);
                    }
                    if (forDashboard != null)
                    {
                        cmd.CommandText += "AND qasja_fundit IS NOT NULL ORDER BY " + forDashboard + " ";
                    }
                    if (limit != 0)
                    {
                        cmd.CommandText += "LIMIT " + limit;
                    }
                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Dentist d = new Dentist();
                            d.setId(dataReader["id"].ToString());
                            d.setEmri(dataReader["emri"].ToString());
                            d.setEmail(dataReader["email"].ToString());
                            d.setPerdoruesi(dataReader["perdoruesi"].ToString());
                            d.setFjalekalimi(dataReader["fjalekalimi"].ToString());
                            string sa = dataReader["foto_profilit"].ToString();
                            if (!string.IsNullOrEmpty(dataReader["foto_profilit"].ToString()))
                                d.setFotoProfilit(utilities.convertProfilePicFromDB(dataReader["foto_profilit"].ToString()));
                            else
                                d.setFotoProfilit(null);
                            d.setQasjaFundit(utilities.convertDateFromDb(dataReader["qasja_fundit"].ToString()));
                            dentistList.Add(d);
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
            return dentistList;
        }

        public List<DataColumn> getSchemaTable()
        {
            return getSchemaTable(tableName);
        }
    }
}
