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
    public class TriajeBL : Interface.ITriaje
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

        public bool Actualizar(Triaje triaje)
        {
            DataRow fila = datos.TraerDataRow("spActualizarTriaje", triaje.IdTriaje1, triaje.Dni1, triaje.Talla1, triaje.Sintomas1, triaje.Peso1, triaje.Temperatura1);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public bool Agregar(Triaje triaje)
        {
            DataRow fila = datos.TraerDataRow("spAgregarTriaje", triaje.IdTriaje1, triaje.Dni1, triaje.Talla1, triaje.Sintomas1, triaje.Peso1, triaje.Temperatura1);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarTriaje", texto, criterio);
        }

        public bool Eliminar(string IdTriaje)
        {
            DataRow fila = datos.TraerDataRow("spEliminarTriaje  ", IdTriaje);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarTriaje");
        }

    }
}
