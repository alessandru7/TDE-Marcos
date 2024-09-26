using System;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n--- MENU DE INVENTÁRIO ---");
            Console.WriteLine("1. Adicionar item");
            Console.WriteLine("2. Listar itens");
            Console.WriteLine("3. Remover item");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Inventario.AdicionarItem();
                    break;
                case "2":
                    Inventario.ListarItens();
                    break;
                case "3":
                    Inventario.RemoverItem();
                    break;
                case "4":
                    continuar = false;
                    Console.WriteLine("Saindo do sistema...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
