using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using PROYECTO_FINAL_POO_Y_BD.CabinContext;

namespace PROYECTO_FINAL_POO_Y_BD
{
    public partial class frmProcesoCita : Form
    {
        public Employee idEmployee { get; set; }
        public frmProcesoCita(Employee id)
        {
            InitializeComponent();
            this.idEmployee = id;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btnVerificarDUI_Click(object sender, EventArgs e)
        {

            var formatoDUI = "^[0-9]{8}-[0-9]{1}$";
            if (Regex.IsMatch(txtDUI_Usuario.Text, formatoDUI) &&
                (2021 - Convert.ToInt32(txtFechaNacimiento_Usuario.Text) > 17) && txtFechaNacimiento_Usuario.Text != " "
                && txtDUI_Usuario.Text != " " && (2021 - Convert.ToInt32(txtFechaNacimiento_Usuario.Text) < 101))
            {
                //SI EL DUI ESTA CORRECTO Y LA FECHA TAMBIEN SE MUESTRAN LOS DEMAS ELEMENTOS
                txtDUI_Usuario.Enabled = false;
                txtFechaNacimiento_Usuario.Enabled = false;
                lblDireccion.Visible = true;
                cmbDepartamento.Visible = true;
                btnVerificarDUI.Visible = false;
                btnvalidar04.Visible = true;
                l3abel3.Visible = false;

                //cargando combobox de los departamentos
                var db = new CabinasDeVacunacionCovidDBContext();
                cmbDepartamento.DataSource = db.Departaments.ToList();
                cmbDepartamento.DisplayMember = "Departament1";
                cmbDepartamento.ValueMember = "Id";

            }
            else
            {
                MessageBox.Show("Verifique que el DUI y fecha de nacimiento sean correctos", "Proceso de Cita",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //BOTON PARA SELECCIONAR DEPARTAMENTO
        private void btnvalidar04_Click(object sender, EventArgs e)
        {
            //SI EL COMBOBOX ESTA EN NULL TIRRAR MENSAJE (Josue eliminar esta validacion de null despues y dejas la otra)
            if (cmbDepartamento.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un departamento", "Proceso de Cita", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                lblMunicipio.Visible = true;
                cmbMunicipios.Visible = true;
                lblNombre.Visible = true;
                txtNombre_Usuario.Visible = true;
                lblTelefono.Visible = true;
                txtTelefono_Usuario.Visible = true;
                lblCorreo.Visible = true;
                txtCorreo_Usuario.Visible = true;
                label1.Visible = true;
                cmbEnfermedades.Visible = true;
                btnVerificar02.Visible = true;
                btnvalidar04.Visible = false;
                cmbDepartamento.Enabled = false;
                txtDireccionCasa.Visible = true;
                lblDireccionCasa.Visible = true;

                var db = new CabinasDeVacunacionCovidDBContext();

                //cargando combobox de emfermedades
                cmbEnfermedades.DataSource = db.Chronicdiseases.ToList();
                cmbEnfermedades.DisplayMember = "Disease";
                cmbEnfermedades.ValueMember = "Id";

                //creando lista de los municipios del departamento seleccionado
                Departament dref = (Departament) cmbDepartamento.SelectedItem;
                var ListMunicipality = db.Municipalities
                    .OrderBy(m => m.IdDepartament)
                    .Where(m => m.IdDepartament.Equals(dref.Id))
                    .ToList();

                //cargando combobox de municipios segun departamento seleccionado
                cmbMunicipios.DataSource = ListMunicipality;
                cmbMunicipios.DisplayMember = "Municipality1";
                cmbMunicipios.ValueMember = "Id";

            }
        }

        private void btnVerificar02_Click(object sender, EventArgs e)
        {
            
            Chronicdisease chref = (Chronicdisease) cmbEnfermedades.SelectedItem;

            var formatoTelefono = "^[0-9]{8}$";
            //Si los campos de datos del usuario estan vacios y municipio en nulo tirar mensaje de error
            if (txtNombre_Usuario.Text != "" && Regex.IsMatch(txtTelefono_Usuario.Text, formatoTelefono) &&
                cmbMunicipios.SelectedItem != null &&
                txtCorreo_Usuario.Text != "" && cmbEnfermedades.SelectedItem != null && txtTelefono_Usuario.Text != "" && txtDireccionCasa.Text!="")

            {
                //Si la enfermedad es otra a la que esta en la base de datos se habilita un nuevo campo para agregarla 
                if (chref.Disease == "Otra")
                {
                    txtEnfermedades_Usuario.Visible = true;
                    lblEnfermedades.Visible = true;
                    txtEnfermedades_Usuario.Enabled = true;
                    btnVerificar03.Visible = true;
                    txtNombre_Usuario.Enabled = false;
                    txtTelefono_Usuario.Enabled = false;
                    txtCorreo_Usuario.Enabled = false;
                    cmbEnfermedades.Enabled = true;
                    btnVerificar02.Visible = false;
                    cmbMunicipios.Enabled = false;
                    txtDireccionCasa.Enabled = false;
                }
                else
                {
                    //Si la enfermedad esta en el combo box pasar a la seccion de seleccionar una institucion
                    //escencial si es que pertenece a una
                    txtEnfermedades_Usuario.Enabled = false;
                    lblIdentificador.Visible = true;
                    cmbIdentificador_Usuario.Visible = true;
                    btnVerificar02.Visible = false;
                    btnSeleccionar.Visible = true;
                    txtNombre_Usuario.Enabled = false;
                    txtTelefono_Usuario.Enabled = false;
                    txtCorreo_Usuario.Enabled = false;
                    cmbMunicipios.Enabled = false;
                    cmbEnfermedades.Enabled = false;
                    txtDireccionCasa.Enabled = false;
                    
                    //cargando combobox de las instituciones
                    var db = new CabinasDeVacunacionCovidDBContext();
                    cmbIdentificador_Usuario.DataSource = db.Institutions.ToList();
                    cmbIdentificador_Usuario.DisplayMember = "Institution1";
                    cmbIdentificador_Usuario.ValueMember = "Id";

                }

            }
            else
            {
                MessageBox.Show("Verifique que los datos esten correctos o no esten vacios", "Proceso de Cita",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //var db = new CabinasDeVacunacionCovidDBContext();
            cmbIdentificador_Usuario.Enabled = false;
            Institution intref = (Institution) cmbIdentificador_Usuario.SelectedItem;
            
            if (intref.Institution1 == "Ninguna")
            {
                btnAgendarCita.Enabled = true;
            }
            else if (cmbIdentificador_Usuario.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una institucion escencial", "Proceso de Cita", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cmbIdentificador_Usuario.Enabled = true;
            }
            else
            {
                btnAgendarCita.Enabled = true;
                btnSeleccionar.Visible = false;
            }
        }

        private void btnVerificar03_Click(object sender, EventArgs e)
        {
            if (txtEnfermedades_Usuario.Text == "")
            {
                MessageBox.Show("Debe llenar el campo de enfermedad a especificar", "Proceso de Cita",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                txtEnfermedades_Usuario.Enabled = false;
                lblIdentificador.Visible = true;
                cmbIdentificador_Usuario.Visible = true;
                btnVerificar02.Visible = false;
                btnSeleccionar.Visible = true;
                txtNombre_Usuario.Enabled = false;
                txtTelefono_Usuario.Enabled = false;
                txtCorreo_Usuario.Enabled = false;
                cmbEnfermedades.Enabled = false;
                btnVerificar03.Visible = false;
                
                var db = new CabinasDeVacunacionCovidDBContext();
                string disease = txtEnfermedades_Usuario.Text;
               
                Chronicdisease diseases = new Chronicdisease(disease);

                db.Add(diseases);
                db.SaveChanges();
                MessageBox.Show("Enfermedad guardada con exito", "CITA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //cargando combobox de emfermedades
                cmbEnfermedades.DataSource = db.Chronicdiseases.AsNoTracking().ToList();
                cmbEnfermedades.DisplayMember = "Disease";
                cmbEnfermedades.ValueMember = "Id";
                btnVerificar02.Visible = true;
                cmbEnfermedades.Enabled = true;
            }
        }


        private void btnCancelarCita_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
            private void btnAgendarCita_Click_1(object sender, EventArgs e)
            {
                var db = new CabinasDeVacunacionCovidDBContext();
                string dui = txtDUI_Usuario.Text;
                string mail = txtCorreo_Usuario.Text;
                string telephone = txtTelefono_Usuario.Text;
                string nameUser = txtNombre_Usuario.Text;
                string address = txtDireccionCasa.Text;
                
                Institution intref = (Institution) cmbIdentificador_Usuario.SelectedItem;
                Institution idb = db.Set<Institution>().SingleOrDefault(i => i.Id == intref.Id);
                
                Municipality muniref = (Municipality) cmbMunicipios.SelectedItem;
                Municipality mdb = db.Set<Municipality>().SingleOrDefault(m => m.Id == muniref.Id);
                
                Chronicdisease chref = (Chronicdisease) cmbEnfermedades.SelectedItem;
                Chronicdisease cdb = db.Set<Chronicdisease>().SingleOrDefault(c => c.Id == chref.Id);

                //guardando datos del paciente
                var patient = new Patient(dui,telephone , nameUser, mail, address, cdb, idb, mdb);
                db.Add(patient);
                db.SaveChanges();
                
                //Generando primer cita
                var random = new Random();
                
                int day;
                //Funcion para generar día, si no tie
                DateTime dateForAppointment;
                if (cmbEnfermedades.Text == "Ninguna" && cmbIdentificador_Usuario.Text == "Ninguna")
                {
                    dateForAppointment = DateTime.Now.AddDays(random.Next(2, 60));
                }
                else
                {
                    dateForAppointment = DateTime.Now.AddDays(random.Next(2, 7));
                }

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
                    .Where(u => u.IdEmployee == idEmployee.Id)
                    .ToList();
                
                
                Patient patref = db.Set<Patient>().SingleOrDefault(c => c.Dui.Equals(dui));
                Cabin cabinref = db.Set<Cabin>().SingleOrDefault(ca => ca.Id.Equals(idEmployee.Id)); //Pasar el id del gestor desde el login para poder usarlo
                
                
                var cita = new Appointment(dateForAppointment,horaCita,"pendiente","pendiente", patref, cabinref);
                

                db.Add(cita);
                db.SaveChanges();
                MessageBox.Show($"Datos del paciente {patref.NamePatient} y primer cita, guardados con éxito, Revisar 'Citas'", "CITA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
    }
}