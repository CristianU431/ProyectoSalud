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
    /// Descripción breve de wsReceta
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsReceta : System.Web.Services.WebService
    {

        [WebMethod(Description = "Listar Receta")]
        public DataSet Listar()
        {
            RecetaBL receta = new RecetaBL();
            return receta.Listar();
        }

        [WebMethod(Description = "Agregar Receta")]
        public string[] Agregar(string IdReceta, string Dni, string Enfermedad, string IdMedicamentos, string Descripcion, string FechaInicio, string FechaLimite, string TipoReceta, string CodMedico, string IdConsultorio)
        {
            RecetaBL recetaBL = new RecetaBL();
            Receta receta = new Receta();
            receta.IdReceta1 = IdReceta;
            receta.Dni1 = Dni;
            receta.Enfermedad1 = Enfermedad;
            receta.IdMedicamentos1 = IdMedicamentos;
            receta.Descripcion1 = Descripcion;
            receta.FechaInicio1 = FechaInicio;
            receta.FechaLimite1 = FechaLimite;
            receta.TipoReceta1 = TipoReceta;
            receta.CodMedico1 = CodMedico;
            receta.IdConsultorio1 = IdConsultorio;
            string[] valores = new string[2];
            valores[0] = recetaBL.Agregar(receta).ToString();
            valores[1] = recetaBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Actualizar Receta")]
        public string[] Actualizar(string IdReceta, string Dni, string Enfermedad, string IdMedicamentos, string Descripcion, string FechaInicio, string FechaLimite, string TipoReceta, string CodMedico, string IdConsultorio)
        {
            RecetaBL recetaBL = new RecetaBL();
            Receta receta = new Receta();
            receta.IdReceta1 = IdReceta;
            receta.Dni1 = Dni;
            receta.Enfermedad1 = Enfermedad;
            receta.IdMedicamentos1 = IdMedicamentos;
            receta.Descripcion1 = Descripcion;
            receta.FechaInicio1 = FechaInicio;
            receta.FechaLimite1 = FechaLimite;
            receta.TipoReceta1 = TipoReceta;
            receta.CodMedico1 = CodMedico;
            receta.IdConsultorio1 = IdConsultorio;
            string[] valores = new string[2];
            valores[0] = recetaBL.Actualizar(receta).ToString();
            valores[1] = recetaBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Eliminar Receta")]
        public string[] Eliminar(string IdReceta)
        {
            RecetaBL recetaBL = new RecetaBL();
            string[] valores = new string[2];
            valores[0] = recetaBL.Eliminar(IdReceta).ToString();
            valores[1] = recetaBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Buscar Receta")]
        public DataSet Buscar(string texto, string criterio)
        {
            RecetaBL receta = new RecetaBL();
            return receta.Buscar(texto, criterio);
        }

    }
}
