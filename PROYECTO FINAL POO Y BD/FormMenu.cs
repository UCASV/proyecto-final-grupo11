using System;
using System.Windows.Forms;

namespace PROYECTO_FINAL_POO_Y_BD
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProcesoCita window = new frmProcesoCita();
                window.Show();
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSeguimientoCita win2 = new frmSeguimientoCita();
            win2.Show();
            
        }
    }
}