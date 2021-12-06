using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string[,] arreglo = { { "fabrizio", "jahir", "Atiquipa" }, { "123", "456", "789" } };

            if (txtUsuario.Text == arreglo[0, 1] && txtPassword.Text == arreglo[1, 1])
            {
                PRINCIPLAMDI principal = new PRINCIPLAMDI();
                principal.Show();
                this.Hide();
            }
            else
            {
                    MessageBox.Show("Error de autenticacion, verifique usuario y/O contraseña ó es posible que su cuenta este inhabilitada", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Text = "";
            }
        }
    }
}
