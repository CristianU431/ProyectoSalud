using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSalud.Intranet.Historial
{
    public partial class HistorialBuscar : System.Web.UI.Page
    {
        //Acceder al servicio web
        srHistorial.wsHistorialSoapClient servicio = new srHistorial.wsHistorialSoapClient();

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // Buscar un Historial a la tabla Historial
            gvHistorial.DataSource = servicio.Buscar(txtTexto.Text, txtCriterio.Text).Tables[0];
            gvHistorial.DataBind(); ;
        }
    }
}