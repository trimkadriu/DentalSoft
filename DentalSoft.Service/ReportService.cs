using DentalSoft.Domain;
using DentalSoft.Repositories;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DentalSoft.Service
{
    public class ReportService
    {
        private ReportsRepository reportsRepository;

        public ReportService()
        {
            reportsRepository = new ReportsRepository();
        }

        public bool editReport(Report report)
        {
            reportsRepository.updateStatement(report);
            return true;
        }

        public bool insertReport(Report report)
        {
            reportsRepository.insertStatement(report);
            return true;
        }

        public void removeReport(Report report)
        {
            reportsRepository.deleteStatement(report);
        }

        public Report getReportById(string id)
        {
            List<Report> reports = reportsRepository.selectStatement(id);
            if (reports.Count == 1)
                return reports[0];
            else
                return null;
        }

        public Report getReportByAppointmentId(string id)
        {
            List<Report> reports = reportsRepository.selectStatement(null, null, id);
            if (reports.Count == 1)
                return reports[0];
            else
                return null;
        }

        public List<Report> getAllReports(Dentist dentist)
        {
            return reportsRepository.selectStatement(null, dentist.getId());
        }

        public List<DataColumn> getSchemaTable()
        {
            return reportsRepository.getSchemaTable();
        }

        public BindingSource getBindingSource(Dentist dentist)
        {
            DataTable dataTable = new DataTable();
            BindingSource bindingSource = new BindingSource();
            List<Report> reports = getAllReports(dentist);
            dataTable.Columns.AddRange(getSchemaTable().ToArray());
            foreach (Report report in reports)
            {
                dataTable.Rows.Add(new object[] 
                {
                    report.getId(), report.getDentistId(), report.getTakimiId(), report.getTakimiArdhshem(), report.getPagesa(), report.getTakimiArdhshemStatus()
                });
            }
            bindingSource.DataSource = dataTable;
            return bindingSource;
        }
    }
}
