using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_DR2.Exercicios
{
    public static class Exercicio9
    {
        public static void Executar()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================================================");
            Console.WriteLine("        9  - Calculadora de Salário Líquido");
            Console.WriteLine("======================================================");
            Console.ResetColor();

            Console.Write("Digite o valor do salário bruto: R$ ");
            double salarioBruto = 0;
            double salarioLiquido = 0;

            while (!double.TryParse(Console.ReadLine(), out salarioBruto) || salarioBruto < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Valor inválido. Digite o valor do salário bruto: R$ ");
                Console.ResetColor();
            }

            if (salarioBruto > 2428.00 && salarioBruto < 2826.65)
            {
                double descontoIR = salarioBruto * 0.075;
                salarioLiquido = salarioBruto - descontoIR;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"O salário líquido após o desconto do IR (7.5%) é: R$ {salarioLiquido:F2}");
                Console.ResetColor();
                return;
            } else if (salarioBruto >= 2826.66 && salarioBruto < 3751.05)
            {
                double descontoIR = salarioBruto * 0.15;
                salarioLiquido = salarioBruto - descontoIR;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"O salário líquido após o desconto do IR (15%) é: R$ {salarioLiquido:F2}");
                Console.ResetColor();
                return;
            }
            else if (salarioBruto >= 3751.06 && salarioBruto < 4664.68)
            {
                double descontoIR = salarioBruto * 0.225;
                salarioLiquido = salarioBruto - descontoIR;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"O salário líquido após o desconto do IR (22.5%) é: R$ {salarioLiquido:F2}");
                Console.ResetColor();
                return;
            }
            else if (salarioBruto >= 4664.68)
            {
                double descontoIR = salarioBruto * 0.275;
                salarioLiquido = salarioBruto - descontoIR;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"O salário líquido após o desconto do IR (27.5%) é: R$ {salarioLiquido:F2}");
                Console.ResetColor();
                return;
            }
            else
            {
                salarioLiquido = salarioBruto;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"O salário líquido é: R$ {salarioLiquido:F2} (isento de IR)");
                Console.ResetColor();
            }
        }
    }
}
