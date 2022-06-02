using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSalud.Intranet.Triaje
{
    public partial class TriajeBuscar : System.Web.UI.Page
    {
        //Acceder al servicio web
        srTriaje.wsTriajeSoapClient servicio = new srTriaje.wsTriajeSoapClient();

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // Buscar un Triaje a la tabla Triaje
            gvTriaje.DataSource = servicio.Buscar(txtTexto.Text, txtCriterio.Text).Tables[0];
            gvTriaje.DataBind(); ;
        }
    }
}