using System;
using System.Globalization;

namespace Fatorial {
    class Ft {
        static void Main22(string[] args) {

            int n = int.Parse(Console.ReadLine());
            int fat = 1;

            for (int i = 1; i <= n; i++) {
                fat = fat * i;
            }
            Console.WriteLine(fat);        
        }
    }
}