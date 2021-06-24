using System.ComponentModel;

namespace PROYECTO_FINAL_POO_Y_BD
{
    partial class frmSeguimientoCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeguimientoCita));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.dtgShow = new System.Windows.Forms.DataGridView();
            this.lblSelectCita = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.cbCitas = new System.Windows.Forms.ComboBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dtgShow)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-241, -129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1138, 793);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnDescargar);
            this.panel1.Controls.Add(this.dtgShow);
            this.panel1.Controls.Add(this.lblSelectCita);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.cbCitas);
            this.panel1.Controls.Add(this.btnVerificar);
            this.panel1.Controls.Add(this.txtDUI);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(54, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 602);
            this.panel1.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(24, 549);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 41);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnEditar.FlatAppearance.BorderSize = 2;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(411, 549);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(154, 41);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar cita";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnDescargar
            // 
            this.btnDescargar.BackColor = System.Drawing.Color.HotPink;
            this.btnDescargar.Enabled = false;
            this.btnDescargar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnDescargar.FlatAppearance.BorderSize = 2;
            this.btnDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDescargar.ForeColor = System.Drawing.Color.White;
            this.btnDescargar.Location = new System.Drawing.Point(184, 548);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(220, 41);
            this.btnDescargar.TabIndex = 8;
            this.btnDescargar.Text = "Descargar PDF";
            this.btnDescargar.UseVisualStyleBackColor = false;
            // 
            // dtgShow
            // 
            this.dtgShow.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgShow.Location = new System.Drawing.Point(3, 197);
            this.dtgShow.Name = "dtgShow";
            this.dtgShow.Size = new System.Drawing.Size(584, 345);
            this.dtgShow.TabIndex = 7;
            // 
            // lblSelectCita
            // 
            this.lblSelectCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblSelectCita.ForeColor = System.Drawing.Color.White;
            this.lblSelectCita.Location = new System.Drawing.Point(163, 147);
            this.lblSelectCita.Name = "lblSelectCita";
            this.lblSelectCita.Size = new System.Drawing.Size(105, 20);
            this.lblSelectCita.TabIndex = 6;
            this.lblSelectCita.Text = "Seleccionar cita:";
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSelect.Enabled = false;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (192)))));
            this.btnSelect.FlatAppearance.BorderSize = 2;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(349, 167);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(82, 24);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.UseVisualStyleBackColor = false;
            // 
            // cbCitas
            // 
            this.cbCitas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCitas.Enabled = false;
            this.cbCitas.FormattingEnabled = true;
            this.cbCitas.Items.AddRange(new object[] {"Cita1", "Cita2"});
            this.cbCitas.Location = new System.Drawing.Point(163, 170);
            this.cbCitas.Name = "cbCitas";
            this.cbCitas.Size = new System.Drawing.Size(180, 21);
            this.cbCitas.TabIndex = 4;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificar.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVerificar.FlatAppearance.BorderSize = 3;
            this.btnVerificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVerificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.Location = new System.Drawing.Point(265, 108);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(95, 29);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(237, 82);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(155, 20);
            this.txtDUI.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(265, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de DUI:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(133, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestionar citas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSeguimientoCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmSeguimientoCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSeguimientoCita";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dtgShow)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnCancelar;

        private System.Windows.Forms.TextBox txtDUI;

        private System.Windows.Forms.Button btnEditar;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}