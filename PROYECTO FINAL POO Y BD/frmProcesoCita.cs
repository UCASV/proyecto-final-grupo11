using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PROYECTO_FINAL_POO_Y_BD
{
    public partial class frmProcesoCita : Form
    {
        public frmProcesoCita()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void frmProcesoCita_Load(object sender, EventArgs e)
        {
          
        }

        private void btnVerificarDUI_Click(object sender, EventArgs e)
        {
            
            var formatoDUI="^[0-9]{8}-[0-9]{1}$";
            if ( Regex.IsMatch(txtDUI_Usuario.Text,formatoDUI) &&  
                 (2021-Convert.ToInt32(txtFechaNacimiento_Usuario.Text)>18 ) && txtFechaNacimiento_Usuario.Text!=" " 
            && txtDUI_Usuario.Text!= " ")
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
                lblEnfermedades.Visible = true;
                txtEnfermedades_Usuario.Visible = true;
                btnVerificarDUI.Visible = false;
                btnVerificar02.Visible = true;
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
                txtCorreo_Usuario.Text == ""
                || txtEnfermedades_Usuario.Text == "")
            {
                MessageBox.Show("Verifique que los campos no esten vacios", "Proceso de Cita", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
               
            }
            else
            {
               
                lblIdentificador.Visible = true;
                cmbIdentificador_Usuario.Visible = true;
                btnVerificar02.Visible = false;
                btnSeleccionar.Visible = true;
                txtNombre_Usuario.Enabled = false;
                txtDireccion_Usuario.Enabled = false;
                txtTelefono_Usuario.Enabled = false;
                txtCorreo_Usuario.Enabled = false;
                txtEnfermedades_Usuario.Enabled = false;
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
                lblNumeroIdentificador.Visible = true;
                txtNumeroIdentificador_Usuario.Visible = true;
                btnAgendarCita.Enabled = true;
                btnSeleccionar.Visible = false;
            }
        
        }
    }
}