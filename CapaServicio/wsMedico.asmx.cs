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
    /// Descripción breve de wsMedico
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsMedico : System.Web.Services.WebService
    {

        [WebMethod(Description = "Listar Medico")]
        public DataSet Listar()
        {
            MedicoBL medico = new MedicoBL();
            return medico.Listar();
        }

        [WebMethod(Description = "Agregar Medico")]
        public string[] Agregar(string CodMedico, string NombreMedico, string ApellidoMedico, string IdEspecialidad)
        {
            MedicoBL medicoBL = new MedicoBL();
            Medico medico = new Medico();
            medico.CodMedico1 = CodMedico;
            medico.NombreMedico1 = NombreMedico;
            medico.ApellidoMedico1 = ApellidoMedico;
            medico.IdEspecialidad1 = IdEspecialidad;
            string[] valores = new string[2];
            valores[0] = medicoBL.Agregar(medico).ToString();
            valores[1] = medicoBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Actualizar Medico")]
        public string[] Actualizar(string CodMedico, string NombreMedico, string ApellidoMedico, string IdEspecialidad)
        {
            MedicoBL medicoBL = new MedicoBL();
            Medico medico = new Medico();
            medico.CodMedico1 = CodMedico;
            medico.NombreMedico1 = NombreMedico;
            medico.ApellidoMedico1 = ApellidoMedico;
            medico.IdEspecialidad1 = IdEspecialidad;
            string[] valores = new string[2];
            valores[0] = medicoBL.Actualizar(medico).ToString();
            valores[1] = medicoBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Eliminar Medico")]
        public string[] Eliminar(string CodMedico)
        {
            MedicoBL medicoBL = new MedicoBL();
            string[] valores = new string[2];
            valores[0] = medicoBL.Eliminar(CodMedico).ToString();
            valores[1] = medicoBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Buscar Medico")]
        public DataSet Buscar(string texto, string criterio)
        {
            MedicoBL medico = new MedicoBL();
            return medico.Buscar(texto, criterio);
        }

    }
}
