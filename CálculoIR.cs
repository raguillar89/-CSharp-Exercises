using System;
using System.Globalization;

namespace Décimo_Sexto {
    class Program16 {
        static void Main(string[] args) {

            Console.WriteLine("Qual o valor do seu Salário: R$");
            double x = double.Parse(Console.ReadLine());
            double a, b, c, d, ir;

            if(x < 2000.00) { 
                a = x * 0.00;
                ir = a;

                Console.WriteLine("Esta isento de pagar Imposto de Renda");
            } else if (x > 2000.00 && x < 3000.00) {
                a = 2000.00 * 0.00;
                b = (x - 2000.00) * 0.08;
                ir = a + b;

                Console.WriteLine("O valor a ser pago de Imposto de Renda é de R$" + ir.ToString("F2", CultureInfo.InvariantCulture));
            } else if (x > 3000.00 && x < 4500.00) {
                a = 2000.00 * 0.00;
                b = 1000.00 * 0.08;
                c = (x - 2000.00 - 1000.00) * 0.18;
                ir = a + b + c;

                Console.WriteLine("O valor a ser pago de Imposto de Renda é de R$" + ir.ToString("F2", CultureInfo.InvariantCulture));
            } else if (x > 4500.00) {
                a = 2000.00 * 0.00;
                b = 1000.00 * 0.08;
                c = 1500.00 * 0.18;
                d = (x - 2000.00 - 1000.00 - 1500.00) * 0.28;
                ir = a + b + c + d;

                Console.WriteLine("O valor a ser pago de Imposto de Renda é de R$" + ir.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}