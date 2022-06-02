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
    /// Descripción breve de wsLaboratorio
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsLaboratorio : System.Web.Services.WebService
    {

        [WebMethod(Description = "Listar Laboratorio")]
        public DataSet Listar()
        {
            LaboratorioBL laboratorio = new LaboratorioBL();
            return laboratorio.Listar();
        }

        [WebMethod(Description = "Agregar Laboratorio")]
        public string[] Agregar(string Idlab, string TipoLab, string NombreLab, string Dni, string Resultado, string CodMedico)
        {
            LaboratorioBL laboratorioBL = new LaboratorioBL();
            Laboratorio laboratorio = new Laboratorio();
            laboratorio.Idlab1 = Idlab;
            laboratorio.TipoLab1 = TipoLab;
            laboratorio.NombreLab1 = NombreLab;
            laboratorio.Dni1 = Dni;
            laboratorio.Resultado1 = Resultado;
            laboratorio.CodMedico1 = CodMedico;
            string[] valores = new string[2];
            valores[0] = laboratorioBL.Agregar(laboratorio).ToString();
            valores[1] = laboratorioBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Actualizar Laboratorio")]
        public string[] Actualizar(string Idlab, string TipoLab, string NombreLab, string Dni, string Resultado, string CodMedico)
        {
            LaboratorioBL laboratorioBL = new LaboratorioBL();
            Laboratorio laboratorio = new Laboratorio();
            laboratorio.Idlab1 = Idlab;
            laboratorio.TipoLab1 = TipoLab;
            laboratorio.NombreLab1 = NombreLab;
            laboratorio.Dni1 = Dni;
            laboratorio.Resultado1 = Resultado;
            laboratorio.CodMedico1 = CodMedico;
            string[] valores = new string[2];
            valores[0] = laboratorioBL.Actualizar(laboratorio).ToString();
            valores[1] = laboratorioBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Eliminar Laboratorio")]
        public string[] Eliminar(string Idlab)
        {
            LaboratorioBL laboratorioBL = new LaboratorioBL();
            string[] valores = new string[2];
            valores[0] = laboratorioBL.Eliminar(Idlab).ToString();
            valores[1] = laboratorioBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Buscar Laboratorio")]
        public DataSet Buscar(string texto, string criterio)
        {
            LaboratorioBL laboratorio = new LaboratorioBL();
            return laboratorio.Buscar(texto, criterio);
        }

    }
}
