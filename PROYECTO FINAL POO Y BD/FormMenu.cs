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
                this.Hide();
        }
    }
}