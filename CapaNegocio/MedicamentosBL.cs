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
    public class MedicamentosBL : Interface.IMedicamentos
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

        public bool Actualizar(Medicamentos medicamentos)
        {
            DataRow fila = datos.TraerDataRow("spActualizarMedicamentos", medicamentos.IdMedicamentos1, medicamentos.NombreMedicamentos1, medicamentos.TipoMedicamento1, medicamentos.Detalle1, medicamentos.Cantidad);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public bool Agregar(Medicamentos medicamentos)
        {
            DataRow fila = datos.TraerDataRow("spAgregarMedicamentos", medicamentos.IdMedicamentos1, medicamentos.NombreMedicamentos1, medicamentos.TipoMedicamento1, medicamentos.Detalle1, medicamentos.Cantidad);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarMedicamentos", texto, criterio);
        }

        public bool Eliminar(string IdMedicamentos)
        {
            DataRow fila = datos.TraerDataRow("spEliminarMedicamentos  ", IdMedicamentos);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarMedicamentos");
        }

    }
}
