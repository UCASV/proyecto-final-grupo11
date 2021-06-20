using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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

        public frmSeguimientoCita()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            var formatoDUI="^[0-9]{8}-[0-9]{1}$";
            
            if (Regex.IsMatch(txtDUI.Text,formatoDUI))
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


        

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
             frmAddVaccine win2 = new frmAddVaccine();
              win2.ShowDialog();                      
        }

        private void btnSelect_Click(object sender, EventArgs e)
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
       
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}