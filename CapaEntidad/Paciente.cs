using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Paciente
    {
        //Atributos de la clase
        private string Dni;
        private string NombrePaciente;
        private string ApellidoPaciente;
        private string Direccion;
        private string Genero;
        private string FechaNacimiento;
        
        //Propiedaddes
        
        public string Dni1 { get => Dni; set => Dni = value; }
        public string NombrePaciente1 { get => NombrePaciente; set => NombrePaciente = value; }
        public string ApellidoPaciente1 { get => ApellidoPaciente; set => ApellidoPaciente = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Genero1 { get => Genero; set => Genero = value; }
        public string FechaNacimiento1 { get => FechaNacimiento; set => FechaNacimiento = value; }

    }
}
