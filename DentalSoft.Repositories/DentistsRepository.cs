using Dentalsoft.Repositories;
using DentalSoft.Domain;
using DentalSoft.Library;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DentalSoft.Repositories
{
    public class DentistsRepository : DBConnection
    {
        private const string tableName = "`dentistet`";
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
                               "'@Id', '@Emri', '@Email', '@Perdoruesi', '@Fjalekalimi', '@FotoProfilit')";
                using (MySqlCommand cmd = new MySqlCommand (query, connection))
                {
                    cmd.Parameters.AddWithValue("Id", dentist.getId());
                    cmd.Parameters.AddWithValue("Emri", dentist.getEmri());
                    cmd.Parameters.AddWithValue("Email", dentist.getEmail());
                    cmd.Parameters.AddWithValue("Perdoruesi", dentist.getPerdoruesi());
                    cmd.Parameters.AddWithValue("Fjalekalimi", dentist.getFjalekalimi());
                    cmd.Parameters.AddWithValue("FotoProfilit", utilities.convertProfilePicForDB(dentist.getFotoProfilit()));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException MySqlEx)
            {
                MessageBox.Show("MySQL numri i gabimit: " + MySqlEx.Number, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public void updateStatement(Dentist dentist)
        {
            try
            {
                connection.Open();
                string query = "UPDATE " + tableName + " SET `emri`='@Emri', `email`='@Email', `perdoruesi`='@Perdoruesi', `fjalekalimi`='@Fjalekalimi', " +
                               "`foto_profilit`='@FotoProfilit', `qasja_fundit`='@QasjaFundit' WHERE `id`='@Id'";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
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
            catch (MySqlException MySqlEx)
            {
                MessageBox.Show("MySQL numri i gabimit: " + MySqlEx.Number, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public void deleteStatement(Dentist dentist)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM " + tableName + " WHERE `id`='@Id'";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", dentist.getId());
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException MySqlEx)
            {
                MessageBox.Show("MySQL numri i gabimit: " + MySqlEx.Number, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public List<Dentist> selectStatement(string id = null, string emri = null, string email = null, string perdoruesi = null, string fjalekalimi = null, 
                                            int limit = 0, string order = null)
        {
            List<Dentist> dentistList = new List<Dentist>();
            try
            {
                connection.Open();
                string query = "SELECT * FROM " + tableName + " WHERE 1 ";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    if (id != null)
                    {
                        cmd.CommandText += "AND `id`='@Id' ";
                        cmd.Parameters.AddWithValue("@Id", id);
                    }
                    if (emri != null)
                    {
                        cmd.CommandText += "AND `emri`='@Emri' ";
                        cmd.Parameters.AddWithValue("@Emri", emri);
                    }
                    if (email != null)
                    {
                        cmd.CommandText += "AND `email`='@Email' ";
                        cmd.Parameters.AddWithValue("@Email", email);
                    }
                    if (perdoruesi != null)
                    {
                        cmd.CommandText += "AND `perdoruesi`='@Perdoruesi' ";
                        cmd.Parameters.AddWithValue("@Perdoruesi", perdoruesi);
                    }
                    if (fjalekalimi != null)
                    {
                        cmd.CommandText += "AND `fjalekalimi`='@Fjalekalimi' ";
                        cmd.Parameters.AddWithValue("@Fjalekalimi", fjalekalimi);
                    }
                    if (order != null)
                    {
                        cmd.CommandText += "ORDER BY @Order ";
                        cmd.Parameters.AddWithValue("@Order", order);
                    }
                    if (limit != 0)
                    {
                        cmd.CommandText += "LIMIT @Limit";
                        cmd.Parameters.AddWithValue("@Limit", limit);
                    }
                    using (MySqlDataReader dataReader = cmd.ExecuteReader())
                    {
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
                            dentistList.Add(d);
                        }
                    }
                }
            }
            catch (MySqlException MySqlEx)
            {
                MessageBox.Show("MySQL numri i gabimit: " + MySqlEx.Number, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Dispose();
            }
            return dentistList;
        }

        public List<DataColumn> getSchemaTable()
        {
            return getSchemaTable(tableName);
        }
    }
}
