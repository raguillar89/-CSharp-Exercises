using System;
using CalculoDeÁreas.Entities;
using CalculoDeÁreas.Entities.Enums;
using System.Globalization;

namespace Course
{
    abstract class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.WriteLine("Entre com a quantidade de figuras: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Figura #{i} data: ");

                Console.Write("Retangulo ou Circulo (r/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Qual a Cor (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Digite a Largura: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Digite a Altura: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Retangulo(width, height, color));
                }
                else
                {
                    Console.Write("Digite o Raio: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circulo(radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Áreas das Figuras: ");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}