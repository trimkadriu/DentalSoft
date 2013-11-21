using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalSoft.Library
{
    public class RtfFactory
    {
        private string template =   "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033\\deflangfe1033{\\fonttbl{\\f0\\fnil\\fcharset0 Times New Roman;}}" +
                                    "{\\*\\generator Msftedit 5.41.21.2509;}\\viewkind4\\uc1\\pard\\nowidctlpar\\sa200\\qc\\lang9\\f0\\fs72 RAPORT\\par" +
                                    "\\fs24\\line\\par" +
                                    "\\pard\\nowidctlpar\\sa200\\sl276\\slmult1\\b\\fs28 P\\lang1033\\'ebrserit Kontrollin\\lang9 :\\tab\\b0 #PERSERIT_KONTROLLIN#\\tab       \\b Takimi i ardhshem: \\b0 #TAKIMI_ARDHSHEM#\\par" +
                                    "\\pard\\nowidctlpar\\sa200\\sl276\\slmult1\\qc\\lang1033\\b\\fs22 ________________________________________________________________________\\line\\b0\\fs28\\par" +
                                    "\\pard\\nowidctlpar\\sa200\\b Emri pacientit\\lang9 :\\tab\\tab\\lang1033\\b0 #EMRI_PACIENTIT#\\tab\\tab\\b Mosha:\\tab\\b0 #MOSHA_PACIENTIT#\\lang9\\fs22\\par" +
                                    "\\b\\fs28 Email:\\tab\\tab\\tab\\b0 #EMAIL_PACIENTIT#\\par" +
                                    "\\b Telefoni:\\tab\\tab\\tab\\b0 #TELEFONI_PACIENTIT#\\par" +
                                    "\\b Data e takimit:\\tab\\tab\\b0 #DATA_TAKIMIT#\\par" +
                                    "\\b Kohezgjatja e takimit:\\tab\\b0 #KOHEZGJATJA_TAKIMIT# (min)\\par" +
                                    "\\ul\\b Problemi:\\ulnone\\b0\\par " +
                                    "#PROBLEMI#\\par" +
                                    "\\ul\\b Komenti:\\ulnone\\b0\\par " +
                                    "#KOMENTI#\\par" +
                                    "\\pard\\nowidctlpar\\sa200\\qc\\lang1033\\b\\fs22 ________________________________________________________________________\\par" +
                                    "\\pard\\nowidctlpar\\sa200\\fs28\\par" +
                                    "\\lang9 Dentist:\\tab\\b0 #DENTISTI#\\lang1033\\b\\par " +
                                    "Kontakt:\\tab\\lang9\\b0 #KONTAKT_DENTISTI#\\lang1033\\b\\par " +
                                    "Pagesa:\\tab\\b0 #PAGESA# \\'80\\par " +
                                    "\\b Data:\\tab\\tab\\lang9\\b0 #DATA_RAPORTIT#\\par" +
                                    "\\lang1033\\line\\pard\\nowidctlpar\\sa200\\qr ____________________________\\line\\fs22 Nenshkrimi dhe vula\\tab\\tab\\par" +
                                    "}";

        public RtfFactory(string perseritKontrollin, string takimiArdshem, string emriPacientit, string mosha, string emailPacientit, string telefoniPacientit,
                          string dataTakimit, string kohezgjatjaTakimit, string problemi, string komenti, string dentisti, string kontaktDentisti,
                          string pagesa, string dataRaportit)
        {
            setPerseritKontrollin(perseritKontrollin);
            setTakimiArdhshem(takimiArdshem);
            setEmriPacientit(emriPacientit);
            setMoshaPacientit(mosha);
            setEmailPacientit(emailPacientit);
            setTelefoniPacientit(telefoniPacientit);
            setDataTakimit(dataTakimit);
            setKoheZgjatjaTakimit(kohezgjatjaTakimit);
            setProblemi(problemi);
            setKomenti(komenti);
            setDentisti(dentisti);
            setKontaktDentisti(kontaktDentisti);
            setPagesa(pagesa);
            setDataRaportit(dataRaportit);
        }

        public RtfFactory() { }

        public void setPerseritKontrollin(string val)
        {
            setVariable("#PERSERIT_KONTROLLIN#", val);
        }

        public void setTakimiArdhshem(string val)
        {
            setVariable("#TAKIMI_ARDHSHEM#", val);
        }

        public void setEmriPacientit(string val)
        {
            setVariable("#EMRI_PACIENTIT#", val);
        }

        public void setMoshaPacientit(string val)
        {
            setVariable("#MOSHA_PACIENTIT#", val);
        }

        public void setEmailPacientit(string val)
        {
            setVariable("#EMAIL_PACIENTIT#", val);
        }

        public void setTelefoniPacientit(string val)
        {
            setVariable("#TELEFONI_PACIENTIT#", val);
        }

        public void setDataTakimit(string val)
        {
            setVariable("#DATA_TAKIMIT#", val);
        }

        public void setKoheZgjatjaTakimit(string val)
        {
            setVariable("#KOHEZGJATJA_TAKIMIT#", val);
        }

        public void setProblemi(string val)
        {
            setVariable("#PROBLEMI#", val);
        }

        public void setKomenti(string val)
        {
            setVariable("#KOMENTI#", val);
        }

        public void setDentisti(string val)
        {
            setVariable("#DENTISTI#", val);
        }

        public void setKontaktDentisti(string val)
        {
            setVariable("#KONTAKT_DENTISTI#", val);
        }

        public void setPagesa(string val)
        {
            setVariable("#PAGESA#", val);
        }

        public void setDataRaportit(string val)
        {
            setVariable("#DATA_RAPORTIT#", val);
        }

        private void setVariable(string var, string val)
        {
            template = template.Replace(var, val);
        }

        public string generateRtf()
        {
            return template;
        }

    }
}
