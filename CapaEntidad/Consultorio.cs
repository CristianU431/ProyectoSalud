using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Consultorio
    {
        //Atributos de la clase
        private string IdConsultorio;
        private string NumConsultorio;
        private string CodMedico;
        private string IdEspecialidad;

        //Propiedaddes

        public string IdConsultorio1 { get => IdConsultorio; set => IdConsultorio = value; }
        public string NumConsultorio1 { get => NumConsultorio; set => NumConsultorio = value; }
        public string CodMedico1 { get => CodMedico; set => CodMedico = value; }
        public string IdEspecialidad1 { get => IdEspecialidad; set => IdEspecialidad = value; }
    }
}
