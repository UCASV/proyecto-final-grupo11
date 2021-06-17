using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_FINAL_POO_Y_BD.CabinasContext
{
    public partial class Enfermedadescronica
    {
        public Enfermedadescronica()
        {
            Pacientes = new HashSet<Paciente>();
        }

        public int Id { get; set; }
        public string Enfermedad { get; set; }

        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
