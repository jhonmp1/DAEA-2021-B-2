using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab06
{
    public partial class Cursos : Form
    {
        SqlConnection con;
        DataSet ds = new DataSet();
        DataTable tableCourse = new DataTable();
        public Cursos()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM Course";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            adapter.Fill(ds, "Course");

            tableCourse = ds.Tables["Course"];

            dgvListado.DataSource = tableCourse;
            dgvListado.Update();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(tableCourse);
            dv.RowFilter = "CourseID = '" + txtCursoID.Text + "'";
            dgvListado.DataSource = dv;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("InsertCourse", con);
            cmd.Parameters.Add("@CourseID", SqlDbType.VarChar, 50, "CourseID");
            cmd.Parameters.Add("@Title", SqlDbType.VarChar, 50, "Title");
            cmd.Parameters.Add("@Credits", SqlDbType.Int, 50, "Credits");
            cmd.Parameters.Add("@DepartmentID", SqlDbType.Int, 50, "DepartmentID");

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = cmd;
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;

            DataRow fila = tableCourse.NewRow();
            fila["CourseID"] = txtCursoID.Text;
            fila["Title"] = txtTitulo.Text;
            fila["Credits"] = txtCredito.Text;
            fila["DepartmentID"] = txtDepartamento.Text;

            tableCourse.Rows.Add(fila);

            adapter.Update(tableCourse);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtCursoID.Enabled = false;
            SqlCommand cmd = new SqlCommand("UpdateCourse", con);
            cmd.Parameters.Add("@CourseID", SqlDbType.VarChar).SourceColumn = "CourseID";
            cmd.Parameters.Add("@Title", SqlDbType.VarChar).SourceColumn = "Title";
            cmd.Parameters.Add("@Credits", SqlDbType.Int).SourceColumn = "Credits";
            cmd.Parameters.Add("@DepartmentID", SqlDbType.Int).SourceColumn = "DepartmentID";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = cmd;
            adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;

            DataRow[] fila = tableCourse.Select("CourseID = '" + txtCursoID.Text + "'");
            fila[0]["Title"] = txtTitulo.Text;
            fila[0]["Credits"] = txtCredito.Text;
            fila[0]["DepartmentID"] = txtDepartamento.Text;

            adapter.Update(tableCourse);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DeletePerson", con);
            cmd.Parameters.Add("@PersonID", SqlDbType.Int).SourceColumn = "PersonID";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = cmd;
            adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;
            DataRow[] fila = tableCourse.Select("PersonID = '" + txtCursoID.Text + "'");
            tableCourse.Rows.Remove(fila[0]);
            adapter.Update(tableCourse);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(tableCourse);
            dv.Sort = "Title ASC";
            dgvListado.DataSource = dv;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCursoID.Text = "";
            txtTitulo.Text = "";
            txtCredito.Text = "";
            txtDepartamento.Text = "";
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            String str = "Server = DESKTOP-4OJ54RK\\SQLEXPRESS2017;DataBase=School;Integrated Security=true";
            con = new SqlConnection(str);
        }

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                txtCursoID.Text = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
                txtTitulo.Text = dgvListado.SelectedRows[0].Cells[1].Value.ToString();
                txtCredito.Text = dgvListado.SelectedRows[0].Cells[2].Value.ToString();
                txtDepartamento.Text = dgvListado.SelectedRows[0].Cells[3].Value.ToString();

            }
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            ManPerson per = new ManPerson();
            per.Show();
            this.Hide();
        }
    }
}
