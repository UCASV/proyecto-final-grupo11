using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.EntityFrameworkCore;
using PROYECTO_FINAL_POO_Y_BD.CabinContext;
using System.Collections.Generic;

namespace PROYECTO_FINAL_POO_Y_BD
{
    public partial class frmSeguimientoCita : Form
    {
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.DataGridView dtgShow;
        private System.Windows.Forms.Label lblSelectCita;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox cbCitas;
        private System.Windows.Forms.Button btnVerificar;

        public frmSeguimientoCita()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            var db = new CabinasDeVacunacionCovidDBContext();
            var formatoDUI = "^[0-9]{8}-[0-9]{1}$";


            


            if (txtDUI.Text != "" && Regex.IsMatch(txtDUI.Text, formatoDUI))
            {

                var verification = db.Appointments
                    .Include(i=> i.DuiPatientNavigation)
                    .Where(i => i.DuiPatientNavigation.Dui.Equals(txtDUI.Text))
                    .ToList();


                MessageBox.Show("SIII", "Seguimiento de Cita", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                if (verification.Count > 0)
                {
                    
                    cargarCita();
                    btnDescargar.Enabled = true;
                    btnEditar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Paciente no registrado", "Seguimiento de Cita", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }


                /*if (Regex.IsMatch(txtDUI.Text, formatoDUI))
>>>>>>> backend
                {

                    btnSelect.Enabled = true;
                    cbCitas.Enabled = true;
<<<<<<< HEAD
=======

>>>>>>> backend
                }
                else
                {
                    MessageBox.Show("Formato de DUI incorrecto", "Seguimiento de Cita", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
<<<<<<< HEAD
                }
            }
=======
                }*/
                
            }
            else
            {
                MessageBox.Show("Formato invalido", "Seguimiento de Cita", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void cargarCita()
        { 
            var db = new CabinasDeVacunacionCovidDBContext();
            
            
            var listPatient = db.Appointments
                .Include(i => i.DuiPatientNavigation)
                .Include(i=> i.IdCabinNavigation)
                .Where(i=> i.DuiPatientNavigation.Dui.Equals(txtDUI.Text))
                .Select(x => new
                {
                    Numero_de_cita = x.Id,
                    Nombre = x.DuiPatientNavigation.NamePatient,
                    txtDUI = x.DuiPatientNavigation.Dui,
                    Telefono = x.DuiPatientNavigation.Telephone,
                    Direccion = x.DuiPatientNavigation.AddressPatient,
                    Email = x.DuiPatientNavigation.Mail,
                    Fecha_cita = x.DateAppointment,
                    Hora_cita = x.HourAppointment,
                    Hora_llegada = x.HourArrival,
                    Hora_vacuna = x.HourVaccine,
                })
                .ToList();
            
            dtgShow.DataSource = null;
            dtgShow.DataSource = listPatient;
        }
        

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
             frmAddVaccine win2 = new frmAddVaccine();
              win2.ShowDialog();                      
        }

        /*private void btnSelect_Click(object sender, EventArgs e)
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
       
        }*/


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void createPDF()
        {
            PdfWriter pdfAppo = new PdfWriter("Reporte_cita.pdf");
            PdfDocument pdf = new PdfDocument(pdfAppo);
            Document document = new Document(pdf, PageSize.LETTER);

            document.SetMargins(40,20,40,20);

            PdfFont fontCols = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontCont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            string[] cols = {"N° cita", "Nombre", "Fecha de cita", "Hora de la cita", "Direccion de cabina"};
            float[] tam = {2, 5, 4, 4, 5};
            
            Table table = new Table(UnitValue.CreatePercentArray(tam));
            table.SetWidth(UnitValue.CreatePercentValue(100));
            
            var db = new CabinasDeVacunacionCovidDBContext();
            var list = db.Appointments
                .Include(i => i.DuiPatientNavigation)
                .Include(i=> i.IdCabinNavigation)
                .Where(i=> i.DuiPatientNavigation.Dui.Equals(txtDUI.Text))
                .Select(x => new
                {
                    Numero_de_cita = x.Id,
                    Nombre = x.DuiPatientNavigation.NamePatient,
                    Fecha_cita = x.DateAppointment,
                    Hora_cita = x.HourAppointment,
                    Direccion = x.IdCabinNavigation.AddressCabin,
                })
                .ToList();


            string dateOne = list[0].Fecha_cita.ToString();
            string date = dateOne.Substring(0, 10);
            foreach (string col in cols)
            {
                table.AddHeaderCell(new Cell().Add(new Paragraph(col).SetFont(fontCols)));
            }
            table.AddCell(new Cell().Add(new Paragraph(list[0].Numero_de_cita.ToString()).SetFont(fontCols)));
            table.AddCell(new Cell().Add(new Paragraph(list[0].Nombre.ToString()).SetFont(fontCols)));
            table.AddCell(new Cell().Add(new Paragraph(date.ToString()).SetFont(fontCols)));
            table.AddCell(new Cell().Add(new Paragraph(list[0].Hora_cita.ToString()).SetFont(fontCols)));
            table.AddCell(new Cell().Add(new Paragraph(list[0].Direccion.ToString()).SetFont(fontCols)));
            
            document.Add(table);
            document.Close();

        }

        private void btnDescargar_Click_1(object sender, EventArgs e)
        {
            createPDF();
        }
    }
}