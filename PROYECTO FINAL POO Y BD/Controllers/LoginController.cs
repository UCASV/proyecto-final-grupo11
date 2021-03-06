using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PROYECTO_FINAL_POO_Y_BD.CabinContext;

namespace PROYECTO_FINAL_POO_Y_BD
{
    public class LoginController 
    {
        
        public void CloseForm(string user, string password, Form1 form1)
        {   
            
            var db = new CabinasDeVacunacionCovidDBContext();
            
            List<Employee> employee = db.Employees
                .OrderBy(e => e.Id)
                .ToList();
            
            var employeeFound = employee.Where(
                u => u.UserEmployee.Equals(user) && 
                     u.PasswordEmployee.Equals(password)
                     ).ToList();
            
            if (employeeFound.Count() == 0)
            {
                MessageBox.Show("Usuario invalido o contraseña incorrecta", "Inicio Sesion", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
            {
                var idEmployee = employeeFound[0].Id;
                FormMenu window1 = new FormMenu(employeeFound[0], form1);
                form1.Hide();
                window1.Show();
            }
        }
    }
}