using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_FINAL_POO_Y_BD.CabinasContext
{
    public partial class Cabina
    {
        public Cabina()
        {
            Cita = new HashSet<Citum>();
        }

        public int Id { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public int IdEmpleado { get; set; }

        public virtual Empleado IdEmpleadoNavigation { get; set; }
        public virtual ICollection<Citum> Cita { get; set; }
    }
}
