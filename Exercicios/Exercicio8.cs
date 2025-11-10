using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_DR2.Exercicios
{
    public static class Exercicio8
    {
        public static void Executar()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================================================");
            Console.WriteLine("         8  - Classificação de Nota Escolar");
            Console.WriteLine("======================================================");
            Console.ResetColor();

            Console.Write("Digite a nota do aluno (0 a 10): ");
            double nota;

            while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Nota inválida. Digite a nota do aluno (0 a 10): ");
                Console.ResetColor();
            }

            string classificacao;
            if (nota < 5)
            {
                classificacao = "Insuficiente";
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (nota >= 5 && nota < 7)
            {
                classificacao = "Regular";
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (nota >= 7 && nota < 9)
            {
                classificacao = "Bom";
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                classificacao = "Excelente";
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.WriteLine($"Classificação: {classificacao}");
            Console.ResetColor();
        }
    }
}
