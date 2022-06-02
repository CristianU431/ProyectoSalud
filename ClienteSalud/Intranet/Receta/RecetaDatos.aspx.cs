using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSalud.Intranet.Receta
{
    public partial class RecetaDatos : System.Web.UI.Page
    {
        //Acceder al servicio web
        srReceta.wsRecetaSoapClient servicio = new srReceta.wsRecetaSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            // Agregar una escuela a la tabla Receta
            string[] msj = servicio.Agregar(txtId.Text, txtDni.Text, txtEnfermedad.Text, txtIdMedicamentos.Text, txtDescipcion.Text, txtFechaInicio.Text, txtFechaLimite.Text, txtTipoReceta.Text, txtCodMedico.Text, txtIdConsultorio.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            // eliminar una escuela a la tabla Receta
            string[] msj = servicio.Eliminar(txtId.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizar una escuela a la tabla Receta
            string[] msj = servicio.Actualizar(txtId.Text, txtDni.Text, txtEnfermedad.Text, txtIdMedicamentos.Text, txtDescipcion.Text, txtFechaInicio.Text, txtFechaLimite.Text, txtTipoReceta.Text, txtCodMedico.Text, txtIdConsultorio.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
        }
    }
}