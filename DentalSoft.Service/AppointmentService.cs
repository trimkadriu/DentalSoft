using DentalSoft.Domain;
using DentalSoft.Library;
using DentalSoft.Repositories;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DentalSoft.Service
{
    public class AppointmentService
    {
        private AppointmentsRepository appointmentsRepository;
        private ValidationUtils validationUtils;

        public AppointmentService()
        {
            appointmentsRepository = new AppointmentsRepository();
            validationUtils = new ValidationUtils();
        }

        public bool editAppointment(Appointment appointment)
        {
            appointmentsRepository.updateStatement(appointment);
            return true;
        }

        public bool insertAppointment(Appointment appointment)
        {
            if (!validationUtils.isValidEmail(appointment.getEmail()))
            {
                MessageBox.Show("Email-i nuk eshte valid. Ju lutem shkruani emailin ne forme te rregullt.", "Gabim!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (appointment.getTelefoni().Length != 13)
            {
                MessageBox.Show("Telefoni nuk eshte valid. Ju lutem shkruani telefonin ne forme te rregullt.", "Gabim!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            appointmentsRepository.insertStatement(appointment);
            return true;
        }

        public void removeDentist(Appointment appointment)
        {

        }

        public Appointment getAppointmentById(string id)
        {
            List<Appointment> appointments = appointmentsRepository.selectStatement(id);
            if (appointments.Count == 1)
                return appointments[0];
            else
                return null;
        }

        public List<Appointment> getAllAppointments()
        {
            return appointmentsRepository.selectStatement();
        }

        public List<DataColumn> getSchemaTable()
        {
            return appointmentsRepository.getSchemaTable();
        }

        public BindingSource getBindingSource()
        {
            DataTable dataTable = new DataTable();
            BindingSource bindingSource = new BindingSource();
            List<Appointment> appointments = getAllAppointments();
            dataTable.Columns.AddRange(getSchemaTable().ToArray());
            foreach (Appointment appointment in appointments)
            {
                dataTable.Rows.Add(new object[] 
                {
                    appointment.getId(), appointment.getEmriPacientit(), appointment.getMosha(), appointment.getEmail(), 
                    appointment.getTelefoni(), appointment.getDataTakimit(), appointment.getKohezgjatjaTakimit().ToString(),
                    appointment.getProblemi(), appointment.getKomenti()
                });
            }
            bindingSource.DataSource = dataTable;
            return bindingSource;
        }
    }
}