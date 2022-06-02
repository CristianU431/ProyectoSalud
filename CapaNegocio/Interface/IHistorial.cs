using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interface
{
    interface IHistorial
    {
        // Declarar metodos comunes
        DataSet Listar();
        bool Agregar(Historial historial);
        bool Eliminar(string IdHistorial);
        bool Actualizar(Historial historial);
        DataSet Buscar(string texto, string criterio);
    }
}
