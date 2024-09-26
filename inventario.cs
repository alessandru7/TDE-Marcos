using System;
using System.Collections.Generic;

public static class Inventario
{
    private static List<Item> inventario = new List<Item>();

    public static void AdicionarItem()
    {
        Console.Write("Digite o nome do item: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a quantidade: ");
        int quantidade = int.Parse(Console.ReadLine());

        inventario.Add(new Item(nome, quantidade));
        Console.WriteLine($"Item '{nome}' adicionado com sucesso!");
    }

    public static void ListarItens()
    {
        if (inventario.Count == 0)
        {
            Console.WriteLine("O inventário está vazio.");
        }
        else
        {
            Console.WriteLine("\n--- ITENS NO INVENTÁRIO ---");
            for (int i = 0; i < inventario.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Nome: {inventario[i].Nome}, Quantidade: {inventario[i].Quantidade}");
            }
        }
    }

    public static void RemoverItem()
    {
        if (inventario.Count == 0)
        {
            Console.WriteLine("O inventário está vazio.");
            return;
        }

        ListarItens();
        Console.Write("Digite o número do item que deseja remover: ");
        int indice = int.Parse(Console.ReadLine());

        if (indice > 0 && indice <= inventario.Count)
        {
            string nomeRemovido = inventario[indice - 1].Nome;
            inventario.RemoveAt(indice - 1);
            Console.WriteLine($"Item '{nomeRemovido}' removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Número inválido. Tente novamente.");
        }
    }
}
