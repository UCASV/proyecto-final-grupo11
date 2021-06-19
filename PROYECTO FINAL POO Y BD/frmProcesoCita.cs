using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using PROYECTO_FINAL_POO_Y_BD.CabinContext;

namespace PROYECTO_FINAL_POO_Y_BD
{
    public partial class frmProcesoCita : Form
    {
        public frmProcesoCita()
        {
            InitializeComponent();
        }

        

        private void frmProcesoCita_Load(object sender, EventArgs e)
        {
            var db = new CabinasDeVacunacionCovidDBContext();
            cmbEnfermedades.DataSource = db.Chronicdiseases.ToList();
            cmbEnfermedades.DisplayMember = "disease";
            cmbEnfermedades.ValueMember = "id";

            cmbIdentificador_Usuario.DataSource = db.Institutions.ToList();
            cmbIdentificador_Usuario.DisplayMember = "institution";
            cmbIdentificador_Usuario.ValueMember = "id";
        }

        private void btnVerificarDUI_Click(object sender, EventArgs e)
        {
            
            var formatoDUI="^[0-9]{8}-[0-9]{1}$";
            if ( Regex.IsMatch(txtDUI_Usuario.Text,formatoDUI) &&  
                 (2021-Convert.ToInt32(txtFechaNacimiento_Usuario.Text)>18 ) && txtFechaNacimiento_Usuario.Text!=" " 
            && txtDUI_Usuario.Text!= "")
            {
                txtDUI_Usuario.Enabled = false;
                txtFechaNacimiento_Usuario.Enabled = false;
                lblNombre.Visible = true;
                txtNombre_Usuario.Visible = true;
                lblDireccion.Visible = true;
                txtDireccion_Usuario.Visible = true;
                lblTelefono.Visible = true;
                txtTelefono_Usuario.Visible = true;
                lblCorreo.Visible = true;
                txtCorreo_Usuario.Visible = true;
                btnVerificarDUI.Visible = false;
                btnVerificar02.Visible = true;
                label1.Visible = true;
                cmbEnfermedades.Visible=true;
            }
            else
            {
                MessageBox.Show("Formato de DUI invalido o Fecha de nacimiento ingresada es menor a 18 años", "Proceso de Cita", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            }

            

        private void btnVerificar02_Click(object sender, EventArgs e)
        {
            
            
            if (txtNombre_Usuario.Text == "" || txtDireccion_Usuario.Text == "" || txtTelefono_Usuario.Text == "" ||
                txtCorreo_Usuario.Text == "" || cmbEnfermedades.SelectedItem==null)
            {
                MessageBox.Show("Verifique que los campos no esten vacios", "Proceso de Cita", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
               
            }
            else
            {
                if (cmbEnfermedades.SelectedItem == "Otra")
                {
                    txtEnfermedades_Usuario.Visible = true;
                    lblEnfermedades.Visible = true;
                    txtEnfermedades_Usuario.Enabled = true;
                    btnVerificar03.Visible = true;
                    txtNombre_Usuario.Enabled = false;
                    txtDireccion_Usuario.Enabled = false;
                    txtTelefono_Usuario.Enabled = false;
                    txtCorreo_Usuario.Enabled = false;
                    cmbEnfermedades.Enabled = false;
                    btnVerificar02.Visible = false;
                }
                else
                {
                    txtEnfermedades_Usuario.Enabled = false;
                    lblIdentificador.Visible = true;
                    cmbIdentificador_Usuario.Visible = true;
                    btnVerificar02.Visible = false;
                    btnSeleccionar.Visible = true;
                    txtNombre_Usuario.Enabled = false;
                    txtDireccion_Usuario.Enabled = false;
                    txtTelefono_Usuario.Enabled = false;
                    txtCorreo_Usuario.Enabled = false;
                    cmbEnfermedades.Enabled = false;
                }
            }
          
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            cmbIdentificador_Usuario.Enabled = false;
            if (cmbIdentificador_Usuario.SelectedItem == "Ninguno")
            {
                
                btnAgendarCita.Enabled = true;
            }

            else if (cmbIdentificador_Usuario.SelectedItem==null)
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
                txtDireccion_Usuario.Enabled = false;
                txtTelefono_Usuario.Enabled = false;
                txtCorreo_Usuario.Enabled = false;
                cmbEnfermedades.Enabled = false;
                btnVerificar03.Visible = false;

            }
        }

       
    }
}