using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_FINAL_POO_Y_BD.CabinssContext
{
    public partial class Cabin
    {
        public Cabin()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int Id { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }
        public string AddressCabin { get; set; }
        public int IdEmployee { get; set; }

        public virtual Employee IdEmployeeNavigation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
