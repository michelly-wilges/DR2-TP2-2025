using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_DR2.Exercicios
{
    public static class Exercicio3
    {
        public static void Executar()
        {
            Console.WriteLine("======================================================");
            Console.WriteLine("           3  - Diferença Entre Duas Datas");
            Console.WriteLine("======================================================");
            Console.WriteLine();

            Console.Write("Digite a primeira data no formato dd/mm/aaaa: ");
            DateTime primeiraData;

            while (!DateTime.TryParse(Console.ReadLine(), out primeiraData))
            {
                Console.Write("Data inválida. Por favor, digite novamente a primeira data no formato dd/mm/aaaa: ");
            }
            Console.Write("Digite a segunda data no formato dd/mm/aaaa: ");
            DateTime segundaData;

            while (!DateTime.TryParse(Console.ReadLine(), out segundaData))
            {
                Console.Write("Data inválida. Por favor, digite novamente a segunda data no formato dd/mm/aaaa: ");
            }

            CalcularDiferencaEntreDatas(primeiraData, segundaData);
        }
        public static void CalcularDiferencaEntreDatas(DateTime primeiraData, DateTime segundaData)
        {
            if (segundaData < primeiraData) // Troca as datas se a segunda for anterior à primeira
            {
                DateTime temp = primeiraData;
                primeiraData = segundaData;
                segundaData = temp;
            }
            TimeSpan diferenca = segundaData - primeiraData;
            int anos = (int)(diferenca.Days / 365.25);
            int meses = (int)((diferenca.Days % 365.25) / 30.44);
            int dias = (int)((diferenca.Days % 365.25) % 30.44);
            Console.WriteLine($"A diferença entre as duas datas é de {anos} anos, {meses} meses e {dias} dias.");
        }
    }
}
