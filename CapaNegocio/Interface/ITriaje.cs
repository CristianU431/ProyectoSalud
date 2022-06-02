using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interface
{
    interface ITriaje
    {
        // Declarar metodos comunes
        DataSet Listar();
        bool Agregar(Triaje triaje);
        bool Eliminar(string IdTriaje);
        bool Actualizar(Triaje triaje);
        DataSet Buscar(string texto, string criterio);
    }
}
