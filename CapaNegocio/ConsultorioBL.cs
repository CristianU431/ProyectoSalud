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
    public class ConsultorioBL : Interface.IConsultorio
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

        public bool Actualizar(Consultorio consultorio)
        {
            DataRow fila = datos.TraerDataRow("spActualizarConsultorio ", consultorio.IdConsultorio1, consultorio.NumConsultorio1, consultorio.CodMedico1, consultorio.IdEspecialidad1);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public bool Agregar(Consultorio consultorio)
        {
            DataRow fila = datos.TraerDataRow("spAgregarConsultorio", consultorio.IdConsultorio1, consultorio.NumConsultorio1, consultorio.CodMedico1, consultorio.IdEspecialidad1);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarConsultorio", texto, criterio);
        }

        public bool Eliminar(string IdConsultorio)
        {
            DataRow fila = datos.TraerDataRow("spEliminarConsultorio  ", IdConsultorio);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarConsultorio");
        }

    }
}
