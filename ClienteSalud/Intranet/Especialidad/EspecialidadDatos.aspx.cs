using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSalud.Intranet.Especialidad
{
    public partial class EspecialidadDatos : System.Web.UI.Page
    {
        //Acceder al servicio web
        srEspecialidad.wsEspecialidadSoapClient servicio = new srEspecialidad.wsEspecialidadSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            // Agregar una escuela a la tabla Especialidad
            string[] msj = servicio.Agregar(txtId.Text, txtNombreEspecialidad.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            // eliminar una escuela a la tabla Especialidad
            string[] msj = servicio.Eliminar(txtId.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizar una escuela a la tabla Especialidad
            string[] msj = servicio.Actualizar(txtId.Text, txtNombreEspecialidad.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
        }
    }
}