using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_FINAL_POO_Y_BD.CabinssContext
{
    public partial class Departament
    {
        public Departament()
        {
            Municipalities = new HashSet<Municipality>();
        }

        public int Id { get; set; }
        public string Departament1 { get; set; }

        public virtual ICollection<Municipality> Municipalities { get; set; }
    }
}
