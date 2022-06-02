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
    public class LaboratorioBL : Interface.ILaboratorio
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

        public bool Actualizar(Laboratorio laboratorio)
        {
            DataRow fila = datos.TraerDataRow("spActualizarLaboratorio", laboratorio.Idlab1, laboratorio.TipoLab1, laboratorio.NombreLab1, laboratorio.Dni1, laboratorio.Resultado1, laboratorio.CodMedico1);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public bool Agregar(Laboratorio laboratorio)
        {
            DataRow fila = datos.TraerDataRow("spAgregarLaboratorio", laboratorio.Idlab1, laboratorio.TipoLab1, laboratorio.NombreLab1, laboratorio.Dni1, laboratorio.Resultado1, laboratorio.CodMedico1);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarLaboratorio", texto, criterio);
        }

        public bool Eliminar(string Idlab)
        {
            DataRow fila = datos.TraerDataRow("spEliminarLaboratorio  ", Idlab);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarLaboratorio");
        }

    }
}
