using System.ComponentModel;

namespace PROYECTO_FINAL_POO_Y_BD
{
    partial class frmProcesoCita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesoCita));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCorreo_Usuario = new System.Windows.Forms.TextBox();
            this.txtTelefono_Usuario = new System.Windows.Forms.TextBox();
            this.txtDireccion_Usuario = new System.Windows.Forms.TextBox();
            this.txtNombre_Usuario = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento_Usuario = new System.Windows.Forms.TextBox();
            this.txtDUI_Usuario = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblDUI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.cmbIdentificador_Usuario = new System.Windows.Forms.ComboBox();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.txtEnfermedades_Usuario = new System.Windows.Forms.TextBox();
            this.lblEnfermedades = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEnfermedades = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancelarCita = new System.Windows.Forms.Button();
            this.btnAgendarCita = new System.Windows.Forms.Button();
            this.btnVerificarDUI = new System.Windows.Forms.Button();
            this.btnVerificar02 = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVerificar03 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.75F));
            this.tableLayoutPanel1.Controls.Add(this.txtCorreo_Usuario, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtTelefono_Usuario, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtDireccion_Usuario, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtNombre_Usuario, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFechaNacimiento_Usuario, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDUI_Usuario, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFechaNacimiento, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDUI, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNombre, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDireccion, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTelefono, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblCorreo, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbIdentificador_Usuario, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblIdentificador, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtEnfermedades_Usuario, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblEnfermedades, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbEnfermedades, 2, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 174);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.37527F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.37527F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.37527F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.37527F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.37527F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.37527F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.37527F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.23774F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.13536F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(507, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtCorreo_Usuario
            // 
            this.txtCorreo_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreo_Usuario.Location = new System.Drawing.Point(287, 257);
            this.txtCorreo_Usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo_Usuario.Name = "txtCorreo_Usuario";
            this.txtCorreo_Usuario.Size = new System.Drawing.Size(217, 22);
            this.txtCorreo_Usuario.TabIndex = 15;
            this.txtCorreo_Usuario.Visible = false;
            // 
            // txtTelefono_Usuario
            // 
            this.txtTelefono_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono_Usuario.Location = new System.Drawing.Point(287, 206);
            this.txtTelefono_Usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono_Usuario.Name = "txtTelefono_Usuario";
            this.txtTelefono_Usuario.Size = new System.Drawing.Size(217, 22);
            this.txtTelefono_Usuario.TabIndex = 14;
            this.txtTelefono_Usuario.Visible = false;
            // 
            // txtDireccion_Usuario
            // 
            this.txtDireccion_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion_Usuario.Location = new System.Drawing.Point(287, 155);
            this.txtDireccion_Usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion_Usuario.Name = "txtDireccion_Usuario";
            this.txtDireccion_Usuario.Size = new System.Drawing.Size(217, 22);
            this.txtDireccion_Usuario.TabIndex = 13;
            this.txtDireccion_Usuario.Visible = false;
            // 
            // txtNombre_Usuario
            // 
            this.txtNombre_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre_Usuario.Location = new System.Drawing.Point(287, 104);
            this.txtNombre_Usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre_Usuario.Name = "txtNombre_Usuario";
            this.txtNombre_Usuario.Size = new System.Drawing.Size(217, 22);
            this.txtNombre_Usuario.TabIndex = 12;
            this.txtNombre_Usuario.Visible = false;
            // 
            // txtFechaNacimiento_Usuario
            // 
            this.txtFechaNacimiento_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaNacimiento_Usuario.Location = new System.Drawing.Point(287, 53);
            this.txtFechaNacimiento_Usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFechaNacimiento_Usuario.Name = "txtFechaNacimiento_Usuario";
            this.txtFechaNacimiento_Usuario.Size = new System.Drawing.Size(217, 22);
            this.txtFechaNacimiento_Usuario.TabIndex = 20;
            // 
            // txtDUI_Usuario
            // 
            this.txtDUI_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDUI_Usuario.Location = new System.Drawing.Point(287, 2);
            this.txtDUI_Usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDUI_Usuario.Name = "txtDUI_Usuario";
            this.txtDUI_Usuario.Size = new System.Drawing.Size(217, 22);
            this.txtDUI_Usuario.TabIndex = 11;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(66, 51);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(215, 51);
            this.lblFechaNacimiento.TabIndex = 21;
            this.lblFechaNacimiento.Text = "Año de nacimiento:";
            this.lblFechaNacimiento.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDUI
            // 
            this.lblDUI.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDUI.Location = new System.Drawing.Point(66, 0);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(215, 51);
            this.lblDUI.TabIndex = 1;
            this.lblDUI.Text = "DUI:";
            this.lblDUI.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.Location = new System.Drawing.Point(66, 102);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(215, 51);
            this.lblNombre.TabIndex = 23;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblNombre.Visible = false;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDireccion.Location = new System.Drawing.Point(66, 153);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(215, 51);
            this.lblDireccion.TabIndex = 24;
            this.lblDireccion.Text = "Direccion:";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDireccion.Visible = false;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefono.Location = new System.Drawing.Point(66, 204);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(215, 51);
            this.lblTelefono.TabIndex = 25;
            this.lblTelefono.Text = "Telefono:";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTelefono.Visible = false;
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorreo.Location = new System.Drawing.Point(66, 255);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(215, 51);
            this.lblCorreo.TabIndex = 26;
            this.lblCorreo.Text = "Correo:";
            this.lblCorreo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCorreo.Visible = false;
            // 
            // cmbIdentificador_Usuario
            // 
            this.cmbIdentificador_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIdentificador_Usuario.DisplayMember = "1";
            this.cmbIdentificador_Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdentificador_Usuario.FormattingEnabled = true;
            this.cmbIdentificador_Usuario.Location = new System.Drawing.Point(287, 405);
            this.cmbIdentificador_Usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbIdentificador_Usuario.Name = "cmbIdentificador_Usuario";
            this.cmbIdentificador_Usuario.Size = new System.Drawing.Size(217, 24);
            this.cmbIdentificador_Usuario.TabIndex = 19;
            this.cmbIdentificador_Usuario.ValueMember = "1";
            this.cmbIdentificador_Usuario.Visible = false;
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdentificador.Location = new System.Drawing.Point(66, 403);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(215, 47);
            this.lblIdentificador.TabIndex = 28;
            this.lblIdentificador.Text = "Identificador Institucion Escencial:";
            this.lblIdentificador.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblIdentificador.Visible = false;
            // 
            // txtEnfermedades_Usuario
            // 
            this.txtEnfermedades_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnfermedades_Usuario.Location = new System.Drawing.Point(287, 359);
            this.txtEnfermedades_Usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEnfermedades_Usuario.Name = "txtEnfermedades_Usuario";
            this.txtEnfermedades_Usuario.Size = new System.Drawing.Size(217, 22);
            this.txtEnfermedades_Usuario.TabIndex = 16;
            this.txtEnfermedades_Usuario.Visible = false;
            // 
            // lblEnfermedades
            // 
            this.lblEnfermedades.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnfermedades.Location = new System.Drawing.Point(66, 357);
            this.lblEnfermedades.Name = "lblEnfermedades";
            this.lblEnfermedades.Size = new System.Drawing.Size(215, 46);
            this.lblEnfermedades.TabIndex = 27;
            this.lblEnfermedades.Text = "Especificar Enfermedad";
            this.lblEnfermedades.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblEnfermedades.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(66, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 51);
            this.label1.TabIndex = 29;
            this.label1.Text = "Enfermedad";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Visible = false;
            // 
            // cmbEnfermedades
            // 
            this.cmbEnfermedades.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEnfermedades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnfermedades.FormattingEnabled = true;
            this.cmbEnfermedades.Location = new System.Drawing.Point(287, 309);
            this.cmbEnfermedades.Name = "cmbEnfermedades";
            this.cmbEnfermedades.Size = new System.Drawing.Size(217, 24);
            this.cmbEnfermedades.TabIndex = 30;
            this.cmbEnfermedades.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label10.Location = new System.Drawing.Point(123, -11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(437, 73);
            this.label10.TabIndex = 22;
            this.label10.Text = "Proceso de Cita     ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancelarCita
            // 
            this.btnCancelarCita.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarCita.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCita.Location = new System.Drawing.Point(78, 646);
            this.btnCancelarCita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarCita.Name = "btnCancelarCita";
            this.btnCancelarCita.Size = new System.Drawing.Size(245, 65);
            this.btnCancelarCita.TabIndex = 9;
            this.btnCancelarCita.Text = "Cancelar";
            this.btnCancelarCita.UseVisualStyleBackColor = false;
            // 
            // btnAgendarCita
            // 
            this.btnAgendarCita.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgendarCita.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgendarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendarCita.Enabled = false;
            this.btnAgendarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAgendarCita.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgendarCita.Location = new System.Drawing.Point(395, 646);
            this.btnAgendarCita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgendarCita.Name = "btnAgendarCita";
            this.btnAgendarCita.Size = new System.Drawing.Size(245, 65);
            this.btnAgendarCita.TabIndex = 10;
            this.btnAgendarCita.Text = "Agendar";
            this.btnAgendarCita.UseVisualStyleBackColor = false;
            // 
            // btnVerificarDUI
            // 
            this.btnVerificarDUI.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVerificarDUI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificarDUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificarDUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnVerificarDUI.ForeColor = System.Drawing.Color.White;
            this.btnVerificarDUI.Location = new System.Drawing.Point(545, 196);
            this.btnVerificarDUI.Margin = new System.Windows.Forms.Padding(0);
            this.btnVerificarDUI.Name = "btnVerificarDUI";
            this.btnVerificarDUI.Size = new System.Drawing.Size(93, 26);
            this.btnVerificarDUI.TabIndex = 11;
            this.btnVerificarDUI.Text = "Verificar";
            this.btnVerificarDUI.UseVisualStyleBackColor = false;
            this.btnVerificarDUI.Click += new System.EventHandler(this.btnVerificarDUI_Click);
            // 
            // btnVerificar02
            // 
            this.btnVerificar02.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVerificar02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificar02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar02.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnVerificar02.ForeColor = System.Drawing.Color.White;
            this.btnVerificar02.Location = new System.Drawing.Point(545, 431);
            this.btnVerificar02.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerificar02.Name = "btnVerificar02";
            this.btnVerificar02.Size = new System.Drawing.Size(93, 27);
            this.btnVerificar02.TabIndex = 12;
            this.btnVerificar02.Text = "Verificar";
            this.btnVerificar02.UseVisualStyleBackColor = false;
            this.btnVerificar02.Visible = false;
            this.btnVerificar02.Click += new System.EventHandler(this.btnVerificar02_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(533, 579);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(107, 28);
            this.btnSeleccionar.TabIndex = 13;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Visible = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(299, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnVerificar03
            // 
            this.btnVerificar03.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVerificar03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificar03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar03.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnVerificar03.ForeColor = System.Drawing.Color.White;
            this.btnVerificar03.Location = new System.Drawing.Point(547, 530);
            this.btnVerificar03.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerificar03.Name = "btnVerificar03";
            this.btnVerificar03.Size = new System.Drawing.Size(93, 27);
            this.btnVerificar03.TabIndex = 24;
            this.btnVerificar03.Text = "Guardar";
            this.btnVerificar03.UseVisualStyleBackColor = false;
            this.btnVerificar03.Visible = false;
            this.btnVerificar03.Click += new System.EventHandler(this.btnVerificar03_Click);
            // 
            // frmProcesoCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 722);
            this.Controls.Add(this.btnVerificar03);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnVerificar02);
            this.Controls.Add(this.btnVerificarDUI);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnAgendarCita);
            this.Controls.Add(this.btnCancelarCita);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcesoCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProcesoCita";
            this.Load += new System.EventHandler(this.frmProcesoCita_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnVerificar03;

        private System.Windows.Forms.ComboBox cmbEnfermedades;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button btnVerificar02;
        private System.Windows.Forms.Button btnSeleccionar;

        private System.Windows.Forms.TextBox txtCorreo_Usuario;

        private System.Windows.Forms.Label lblDUI;

        private System.Windows.Forms.Label lblFechaNacimiento;

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblEnfermedades;
        private System.Windows.Forms.Label lblIdentificador;

        private System.Windows.Forms.Button btnVerificarDUI;

        private System.Windows.Forms.Button btnB;

        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.TextBox txtFechaNacimiento_Usuario;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.TextBox txtDireccion_Usuario;
        private System.Windows.Forms.TextBox txtTelefono_Usuario;
        private System.Windows.Forms.TextBox txtEnfermedades_Usuario;
        private System.Windows.Forms.ComboBox cmbIdentificador_Usuario;

        private System.Windows.Forms.TextBox txtDUI_Usuario;
        private System.Windows.Forms.TextBox txtNombre_Usuario;

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Button btnCancelarCita;
        private System.Windows.Forms.Button btnAgendarCita;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}