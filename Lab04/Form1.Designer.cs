
namespace Lab03
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPersona = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.chkAutenticacion = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtBaseDatos = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.btnCurso = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCurso);
            this.panel1.Controls.Add(this.btnPersona);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnDesconectar);
            this.panel1.Controls.Add(this.btnEstado);
            this.panel1.Controls.Add(this.btnConectar);
            this.panel1.Controls.Add(this.chkAutenticacion);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtBaseDatos);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtServidor);
            this.panel1.Location = new System.Drawing.Point(7, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 221);
            this.panel1.TabIndex = 0;
            // 
            // btnPersona
            // 
            this.btnPersona.Location = new System.Drawing.Point(156, 191);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(75, 23);
            this.btnPersona.TabIndex = 13;
            this.btnPersona.Text = "Persona";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Usuario";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Enabled = false;
            this.btnDesconectar.Location = new System.Drawing.Point(289, 159);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(81, 23);
            this.btnDesconectar.TabIndex = 11;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(200, 159);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(75, 23);
            this.btnEstado.TabIndex = 10;
            this.btnEstado.Text = "Estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(111, 159);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 9;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // chkAutenticacion
            // 
            this.chkAutenticacion.AutoSize = true;
            this.chkAutenticacion.Checked = true;
            this.chkAutenticacion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutenticacion.Location = new System.Drawing.Point(19, 121);
            this.chkAutenticacion.Name = "chkAutenticacion";
            this.chkAutenticacion.Size = new System.Drawing.Size(143, 17);
            this.chkAutenticacion.TabIndex = 8;
            this.chkAutenticacion.Text = "Autentificacion integrada";
            this.chkAutenticacion.UseVisualStyleBackColor = true;
            this.chkAutenticacion.CheckedChanged += new System.EventHandler(this.chkAutenticacion_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(241, 85);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(212, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // txtBaseDatos
            // 
            this.txtBaseDatos.Location = new System.Drawing.Point(19, 85);
            this.txtBaseDatos.Name = "txtBaseDatos";
            this.txtBaseDatos.Size = new System.Drawing.Size(212, 20);
            this.txtBaseDatos.TabIndex = 6;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(241, 32);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(212, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Base de Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(19, 32);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(212, 20);
            this.txtServidor.TabIndex = 4;
            this.txtServidor.TextChanged += new System.EventHandler(this.txtServidor_TextChanged);
            // 
            // btnCurso
            // 
            this.btnCurso.Location = new System.Drawing.Point(237, 191);
            this.btnCurso.Name = "btnCurso";
            this.btnCurso.Size = new System.Drawing.Size(75, 23);
            this.btnCurso.TabIndex = 14;
            this.btnCurso.Text = "Curso";
            this.btnCurso.UseVisualStyleBackColor = true;
            this.btnCurso.Click += new System.EventHandler(this.btnCurso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 282);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.CheckBox chkAutenticacion;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtBaseDatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPersona;
        private System.Windows.Forms.Button btnCurso;
    }
}

