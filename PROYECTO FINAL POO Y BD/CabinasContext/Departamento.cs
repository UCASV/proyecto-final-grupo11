using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_FINAL_POO_Y_BD.CabinasContext
{
    public partial class Departamento
    {
        public Departamento()
        {
            Municipios = new HashSet<Municipio>();
        }

        public int Id { get; set; }
        public string Departamento1 { get; set; }

        public virtual ICollection<Municipio> Municipios { get; set; }
    }
}
