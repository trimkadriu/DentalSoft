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
    public class ReportsRepository : DBConnection
    {
        private const string tableName = "raportet";
        private Utilities utilities;

        public ReportsRepository()
        {
            utilities = new Utilities();
        }

        public void insertStatement(Report report)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO " + tableName + " (id, dentisti, takimi, takimi_ardhshem, pagesa, perserit_kontrollin) VALUES (" +
                               "@Id, @Dentisti, @Takimi, @TakimiArdhshem, @Pagesa, @PerseritKontrollin)";
                string takimiArdhshem = null;
                if (report.getTakimiArdhshem() != null)
                    takimiArdhshem = report.getTakimiArdhshem();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", report.getId());
                    cmd.Parameters.AddWithValue("@Dentisti", report.getDentistId());
                    cmd.Parameters.AddWithValue("@Takimi", report.getTakimiId());
                    cmd.Parameters.AddWithValue("@TakimiArdhshem", takimiArdhshem);
                    cmd.Parameters.AddWithValue("@Pagesa", report.getPagesa());
                    cmd.Parameters.AddWithValue("@PerseritKontrollin", report.getTakimiArdhshemStatus().ToString());
                    cmd.ExecuteNonQuery();
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
        }

        public void updateStatement(Report report)
        {
            try
            {
                connection.Open();
                string query = "UPDATE " + tableName + " SET takimi_ardhshem=@TakimiArdhshem, pagesa=@Pagesa, perserit_kontrollin=@PerseritKontrollin WHERE id=@Id";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Pagesa", report.getPagesa());
                    cmd.Parameters.AddWithValue("@PerseritKontrollin", report.getTakimiArdhshemStatus().ToString());
                    cmd.Parameters.AddWithValue("@Id", report.getId());
                    if (report.getTakimiArdhshem() == null)
                        cmd.Parameters.AddWithValue("@TakimiArdhshem", null);
                    else
                        cmd.Parameters.AddWithValue("@TakimiArdhshem", report.getTakimiArdhshem());
                    cmd.ExecuteNonQuery();
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
        }

        public void deleteStatement(Report report)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM " + tableName + " WHERE id=@Id";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", report.getId());
                    cmd.ExecuteNonQuery();
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
        }

        public List<Report> selectStatement(string id = null, string dentistId = null, string takimiId = null, string takimiArdhshem = null,
                                            string pagesa = null, string perseritKontrollin = null, bool forDashboard = false)
        {
            List<Report> reportList = new List<Report>();
            try
            {
                connection.Open();
                string query = "SELECT * FROM " + tableName + " WHERE 1 ";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    if (id != null)
                    {
                        cmd.CommandText += "AND id=@Id ";
                        cmd.Parameters.AddWithValue("@Id", id);
                    }
                    if (dentistId != null)
                    {
                        cmd.CommandText += "AND dentisti=@Dentisti ";
                        cmd.Parameters.AddWithValue("@Dentisti", dentistId);
                    }
                    if (takimiId != null)
                    {
                        cmd.CommandText += "AND takimi=@Takimi ";
                        cmd.Parameters.AddWithValue("@Takimi", takimiId);
                    }
                    if (takimiArdhshem != null)
                    {
                        cmd.CommandText += "AND takimi_ardhshem=@TakimiArdhshem ";
                        cmd.Parameters.AddWithValue("@TakimiArdhshem", takimiArdhshem);
                    }
                    if (pagesa != null)
                    {
                        cmd.CommandText += "AND pagesa=@Pagesa ";
                        cmd.Parameters.AddWithValue("@Pagesa", pagesa);
                    }
                    if (perseritKontrollin != null)
                    {
                        cmd.CommandText += "AND perserit_kontrollin=@PerseritKontrollin ";
                        cmd.Parameters.AddWithValue("@PerseritKontrollin", perseritKontrollin);
                    }
                    if (forDashboard)
                    {
                        DateTime today = DateTime.Now;
                        DateTime startOfToday = today.Date;
                        DateTime endOfToday = startOfToday.AddDays(1).AddTicks(-1);
                        cmd.CommandText += "AND data_krijimit between @StartOfToday AND @EndOfToday";
                        cmd.Parameters.AddWithValue("@StartOfToday", utilities.convertDateForDB(startOfToday));
                        cmd.Parameters.AddWithValue("@EndOfToday", utilities.convertDateForDB(endOfToday));
                    }
                    using(MySqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Report r = new Report();
                            r.setId(dataReader.GetString("id"));
                            r.setDentistId(dataReader.GetString("dentisti"));
                            r.setTakimiId(dataReader.GetString("takimi"));
                            if(string.IsNullOrEmpty(dataReader["takimi_ardhshem"].ToString()))
                                r.setTakimiArdhshem(null);
                            else
                                r.setTakimiArdhshem(dataReader["takimi_ardhshem"].ToString());
                            r.setPagesa(decimal.Parse(dataReader.GetString("pagesa")));
                            r.setTakimiArdhshemStatus(dataReader.GetString("perserit_kontrollin"));
                            r.setDataKrijimit(utilities.convertDateFromDb(dataReader["data_krijimit"].ToString()));
                            reportList.Add(r);
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
            return reportList;
        }

        public string selectSumPagesat(Dentist dentist)
        {
            string sumPagesat = "0.00";
            try
            {
                connection.Open();
                string query = "SELECT SUM(`pagesa`) AS pagesat_total FROM " + tableName + " " +
                               "WHERE dentisti = @Dentist AND data_krijimit between @StartOfToday AND @EndOfToday";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    DateTime today = DateTime.Now;
                    DateTime startOfToday = today.Date;
                    DateTime endOfToday = startOfToday.AddDays(1).AddTicks(-1);

                    cmd.Parameters.AddWithValue("@Dentist", dentist.getId());
                    cmd.Parameters.AddWithValue("@StartOfToday", utilities.convertDateForDB(startOfToday));
                    cmd.Parameters.AddWithValue("@EndOfToday", utilities.convertDateForDB(endOfToday));

                    using(MySqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            if (!string.IsNullOrEmpty((dataReader["pagesat_total"].ToString())))
                                sumPagesat = dataReader.GetString("pagesat_total");
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
            return sumPagesat;
        }

        public List<DataColumn> getSchemaTable()
        {
            return getSchemaTable(tableName);
        }
    }
}
