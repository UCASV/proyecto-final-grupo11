using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_FINAL_POO_Y_BD.CabinssContext
{
    public partial class Employee
    {
        public Employee()
        {
            Cabins = new HashSet<Cabin>();
        }

        public int Id { get; set; }
        public string NameEmployee { get; set; }
        public string Mail { get; set; }
        public string TypeEmployee { get; set; }
        public string UserEmployee { get; set; }
        public string PasswordEmployee { get; set; }
        public string AddressEmployee { get; set; }
        public int IdMunicipality { get; set; }

        public virtual Municipality IdMunicipalityNavigation { get; set; }
        public virtual ICollection<Cabin> Cabins { get; set; }
    }
}
