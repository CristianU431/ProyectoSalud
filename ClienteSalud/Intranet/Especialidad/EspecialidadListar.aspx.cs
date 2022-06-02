using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSalud.Intranet.Especialidad
{
    public partial class EspecialidadListar : System.Web.UI.Page
    {
        //Acceder al servicio web
        srEspecialidad.wsEspecialidadSoapClient servicio = new srEspecialidad.wsEspecialidadSoapClient();

        //Metodo para listar Especialidad
        private void Listar()
        {
            gvEspecialidad.DataSource = servicio.Listar().Tables[0];
            gvEspecialidad.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Solo debe cargar la primera vez
            if (!Page.IsPostBack)
                Listar();
        }
    }
}