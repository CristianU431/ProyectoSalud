using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSalud.Intranet.Triaje
{
    public partial class TriajeListar : System.Web.UI.Page
    {
        //Acceder al servicio web
        srTriaje.wsTriajeSoapClient servicio = new srTriaje.wsTriajeSoapClient();

        //Metodo para listar Triaje
        private void Listar()
        {
            gvTriaje.DataSource = servicio.Listar().Tables[0];
            gvTriaje.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Solo debe cargar la primera vez
            if (!Page.IsPostBack)
                Listar();
        }
    }
}