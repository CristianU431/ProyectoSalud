using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interface
{
    interface ILaboratorio
    {
        // Declarar metodos comunes
        DataSet Listar();
        bool Agregar(Laboratorio laboratorio);
        bool Eliminar(string Idlab);
        bool Actualizar(Laboratorio laboratorio);
        DataSet Buscar(string texto, string criterio);
    }
}
