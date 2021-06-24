using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using PROYECTO_FINAL_POO_Y_BD.CabinContext;

namespace PROYECTO_FINAL_POO_Y_BD
{
    public partial class frmAddVaccine : Form
    {
        private int id_cita { get; set; }
        private string dui { get; set; }
        private Employee employeeSelected { get; set; }
        public frmAddVaccine(int id_cita1, string dui1, Employee employee1)
        {
            InitializeComponent();
            this.id_cita = id_cita1;
            this.dui = dui1;
            this.employeeSelected = employee1;
        }


        private void btnVerificar_Click(object sender, EventArgs e)
        {
            var formatoDUI = "^[0-9]{8}-[0-9]{1}$";
            //SI EL DUI ES CORRECTO O ESTA EN LA BASE DE DATOS SE HABILITARAN LOS CAMPOS PARA ARREGLAR HORAS Y FECHA
            if (Regex.IsMatch(txtDUI.Text, formatoDUI) && txtDUI.Text != "")
            {
                dtFechaLlegada.Enabled = true;
                dtFechaVacuna.Enabled = true;
                txtHoraLlegada.Enabled = true;
                txtHoraVacuna.Enabled = true;
                txtDUI.Enabled = false;
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Formato de DUI incorrecto o DUI no encontrado", "Vacunación", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            var db = new CabinasDeVacunacionCovidDBContext();
            //SI LOS CAMPOS PARA EDITAR HORA ESTAN VACIOS NO DEJARA GUARDAR
            if (txtHoraLlegada.Text == "" || txtHoraVacuna.Text == "")
            {
                MessageBox.Show("Verifique que los campos no esten vacios", "Vacunación", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                var appSelected = db.Appointments
                  .Where(u => u.Id.Equals(id_cita))
                  .ToList().First();
                var apps = db.Appointments
                    .Where(u => u.DuiPatient.Equals(dui))
                    .ToList();
                if (apps.Count > 1)
                {
                    appSelected.HourArrival = txtHoraLlegada.Text;
                    appSelected.HourVaccine = txtHoraVacuna.Text;
                    db.SaveChanges();
                    MessageBox.Show($"Se actualizaron los horarios de llegada y de vacunación y con esto ha completado sus dosis de vacunas.", "Vacunación", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    Random random = new Random();
                    int numDays = random.Next(42, 56);
                    appSelected.HourArrival = txtHoraLlegada.Text;
                    appSelected.HourVaccine = txtHoraVacuna.Text;
                    db.SaveChanges();
                    //Generando hora de cita
                    var hora = random.Next(7, 17);
                    string horaCita;
                    if (hora < 10)
                    {
                        horaCita = "0" + hora + ":00";
                    }
                    else
                    {
                        horaCita = hora + ":00";
                    }
                    var cabin = db.Cabins
                        .Where(u => u.IdEmployee == employeeSelected.Id)
                        .ToList();
                
                
                    Patient patref = db.Set<Patient>().SingleOrDefault(c => c.Dui.Equals(dui));
                    Cabin cabinref = db.Set<Cabin>().SingleOrDefault(ca => ca.Id.Equals(employeeSelected.Id)); 
                    var secondCite = new Appointment(appSelected.DateAppointment.AddDays(numDays),horaCita,"Pendiente", "Pendiente",patref,cabinref);

                    db.Add(secondCite);
                    db.SaveChanges();
                    MessageBox.Show($"Se actualizaron los horarios de llegada, vacunación y ya se encuentra creada la cita para su segunda dosis.", "Vacunación", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);   
                }


                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}