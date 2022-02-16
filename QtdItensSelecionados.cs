using System;
using System.Globalization;

namespace Itens_Selecionados {
    class Qtd {
        static void Main18(string[] args) {

            Console.Write("Digite o Tipo de Combustível Deseja: \n\n1. Álcool \n2. Gasolina \n3. Diesel \n4. Sair \n\n");
            int x = int.Parse(Console.ReadLine());
            int alcool = 0, gasolina = 0, diesel = 0;

            while(x != 4) { 
                if(x == 1) { 
                    alcool++;
                } else if (x == 2) { 
                    gasolina++;
                } else if (x == 3) {
                    diesel++;
                } else if (x >= 5) {
                    Console.WriteLine("Combustível Inválido. Escolha Novamente uma das Opções:  \n\n1. Álcool \n2. Gasolina \n3. Diesel \n4. Sair \n\n");
                }
                Console.Write("Digite o Tipo de Combustível Deseja: \n\n1. Álcool \n2. Gasolina \n3. Diesel \n4. Sair \n\n");
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Até Logo! \nAlcool: {0} \nGasolina: {1} \nDiesel: {2}",alcool, gasolina, diesel);
        }
    }
}