using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TP2_DR2.Exercicios
{
    public static class Exercicio1
    {

        public static void Executar()
        {
            Console.WriteLine("======================================================");
            Console.WriteLine("            1  - Cálculo de Idade Precisa");
            Console.WriteLine("======================================================");
            Console.WriteLine();

            Console.Write("Digite sua data de nascimento no formato dd/mm/aaaa: ");
            DateTime dataNascimento;

            while (!DateTime.TryParse(Console.ReadLine(), out dataNascimento))
            {
                Console.Write("Data inválida. Por favor, digite novamente sua data de nascimento (formato: dd/mm/aaaa): ");
            }
            CalcularIdade(dataNascimento);
        }
        public static void CalcularIdade(DateTime dataNascimento)
        {
            DateTime dataAtual = DateTime.Now;

            int anos = dataAtual.Year - dataNascimento.Year;
            int meses = dataAtual.Month - dataNascimento.Month;
            int dias = dataAtual.Day - dataNascimento.Day;

            if (dias < 0)
            {
                meses--;
                dias += DateTime.DaysInMonth(dataAtual.Year, (dataAtual.Month == 1) ? 12 : dataAtual.Month - 1);
            }
            if (meses < 0)
            {
                anos--;
                meses += 12;
            }

            Console.WriteLine($"Você já viveu {anos} anos, {meses} meses e {dias} dias.");
        }
    }
}
