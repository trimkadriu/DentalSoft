using Dentalsoft.Repositories;
using DentalSoft.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DentalSoft.Repositories
{
    public class AppointmentsRepository : Connection
    {
        private string query;
        private const string tableName = "takimet";

        public void insertStatement(Appointment appointment)
        {
            if (OpenConnection())
            {
                query = "INSERT INTO " + tableName + " (id, emri_pacientit, mosha, email, telefoni, data_takimit, kohezgjatja_takimit, problemi, komenti) VALUES ('" +
                        appointment.getId() + "', '" +
                        appointment.getEmriPacientit() + "', '" +
                        appointment.getMosha() + "', '" +
                        appointment.getEmail() + "', '" +
                        appointment.getTelefoni() + "', '" +
                        appointment.getDataTakimit() + "', '" +
                        appointment.getKohezgjatjaTakimit() + "', '" +
                        appointment.getProblemi() + "', '" +
                        appointment.getKomenti() + "')";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                query = string.Empty;
            }
        }

        public void updateStatement(Appointment appointment)
        {
            if (OpenConnection())
            {
                if (selectStatement(appointment.getId()).Count == 1)
                {
                    query = "UPDATE " + tableName + " SET " +
                            "emri_pacientit='" + appointment.getEmriPacientit() + "', " +
                            "mosha='" + appointment.getMosha() + "', " +
                            "email='" + appointment.getEmail() + "', " +
                            "telefoni='" + appointment.getTelefoni() + "', " +
                            "data_takimit='" + appointment.getDataTakimit() + "'" +
                            "kohezgjatja_takimit='" + appointment.getKohezgjatjaTakimit() + "'" +
                            "problemi='" + appointment.getProblemi() + "'" +
                            "komenti='" + appointment.getKomenti() + "' " +
                            "WHERE id='" + appointment.getId() + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    query = string.Empty;
                }
            }
        }

        public void deleteStatement(Appointment appointment)
        {
            if (OpenConnection())
            {
                query = "DELETE FROM " + tableName + " WHERE id='" + appointment.getId() + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                query = string.Empty;
            }
        }

        public List<Appointment> selectStatement(string id = null, string emriPacientit = null, string mosha = null, string email = null, string telefoni = null,
                                                 string dataTakimit = null, string kohezgjatjaTakimit = null, string problemi = null, string komenti = null)
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
                if (email != null)
                    query = query + "AND email='" + email + "' ";
                if (telefoni != null)
                    query = query + "AND telefoni='" + telefoni + "' ";
                if (dataTakimit != null)
                    query = query + "AND data_takimit='" + dataTakimit + "' ";
                if (kohezgjatjaTakimit != null)
                    query = query + "AND kohezgjatja_takimit='" + kohezgjatjaTakimit + "' ";
                if (problemi != null)
                    query = query + "AND problemi='" + problemi + "' ";
                if (komenti != null)
                    query = query + "AND komenti='" + komenti + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                List<Appointment> list = new List<Appointment>();
                while (dataReader.Read())
                {
                    Appointment a = new Appointment();
                    a.setId(dataReader["id"].ToString());
                    a.setEmriPacientit(dataReader["emri_pacientit"].ToString());
                    a.setMosha(int.Parse(dataReader["mosha"].ToString()));
                    a.setEmail(dataReader["email"].ToString());
                    a.setTelefoni(dataReader["telefoni"].ToString());
                    a.setDataTakimit(DateTime.Parse(dataReader["data_takimit"].ToString()));
                    a.setKohezgjatjaTakimit(int.Parse(dataReader["kohezgjatja_takimit"].ToString()));
                    a.setProblemi(dataReader["problemi"].ToString());
                    a.setKomenti(dataReader["komenti"].ToString());
                    list.Add(a);
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
