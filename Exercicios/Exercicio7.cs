using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace TP2_DR2.Exercicios
{
    public static class Exercicio7
    {
        public static void Executar()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================================================");
            Console.WriteLine("       7  - Verificador de Número Par ou Ímpar");
            Console.WriteLine("======================================================");
            Console.ResetColor();

            Console.WriteLine("Digite um número inteiro: ");
            int numero;

            while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro: ");
                Console.ResetColor();
            }

            VerificarParOuImpar(numero);

            void VerificarParOuImpar(int num)
            {
                if (num % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"O número {num} é par.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"O número {num} é ímpar.");
                }
                Console.ResetColor();
            }

        }
    }
}
