using System;
namespace Décimo_Primeiro {
    class Program11 {
        static void Main11(string[] args) {

            Console.WriteLine("Digite dois números inteiros: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            
            int xy = x / y;
            int yx = y / x;

            int xxyy = xy * y;
            int yyxx = yx * x;

            if(x == xxyy || y == yyxx) {
                Console.WriteLine("Os valores são multiplos.");
            } else {
                Console.WriteLine("Os valores não são multiplos.");
            }        
        }     
    }
}