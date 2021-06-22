using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_FINAL_POO_Y_BD.CabinContext
{
    public partial class Chronicdisease
    {
        public Chronicdisease()
        {
            Patients = new HashSet<Patient>();
        }
        

        public int Id { get; set; }
        public string Disease { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
        
        public Chronicdisease(string disease)
        {
            Disease = disease;
        }
    }
}
