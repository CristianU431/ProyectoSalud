using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSalud.Intranet.Triaje
{
    public partial class TriajeDatos : System.Web.UI.Page
    {
        //Acceder al servicio web
        srTriaje.wsTriajeSoapClient servicio = new srTriaje.wsTriajeSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            // Agregar una escuela a la tabla Triaje
            string[] msj = servicio.Agregar(txtId.Text, txtDni.Text, txtTalla.Text, txtSintomas.Text, txtPeso.Text, txtTemperatura.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            // eliminar una escuela a la tabla Triaje
            string[] msj = servicio.Eliminar(txtId.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizar una escuela a la tabla Triaje
            string[] msj = servicio.Actualizar(txtId.Text, txtDni.Text, txtTalla.Text, txtSintomas.Text, txtPeso.Text, txtTemperatura.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
        }
    }
}