namespace TP2_DR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine($@"
                ============================================================
                        TP2 - Fundamentos de Desenvolvimento com C#        
                ============================================================

                              1  - Cálculo de Idade Precisa
                              2  - Dias até o Próximo Aniversário
                              3  - Diferença Entre Duas Datas
                              4  - Formulário de Cadastro Simples
                              5  - Conversor de Temperatura
                              6  - Cálculo de IMC
                              7  - Verificador de Número Par ou Ímpar
                              8  - Classificação de Nota Escolar
                              9  - Calculadora de Salário Líquido
                              10 - Contagem Regressiva
                              11 - Tabuada Interativa
                              12 - Jogo de Adivinhação

                 Digite o número do exercício para executar ou 0 para sair: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    opcao = -1; // Opção inválida
                }

                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Exercicios.Exercicio1.Executar();
                        break;
                    case 2:
                        Exercicios.Exercicio2.Executar();
                        break;
                    case 3:
                        Exercicios.Exercicio3.Executar();
                        break;
                    case 4:
                        Exercicios.Exercicio4.Executar();
                        break;
                    case 5:
                        Exercicios.Exercicio5.Executar();
                        break;
                    case 6:
                        Exercicios.Exercicio6.Executar();
                        break;
                    case 7:
                        Exercicios.Exercicio7.Executar();
                        break;
                    case 8:
                        Exercicios.Exercicio8.Executar();
                        break;
                    case 9:
                        Exercicios.Exercicio9.Executar();
                        break;
                    case 10:
                        Exercicios.Exercicio10.Executar();
                        break;
                    case 11:
                        Exercicios.Exercicio11.Executar();
                        break;
                    case 12:
                        Exercicios.Exercicio12.Executar();
                        break;
                    case 0:
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida, digite novamente.");
                        break;
                }
                if (opcao != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Pressione qualquer tecla para retornar ao menu.");
                    Console.ReadKey();
                }
            } while (opcao != 0);
        }
    }
}
