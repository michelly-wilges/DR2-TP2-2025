using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TP2_DR2.Exercicios
{
    public static class Exercicio4
    {
        public static void Executar()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================================================");
            Console.WriteLine("         4  - Formulário de Cadastro Simples");
            Console.WriteLine("======================================================");
            Console.ResetColor();

            string nome = ColetarNome();
            int idade = ColetarIdade();
            string telefone = ColetarTelefone();
            string email = ColetarEmail();

            ExibirDadosCadastrais(nome, idade, telefone, email);

            Console.WriteLine("Cadastro realizado com sucesso!");
        }

        private static string ColetarNome()
        {
            string nome;
            while (true)
            {
                Console.Write("Digite o seu nome completo: ");
                nome = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(nome))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nome inválido. Por favor, digite novamente.");
                    Console.ResetColor();
                    continue;
                }

                if (nome.Length < 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O nome deve ter pelo menos 3 caracteres. Por favor, digite novamente.");
                    Console.ResetColor();
                    continue;
                }
                break;
            }
            return nome;

        }
        private static int ColetarIdade()
        {
            int idade;
            while (true)
            {
                Console.Write("Digite a sua idade: ");
                if (!int.TryParse(Console.ReadLine(), out idade) || idade < 0 || idade > 120)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Idade inválida. Por favor, digite um número inteiro válido para a idade.");
                    Console.ResetColor();
                    continue;
                }
                break;
            }
            return idade;
        }

        private static string ColetarTelefone()
        {
            string telefone;
            while (true)
            {
                Console.Write("Digite o seu telefone com DDD: ");
                telefone = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(telefone))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Telefone inválido. Por favor, digite novamente.");
                    Console.ResetColor();
                    continue;
                }
                string numeroTelefone = Regex.Replace(telefone, @"[^\d]", "");

                if (numeroTelefone.Length < 10 || numeroTelefone.Length > 11)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Telefone inválido. O número deve conter 10 ou 11 dígitos. Por favor, digite novamente.");
                    Console.ResetColor();
                    continue;
                }

                if (numeroTelefone.Length == 11)
                {
                    telefone = $"({numeroTelefone.Substring(0, 2)}) {numeroTelefone.Substring(2, 5)}-{numeroTelefone.Substring(7, 4)}";
                }
                else
                {
                    telefone = $"({numeroTelefone.Substring(0, 2)}) {numeroTelefone.Substring(2, 4)}-{numeroTelefone.Substring(6, 4)}";
                }
                break;
            }
            return telefone;
        }
        private static string ColetarEmail()
        {
            string email;
            while (true)
            {
                Console.Write("Digite o seu email: ");
                email = Console.ReadLine()?.Trim().ToLower();
                if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Email inválido. Por favor, digite um email válido.");
                    Console.ResetColor();
                    continue;
                }
                break;
            }
            return email;
        }

        private static void ExibirDadosCadastrais(string nome, int idade, string telefone, string email)
        {
            string resultado = $@"

            ========================================================
                              DADOS CADASTRAIS
            ========================================================

            Nome .......: {nome}
            Idade ......: {idade} anos
            Telefone ...: {telefone}
            Email ......: {email}

            ========================================================";

            Console.WriteLine(resultado);

        }
    }
}
