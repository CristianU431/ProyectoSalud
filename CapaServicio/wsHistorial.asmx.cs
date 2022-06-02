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
    /// Descripción breve de wsHistorial
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsHistorial : System.Web.Services.WebService
    {

        [WebMethod(Description = "Listar Historial")]
        public DataSet Listar()
        {
            HistorialBL historial = new HistorialBL();
            return historial.Listar();
        }

        [WebMethod(Description = "Agregar Historial")]
        public string[] Agregar(string IdHistorial, string Dni, string UltimaFechadeEntrada, string UltimaFechadeAlta, string CodMedico, string IdConsultorio, string IdReceta)
        {
            HistorialBL historialBL = new HistorialBL();
            Historial historial = new Historial();
            historial.IdHistorial1 = IdHistorial;
            historial.Dni1 = Dni;
            historial.UltimaFechadeEntrada1 = UltimaFechadeEntrada;
            historial.UltimaFechadeAlta1 = UltimaFechadeAlta;
            historial.CodMedico1 = CodMedico;
            historial.IdConsultorio1 = IdConsultorio;
            historial.IdReceta1 = IdReceta;
            string[] valores = new string[2];
            valores[0] = historialBL.Agregar(historial).ToString();
            valores[1] = historialBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Actualizar Historial")]
        public string[] Actualizar(string IdHistorial, string Dni, string UltimaFechadeEntrada, string UltimaFechadeAlta, string CodMedico, string IdConsultorio, string IdReceta)
        {
            HistorialBL historialBL = new HistorialBL();
            Historial historial = new Historial();
            historial.IdHistorial1 = IdHistorial;
            historial.Dni1 = Dni;
            historial.UltimaFechadeEntrada1 = UltimaFechadeEntrada;
            historial.UltimaFechadeAlta1 = UltimaFechadeAlta;
            historial.CodMedico1 = CodMedico;
            historial.IdConsultorio1 = IdConsultorio;
            historial.IdReceta1 = IdReceta;
            string[] valores = new string[2];
            valores[0] = historialBL.Actualizar(historial).ToString();
            valores[1] = historialBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Eliminar Historial")]
        public string[] Eliminar(string IdHistorial)
        {
            HistorialBL historialBL = new HistorialBL();
            string[] valores = new string[2];
            valores[0] = historialBL.Eliminar(IdHistorial).ToString();
            valores[1] = historialBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Buscar Historial")]
        public DataSet Buscar(string texto, string criterio)
        {
            HistorialBL historial = new HistorialBL();
            return historial.Buscar(texto, criterio);
        }

    }
}
