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
    /// Descripción breve de wsTriaje
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsTriaje : System.Web.Services.WebService
    {

        [WebMethod(Description = "Listar Triaje")]
        public DataSet Listar()
        {
            TriajeBL triaje = new TriajeBL();
            return triaje.Listar();
        }

        [WebMethod(Description = "Agregar Triaje")]
        public string[] Agregar(string IdTriaje, string Dni, string Talla, string Sintomas, string Peso, string Temperatura)
        {
            TriajeBL triajeBL = new TriajeBL();
            Triaje triaje = new Triaje();
            triaje.IdTriaje1 = IdTriaje;
            triaje.Dni1 = Dni;
            triaje.Talla1 = Talla;
            triaje.Sintomas1 = Sintomas;
            triaje.Peso1 = Peso;
            triaje.Temperatura1 = Temperatura;
            string[] valores = new string[2];
            valores[0] = triajeBL.Agregar(triaje).ToString();
            valores[1] = triajeBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Actualizar Triaje")]
        public string[] Actualizar(string IdTriaje, string Dni, string Talla, string Sintomas, string Peso, string Temperatura)
        {
            TriajeBL triajeBL = new TriajeBL();
            Triaje triaje = new Triaje();
            triaje.IdTriaje1 = IdTriaje;
            triaje.Dni1 = Dni;
            triaje.Talla1 = Talla;
            triaje.Sintomas1 = Sintomas;
            triaje.Peso1 = Peso;
            triaje.Temperatura1 = Temperatura;
            string[] valores = new string[2];
            valores[0] = triajeBL.Actualizar(triaje).ToString();
            valores[1] = triajeBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Eliminar Triaje")]
        public string[] Eliminar(string IdTriaje)
        {
            TriajeBL triajeBL = new TriajeBL();
            string[] valores = new string[2];
            valores[0] = triajeBL.Eliminar(IdTriaje).ToString();
            valores[1] = triajeBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Buscar Triaje")]
        public DataSet Buscar(string texto, string criterio)
        {
            TriajeBL triaje = new TriajeBL();
            return triaje.Buscar(texto, criterio);
        }

    }
}
