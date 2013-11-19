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
            rtbRaport.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033\\deflangfe1033{\\fonttbl{\\f0\\fnil\\fcharset0 Times New Roman;}}" +
                            "{\\*\\generator Msftedit 5.41.21.2509;}\\viewkind4\\uc1\\pard\\nowidctlpar\\sa200\\qc\\lang9\\f0\\fs72 RAPORT\\par" +
                            "\\fs24\\line\\par" +
                            "\\pard\\nowidctlpar\\sa200\\sl276\\slmult1\\b\\fs28 P\\lang1033\\'ebrserit Kontrollin\\lang9 :\\tab\\b0 PO\\tab       \\b Takimi i ardhshem: \\b0 2013-11-18 22:26\\par" +
                            "\\pard\\nowidctlpar\\sa200\\sl276\\slmult1\\qc\\lang1033\\b\\fs22 ________________________________________________________________________\\line\\b0\\fs28\\par" +
                            "\\pard\\nowidctlpar\\sa200\\b Emri pacientit\\lang9 :\\tab\\tab\\lang1033\\b0 Sadudin Bushi\\tab\\tab\\b Mosha:\\tab\\b0 20\\lang9\\fs22\\par" +
                            "\\b\\fs28 Email:\\tab\\tab\\tab\\b0 sadudin_bushi@hotmail.com\\par" +
                            "\\b Telefoni:\\tab\\tab\\tab\\b0 (044) 123-789\\par" +
                            "\\b Data e takimit:\\tab\\tab\\b0 2013-11-05 00:50\\par" +
                            "\\b Kohezgjatja e takimit:\\tab\\b0 10 (min)\\par" +
                            "\\ul\\b Problemi:\\ulnone\\b0\\par" +
                            "Heqje te dhembeve te fundit 28, 29, 30. Modelimi i protezave fikse.\\par" +
                            "\\ul\\b Komenti:\\ulnone\\b0\\par" +
                            "Nuk ka koment.\\par" +
                            "\\pard\\nowidctlpar\\sa200\\qc\\lang1033\\b\\fs22 ________________________________________________________________________\\par" +
                            "\\pard\\nowidctlpar\\sa200\\fs28\\par" +
                            "\\lang9 Dentist:\\tab\\b0 Trim Kadriu\\lang1033\\b\\par" +
                            "Kontakt:\\tab\\lang9\\b0 trim.kadriu@hotmail.com\\lang1033\\b\\par" +
                            "Pagesa:\\tab\\b0 250 \\'80\\par" +
                            "\\b Data:\\tab\\tab\\lang9\\b0 2013-11-05 00:50\\par" +
                            "\\lang1033\\line\\pard\\nowidctlpar\\sa200\\qr ____________________________\\line\\fs22 Nenshkrimi dhe vula\\tab\\tab\\par" +
                            "}";
            rtbRaport.ZoomFactor = 0.80f;
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
