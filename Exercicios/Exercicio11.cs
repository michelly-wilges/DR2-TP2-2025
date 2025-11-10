using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_DR2.Exercicios
{
    public static class Exercicio11
    {
        public static void Executar()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================================================");
            Console.WriteLine("              11 - Tabuada Interativa");
            Console.WriteLine("======================================================");
            Console.ResetColor();

            Console.WriteLine("Digite um número para a exibição da tabuada: ");
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Entrada inválida. Digite um número inteiro: ");
                Console.ResetColor();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Tabuada do {numero}:");
            
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }

            Console.ResetColor();
        }
    }
}
