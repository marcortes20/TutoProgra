// See https://aka.ms/new-console-template for more information


using Practica_1_POO.Entidades;

Rectangulo rectangulo = new Rectangulo();
rectangulo.Altura = 5.6;
rectangulo.Base = 5.8;

Circulo circulo = new Circulo();
circulo.radio = 5;

rectangulo.CalcularAreaRectangulo();
circulo.CalcularAreaCirculo();

circulo.Dibujar();
rectangulo.Dibujar();


