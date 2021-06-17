using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_FINAL_POO_Y_BD.CabinasContext
{
    public partial class Municipio
    {
        public Municipio()
        {
            Empleados = new HashSet<Empleado>();
            Pacientes = new HashSet<Paciente>();
        }

        public int Id { get; set; }
        public string Municipio1 { get; set; }
        public int IdDepartamento { get; set; }

        public virtual Departamento IdDepartamentoNavigation { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
