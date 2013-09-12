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

        public bool editDentist(Dentist dentist)
        {
            
            return true;
        }

        public bool insertDentist(Dentist dentist)
        {
            
            return true;
        }

        public void removeDentist(Dentist dentist)
        {

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