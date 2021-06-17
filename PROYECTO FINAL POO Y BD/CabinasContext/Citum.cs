using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_FINAL_POO_Y_BD.CabinasContext
{
    public partial class Citum
    {
        public int Id { get; set; }
        public DateTime FechaCita { get; set; }
        public string HoraVacuna { get; set; }
        public string HoraCita { get; set; }
        public string DuiPaciente { get; set; }
        public int IdCabina { get; set; }

        public virtual Paciente DuiPacienteNavigation { get; set; }
        public virtual Cabina IdCabinaNavigation { get; set; }
    }
}
