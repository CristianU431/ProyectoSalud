using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interface
{
    interface IReceta
    {
        // Declarar metodos comunes
        DataSet Listar();
        bool Agregar(Receta receta);
        bool Eliminar(string IdReceta);
        bool Actualizar(Receta receta);
        DataSet Buscar(string texto, string criterio);
    }
}
