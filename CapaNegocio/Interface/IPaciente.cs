using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interface
{
    interface IPaciente
    {
        // Declarar metodos comunes
        DataSet Listar();
        bool Agregar(Paciente paciente);
        bool Eliminar(string Dni);
        bool Actualizar(Paciente paciente);
        DataSet Buscar(string texto, string criterio);
    }
}
