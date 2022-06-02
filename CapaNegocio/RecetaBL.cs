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
    public class RecetaBL : Interface.IReceta
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

        public bool Actualizar(Receta receta)
        {
            DataRow fila = datos.TraerDataRow("spActualizarReceta", receta.IdReceta1, receta.Dni1, receta.Enfermedad1, receta.IdMedicamentos1, receta.Descripcion1, receta.FechaInicio1, receta.FechaLimite1, receta.TipoReceta1, receta.CodMedico1, receta.IdConsultorio1);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public bool Agregar(Receta receta)
        {
            DataRow fila = datos.TraerDataRow("spAgregarReceta", receta.IdReceta1, receta.Dni1, receta.Enfermedad1, receta.IdMedicamentos1, receta.Descripcion1, receta.FechaInicio1, receta.FechaLimite1, receta.TipoReceta1, receta.CodMedico1, receta.IdConsultorio1);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarReceta", texto, criterio);
        }

        public bool Eliminar(string IdReceta)
        {
            DataRow fila = datos.TraerDataRow("spEliminarReceta  ", IdReceta);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarReceta");
        }

    }
}
