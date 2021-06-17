using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_FINAL_POO_Y_BD.CabinasContext
{
    public partial class Empleado
    {
        public Empleado()
        {
            Cabinas = new HashSet<Cabina>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Tipo { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Direccion { get; set; }
        public int IdMunicipio { get; set; }

        public virtual Municipio IdMunicipioNavigation { get; set; }
        public virtual ICollection<Cabina> Cabinas { get; set; }
    }
}
