using System;
using System.Globalization;

namespace MediaPonderada {
    class MP {
        static void Main21(string[] args) {

            Console.WriteLine("Digite os valores de N, X, Y e Z: ");
            int n = int.Parse(Console.ReadLine());
            double x, y, z;            

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite o valor de X: ");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de Y: ");
                y = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de z: ");
                z = double.Parse(Console.ReadLine());                

                double media = ((x * 2) + (y * 3) + (z * 5)) / (2 + 3 + 5);

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));                
            }
        }
    }
}