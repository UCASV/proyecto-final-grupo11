using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PROYECTO_FINAL_POO_Y_BD
{
    public partial class frmSeguimientoCita : Form
    {
        public frmSeguimientoCita()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            var formatoDUI="^[0-9]{8}-[0-9]{1}$";
            
            if (textBox1.Text != "" && Regex.IsMatch(textBox1.Text,formatoDUI))
            {
                //EL FORMATO ESTA CORRECTO PERO FALTA UNA VALIDACION MAS
                MessageBox.Show("SIII", "Seguimiento de Cita", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                /* if( si el DUI ya tiene cita en la Base de datos){
                    QUE MUESTRE LOS DATOS DE LA CITA QUE PERTENEZCA AL DUI INGRESADO ANTERIORMENTE
                    
                 }
                
                else
                {
                     NOTIFICAR QUE NO ESTA LA CITA Y MOSTRAR OPCION DE AGENDAR UNA CITA!
                } */
               
            }
            else
            {
                MessageBox.Show("Formato de DUI incorrecto", "Seguimiento de Cita", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        }
    }
}