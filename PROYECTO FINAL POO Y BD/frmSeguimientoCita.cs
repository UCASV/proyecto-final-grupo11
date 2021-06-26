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
        private System.Windows.Forms.Button btnVerificar;

        private Employee employeeSelected { get; set; }
        FormMenu _formMenu {get;set;}
        public frmSeguimientoCita(Employee employee, FormMenu menu)
        {
            InitializeComponent();
            this.employeeSelected = employee;
            this._formMenu = menu;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            var db = new CabinasDeVacunacionCovidDBContext();
            var formatoDUI = "^[0-9]{8}-[0-9]{1}$";

            

            if (txtDUI.Text != "" && Regex.IsMatch(txtDUI.Text, formatoDUI))
            {

                var verification = db.Appointments
                    .Include(i => i.DuiPatientNavigation)
                    .Where(i => i.DuiPatientNavigation.Dui.Equals(txtDUI.Text))
                    .ToList();
                
                
                if (verification.Count > 0)
                {
                    
                    cargarCita();
                    btnDescargar.Enabled = true;
                    btnEditar.Enabled = true;
                    txtDescargarCita.Visible = true;
                    label3.Visible = true;
                }
                else
                {
                    MessageBox.Show("Paciente no registrado", "Seguimiento de Cita", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                
                
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
                    DUI = x.DuiPatientNavigation.Dui,
                    Telefono = x.DuiPatientNavigation.Telephone,
                    Direccion = x.DuiPatientNavigation.AddressPatient,
                    Email = x.DuiPatientNavigation.Mail,              
                    Fecha_cita = Convert.ToDateTime(x.DateAppointment.ToString()).ToString("yyyy-MM-dd"),
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
            int id = Convert.ToInt32(txtDescargarCita.Text);
            var db = new CabinasDeVacunacionCovidDBContext();
            int idAppointment = Int32.Parse(txtDescargarCita.Text);
            var appointments1 = db.Appointments.
                Where(c => c.Id == idAppointment && c.DuiPatientNavigation.Dui == txtDUI.Text)
                .ToList();

            if (appointments1.Count == 1)
            { 
                this.Visible = false;
                frmAddVaccine win2 = new frmAddVaccine(id,txtDUI.Text, employeeSelected, this);
                win2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Esa cita no coincide con este paciente.", "Descarga de Cita", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
                                   
        }

        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        
        private void createPDF(string directory)
        {
            PdfWriter pdfAppo = new PdfWriter(directory);
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
            int idCita = Convert.ToInt32(txtDescargarCita.Text);
            var list = db.Appointments
                .Include(i => i.DuiPatientNavigation)
                .Include(i=> i.IdCabinNavigation)
                .Where(i=> i.DuiPatientNavigation.Dui.Equals(txtDUI.Text) && i.Id.Equals(idCita))
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
            var db = new CabinasDeVacunacionCovidDBContext();
            int idAppointment = Int32.Parse(txtDescargarCita.Text);
            var appointments1 = db.Appointments.
                Where(c => c.Id == idAppointment && c.DuiPatientNavigation.Dui == txtDUI.Text)
                .ToList();

            if (appointments1.Count == 1)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "texto (*.pdf)|*pdf|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string directory = saveFileDialog1.FileName;
                    createPDF(directory);
                }

            }
            else
            {
                MessageBox.Show("Esa cita no coincide con este paciente.", "Descarga de Cita", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void frmSeguimientoCita_FormClosed(object sender, FormClosedEventArgs e)
        {
            _formMenu.Visible = true;
        }
    }
}