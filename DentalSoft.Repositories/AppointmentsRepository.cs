using Dentalsoft.Repositories;
using DentalSoft.Domain;
using DentalSoft.Library;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DentalSoft.Repositories
{
    public class AppointmentsRepository : DBConnection
    {
        private const string tableName = "`takimet`";
        private Utilities utilities;

        public AppointmentsRepository()
        {
            utilities = new Utilities();
        }

        public void insertStatement(Appointment appointment)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO " + tableName + " (id, dentisti, emri_pacientit, mosha, email, telefoni, data_takimit, " + 
                               "kohezgjatja_takimit, problemi, komenti) VALUES ('@Id', '@Dentisti', '@EmriPacientit', '@Mosha'," +
                               "'@Email', '@Telefoni', '@DataTakimit', '@KohezgjatjaTakimit', '@Problemi', '@Komenti')";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", appointment.getId());
                    cmd.Parameters.AddWithValue("@Dentisti", appointment.getDentistId());
                    cmd.Parameters.AddWithValue("@EmriPacientit", appointment.getEmriPacientit());
                    cmd.Parameters.AddWithValue("@Mosha", appointment.getMosha());
                    cmd.Parameters.AddWithValue("@Email", appointment.getEmail());
                    cmd.Parameters.AddWithValue("@Telefoni", appointment.getTelefoni());
                    cmd.Parameters.AddWithValue("@DataTakimit", utilities.convertDateForDB(appointment.getDataTakimit()));
                    cmd.Parameters.AddWithValue("@KohezgjatjaTakimit", appointment.getKohezgjatjaTakimit());
                    cmd.Parameters.AddWithValue("@Problemi", appointment.getProblemi());
                    cmd.Parameters.AddWithValue("@Komenti", appointment.getKomenti());
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

        public void updateStatement(Appointment appointment)
        {
            try
            {
                connection.Open();
                string query = "UPDATE " + tableName + " SET `emri_pacientit`='@EmriPacientit', `mosha`='@Mosha', `email`='@Email', " +
                               "`telefoni`='@Telefoni', `data_takimit`='@DataTakimit', `kohezgjatja_takimit`='@KohezgjatjaTakimit', " +
                               "`problemi`='@Problemi', `komenti`='@Komenti' WHERE `id`='@Id'";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", appointment.getId());
                    cmd.Parameters.AddWithValue("@EmriPacientit", appointment.getEmriPacientit());
                    cmd.Parameters.AddWithValue("@Mosha", appointment.getMosha());
                    cmd.Parameters.AddWithValue("@Email", appointment.getEmail());
                    cmd.Parameters.AddWithValue("@Telefoni", appointment.getTelefoni());
                    cmd.Parameters.AddWithValue("@DataTakimit", utilities.convertDateForDB(appointment.getDataTakimit()));
                    cmd.Parameters.AddWithValue("@KohezgjatjaTakimit", appointment.getKohezgjatjaTakimit());
                    cmd.Parameters.AddWithValue("@Problemi", appointment.getProblemi());
                    cmd.Parameters.AddWithValue("@Komenti", appointment.getKomenti());
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

        public void deleteStatement(Appointment appointment)
        {
            ReportsRepository reportsRepository = new ReportsRepository();
            List<Report> reportList = reportsRepository.selectStatement(null, null, null, appointment.getId());
            if (reportList.Count == 1)
            {
                reportList[0].setTakimiArdhshem(null);
                reportList[0].setTakimiArdhshemStatus(Domain.Enums.TakimiRiStatus.Pacaktuar);
                reportsRepository.updateStatement(reportList[0]);
            }
            try
            {
                connection.Open();
                string query = "DELETE FROM " + tableName + " WHERE `id`='@Id'";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", appointment.getId());
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

        public List<Appointment> selectStatement(string id = null, string dentistId = null, string emriPacientit = null, int mosha = 0, string email = null, string telefoni = null,
                                                 DateTime? dataTakimit = null, int kohezgjatjaTakimit = 0, string problemi = null, string komenti = null, bool forDashboard = false)
        {
            List<Appointment> appointmentList = new List<Appointment>();
            try
            {
                connection.Open();
                string query = "SELECT * FROM " + tableName + " WHERE 1 ";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    if (id != null)
                    {
                        query += "AND `id`='@Id' ";
                        cmd.Parameters.AddWithValue("@Id", id);
                    }
                    if (dentistId != null) 
                    {
                        query += "AND `dentisti`='@Dentist' ";
                        cmd.Parameters.AddWithValue("@Dentist", dentistId);
                    }
                    if (emriPacientit != null)
                    {
                        query += "AND `emri_pacientit`='@EmriPacientit' ";
                        cmd.Parameters.AddWithValue("@EmriPacientit", emriPacientit);
                    }
                    if (mosha != 0)
                    {
                        query += "AND `mosha`='@Mosha' ";
                        cmd.Parameters.AddWithValue("@Mosha", mosha);
                    }
                    if (email != null)
                    {
                        query += "AND `email`='@Email' ";
                        cmd.Parameters.AddWithValue("@Email", email);
                    }
                    if (telefoni != null)
                    {
                        query += "AND `telefoni`='@Telefoni' ";
                        cmd.Parameters.AddWithValue("@Telefoni", telefoni);
                    }
                    if (dataTakimit.HasValue)
                    {
                        query += "AND `data_takimit`='@DataTakimit' ";
                        cmd.Parameters.AddWithValue("@DataTakimit", utilities.convertDateForDB(dataTakimit.Value));
                    }
                    if (kohezgjatjaTakimit != 0)
                    {
                        query += "AND `kohezgjatja_takimit`='@KohezgjatjaTakimit' ";
                        cmd.Parameters.AddWithValue("@KohezgjatjaTakimit", kohezgjatjaTakimit);
                    }
                    if (problemi != null)
                    {
                        query += "AND `problemi`='@Problemi' ";
                        cmd.Parameters.AddWithValue("@Problemi", problemi);
                    }
                    if (komenti != null)
                    {
                        query += "AND `komenti`='@Komenti' ";
                        cmd.Parameters.AddWithValue("@Komenti", komenti);
                    }
                    if (forDashboard) 
                    {
                        DateTime today = DateTime.Now; 
                        DateTime startOfToday = today.Date; 
                        DateTime endOfToday = startOfToday.AddDays(1).AddTicks(-1);
                        query += "AND `data_takimit` between '@StartOfToday' AND '@EndOfToday'";
                        cmd.Parameters.AddWithValue("@StartOfToday", utilities.convertDateForDB(startOfToday));
                        cmd.Parameters.AddWithValue("@EndOfToday", utilities.convertDateForDB(endOfToday));
                    }
                    using (MySqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Appointment a = new Appointment();
                            a.setId(dataReader.GetString("id"));
                            a.setDentistId(dataReader.GetString("dentisti"));
                            a.setEmriPacientit(dataReader.GetString("emri_pacientit"));
                            a.setMosha(int.Parse(dataReader.GetString("mosha")));
                            a.setEmail(dataReader.GetString("email"));
                            a.setTelefoni(dataReader.GetString("telefoni"));
                            a.setDataTakimit(utilities.convertDateFromDb(dataReader["data_takimit"].ToString()));
                            a.setKohezgjatjaTakimit(int.Parse(dataReader.GetString("kohezgjatja_takimit")));
                            a.setProblemi(dataReader.GetString("problemi"));
                            a.setKomenti(dataReader.GetString("komenti"));
                            appointmentList.Add(a);
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
            return appointmentList;
        }

        public List<DataColumn> getSchemaTable()
        {
            return getSchemaTable(tableName);
        }
    }
}
