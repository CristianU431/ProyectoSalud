using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interface
{
    interface IConsultorio
    {
        // Declarar metodos comunes
        DataSet Listar();
        bool Agregar(Consultorio consultorio);
        bool Eliminar(string IdConsultorio);
        bool Actualizar(Consultorio colsultorio);
        DataSet Buscar(string texto, string criterio);
    }
}
