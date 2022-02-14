using System;
using System.Globalization;

namespace Décimo_Quinto {
    class Program15 {
        static void Main15(string[] args) {
            Console.WriteLine("Digite um Valor Decimal para X: ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um Valor Decimal para Y: ");
            double y = double.Parse(Console.ReadLine());

            if (x == 0 && y == 0) {
                Console.WriteLine("Origem.");
            } else if (x > 0 && y > 0) {
                Console.WriteLine("Q1.");
            } else if (x < 0 && y > 0) {
                Console.WriteLine("Q2.");
            } else if (x < 0 && y < 0) {
                Console.WriteLine("Q3.");
            } else if (x > 0 && y < 0) {
                Console.WriteLine("Q4.");
            }
        }
    }
}