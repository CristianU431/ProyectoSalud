using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSalud.Intranet.Medico
{
    public partial class MedicoListar : System.Web.UI.Page
    {
        //Acceder al servicio web
        srMedico.wsMedicoSoapClient servicio = new srMedico.wsMedicoSoapClient();

        //Metodo para listar Medico
        private void Listar()
        {
            gvMedico.DataSource = servicio.Listar().Tables[0];
            gvMedico.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Solo debe cargar la primera vez
            if (!Page.IsPostBack)
                Listar();
        }
    }
}