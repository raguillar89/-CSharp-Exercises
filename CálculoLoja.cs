using System;
using System.Globalization;

namespace Décimo_Terceiro {
    class Program13 {
        static void Main13(string[] args) {

            int qtd1 = 0;
            double vl1 = 4.00;
            int qtd2 = 0;
            double vl2 = 4.50;
            int qtd3 = 0;
            double vl3 = 5.00;
            int qtd4 = 0;
            double vl4 = 2.00;
            int qtd5 = 0;
            double vl5 = 1.50;
            int item = 0;

            Console.WriteLine("Bem-Vindo ao Darth' Burger.");

                while(item < 6) {
                    Console.WriteLine("Qual seria seu pedido? \n\n1. Cachorro-Quente - R$4.00 \n2. X-Salada - R$4.50 \n3. X-Bacon - R$5.00 \n4. Torrada Simples - R$2.00 \n5. Refrigerante - R$1.50 \n6. Finalizar Pedido");
                    item = int.Parse(Console.ReadLine());

                    switch (item) {
                        case 1:
                            Console.WriteLine("\nQuantos Cachorros-Quentes deseja?");
                            int a = int.Parse(Console.ReadLine());
                            qtd1 = qtd1 + a;

                            break;
                        case 2:
                            Console.WriteLine("\nQuantos X-Saladas deseja?");
                            int b = int.Parse(Console.ReadLine());
                            qtd2 = qtd2 + b;

                        break;
                        case 3:
                            Console.WriteLine("\nQuantos X-Bacons deseja?");
                            int c = int.Parse(Console.ReadLine());
                            qtd3 = qtd3 + c;

                        break;
                        case 4:
                            Console.WriteLine("\nQuantos Torradas Simples deseja?");
                            int d = int.Parse(Console.ReadLine());
                            qtd4 = qtd4 + d;

                        break;
                        case 5:
                            Console.WriteLine("\nQuantos Refrigerantes deseja?");
                            int e = int.Parse(Console.ReadLine());
                            qtd5 = qtd5 + e;

                        break;
                        default:

                        break;
                    }
                }

            double total = (qtd1 * vl1) + (qtd2 * vl2) + (qtd3 * vl3) + (qtd4 * vl4) + (qtd5 * vl5);

            Console.WriteLine("O valor total do pedido é de: R$" + total.ToString("F2", CultureInfo.InvariantCulture));

            }                    
        }     
    
}