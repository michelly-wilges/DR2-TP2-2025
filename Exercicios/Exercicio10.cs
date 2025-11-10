using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_DR2.Exercicios
{
    public static class Exercicio10
    {
        public static void Executar()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================================================");
            Console.WriteLine("              10 - Contagem Regressiva");
            Console.WriteLine("======================================================");
            Console.ResetColor();

            int contador;

            Console.WriteLine("Digite um número para iniciar a contagem regressiva: ");

            while (!int.TryParse(Console.ReadLine(), out contador) || contador <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Valor inválido. Digite um número maior que 0.");
                Console.ResetColor();
            }

            for (contador = contador; contador >= 0; contador--)
            {
                if (contador > 0)
                {
                    Console.WriteLine(contador);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Acabou!");
                    Console.ResetColor();
                }
                System.Threading.Thread.Sleep(700);
            }
        }
    }
}
