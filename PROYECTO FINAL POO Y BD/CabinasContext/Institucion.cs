using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_FINAL_POO_Y_BD.CabinasContext
{
    public partial class Institucion
    {
        public Institucion()
        {
            Pacientes = new HashSet<Paciente>();
        }

        public int Id { get; set; }
        public string Institucion1 { get; set; }

        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
