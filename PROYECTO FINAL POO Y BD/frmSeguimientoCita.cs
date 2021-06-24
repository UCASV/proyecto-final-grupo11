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
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.DataGridView dtgShow;
        private Label lblSelectCita;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox cbCitas;
        private System.Windows.Forms.Button btnVerificar;

        private Employee employeeSelected { get; set; }
        public frmSeguimientoCita(Employee employee)
        {
            InitializeComponent();
            this.employeeSelected = employee;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            var db = new CabinasDeVacunacionCovidDBContext();
            var formatoDUI = "^[0-9]{8}-[0-9]{1}$";
            
//            if (textBox1.Text != " " && Regex.IsMatch(textBox1.Text, formatoDUI))

            if (txtDUI.Text != "" && Regex.IsMatch(txtDUI.Text, formatoDUI))
            {

                var verification = db.Appointments
                    .Include(i => i.DuiPatientNavigation)
                    .Where(i => i.DuiPatientNavigation.Dui.Equals(txtDUI.Text))
                    .ToList();

                //EL FORMATO ESTA CORRECTO PERO FALTA UNA VALIDACION MAS
                MessageBox.Show("SIII", "Seguimiento de Cita", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                cbCitas.DataSource = verification;
                cbCitas.DisplayMember = "DateAppointment";
                cbCitas.ValueMember = "Id";
                cbCitas.Enabled = true;
                btnSelect.Enabled = true;
                if (verification.Count > 0)
                {
                    //cargarCita2();
                    cargarCita();
                    btnDescargar.Enabled = true;
                    btnEditar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Paciente no registrado", "Seguimiento de Cita", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                
                
                /*if (Regex.IsMatch(txtDUI.Text, formatoDUI))
                {

                    btnSelect.Enabled = true;
                    cbCitas.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Formato de DUI incorrecto", "Seguimiento de Cita", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
                }*/
                
            }
            else
            {
                MessageBox.Show("Formato invalido", "Seguimiento de Cita", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void cargarCita()
        { 
            var db = new CabinasDeVacunacionCovidDBContext();
            
            
            var listPatient = db.Appointments
                .Include(i => i.DuiPatientNavigation)
                .Include(i=> i.IdCabinNavigation)
                .Where(i=> i.DuiPatientNavigation.Dui.Equals(txtDUI.Text))
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
            
             frmAddVaccine win2 = new frmAddVaccine((int)cbCitas.SelectedValue,txtDUI.Text, employeeSelected);
              win2.ShowDialog();                      
        }

        /*private void btnSelect_Click(object sender, EventArgs e)
        {
         if(cbCitas.SelectedItem == null){
             MessageBox.Show("Debe seleccionar una Cita", "Seguimiento de Cita", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
         }
          //Si se selecciona cita 1 que se muestren datos de cita 1 desde la base de datos
         else if(cbCitas.SelectedItem == "Cita1")
                 {
                     MessageBox.Show("Se selecciono Cita 1", "Seguimiento de Cita", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                     btnDescargar.Enabled = true;
                     btnEditar.Enabled = true;
                 }
                   //Si se selecciona cita 2 que se muestren datos de cita 1 desde la base de datos
         else
         {
             MessageBox.Show("Se selecciono Cita 2", "Seguimiento de Cita", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                 
                  btnDescargar.Enabled = true;
                  btnEditar.Enabled = true;
         }
        }*/


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}