using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Triaje
    {
        //Atributos de la clase
        private string IdTriaje;
        private string Dni;
        private string Talla;
        private string Sintomas;
        private string Peso;
        private string Temperatura;
        
        //Propiedaddes
        
        public string IdTriaje1 { get => IdTriaje; set => IdTriaje = value; }
        public string Dni1 { get => Dni; set => Dni = value; }
        public string Talla1 { get => Talla; set => Talla = value; }
        public string Sintomas1 { get => Sintomas; set => Sintomas = value; }
        public string Peso1 { get => Peso; set => Peso = value; }
        public string Temperatura1 { get => Temperatura; set => Temperatura = value; }

    }
}
