namespace PROYECTO_FINAL_POO_Y_BD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_forgot = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_forgot);
            this.panel1.Controls.Add(this.btn_send);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_password);
            this.panel1.Controls.Add(this.textBox_username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 477);
            this.panel1.TabIndex = 0;
            // 
            // lbl_forgot
            // 
            this.lbl_forgot.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_forgot.ForeColor = System.Drawing.Color.Blue;
            this.lbl_forgot.Location = new System.Drawing.Point(515, 334);
            this.lbl_forgot.Name = "lbl_forgot";
            this.lbl_forgot.Size = new System.Drawing.Size(128, 13);
            this.lbl_forgot.TabIndex = 9;
            this.lbl_forgot.Text = "Olvide mi contraseña";
            this.lbl_forgot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.White;
            this.btn_send.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (255)))), ((int) (((byte) (255)))));
            this.btn_send.FlatAppearance.BorderSize = 2;
            this.btn_send.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (255)))), ((int) (((byte) (255)))));
            this.btn_send.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (255)))), ((int) (((byte) (255)))));
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_send.Location = new System.Drawing.Point(396, 322);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(89, 25);
            this.btn_send.TabIndex = 8;
            this.btn_send.Text = "Iniciar";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(396, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(396, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuario";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(396, 281);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(247, 20);
            this.textBox_password.TabIndex = 5;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(396, 225);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(247, 20);
            this.textBox_username.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(346, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Iniciar sesión";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(423, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-44, -20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(833, 507);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 473);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btn_send;
        public System.Windows.Forms.TextBox textBox_username;
        public System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label lbl_forgot;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}