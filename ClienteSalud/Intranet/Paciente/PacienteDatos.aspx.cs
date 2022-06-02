using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSalud.Intranet.Paciente
{
    public partial class PacienteDatos : System.Web.UI.Page
    {
        //Acceder al servicio web
        srPaciente.wsPacienteSoapClient servicio = new srPaciente.wsPacienteSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            // Agregar una escuela a la tabla Escuela
            string[] msj = servicio.Agregar(txtDni.Text, txtNombrePaciente.Text, txtApellidoPaciente.Text, txtDireccion.Text, txtGenero.Text, txtFechaNacimiento.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            // eliminar una escuela a la tabla Escuela
            string[] msj = servicio.Eliminar(txtDni.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizar una escuela a la tabla Escuela
            string[] msj = servicio.Actualizar(txtDni.Text, txtNombrePaciente.Text, txtApellidoPaciente.Text, txtDireccion.Text, txtGenero.Text, txtFechaNacimiento.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
        }
    }
}