using System.Collections;
using System.Security.Cryptography;

namespace Jokenpo.ConsoleApp;

class Program
{

    static void Main(string[] args)
    {

        cabecalho();
        escolhaJogador();

    }
    static string escolhaJogador()
    {
        do
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Pedra");
            Console.WriteLine("2 - Papel");
            Console.WriteLine("3 - Tesoura");
            Console.WriteLine("4 - Sair");

            string opcao = Console.ReadLine()?.Trim() ?? ""; //// O "??" evita o aviso de valor nulo e o Trim() remove espaços acidentais

            Random random = new Random();
            int opcaoComputador = random.Next(1, 4);

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Você escolheu Pedra.");
                    Console.WriteLine($"O computador escolheu {opcaoComputador}.");

                    if (opcaoComputador == 1)
                    {
                        Console.WriteLine("\nEmpate!");
                        Console.WriteLine("------------------------");
                    }
                    else if (opcaoComputador == 2)
                    {
                        Console.WriteLine("\nO computador venceu! Papel cobre Pedra.");
                        Console.WriteLine("-----------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("\nParabéns! Você venceu! Pedra quebra Tesoura.");
                        Console.WriteLine("----------------------------------------------");

                    }
                    continue;
                case "2":
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Você escolheu Papel.");
                    Console.WriteLine($"O computador escolheu {opcaoComputador}.");

                    if (opcaoComputador == 2)
                    {
                        Console.WriteLine("\nEmpate!");
                        Console.WriteLine("------------------------");
                    }
                    else if (opcaoComputador == 1)
                    {
                        Console.WriteLine("\nParabéns! Você venceu! Papel cobre Pedra.");
                        Console.WriteLine("-------------------------------------------");

                    }
                    else
                    {
                        Console.WriteLine("\nO computador venceu! Tesoura corta Papel.");
                        Console.WriteLine("-------------------------------------------");
                    }
                    continue;
                case "3":
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Você escolheu Tesoura.");
                    Console.WriteLine($"O computador escolheu {opcaoComputador}.");
                    if (opcaoComputador == 3)
                    {
                        Console.WriteLine("\nEmpate!");
                        Console.WriteLine("------------------------");
                    }
                    else if (opcaoComputador == 2)
                    {
                        Console.WriteLine("\nParabéns! Você venceu! Tesoura corta Papel.");
                        Console.WriteLine("---------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("\nO computador venceu! Pedra quebra Tesoura.");
                        Console.WriteLine("--------------------------------------------");
                    }
                    continue;
                case "4":
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Saindo do jogo. Até a próxima!");
                    Console.WriteLine("------------------------------");
                    return opcao;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    continue;
            }

        } while (true);
    }

    static void cabecalho()
    {
        Console.Clear();
        Console.WriteLine("------------------------");
        Console.WriteLine("Bem-vindo ao Jokenpô!");
        Console.WriteLine("------------------------");
    }

}
