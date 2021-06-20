using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_FINAL_POO_Y_BD.CabinsContext
{
    public partial class Institution
    {
        public Institution()
        {
            Patients = new HashSet<Patient>();
        }

        public int Id { get; set; }
        public string Institution1 { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
    }
}
