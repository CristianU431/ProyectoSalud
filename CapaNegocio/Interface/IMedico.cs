using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interface
{
    interface IMedico
    {
        // Declarar metodos comunes
        DataSet Listar();
        bool Agregar(Medico medico);
        bool Eliminar(string CodMedico);
        bool Actualizar(Medico medico);
        DataSet Buscar(string texto, string criterio);
    }
}
