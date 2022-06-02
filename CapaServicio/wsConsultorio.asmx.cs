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
    /// Descripción breve de wsConsultorio
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsConsultorio : System.Web.Services.WebService
    {

        [WebMethod(Description = "Listar Consultorio")]
        public DataSet Listar()
        {
            ConsultorioBL consultorio = new ConsultorioBL();
            return consultorio.Listar();
        }

        [WebMethod(Description = "Agregar Consultorio")]
        public string[] Agregar(string IdConsultorio, string NumConsultorio, string CodMedico, string IdEspecialidad)
        {
            ConsultorioBL consultorioBL = new ConsultorioBL();
            Consultorio Consultorio = new Consultorio();
            Consultorio.IdConsultorio1 = IdConsultorio;
            Consultorio.NumConsultorio1 = NumConsultorio;
            Consultorio.CodMedico1 = CodMedico;
            Consultorio.IdEspecialidad1 = IdEspecialidad;
            string[] valores = new string[2];
            valores[0] = consultorioBL.Agregar(Consultorio).ToString();
            valores[1] = consultorioBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Actualizar Consultorio")]
        public string[] Actualizar(string IdConsultorio, string NumConsultorio, string CodMedico, string IdEspecialidad)
        {
            ConsultorioBL consultorioBL = new ConsultorioBL();
            Consultorio consultorio = new Consultorio();
            consultorio.IdConsultorio1 = IdConsultorio;
            consultorio.NumConsultorio1 = NumConsultorio;
            consultorio.CodMedico1 = CodMedico;
            consultorio.IdEspecialidad1 = IdEspecialidad;
            string[] valores = new string[2];
            valores[0] = consultorioBL.Actualizar(consultorio).ToString();
            valores[1] = consultorioBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Eliminar Consultorio")]
        public string[] Eliminar(string IdConsultorio)
        {
            ConsultorioBL consultorioBL = new ConsultorioBL();
            string[] valores = new string[2];
            valores[0] = consultorioBL.Eliminar(IdConsultorio).ToString();
            valores[1] = consultorioBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Buscar Consultorio")]
        public DataSet Buscar(string texto, string criterio)
        {
            ConsultorioBL consultorio = new ConsultorioBL();
            return consultorio.Buscar(texto, criterio);
        }

    }
}
