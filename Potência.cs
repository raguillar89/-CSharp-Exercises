using System;
using System.Globalization;

namespace Potencia {
    class Pot {
        static void Main(string[] args) {

            Console.WriteLine("Digite o Valor de N: ");
            int n = int.Parse(Console.ReadLine());
            double x, y, z;

            for (int i = 1; i <= n; i++) {
                x = Math.Pow(i, 1);
                y = Math.Pow(i, 2);
                z = Math.Pow(i, 3);

                Console.WriteLine("\nn¹ = " + x);
                Console.WriteLine("n² = " + y);
                Console.WriteLine("n³ = " + z);
            }
        }
    }
}