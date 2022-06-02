using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSalud.Intranet.Paciente
{
    public partial class PacienteBuscar : System.Web.UI.Page
    {
        //Acceder al servicio web
        srPaciente.wsPacienteSoapClient servicio = new srPaciente.wsPacienteSoapClient();

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // Buscar un Paciente en la tabla Paciente
            gvPaciente.DataSource = servicio.Buscar(txtTexto.Text, txtCriterio.Text).Tables[0];
            gvPaciente.DataBind(); ;
        }
    }
}