using System;
public class Item
{
    public string Nome { get; set; }
    public int Quantidade { get; set; }

    public Item(string nome, int quantidade)
    {
        Nome = nome;
        Quantidade = quantidade;
    }
}
