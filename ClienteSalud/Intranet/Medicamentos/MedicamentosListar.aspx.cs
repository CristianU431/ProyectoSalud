using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSalud.Intranet.Medicamentos
{
    public partial class MedicamentosListar : System.Web.UI.Page
    {
        //Acceder al servicio web
        srMedicamentos.wsMedicamentosSoapClient servicio = new srMedicamentos.wsMedicamentosSoapClient();

        //Metodo para listar Medicamentos
        private void Listar()
        {
            gvMedicamentos.DataSource = servicio.Listar().Tables[0];
            gvMedicamentos.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Solo debe cargar la primera vez
            if (!Page.IsPostBack)
                Listar();
        }
    }
}