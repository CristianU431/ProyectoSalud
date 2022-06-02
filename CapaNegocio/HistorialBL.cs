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
    public class HistorialBL : Interface.IHistorial
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

        public bool Actualizar(Historial historial)
        {
            DataRow fila = datos.TraerDataRow("spActualizarHistorial", historial.IdHistorial1, historial.Dni1, historial.UltimaFechadeEntrada1, historial.UltimaFechadeAlta1, historial.CodMedico1, historial.IdConsultorio1, historial.IdReceta1);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public bool Agregar(Historial historial)
        {
            DataRow fila = datos.TraerDataRow("spAgregarHistorial", historial.IdHistorial1, historial.Dni1, historial.UltimaFechadeEntrada1, historial.UltimaFechadeAlta1, historial.CodMedico1, historial.IdConsultorio1, historial.IdReceta1);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarHistorial", texto, criterio);
        }

        public bool Eliminar(string IdHistorial)
        {
            DataRow fila = datos.TraerDataRow("spEliminarHistorial  ", IdHistorial);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarHistorial");
        }

    }
}
