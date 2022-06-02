using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSalud.Intranet.Consultorio
{
    public partial class ConsultorioBuscar : System.Web.UI.Page
    {
        //Acceder al servicio web
        srConsultorio.wsConsultorioSoapClient servicio = new srConsultorio.wsConsultorioSoapClient();

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // Buscar un Consultorio a la tabla Consultorio
            gvConsultorio.DataSource = servicio.Buscar(txtTexto.Text, txtCriterio.Text).Tables[0];
            gvConsultorio.DataBind(); ;
        }
    }
}