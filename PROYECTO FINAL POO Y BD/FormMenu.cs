using System;
using System.Windows.Forms;
using PROYECTO_FINAL_POO_Y_BD.CabinContext;


namespace PROYECTO_FINAL_POO_Y_BD
{
    public partial class FormMenu : Form
    {
        public Employee idEmployee { get; set; }
        private Form1 _form1 {get; set;}
            public FormMenu(Employee id, Form1 form1)
        {
            InitializeComponent();
            this.idEmployee = id;
            this._form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        this.Visible = false;
            frmProcesoCita window = new frmProcesoCita(idEmployee, this);
            window.ShowDialog();
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmSeguimientoCita win2 = new frmSeguimientoCita(idEmployee, this);
            win2.ShowDialog();
            
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            _form1.Close();
        }
    }
}