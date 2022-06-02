using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSalud.Intranet.Medico
{
    public partial class MedicoBuscar : System.Web.UI.Page
    {
        //Acceder al servicio web
        srMedico.wsMedicoSoapClient servicio = new srMedico.wsMedicoSoapClient();

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // Buscar un Medico a la tabla Medico
            gvMedico.DataSource = servicio.Buscar(txtTexto.Text, txtCriterio.Text).Tables[0];
            gvMedico.DataBind(); ;
        }
    }
}