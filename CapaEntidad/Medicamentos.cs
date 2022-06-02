using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Medicamentos
    {
        //Atributos de la clase
        private string IdMedicamentos;
        private string NombreMedicamentos;
        private string TipoMedicamento;
        private string Detalle;
        private string cantidad;

        //Propiedaddes

        public string IdMedicamentos1 { get => IdMedicamentos; set => IdMedicamentos = value; }
        public string NombreMedicamentos1 { get => NombreMedicamentos; set => NombreMedicamentos = value; }
        public string TipoMedicamento1 { get => TipoMedicamento; set => TipoMedicamento = value; }
        public string Detalle1 { get => Detalle; set => Detalle = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }

        

    }
}
