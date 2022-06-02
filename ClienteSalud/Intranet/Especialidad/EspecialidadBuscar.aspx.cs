using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSalud.Intranet.Especialidad
{
    public partial class EspecialidadBuscar : System.Web.UI.Page
    {
        //Acceder al servicio web
        srEspecialidad.wsEspecialidadSoapClient servicio = new srEspecialidad.wsEspecialidadSoapClient();

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // Buscar un Especialidad a la tabla Especialidad
            gvEspecialidad.DataSource = servicio.Buscar(txtTexto.Text, txtCriterio.Text).Tables[0];
            gvEspecialidad.DataBind(); ;
        }
    }
}