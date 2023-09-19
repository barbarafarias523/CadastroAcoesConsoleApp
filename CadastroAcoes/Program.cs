using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, int> carteiraDeAcoes = new Dictionary<string, int>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Cadastro de ação");
            Console.WriteLine("2. Pesquisar por ação");
            Console.WriteLine("3. Visualizar a carteira de ações");
            Console.WriteLine("4. Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastrarAcao();
                    break;
                case "2":
                    PesquisarAcao();
                    break;
                case "3":
                    VisualizarCarteira();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opção inválida. Outra chance:");
                    break;
            }
        }
    }

    static void CadastrarAcao()
    {
        Console.Write("Código da ação: ");
        string codigo = Console.ReadLine();
        Console.Write("Quantidade de ações: ");
        int qtdAcao = int.Parse(Console.ReadLine());

        if (carteiraDeAcoes.ContainsKey(codigo))
        {
            carteiraDeAcoes[codigo] += qtdAcao;
        }
        else
        {
            carteiraDeAcoes[codigo] = qtdAcao;
        }

        Console.WriteLine("Ação cadastrada!");
    }

    static void PesquisarAcao()
    {
        Console.Write("Código da ação que deseja pesquisar: ");
        string codigo = Console.ReadLine();

        if (carteiraDeAcoes.ContainsKey(codigo))
        {
            int qtd = carteiraDeAcoes[codigo];
            Console.WriteLine($"Ação: {codigo}, Quantidade: {qtd}");
        }
        else
        {
            Console.WriteLine("Ação não encontrada.");
        }
    }

    static void VisualizarCarteira()
    {
        Console.WriteLine("Carteira de Ações:");
        foreach (var item in carteiraDeAcoes)
        {
            Console.WriteLine($"Ação: {item.Key}, Quantidade: {item.Value}");
        }
    }
}