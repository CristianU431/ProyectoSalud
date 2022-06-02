using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSalud.Intranet.Laboratorio
{
    public partial class LaboratorioListar : System.Web.UI.Page
    {
        //Acceder al servicio web
        srLaboratorio.wsLaboratorioSoapClient servicio = new srLaboratorio.wsLaboratorioSoapClient();

        //Metodo para listar Laboratorio
        private void Listar()
        {
            gvLaboratorio.DataSource = servicio.Listar().Tables[0];
            gvLaboratorio.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Solo debe cargar la primera vez
            if (!Page.IsPostBack)
                Listar();
        }
    }
}