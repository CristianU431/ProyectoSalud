using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSalud.Intranet.Consultorio
{
    public partial class ConsultorioListar : System.Web.UI.Page
    {
        //Acceder al servicio web
        srConsultorio.wsConsultorioSoapClient servicio = new srConsultorio.wsConsultorioSoapClient();

        //Metodo para listar Consultorio
        private void Listar()
        {
            gvConsultorio.DataSource = servicio.Listar().Tables[0];
            gvConsultorio.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Solo debe cargar la primera vez
            if (!Page.IsPostBack)
                Listar();
        }
    }
}