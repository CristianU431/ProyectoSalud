using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSalud.Intranet.Historial
{
    public partial class HistorialListar : System.Web.UI.Page
    {
        //Acceder al servicio web
        srHistorial.wsHistorialSoapClient servicio = new srHistorial.wsHistorialSoapClient();

        //Metodo para listar Historial
        private void Listar()
        {
            gvHistorial.DataSource = servicio.Listar().Tables[0];
            gvHistorial.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Solo debe cargar la primera vez
            if (!Page.IsPostBack)
                Listar();
        }
    }
}