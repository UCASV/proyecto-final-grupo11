using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_FINAL_POO_Y_BD.CabinContext
{
    public partial class Appointment
    {
        public int Id { get; set; }
        public DateTime DateAppointment { get; set; }
        public string HourAppointment { get; set; }
        public string HourVaccine { get; set; }
        public string HourArrival { get; set; }
        public string DuiPatient { get; set; }
        public int IdCabin { get; set; }

        public virtual Patient DuiPatientNavigation { get; set; }
        public virtual Cabin IdCabinNavigation { get; set; }


        public Appointment()
        {
            
        }

    public Appointment(DateTime dateAppointment, string hourAppointment, string hourVaccine, string hourArrival, Patient duiPatientNavigation, Cabin idCabinNavigation)
        {
            
            DateAppointment = dateAppointment;
            HourAppointment = hourAppointment;
            HourVaccine = hourVaccine;
            HourArrival = hourArrival;
            DuiPatientNavigation = duiPatientNavigation;
            IdCabinNavigation = idCabinNavigation;
        }
    }
}
