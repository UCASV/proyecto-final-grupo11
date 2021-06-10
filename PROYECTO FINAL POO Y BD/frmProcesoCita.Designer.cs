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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTituloCita = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelarCita = new System.Windows.Forms.Button();
            this.btnAgendarCita = new System.Windows.Forms.Button();
            this.txtDUI_Usuario = new System.Windows.Forms.TextBox();
            this.txtNombre_Usuario = new System.Windows.Forms.TextBox();
            this.txtDireccion_Usuario = new System.Windows.Forms.TextBox();
            this.txtTelefono_Usuario = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtEnfermedades_Usuario = new System.Windows.Forms.TextBox();
            this.txtNumeroIdentificador_Usuario = new System.Windows.Forms.TextBox();
            this.cmbIdentificador_Usuario = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.lblTituloCita, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelarCita, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.btnAgendarCita, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtDUI_Usuario, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNombre_Usuario, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDireccion_Usuario, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTelefono_Usuario, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtEnfermedades_Usuario, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtNumeroIdentificador_Usuario, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.cmbIdentificador_Usuario, 2, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(627, 527);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblTituloCita
            // 
            this.lblTituloCita.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.lblTituloCita, 2);
            this.lblTituloCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTituloCita.Location = new System.Drawing.Point(65, 0);
            this.lblTituloCita.Name = "lblTituloCita";
            this.lblTituloCita.Size = new System.Drawing.Size(494, 53);
            this.lblTituloCita.TabIndex = 0;
            this.lblTituloCita.Text = "Proceso de Cita";
            this.lblTituloCita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(65, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "DUI:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(65, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 53);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(65, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 53);
            this.label3.TabIndex = 3;
            this.label3.Text = "Direccion:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(65, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 53);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefono:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(65, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 53);
            this.label5.TabIndex = 5;
            this.label5.Text = "Correo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(65, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 53);
            this.label6.TabIndex = 6;
            this.label6.Text = "Enfermedades:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(65, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 53);
            this.label7.TabIndex = 7;
            this.label7.Text = "Identificador institucion escencial:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(65, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 53);
            this.label8.TabIndex = 8;
            this.label8.Text = "Numero de identificador:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCancelarCita
            // 
            this.btnCancelarCita.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarCita.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelarCita.Location = new System.Drawing.Point(65, 480);
            this.btnCancelarCita.Name = "btnCancelarCita";
            this.btnCancelarCita.Size = new System.Drawing.Size(244, 44);
            this.btnCancelarCita.TabIndex = 9;
            this.btnCancelarCita.Text = "Cancelar";
            this.btnCancelarCita.UseVisualStyleBackColor = false;
            // 
            // btnAgendarCita
            // 
            this.btnAgendarCita.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgendarCita.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgendarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAgendarCita.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgendarCita.Location = new System.Drawing.Point(315, 480);
            this.btnAgendarCita.Name = "btnAgendarCita";
            this.btnAgendarCita.Size = new System.Drawing.Size(244, 44);
            this.btnAgendarCita.TabIndex = 10;
            this.btnAgendarCita.Text = "Agendar";
            this.btnAgendarCita.UseVisualStyleBackColor = false;
            // 
            // txtDUI_Usuario
            // 
            this.txtDUI_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDUI_Usuario.Location = new System.Drawing.Point(315, 56);
            this.txtDUI_Usuario.Name = "txtDUI_Usuario";
            this.txtDUI_Usuario.Size = new System.Drawing.Size(244, 22);
            this.txtDUI_Usuario.TabIndex = 11;
            // 
            // txtNombre_Usuario
            // 
            this.txtNombre_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre_Usuario.Location = new System.Drawing.Point(315, 109);
            this.txtNombre_Usuario.Name = "txtNombre_Usuario";
            this.txtNombre_Usuario.Size = new System.Drawing.Size(244, 22);
            this.txtNombre_Usuario.TabIndex = 12;
            // 
            // txtDireccion_Usuario
            // 
            this.txtDireccion_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion_Usuario.Location = new System.Drawing.Point(315, 162);
            this.txtDireccion_Usuario.Name = "txtDireccion_Usuario";
            this.txtDireccion_Usuario.Size = new System.Drawing.Size(244, 22);
            this.txtDireccion_Usuario.TabIndex = 13;
            // 
            // txtTelefono_Usuario
            // 
            this.txtTelefono_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono_Usuario.Location = new System.Drawing.Point(315, 215);
            this.txtTelefono_Usuario.Name = "txtTelefono_Usuario";
            this.txtTelefono_Usuario.Size = new System.Drawing.Size(244, 22);
            this.txtTelefono_Usuario.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(315, 268);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(244, 22);
            this.textBox5.TabIndex = 15;
            // 
            // txtEnfermedades_Usuario
            // 
            this.txtEnfermedades_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnfermedades_Usuario.Location = new System.Drawing.Point(315, 321);
            this.txtEnfermedades_Usuario.Multiline = true;
            this.txtEnfermedades_Usuario.Name = "txtEnfermedades_Usuario";
            this.txtEnfermedades_Usuario.Size = new System.Drawing.Size(244, 47);
            this.txtEnfermedades_Usuario.TabIndex = 16;
            // 
            // txtNumeroIdentificador_Usuario
            // 
            this.txtNumeroIdentificador_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroIdentificador_Usuario.Location = new System.Drawing.Point(315, 427);
            this.txtNumeroIdentificador_Usuario.Name = "txtNumeroIdentificador_Usuario";
            this.txtNumeroIdentificador_Usuario.Size = new System.Drawing.Size(244, 22);
            this.txtNumeroIdentificador_Usuario.TabIndex = 18;
            // 
            // cmbIdentificador_Usuario
            // 
            this.cmbIdentificador_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIdentificador_Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdentificador_Usuario.FormattingEnabled = true;
            this.cmbIdentificador_Usuario.Items.AddRange(new object[] {"Ninguno", "Educacion", "Salud", "Policia Nacional Civil", "Gobierno", "Fuerza Armada", "Periodismo"});
            this.cmbIdentificador_Usuario.Location = new System.Drawing.Point(315, 374);
            this.cmbIdentificador_Usuario.Name = "cmbIdentificador_Usuario";
            this.cmbIdentificador_Usuario.Size = new System.Drawing.Size(244, 24);
            this.cmbIdentificador_Usuario.TabIndex = 19;
            // 
            // frmProcesoCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 551);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcesoCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProcesoCita";
            this.Load += new System.EventHandler(this.frmProcesoCita_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtNumeroIdentificador_Usuario;

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

        private System.Windows.Forms.Label lblTituloCita;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}