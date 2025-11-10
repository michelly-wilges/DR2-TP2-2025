using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_DR2.Exercicios
{
    public static class Exercicio2
    {
        public static void Executar()
        {
            Console.WriteLine("======================================================");
            Console.WriteLine("          2  - Dias até o Próximo Aniversário");
            Console.WriteLine("======================================================");
            Console.WriteLine();

            Console.WriteLine("Digite sua data de nascimento no formato dd/mm/aaaa: ");
            DateTime dataNascimento;

            while (!DateTime.TryParse(Console.ReadLine(), out dataNascimento))
            {
                Console.Write("Data inválida. Por favor, digite novamente sua data de nascimento (formato: dd/mm/aaaa): ");
            }
            CalcularDiasParaAniversario(dataNascimento);
        }
        public static void CalcularDiasParaAniversario(DateTime dataNascimento)
        {
            DateTime dataAtual = DateTime.Now;

            DateTime proximoAniversario = new DateTime(dataAtual.Year, dataNascimento.Month, dataNascimento.Day);

            if (proximoAniversario < dataAtual)
            {
                proximoAniversario = proximoAniversario.AddYears(1); //adiciona 1 ano ao aniversário se já passou esse ano.
            }
            int diasRestantes = (proximoAniversario - dataAtual).Days;
            Console.WriteLine($"Faltam {diasRestantes} dias para o seu próximo aniversário.");
        }
    }
}
