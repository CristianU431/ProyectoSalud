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
    public class PacienteBL : Interface.IPaciente
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

        public bool Actualizar(Paciente paciente)
        {
            DataRow fila = datos.TraerDataRow("spActualizarPaciente", paciente.Dni1, paciente.NombrePaciente1, paciente.ApellidoPaciente1, paciente.Direccion1, paciente.Genero1, paciente.FechaNacimiento1);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public bool Agregar(Paciente paciente)
        {
            DataRow fila = datos.TraerDataRow("spAgregarPaciente", paciente.Dni1, paciente.NombrePaciente1, paciente.ApellidoPaciente1, paciente.Direccion1, paciente.Genero1, paciente.FechaNacimiento1);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarPaciente", texto, criterio);
        }

        public bool Eliminar(string Dni)
        {
            DataRow fila = datos.TraerDataRow("spEliminarPaciente  ", Dni);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarPaciente");
        }

    }
}
