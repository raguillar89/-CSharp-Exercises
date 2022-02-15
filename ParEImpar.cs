using System;
namespace ParEImpar {
    class PI {
        static void Main10(string[] args) {

            Console.WriteLine("Digite um número inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if(x % 2 == 0) {
                Console.WriteLine("O valor é Par.");
            } else {
                Console.WriteLine("O valor é Impar.");
            }        
        }     
    }
}
