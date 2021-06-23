using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PROYECTO_FINAL_POO_Y_BD
{
    public partial class frmAddVaccine : Form
    {
        public frmAddVaccine()
        {
            InitializeComponent();
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
            //SI LOS CAMPOS PARA EDITAR HORA ESTAN VACIOS NO DEJARA GUARDAR
            if (txtHoraLlegada.Text == "" || txtHoraVacuna.Text == "")
            {
                MessageBox.Show("Verifique que los campos no esten vacios", "Vacunación", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Se guardaron los ajustes!!", "Vacunación", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}