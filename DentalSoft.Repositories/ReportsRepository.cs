using Dentalsoft.Repositories;
using DentalSoft.Domain;
using DentalSoft.Domain.Enums;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DentalSoft.Repositories
{
    public class ReportsRepository : Connection
    {
        private string query;
        private const string tableName = "raportet";

        public void insertStatement(Report report)
        {
            if (OpenConnection())
            {
                query = "INSERT INTO " + tableName + " (id, emri_pacientit, mosha, gjinia, problemi, pagesa, perserit_kontrollin) VALUES ('" +
                        report.getId() + "', '" +
                        report.getEmriPacientit() + "', '" +
                        report.getMosha() + "', '" +
                        report.getGjinia() + "', '" +
                        report.getProblemi() + "', '" +
                        report.getPagesa() + "', '" +
                        report.getPerseritKontrollin() + "')";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                query = string.Empty;
            }
        }

        public void updateStatement(Report report)
        {
            if (OpenConnection())
            {
                if (selectStatement(report.getId()).Count == 1)
                {
                    query = "UPDATE " + tableName + " SET " +
                            "emri_pacientit='" + report.getEmriPacientit() + "', " +
                            "mosha='" + report.getMosha() + "', " +
                            "gjinia='" + report.getGjinia() + "', " +
                            "problemi='" + report.getProblemi() + "', " +
                            "pagesa='" + report.getPagesa() + "'" +
                            "perserit_kontrollin='" + report.getPerseritKontrollin() + "' " +
                            "WHERE id='" + report.getId() + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    query = string.Empty;
                }
            }
        }

        public void deleteStatement(Report report)
        {
            if (OpenConnection())
            {
                query = "DELETE FROM " + tableName + " WHERE id='" + report.getId() + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                query = string.Empty;
            }
        }

        public List<Report> selectStatement(string id = null, string emriPacientit = null, string mosha = null, string gjinia = null, string problemi = null,
                                                 string pagesa = null, string perseritKontrollin = null)
        {
            if (OpenConnection())
            {
                query = "SELECT * FROM " + tableName + " WHERE 1 ";
                if (id != null)
                    query = query + "AND id='" + id + "' ";
                if (emriPacientit != null)
                    query = query + "AND emri_pacientit='" + emriPacientit + "' ";
                if (mosha != null)
                    query = query + "AND mosha='" + mosha + "' ";
                if (gjinia != null)
                    query = query + "AND gjinia='" + gjinia + "' ";
                if (problemi != null)
                    query = query + "AND problemi='" + problemi + "' ";
                if (pagesa != null)
                    query = query + "AND pagesa='" + pagesa + "' ";
                if (perseritKontrollin != null)
                    query = query + "AND perserit_kontrollin='" + perseritKontrollin + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                List<Report> list = new List<Report>();
                while (dataReader.Read())
                {
                    Report r = new Report();
                    r.setId(dataReader["id"].ToString());
                    r.setEmriPacientit(dataReader["emri_pacientit"].ToString());
                    r.setMosha(int.Parse(dataReader["mosha"].ToString()));
                    r.setGjinia((Gender)Enum.Parse(typeof(Gender), dataReader["gjinia"].ToString()));
                    r.setProblemi(dataReader["problemi"].ToString());
                    r.setPagesa(int.Parse(dataReader["pagesa"].ToString()));
                    r.setPerseritKontrollin((Status)Enum.Parse(typeof(Status), dataReader["perserit_kontrollin"].ToString()));
                    list.Add(r);
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
