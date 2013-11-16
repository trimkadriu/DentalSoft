using DentalSoft.Domain;
using DentalSoft.Domain.Enums;
using DentalSoft.Service;
using System;
using System.Windows.Forms;

namespace DentalSoft
{
    public partial class frmGenerateReport : Form
    {
        private Report report;
        private Appointment appointment;
        private Appointment nextAppointment;
        private AppointmentService appointmentService;
        private ReportService reportService;

        public frmGenerateReport(Appointment appointment, Report report = null)
        {
            InitializeComponent();
            this.appointment = appointment;
            this.report = report;
            appointmentService = new AppointmentService();
            reportService = new ReportService();
            Init();
        }

        private void Init()
        {
            if (isEditingReport())
            {
                this.Text = "Ndrysho raport";
                btnGjeneroRaport.Text = "Ruaj ndryshimet";
                nudPagesa.Value = report.getPagesa();
                cmbTakimiTjeterStatus.SelectedItem = report.getTakimiArdhshemStatus();
                if (report.getTakimiArdhshemStatus().Equals(TakimiRiStatus.Po))
                {
                    nextAppointment = appointmentService.getAppointmentById(report.getTakimiArdhshem());
                    dtpDataETakimitTjeter.Value = nextAppointment.getDataTakimit();
                    dtpDataETakimitTjeter.MinDate = dtpDataETakimitTjeter.Value;
                    nudKohezgjatja.Value = nextAppointment.getKohezgjatjaTakimit();
                    txtProblemi.Text = nextAppointment.getProblemi();
                    llogaritMinutatNeOre();
                }
            }
            else
            {
                cmbTakimiTjeterStatus.SelectedItem = TakimiRiStatus.Pacaktuar;
                dtpDataETakimitTjeter.MinDate = DateTime.Now;
            }
            dtpDataETakimitTjeter.MaxDate = DateTime.Now.AddYears(1);
            showHideAppointmentFields();
        }

        private bool isEditingReport()
        {
            if (report == null)
                return false;
            return true;
        }

        private void cmbTakimiTjeterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            showHideAppointmentFields();
        }

        private void showHideAppointmentFields()
        {
            if (cmbTakimiTjeterStatus.SelectedItem.Equals(TakimiRiStatus.Po))
            {
                lblKohaETakimit.Visible = true;
                lblKohezgjatjaETakimit.Visible = true;
                lblMin.Visible = true;
                lblProblemi.Visible = true;
                dtpDataETakimitTjeter.Visible = true;
                nudKohezgjatja.Visible = true;
                txtProblemi.Visible = true;
                txtOret.Visible = true;
                btnGjeneroRaport.Top = 239;
                btnAnulo.Top = 239;
            }
            else
            {
                lblKohaETakimit.Visible = false;
                lblKohezgjatjaETakimit.Visible = false;
                lblMin.Visible = false;
                lblProblemi.Visible = false;
                dtpDataETakimitTjeter.Visible = false;
                nudKohezgjatja.Visible = false;
                txtProblemi.Visible = false;
                txtOret.Visible = false;
                btnGjeneroRaport.Top = 90;
                btnAnulo.Top = 90;
            }
        }

        private void btnGjeneroRaport_Click(object sender, EventArgs e)
        {
            if (validoReportForm())
            {
                if (isEditingReport())
                {
                    report.setPagesa(decimal.Parse(nudPagesa.Text));
                    report.setTakimiArdhshemStatus(getTakimiStatusFromComboBox(cmbTakimiTjeterStatus));
                    //report.setTakimiId(appointment.getId());
                    nextAppointment = appointmentService.getAppointmentById(report.getTakimiArdhshem());
                    if (cmbTakimiTjeterStatus.SelectedItem.Equals(TakimiRiStatus.Po))
                    {
                        if (nextAppointment == null)
                        {
                            nextAppointment = new Appointment(null, appointment.getDentistId(), appointment.getEmriPacientit(),
                                                              appointment.getMosha(), appointment.getEmail(), appointment.getTelefoni(), dtpDataETakimitTjeter.Value,
                                                              int.Parse(nudKohezgjatja.Text), txtProblemi.Text, appointment.getKomenti());
                            report.setTakimiArdhshem(nextAppointment.getId());
                            appointmentService.insertAppointment(nextAppointment);
                        }
                        else
                        {
                            nextAppointment.setDataTakimit(dtpDataETakimitTjeter.Value);
                            nextAppointment.setKohezgjatjaTakimit(int.Parse(nudKohezgjatja.Text));
                            nextAppointment.setProblemi(txtProblemi.Text);
                            appointmentService.editAppointment(nextAppointment);
                        }
                    }
                    else
                        if (nextAppointment != null)
                        {
                            appointmentService.removeAppointment(nextAppointment);
                            report.setTakimiArdhshem(null);
                        }
                    reportService.editReport(report);
                }
                else
                {
                    if (cmbTakimiTjeterStatus.SelectedItem.Equals(TakimiRiStatus.Po))
                    {
                        nextAppointment = new Appointment(null, appointment.getDentistId(), appointment.getEmriPacientit(),
                                                          appointment.getMosha(), appointment.getEmail(), appointment.getTelefoni(), dtpDataETakimitTjeter.Value,
                                                          int.Parse(nudKohezgjatja.Text), txtProblemi.Text, appointment.getKomenti());
                        appointmentService.insertAppointment(nextAppointment);
                        report = new Report(null, frmMain.loggedInDentist.getId(), appointment.getId(), nextAppointment.getId(), decimal.Parse(nudPagesa.Text),
                                            getTakimiStatusFromComboBox(cmbTakimiTjeterStatus));
                    }
                    else
                        report = new Report(null, frmMain.loggedInDentist.getId(), appointment.getId(), null, decimal.Parse(nudPagesa.Text), 
                                            getTakimiStatusFromComboBox(cmbTakimiTjeterStatus));
                    reportService.insertReport(report);
                }
            }
        }

        private bool validoReportForm()
        {
            if (string.IsNullOrWhiteSpace(nudPagesa.Text))
            {
                nudPagesa.Focus();
                return false;
            }
            if (cmbTakimiTjeterStatus.SelectedItem.Equals(TakimiRiStatus.Po))
            {
                if (string.IsNullOrWhiteSpace(dtpDataETakimitTjeter.Text))
                {
                    dtpDataETakimitTjeter.Focus();
                    return false;
                }
                if (string.IsNullOrWhiteSpace(nudKohezgjatja.Text))
                {
                    nudKohezgjatja.Focus();
                    return false;
                }
                if (string.IsNullOrWhiteSpace(txtProblemi.Text))
                {
                    txtProblemi.Focus();
                    return false;
                }
            }
            return true;
        }

        private TakimiRiStatus getTakimiStatusFromComboBox(ComboBox cmb)
        {
            return (TakimiRiStatus)Enum.Parse(typeof(TakimiRiStatus), cmb.SelectedItem.ToString());
        }

        private void nudKohezgjatja_ValueChanged(object sender, EventArgs e)
        {
            llogaritMinutatNeOre();
        }

        private void llogaritMinutatNeOre()
        {
            TimeSpan ts = TimeSpan.FromMinutes(double.Parse(nudKohezgjatja.Text));
            txtOret.Text = ts.ToString();
        }
    }
}
