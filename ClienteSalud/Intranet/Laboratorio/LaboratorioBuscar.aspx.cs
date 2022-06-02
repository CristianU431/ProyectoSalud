using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSalud.Intranet.Laboratorio
{
    public partial class LaboratorioBuscar : System.Web.UI.Page
    {
        //Acceder al servicio web
        srLaboratorio.wsLaboratorioSoapClient servicio = new srLaboratorio.wsLaboratorioSoapClient();

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // Buscar un Analisis de Laboratorio a la tabla AnalisisLaboratorio
            gvLaboratorio.DataSource = servicio.Buscar(txtTexto.Text, txtCriterio.Text).Tables[0];
            gvLaboratorio.DataBind(); ;
        }
    }
}