using CapaNegocio.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;
using CapaEntidad;

namespace CapaNegocio
{
    public class MedicoBL : Interface.IMedico
    {

        //Atributo que devuelve el mensaje del PA
        private string mensaje;

        // Propiedad de solo lectura
        public string Mensaje
        {
            get { return mensaje; }
        }


        //Utilizar los archivos cs de la capa datos
        Datos datos = new DatosSQL();

        public bool Actualizar(Medico medico)
        {
            DataRow fila = datos.TraerDataRow("spActualizarMedico", medico.CodMedico1, medico.NombreMedico1, medico.ApellidoMedico1, medico.IdEspecialidad1);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public bool Agregar(Medico medico)
        {
            DataRow fila = datos.TraerDataRow("spAgregarMedico", medico.CodMedico1, medico.NombreMedico1, medico.ApellidoMedico1, medico.IdEspecialidad1);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarMedico", texto, criterio);
        }

        public bool Eliminar(string CodMedico)
        {
            DataRow fila = datos.TraerDataRow("spEliminarMedico  ", CodMedico);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarMedico");
        }

    }
}
