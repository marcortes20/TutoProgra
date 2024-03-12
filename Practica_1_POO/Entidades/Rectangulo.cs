using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_POO.Entidades
{
    internal class Rectangulo:FiguraGeometrica, IDibujable { 
        public double Base { get; set; }
        public double Altura { get; set; }

        public void CalcularAreaRectangulo()
        {
            double area = Base * Altura;
            Console.WriteLine($"El area del cuadrado es: {area}");
        }

        public void Dibujar()
        {
            Console.WriteLine("Estoy dibujando un cuadrado");
        }
    }
}
