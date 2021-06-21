using System;
using System.Windows.Forms;
using PROYECTO_FINAL_POO_Y_BD.CabinssContext;

namespace PROYECTO_FINAL_POO_Y_BD
{
    public partial class FormMenu : Form
    {
        public int idEmployee { get; set; }
            public FormMenu(int id)
        {
            InitializeComponent();
            this.idEmployee = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProcesoCita window = new frmProcesoCita(idEmployee);
                window.ShowDialog();
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSeguimientoCita win2 = new frmSeguimientoCita();
            win2.ShowDialog();
            
        }
    }
}