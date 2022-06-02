using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSalud.Intranet.Receta
{
    public partial class RecetaListar : System.Web.UI.Page
    {
        //Acceder al servicio web
        srReceta.wsRecetaSoapClient servicio = new srReceta.wsRecetaSoapClient();

        //Metodo para listar Receta
        private void Listar()
        {
            gvReceta.DataSource = servicio.Listar().Tables[0];
            gvReceta.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Solo debe cargar la primera vez
            if (!Page.IsPostBack)
                Listar();
        }
    }
}