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

      

        private void btnVerificarDUI_Click(object sender, EventArgs e)
        {
            
            var formatoDUI="^[0-9]{8}-[0-9]{1}$";
            if ( Regex.IsMatch(txtDUI_Usuario.Text,formatoDUI) &&  
                 (2021-Convert.ToInt32(txtFechaNacimiento_Usuario.Text)>17 ) && txtFechaNacimiento_Usuario.Text!=" " 
            && txtDUI_Usuario.Text!= " " &&  (2021-Convert.ToInt32(txtFechaNacimiento_Usuario.Text)<101 ) )
            {
                //SI EL DUI ESTA CORRECTO Y LA FECHA TAMBIEN SE MUESTRAN LOS DEMAS ELEMENTOS
                txtDUI_Usuario.Enabled = false;
                txtFechaNacimiento_Usuario.Enabled = false;
                lblDireccion.Visible = true;
                cmbDepartamento.Visible = true;
                btnVerificarDUI.Visible = false;
                btnvalidar04.Visible = true;
                l3abel3.Visible = false;

            }
            else
            {
                MessageBox.Show("Verifique que el DUI y fecha de nacimiento sean correctos", "Proceso de Cita", MessageBoxButtons.OK,
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
                cmbEnfermedades.Visible=true;
                btnVerificar02.Visible = true;
                btnvalidar04.Visible = false;
                cmbDepartamento.Enabled = false;
            }
        }

        private void btnVerificar02_Click(object sender, EventArgs e)
        {
            var formatoTelefono = "^[0-9]{8}$";
            //Si los campos de datos del usuario estan vacios y municipio en nulo tirar mensaje de error
            if (txtNombre_Usuario.Text != "" && Regex.IsMatch(txtTelefono_Usuario.Text,formatoTelefono) && cmbMunicipios.SelectedItem!=null &&
                txtCorreo_Usuario.Text != "" && cmbEnfermedades.SelectedItem!=null && txtTelefono_Usuario.Text!="")
                
            {
                //Si la enfermedad es otra a la que esta en la base de datos se habilita un nuevo campo para agregarla 
                if (cmbEnfermedades.SelectedItem == "Otra")
                {
                    txtEnfermedades_Usuario.Visible = true;
                    lblEnfermedades.Visible = true;
                    txtEnfermedades_Usuario.Enabled = true;
                    btnVerificar03.Visible = true;
                    txtNombre_Usuario.Enabled = false;
                    txtTelefono_Usuario.Enabled = false;
                    txtCorreo_Usuario.Enabled = false;
                    cmbEnfermedades.Enabled = false;
                    btnVerificar02.Visible = false;
                    cmbMunicipios.Enabled = false;
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
                }
               
            }
            else
            {
                MessageBox.Show("Verifique que los datos esten correctos o no esten vacios", "Proceso de Cita", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

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
                txtTelefono_Usuario.Enabled = false;
                txtCorreo_Usuario.Enabled = false;
                cmbEnfermedades.Enabled = false;
                btnVerificar03.Visible = false;

            }
        }


        private void btnCancelarCita_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtEnfermedades_Usuario_TextChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}