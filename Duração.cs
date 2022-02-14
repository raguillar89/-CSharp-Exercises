using System;
namespace Décimo_Segundo {
    class Program12 {
        static void Main12(string[] args) {

            Console.WriteLine("Digite o valor de X (Número Inteiro): ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de Y (Número Inteiro): ");
            int y = int.Parse(Console.ReadLine());

            if(x < 0 || x > 24 || y < 0 || y > 24) {
                Console.WriteLine("Valor inválido.");
            } else if(x > 0 || x < 24 && y > 0 || y < 24) {
                int hora1 = 24 - x;
                int hora2 = 24 - y;

                int duracao = hora1 + hora2;

                Console.WriteLine(duracao);
            }                    
        }     
    }
}