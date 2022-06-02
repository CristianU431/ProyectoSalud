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
    public class EspecialidadBL : Interface.IEspecialidad
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

        public bool Actualizar(Especialidad especialidad)
        {
            DataRow fila = datos.TraerDataRow("spActualizarEspecialidad", especialidad.IdEspecialidad1, especialidad.NombreEspecialidad1);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public bool Agregar(Especialidad especialidad)
        {
            DataRow fila = datos.TraerDataRow("spAgregarEspecialidad", especialidad.IdEspecialidad1, especialidad.NombreEspecialidad1);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarEspecialidad", texto, criterio);
        }

        public bool Eliminar(string IdEspecialidad)
        {
            DataRow fila = datos.TraerDataRow("spEliminarEspecialidad  ", IdEspecialidad);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarEspecialidad");
        }

    }
}
