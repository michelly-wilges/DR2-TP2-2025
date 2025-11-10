using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_DR2.Exercicios
{
    public static class Exercicio6
    {
        public static void Executar()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================================================");
            Console.WriteLine("                6  - Cálculo de IMC");
            Console.WriteLine("======================================================");
            Console.ResetColor();

            Console.Write("Digite seu peso em quilos: ");
            double peso;
            while (!double.TryParse(Console.ReadLine(), out peso) || peso <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Peso inválido. Digite seu peso em quilos: ");
                Console.ResetColor();
            }

            Console.Write("Digite sua altura em metros: ");
            double altura;
            while (!double.TryParse(Console.ReadLine(), out altura) || altura <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Altura inválida. Digite sua altura em metros: ");
                Console.ResetColor();
            }

            double imc = peso / (altura * altura);

            string mensagem = null;

            if (imc < 22) {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                mensagem = "Você está abaixo do peso.";

            }
            if (imc >= 22 && imc < 27) {
                Console.ForegroundColor = ConsoleColor.Green;
                mensagem = "Você está dentro do peso ideal.";

            }
            if (imc >= 27 && imc < 29.99) {
                Console.ForegroundColor = ConsoleColor.Yellow;
                mensagem = "Você apresenta sobrepeso.";

            }
            if (imc >= 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                mensagem = "Você apresenta obesidade.";

            }
            if (mensagem != null)
            {
                Console.WriteLine($"Seu IMC é: {imc:F2}. {mensagem}");
            }
            Console.ResetColor();
        }
    }
}
