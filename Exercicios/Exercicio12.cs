using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TP2_DR2.Exercicios
{
    public static class Exercicio12
    {
        public static void Executar()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================================================");
            Console.WriteLine("             12 - Jogo de Adivinhação");
            Console.WriteLine("======================================================");
            Console.ResetColor();

            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int tentativas = 0;
            int palpite = 0;
            string condicao;

            Console.WriteLine("Digite um número entre 1 e 100 para tentar adivinhar o número secreto: ");

            while (true)
            {
                while (!int.TryParse(Console.ReadLine(), out palpite) || palpite < 1 || palpite > 100)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Entrada inválida. Por favor, digite um número entre 1 e 100: ");
                    Console.ResetColor();
                }

                tentativas++;

                if (palpite == numeroSecreto)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Parabéns! Você acertou na {tentativas}ª tentativa. O número secreto era {numeroSecreto}.");
                    Console.ResetColor();
                    break;
                }
                else
                {
                    condicao = palpite < numeroSecreto ? "maior" : "menor";

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Não foi dessa vez! Você digitou {palpite}, mas o número secreto é {condicao}.");
                    Console.ResetColor();
                    Console.Write("Tente novamente: ");
                }
            }
        }
    }
}
