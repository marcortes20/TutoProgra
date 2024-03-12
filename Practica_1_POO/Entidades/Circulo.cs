using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_POO.Entidades
{
    internal class Circulo : FiguraGeometrica, IDibujable
    {

        public double radio { get; set; }

        public void CalcularAreaCirculo()
        {
           double area = (Math.Pow(radio,2) * Math.PI) ;

            Console.WriteLine($"El area del circulo es: {area.ToString("F2")}");
        }

        public void Dibujar()
        {
            Console.WriteLine("Estoy dibujando un circulo");
        }
    }
}
