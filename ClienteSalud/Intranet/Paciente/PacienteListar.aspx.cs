using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSalud.Intranet.Paciente
{
    public partial class PacienteListar : System.Web.UI.Page
    {
        //Acceder al servicio web
        srPaciente.wsPacienteSoapClient servicio = new srPaciente.wsPacienteSoapClient();

        //Metodo para listar Paciente
        private void Listar()
        {
            gvPaciente.DataSource = servicio.Listar().Tables[0];
            gvPaciente.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Solo debe cargar la primera vez
            if (!Page.IsPostBack)
                Listar();
        }
    }
}