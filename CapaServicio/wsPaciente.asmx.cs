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
    /// Descripción breve de wsPaciente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsPaciente : System.Web.Services.WebService
    {

        [WebMethod(Description = "Listar Paciente")]
        public DataSet Listar()
        {
            PacienteBL paciente = new PacienteBL();
            return paciente.Listar();
        }

        [WebMethod(Description = "Agregar Paciente")]
        public string[] Agregar(string Dni, string NombrePaciente, string ApellidoPaciente, string Direccion, string Genero, string FechaNacimiento)
        {
            PacienteBL pacienteBL = new PacienteBL();
            Paciente paciente = new Paciente();
            paciente.Dni1 = Dni;
            paciente.NombrePaciente1 = NombrePaciente;
            paciente.ApellidoPaciente1 = ApellidoPaciente;
            paciente.Direccion1 = Direccion;
            paciente.Genero1 = Genero;
            paciente.FechaNacimiento1 = FechaNacimiento;
            string[] valores = new string[2];
            valores[0] = pacienteBL.Agregar(paciente).ToString();
            valores[1] = pacienteBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Actualizar Paciente")]
        public string[] Actualizar(string Dni, string NombrePaciente, string ApellidoPaciente, string Direccion, string Genero, string FechaNacimiento)
        {
            PacienteBL pacienteBL = new PacienteBL();
            Paciente paciente = new Paciente();
            paciente.Dni1 = Dni;
            paciente.NombrePaciente1 = NombrePaciente;
            paciente.ApellidoPaciente1 = ApellidoPaciente;
            paciente.Direccion1 = Direccion;
            paciente.Genero1 = Genero;
            paciente.FechaNacimiento1 = FechaNacimiento;
            string[] valores = new string[2];
            valores[0] = pacienteBL.Actualizar(paciente).ToString();
            valores[1] = pacienteBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Eliminar Paciente")]
        public string[] Eliminar(string Dni)
        {
            PacienteBL pacienteBL = new PacienteBL();
            string[] valores = new string[2];
            valores[0] = pacienteBL.Eliminar(Dni).ToString();
            valores[1] = pacienteBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Buscar Paciente")]
        public DataSet Buscar(string texto, string criterio)
        {
            PacienteBL paciente = new PacienteBL();
            return paciente.Buscar(texto, criterio);
        }

    }
}
