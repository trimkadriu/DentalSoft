using Dentalsoft.Repositories;
using DentalSoft.Domain;
using DentalSoft.Library;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DentalSoft.Repositories
{
    public class AppointmentsRepository : Connection
    {
        private string query;
        private const string tableName = "takimet";
        private Utilities utilities;
        MySqlCommand cmd;

        public AppointmentsRepository()
        {
            utilities = new Utilities();
        }

        public void insertStatement(Appointment appointment)
        {
            if (OpenConnection())
            {
                query = "INSERT INTO " + tableName + " (id, dentisti, emri_pacientit, mosha, email, telefoni, data_takimit, kohezgjatja_takimit, problemi, komenti) VALUES ('" +
                        appointment.getId() + "', '" +
                        appointment.getDentistId() + "', '" +
                        appointment.getEmriPacientit() + "', '" +
                        appointment.getMosha() + "', '" +
                        appointment.getEmail() + "', '" +
                        appointment.getTelefoni() + "', '" +
                        utilities.convertDateForDB(appointment.getDataTakimit()) + "', '" +
                        appointment.getKohezgjatjaTakimit() + "', '" +
                        appointment.getProblemi() + "', '" +
                        appointment.getKomenti() + "')";
                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                clean();
            }
        }

        public void updateStatement(Appointment appointment)
        {
            if (OpenConnection())
            {
                query = "UPDATE " + tableName + " SET " +
                        "emri_pacientit='" + appointment.getEmriPacientit() + "', " +
                        "mosha='" + appointment.getMosha() + "', " +
                        "email='" + appointment.getEmail() + "', " +
                        "telefoni='" + appointment.getTelefoni() + "', " +
                        "data_takimit='" + utilities.convertDateForDB(appointment.getDataTakimit()) + "', " +
                        "kohezgjatja_takimit='" + appointment.getKohezgjatjaTakimit() + "', " +
                        "problemi='" + appointment.getProblemi() + "', " +
                        "komenti='" + appointment.getKomenti() + "' " +
                        "WHERE id='" + appointment.getId() + "'";
                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                clean();
            }
        }

        public void deleteStatement(Appointment appointment)
        {
            if (OpenConnection())
            {
                ReportsRepository reportsRepository = new ReportsRepository();
                List<Report> reportList = reportsRepository.selectStatement(null, null, null, appointment.getId());
                if (reportList.Count == 1)
                {
                    reportList[0].setTakimiArdhshem(null);
                    reportList[0].setTakimiArdhshemStatus(Domain.Enums.TakimiRiStatus.Pacaktuar);
                    reportsRepository.updateStatement(reportList[0]);
                }
                query = "DELETE FROM " + tableName + " WHERE id='" + appointment.getId() + "'";
                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                clean();
            }
        }

        public List<Appointment> selectStatement(string id = null, string dentistId = null, string emriPacientit = null, int mosha = 0, string email = null, string telefoni = null,
                                                 DateTime? dataTakimit = null, int kohezgjatjaTakimit = 0, string problemi = null, string komenti = null, bool forDashboard = false)
        {
            if (OpenConnection())
            {
                query = "SELECT * FROM " + tableName + " WHERE 1 ";
                if (id != null)
                    query = query + "AND id='" + id + "' ";
                if (dentistId != null)
                    query = query + "AND dentisti='" + dentistId + "' ";
                if (emriPacientit != null)
                    query = query + "AND emri_pacientit='" + emriPacientit + "' ";
                if (mosha != 0)
                    query = query + "AND mosha='" + mosha + "' ";
                if (email != null)
                    query = query + "AND email='" + email + "' ";
                if (telefoni != null)
                    query = query + "AND telefoni='" + telefoni + "' ";
                if (dataTakimit.HasValue)
                    query = query + "AND data_takimit='" + utilities.convertDateForDB(dataTakimit.Value) + "' ";
                if (kohezgjatjaTakimit != 0)
                    query = query + "AND kohezgjatja_takimit='" + kohezgjatjaTakimit + "' ";
                if (problemi != null)
                    query = query + "AND problemi='" + problemi + "' ";
                if (komenti != null)
                    query = query + "AND komenti='" + komenti + "' ";
                if (forDashboard) {
                    DateTime today = DateTime.Now; 
                    DateTime startOfToday = today.Date; 
                    DateTime endOfToday = startOfToday.AddDays(1).AddTicks(-1);
                    query = query + "AND `data_takimit` between '" + utilities.convertDateForDB(startOfToday) + "' AND '" + utilities.convertDateForDB(endOfToday) + "'";
                }
                cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                List<Appointment> list = new List<Appointment>();
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
                    list.Add(a);
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
