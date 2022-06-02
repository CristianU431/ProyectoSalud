using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using CapaNegocio;
using CapaEntidad;
using System.Data;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de wsMedicamentos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsMedicamentos : System.Web.Services.WebService
    {

        [WebMethod(Description = "Listar Medicamentos")]
        public DataSet Listar()
        {
            MedicamentosBL medicamentos = new MedicamentosBL();
            return medicamentos.Listar();
        }

        [WebMethod(Description = "Agregar Medicamentos")]
        public string[] Agregar(string IdMedicamentos, string NombreMedicamentos, string TipoMedicamento, string Detalle, string cantidad)
        {
            MedicamentosBL medicamentosBL = new MedicamentosBL();
            Medicamentos medicamentos = new Medicamentos();
            medicamentos.IdMedicamentos1 = IdMedicamentos;
            medicamentos.NombreMedicamentos1 = NombreMedicamentos;
            medicamentos.TipoMedicamento1 = TipoMedicamento;
            medicamentos.Detalle1 = Detalle;
            medicamentos.Cantidad = cantidad;
            string[] valores = new string[2];
            valores[0] = medicamentosBL.Agregar(medicamentos).ToString();
            valores[1] = medicamentosBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Actualizar Medicamentos")]
        public string[] Actualizar(string IdMedicamentos, string NombreMedicamentos, string TipoMedicamento, string Detalle, string cantidad)
        {
            MedicamentosBL medicamentosBL = new MedicamentosBL();
            Medicamentos medicamentos = new Medicamentos();
            medicamentos.IdMedicamentos1 = IdMedicamentos;
            medicamentos.NombreMedicamentos1 = NombreMedicamentos;
            medicamentos.TipoMedicamento1 = TipoMedicamento;
            medicamentos.Detalle1 = Detalle;
            medicamentos.Cantidad = cantidad;
            string[] valores = new string[2];
            valores[0] = medicamentosBL.Actualizar(medicamentos).ToString();
            valores[1] = medicamentosBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Eliminar Medicamentos")]
        public string[] Eliminar(string IdMedicamentos)
        {
            MedicamentosBL medicamentosBL = new MedicamentosBL();
            string[] valores = new string[2];
            valores[0] = medicamentosBL.Eliminar(IdMedicamentos).ToString();
            valores[1] = medicamentosBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Buscar Medicamentos")]
        public DataSet Buscar(string texto, string criterio)
        {
            MedicamentosBL medicamentos = new MedicamentosBL();
            return medicamentos.Buscar(texto, criterio);
        }

    }
}
