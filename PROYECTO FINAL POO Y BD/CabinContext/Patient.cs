using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_FINAL_POO_Y_BD.CabinContext
{
    public partial class Patient
    {
        public Patient()
        {
            Appointments = new HashSet<Appointment>();
        }

        public string NamePatient { get; set; }
        public string Dui { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }
        public string AddressPatient { get; set; }
        public int IdInstitution { get; set; }
        public int IdChronicdiseases { get; set; }
        public int IdMunicipality { get; set; }

        public virtual Chronicdisease IdChronicdiseasesNavigation { get; set; }
        public virtual Institution IdInstitutionNavigation { get; set; }
        public virtual Municipality IdMunicipalityNavigation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }

        public Patient(string namePatient, string dui, string telephone, string mail, string addressPatient, int idInstitution, int idChronicdiseases, int idMunicipality, Chronicdisease idChronicdiseasesNavigation, Institution idInstitutionNavigation, Municipality idMunicipalityNavigation)
        {
            NamePatient = namePatient;
            Dui = dui;
            Telephone = telephone;
            Mail = mail;
            AddressPatient = addressPatient;
            IdInstitution = idInstitution;
            IdChronicdiseases = idChronicdiseases;
            IdMunicipality = idMunicipality;
            IdChronicdiseasesNavigation = idChronicdiseasesNavigation;
            IdInstitutionNavigation = idInstitutionNavigation;
            IdMunicipalityNavigation = idMunicipalityNavigation;
            
        }
    }
}
