using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_FINAL_POO_Y_BD.CabinasContext
{
    public partial class Paciente
    {
        public Paciente()
        {
            Cita = new HashSet<Citum>();
        }

        public string Dui { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public int IdInstitucion { get; set; }
        public int IdEnfermedadescronicas { get; set; }
        public int IdMunicipio { get; set; }

        public virtual Enfermedadescronica IdEnfermedadescronicasNavigation { get; set; }
        public virtual Institucion IdInstitucionNavigation { get; set; }
        public virtual Municipio IdMunicipioNavigation { get; set; }
        public virtual ICollection<Citum> Cita { get; set; }
    }
}
