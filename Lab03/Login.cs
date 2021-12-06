using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            login();
        }
        private void login()
        {
            SqlConnection cn = new SqlConnection("Server=DESKTOP-4OJ54RK\\SQLEXPRESS2017; DataBase=db_lab03;Integrated Security=true");
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT usuario_nombre,usuario_password FROM tbl_usuario WHERE usuario_nombre='"+txtUsuario.Text+ "' and usuario_password='"+txtPassword.Text+"'", cn);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error de autenticacion, verifique usuario y/O contraseña ó es posible que su cuenta este inhabilitada", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
