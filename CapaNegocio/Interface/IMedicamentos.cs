using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interface
{
    interface IMedicamentos
    {
        // Declarar metodos comunes
        DataSet Listar();
        bool Agregar(Medicamentos medicamentos);
        bool Eliminar(string IdMedicamentos);
        bool Actualizar(Medicamentos medicamentos);
        DataSet Buscar(string texto, string criterio);
    }
}
