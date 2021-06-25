using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using PROYECTO_FINAL_POO_Y_BD.Controllers;

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

            var LoginController = new LoginController();
            LoginController.CloseForm(textBox_username.Text, textBox_password.Text, this);

            ////////////////////////////
        }
    }
}