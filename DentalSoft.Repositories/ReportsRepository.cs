using Dentalsoft.Repositories;
using DentalSoft.Domain;
using DentalSoft.Domain.Enums;
using DentalSoft.Library;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DentalSoft.Repositories
{
    public class ReportsRepository : Connection
    {
        private string query;
        private const string tableName = "raportet";
        private Utilities utilities;
        private MySqlCommand cmd;

        public ReportsRepository()
        {
            utilities = new Utilities();
        }

        public void insertStatement(Report report)
        {
            if (OpenConnection())
            {
                string takimiArdhshem;
                if (report.getTakimiArdhshem() == null)
                    takimiArdhshem = "NULL";
                else
                    takimiArdhshem = report.getTakimiArdhshem();
                query = "INSERT INTO " + tableName + " (id, dentisti, takimi, takimi_ardhshem, pagesa, perserit_kontrollin) VALUES ('" +
                        report.getId() + "', '" +
                        report.getDentistId() + "', '" +
                        report.getTakimiId() + "', '" +
                        takimiArdhshem + "', '" +
                        report.getPagesa() + "', '" +
                        report.getTakimiArdhshemStatus() + "')";
                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                clean();
            }
        }

        public void updateStatement(Report report)
        {
            if (OpenConnection())
            {
                string takimiArdhshem;
                if(report.getTakimiArdhshem() == null)
                    takimiArdhshem = "takimi_ardhshem=NULL, ";
                else
                    takimiArdhshem = "takimi_ardhshem='" + report.getTakimiArdhshem() + "', ";
                query = "UPDATE " + tableName + " SET " +
                        takimiArdhshem +
                        "pagesa='" + report.getPagesa() + "', " +
                        "perserit_kontrollin='" + report.getTakimiArdhshemStatus() + "' " +
                        "WHERE id='" + report.getId() + "'";
                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                clean();
            }
        }

        public void deleteStatement(Report report)
        {
            if (OpenConnection())
            {
                query = "DELETE FROM " + tableName + " WHERE id='" + report.getId() + "'";
                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                clean();
            }
        }

        public List<Report> selectStatement(string id = null, string dentistId = null, string takimiId = null, string takimiArdhshem = null,
                                            string pagesa = null, string perseritKontrollin = null)
        {
            if (OpenConnection())
            {
                query = "SELECT * FROM " + tableName + " WHERE 1 ";
                if (id != null)
                    query = query + "AND id='" + id + "' ";
                if (dentistId != null)
                    query = query + "AND dentisti='" + dentistId + "' ";
                if (takimiId != null)
                    query = query + "AND takimi='" + takimiId + "' ";
                if (takimiArdhshem != null)
                    query = query + "AND takimi_ardhshem='" + takimiArdhshem + "' ";
                if (pagesa != null)
                    query = query + "AND pagesa='" + pagesa + "' ";
                if (perseritKontrollin != null)
                    query = query + "AND perserit_kontrollin='" + perseritKontrollin + "'";
                cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                List<Report> list = new List<Report>();
                while (dataReader.Read())
                {
                    Report r = new Report();
                    r.setId(dataReader["id"].ToString());
                    r.setDentistId(dataReader["dentisti"].ToString());
                    r.setTakimiId(dataReader["takimi"].ToString());
                    r.setTakimiArdhshem(dataReader["takimi_ardhshem"].ToString());
                    r.setPagesa(decimal.Parse(dataReader["pagesa"].ToString()));
                    r.setTakimiArdhshemStatus(dataReader["perserit_kontrollin"].ToString());
                    list.Add(r);
                }
                dataReader.Close();
                cmd.ExecuteNonQuery();
                clean();
                return list;
            }
            return null;
        }

        public List<DataColumn> getSchemaTable()
        {
            if (OpenConnection())
            {
                query = "SELECT COLUMN_NAME as columns FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '" +
                        this.database + "' AND TABLE_NAME = '" + tableName + "'";
                cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                List<DataColumn> columns = new List<DataColumn>();
                while (dataReader.Read())
                {
                    DataColumn dc = new DataColumn();
                    dc.ColumnName = utilities.toUpperFirstLetter(dataReader.GetString("columns"));
                    columns.Add(dc);
                }
                clean();
                return columns;
            }
            return null;
        }

        private void clean()
        {
            cmd.Dispose();
            this.CloseConnection();
            query = string.Empty;
        }
    }
}
