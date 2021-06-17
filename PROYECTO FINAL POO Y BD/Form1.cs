using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL_POO_Y_BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {

            if (textBox_username.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Usuario invalido o contraseña incorrecta", "Inicio Sesion", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                FormMenu window1 = new FormMenu();
                window1.Show();
                this.Hide();
            }
            
              

        }
    }
}