using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//DATAGRIDVIEW CON UN CRUD BASICO
//FABRIZIO JAHIR ATIQUIPA MENDOZA
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string activo;
            if (chxActivo.Checked)
            {
                activo = "SI";
            }
            else
            {
                activo = "NO";
            }
            Random rnd = new Random();
            int numero = rnd.Next(111111, 999999);
            string dni = txtDNI.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            string time = dateTime.Text;
            string departamento = cmbDepartamento.Text;
            string cargo = cmbCargo.Text;
            dgvUsuarios.Rows.Add(numero, dni, nombre, apellido, direccion, telefono, email, time, departamento, cargo, activo);
            limpiar();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string activo;
            if (chxActivo.Checked)
            {
                activo = "SI";
            }
            else
            {
                activo = "NO";
            }
            dgvUsuarios.CurrentRow.Cells[1].Value = txtDNI.Text;
            dgvUsuarios.CurrentRow.Cells[2].Value = txtNombre.Text;
            dgvUsuarios.CurrentRow.Cells[3].Value = txtApellido.Text;
            dgvUsuarios.CurrentRow.Cells[4].Value = txtDireccion.Text;
            dgvUsuarios.CurrentRow.Cells[5].Value = txtTelefono.Text;
            dgvUsuarios.CurrentRow.Cells[6].Value = txtEmail.Text;
            dgvUsuarios.CurrentRow.Cells[7].Value = dateTime.Text;
            dgvUsuarios.CurrentRow.Cells[8].Value = cmbDepartamento.Text;
            dgvUsuarios.CurrentRow.Cells[9].Value = cmbCargo.Text;
            dgvUsuarios.CurrentRow.Cells[10].Value = activo;
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.Rows.RemoveAt(dgvUsuarios.CurrentRow.Index);
            limpiar();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string activo;
            txtDNI.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtApellido.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
            txtTelefono.Text = dgvUsuarios.CurrentRow.Cells[5].Value.ToString();
            txtEmail.Text = dgvUsuarios.CurrentRow.Cells[6].Value.ToString();
            dateTime.Text = dgvUsuarios.CurrentRow.Cells[7].Value.ToString();
            cmbDepartamento.Text = dgvUsuarios.CurrentRow.Cells[8].Value.ToString();
            cmbCargo.Text = dgvUsuarios.CurrentRow.Cells[9].Value.ToString();
            activo = dgvUsuarios.CurrentRow.Cells[10].Value.ToString();
            if (activo == "SI")
            {
                chxActivo.Checked = true;
            }
            else
            {
                chxActivo.Checked = false;
            }
        }
        private void limpiar()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }
        
    }
}
