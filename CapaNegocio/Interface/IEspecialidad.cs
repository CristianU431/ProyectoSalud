using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interface
{
    interface IEspecialidad
    {
        // Declarar metodos comunes
        DataSet Listar();
        bool Agregar(Especialidad especialidad);
        bool Eliminar(string IdEspecialidad);
        bool Actualizar(Especialidad especialidad);
        DataSet Buscar(string texto, string criterio);
    }
}
