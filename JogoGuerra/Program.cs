using System;

class Personagem
{
    // herói ou vilão
    public string Tipo { get; set; }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Jogo de Guerra: heróis e vilões");
        Console.WriteLine("");

        // Cria uma instância da classe Personagem
        Personagem thor = new Personagem();
        thor.Tipo = "herói";

        // Exibe o tipo do personagem
        Console.WriteLine("O personagem é do tipo: " + thor.Tipo);
    }
}


