using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using PROYECTO_FINAL_POO_Y_BD.CabinContext;

namespace PROYECTO_FINAL_POO_Y_BD
{
    public partial class frmSeguimientoCita : Form
    {
        private Button btnDescargar;
        private DataGridView dtgShow;
        private Label lblSelectCita;
        private Button btnSelect;
        private ComboBox cbCitas;
        private Button btnVerificar;

        public frmSeguimientoCita()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            var db = new CabinasDeVacunacionCovidDBContext();
            var formatoDUI="^[0-9]{8}-[0-9]{1}$";
            
            if (textBox1.Text != " " && Regex.IsMatch(textBox1.Text,formatoDUI))
            {
                
                var verification = db.Appointments
                    .Where(i => i.DuiPatient.Equals(txtDUI))
                    .ToList();
                
                //EL FORMATO ESTA CORRECTO PERO FALTA UNA VALIDACION MAS
                MessageBox.Show("SIII", "Seguimiento de Cita", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                
                 if(verification.Count > 0)
                 {
                   cargarCita2();
                 }
                 else
                 {
                    MessageBox.Show("Paciente no registrado", "Seguimiento de Cita", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                 }
            }
            else
            {
                MessageBox.Show("Formato de DUI incorrecto", "Seguimiento de Cita", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            } 
        }


        private void cargarCita()
        { 
            var db = new CabinasDeVacunacionCovidDBContext();
            
            
            var listPatient = db.Appointments
                .Include(i => i.DuiPatientNavigation)
                .Include(i=> i.IdCabinNavigation)
                .Where(i=> i.DuiPatientNavigation.Dui.Equals(txtDUI))
                .Select(x => new
                {
                    Numero_de_cita = x.Id,
                    Nombre = x.DuiPatientNavigation.NamePatient,
                    txtDUI = x.DuiPatientNavigation.Dui,
                    Telefono = x.DuiPatientNavigation.Telephone,
                    Direccion = x.DuiPatientNavigation.AddressPatient,
                    Email = x.DuiPatientNavigation.Mail,
                    Fecha_cita = x.DateAppointment,
                    Hora_cita = x.HourAppointment,
                    Hora_llegada = x.HourArrival,
                    Hora_vacuna = x.HourVaccine,
                })
                .ToList();
            
            
            dtgShow.DataSource = null;
            dtgShow.DataSource = listPatient;
        }
        private void cargarCita2()
        { 
            var db = new CabinasDeVacunacionCovidDBContext();
            
            
            var listPatient = db.Appointments
                .Include(i => i.DuiPatientNavigation)
                .Include(i=> i.IdCabinNavigation)
                .Where(i=> i.DuiPatient.Equals(txtDUI))
                .Select(x => new
                {
                    Numero_de_cita = x.Id,
                    Nombre = x.DuiPatientNavigation.NamePatient,
                    txtDUI = x.DuiPatientNavigation.Dui,
                    Telefono = x.DuiPatientNavigation.Telephone,
                    Direccion = x.DuiPatientNavigation.AddressPatient,
                    Email = x.DuiPatientNavigation.Mail,
                    Fecha_cita = x.DateAppointment,
                    Hora_cita = x.HourAppointment,
                    Hora_llegada = x.HourArrival,
                    Hora_vacuna = x.HourVaccine,
                })
                .ToList();
            
            dtgShow.DataSource = null;
            dtgShow.DataSource = listPatient;
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
             frmAddVaccine win2 = new frmAddVaccine();
              win2.ShowDialog();                      
        }
    }
}