using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_DR2.Exercicios
{
    public static class Exercicio5
    {
        public static void Executar()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================================================");
            Console.WriteLine("            5  - Conversor de Temperatura");
            Console.WriteLine("======================================================");
            Console.ResetColor();

            Console.Write("Digite a temperatura em Celsius: ");
            double celsius;
            while (!double.TryParse(Console.ReadLine(), out celsius))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Temperatura inválida. Digite um número válido: ");
                Console.ResetColor();
            }

            ExibirMenuConversao();

            Console.WriteLine("Escolha uma opção para conversão: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    double fahrenheit = (celsius * 9.0 / 5.0) + 32;
                    Console.WriteLine($"✓ {celsius:F2}°C = {fahrenheit:F2}°F");
                    break;
                case "2":
                    double kelvin = celsius + 273.15;
                    Console.WriteLine($"{celsius}°C equivalem a {kelvin:F2}K");
                    break;
                case "3":
                    double f = (celsius * 9.0 / 5.0) + 32;
                    double k = celsius + 273.15;
                    Console.WriteLine($"{celsius}°C equivalem a:");
                    Console.WriteLine($"  {f:F2}°F (Fahrenheit)");
                    Console.WriteLine($"  {k:F2}K (Kelvin)");
                    break;
                case "0":
                    Console.WriteLine("Retornando ao menu principal...");
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida.");
                    Console.ResetColor();
                    break;
            }
        }

         private static void ExibirMenuConversao()
        {
            Console.WriteLine("Escolha o tipo de conversão:");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Celsius para Kelvin");
            Console.WriteLine("3 - Ambas");
            Console.WriteLine("0 - Voltar ao menu principal");
        }
    }
}
