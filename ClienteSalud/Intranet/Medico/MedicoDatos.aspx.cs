using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSalud.Intranet.Medico
{
    public partial class MedicoDatos : System.Web.UI.Page
    {
        //Acceder al servicio web
        srMedico.wsMedicoSoapClient servicio = new srMedico.wsMedicoSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            // Agregar una escuela a la tabla Medico
            string[] msj = servicio.Agregar(txtCod.Text, txtNombreMedico.Text, txtApellidoMedico.Text, txtIdEspecialidad.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            // eliminar una escuela a la tabla Medico
            string[] msj = servicio.Eliminar(txtCod.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizar una escuela a la tabla Medico
            string[] msj = servicio.Actualizar(txtCod.Text, txtNombreMedico.Text, txtApellidoMedico.Text, txtIdEspecialidad.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
        }
    }
}