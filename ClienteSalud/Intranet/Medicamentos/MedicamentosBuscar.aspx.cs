using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteSalud.Intranet.Medicamentos
{
    public partial class MedicamentosBuscar : System.Web.UI.Page
    {
        //Acceder al servicio web
        srMedicamentos.wsMedicamentosSoapClient servicio = new srMedicamentos.wsMedicamentosSoapClient();

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // Buscar un Medicamento en la tabla Medicamentos
            gvMedicamentos.DataSource = servicio.Buscar(txtTexto.Text, txtCriterio.Text).Tables[0];
            gvMedicamentos.DataBind(); ;
        }
    }
}