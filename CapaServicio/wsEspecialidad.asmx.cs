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
    /// Descripción breve de wsEspecialidad
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsEspecialidad : System.Web.Services.WebService
    {

        [WebMethod(Description = "Listar Especialidad")]
        public DataSet Listar()
        {
            EspecialidadBL especialidad = new EspecialidadBL();
            return especialidad.Listar();
        }

        [WebMethod(Description = "Agregar Especialidad")]
        public string[] Agregar(string IdEspecialidad, string NombreEspecialidad)
        {
            EspecialidadBL especialidadBL = new EspecialidadBL();
            Especialidad especialidad = new Especialidad();
            especialidad.IdEspecialidad1 = IdEspecialidad;
            especialidad.NombreEspecialidad1 = NombreEspecialidad;
            string[] valores = new string[2];
            valores[0] = especialidadBL.Agregar(especialidad).ToString();
            valores[1] = especialidadBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Actualizar Especialidad")]
        public string[] Actualizar(string IdEspecialidad, string NombreEspecialidad)
        {
            EspecialidadBL especialidadBL = new EspecialidadBL();
            Especialidad especialidad = new Especialidad();
            especialidad.IdEspecialidad1 = IdEspecialidad;
            especialidad.NombreEspecialidad1 = NombreEspecialidad;
            string[] valores = new string[2];
            valores[0] = especialidadBL.Actualizar(especialidad).ToString();
            valores[1] = especialidadBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Eliminar Especialidad")]
        public string[] Eliminar(string IdEspecialidad)
        {
            EspecialidadBL especialidadBL = new EspecialidadBL();
            string[] valores = new string[2];
            valores[0] = especialidadBL.Eliminar(IdEspecialidad).ToString();
            valores[1] = especialidadBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Buscar Especialidad")]
        public DataSet Buscar(string texto, string criterio)
        {
            EspecialidadBL especialidad = new EspecialidadBL();
            return especialidad.Buscar(texto, criterio);
        }

    }
}
