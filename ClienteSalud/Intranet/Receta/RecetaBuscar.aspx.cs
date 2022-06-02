using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSalud.Intranet.Receta
{
    public partial class RecetaBuscar : System.Web.UI.Page
    {
        //Acceder al servicio web
        srReceta.wsRecetaSoapClient servicio = new srReceta.wsRecetaSoapClient();

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // Buscar un Receta en la tabla Receta
            gvReceta.DataSource = servicio.Buscar(txtTexto.Text, txtCriterio.Text).Tables[0];
            gvReceta.DataBind(); ;
        }
    }
}