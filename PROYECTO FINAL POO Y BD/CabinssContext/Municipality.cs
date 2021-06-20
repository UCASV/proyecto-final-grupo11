using System;
using System.Collections.Generic;

#nullable disable

namespace PROYECTO_FINAL_POO_Y_BD.CabinssContext
{
    public partial class Municipality
    {
        public Municipality()
        {
            Employees = new HashSet<Employee>();
            Patients = new HashSet<Patient>();
        }

        public int Id { get; set; }
        public string Municipality1 { get; set; }
        public int IdDepartament { get; set; }

        public virtual Departament IdDepartamentNavigation { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
