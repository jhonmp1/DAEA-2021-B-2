using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_09
{
    public partial class Person : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSaludar_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Hola " + txtNombre.Text + "');</script>");
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Hola " + txtNombre.Text + " usted fue registrado con el usuario "+ txtUsuario.Text +".');</script>");
        }
    }
}