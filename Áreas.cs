using System;
using System.Globalization;

namespace Areas
{
    class Program {
        static void Main(string[] args) {
                                  
            Console.WriteLine("Para calcular as áreas, digite os valores de A, B e C: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double pi = 3.14159;

            double triangulo = (a * c) / 2;
            double circulo = pi * Math.Pow(c, 2);
            double trapezio = ((a + b) * c) / 2;
            double quadrado = b * b;
            double retangulo = a * b;

            Console.WriteLine("Área do Triângulo: " + triangulo.ToString("F2", CultureInfo.InvariantCulture) + "m²");
            Console.WriteLine("Área do Círculo: " + circulo.ToString("F2", CultureInfo.InvariantCulture) + "m²");
            Console.WriteLine("Área do Trapézio: " + trapezio.ToString("F2", CultureInfo.InvariantCulture) + "m²");
            Console.WriteLine("Área do Quadrado: " + quadrado.ToString("F2", CultureInfo.InvariantCulture) + "m²");
            Console.WriteLine("Área do Retângulo: " + retangulo.ToString("F2", CultureInfo.InvariantCulture) + "m²");

        }
    }
}