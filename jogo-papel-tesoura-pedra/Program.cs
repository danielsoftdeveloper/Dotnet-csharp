// Jogo Papel, Tesoura e Pedra

using System;

namespace jogoPapelTesouraPedra
{
    class Program
    {
        static void Main(string[] args)
        {
             int opcao1;
            int opcao2;

            Console.Clear();
            Console.WriteLine("Jogo o começou");

            Console.WriteLine("Escolha entre pedra (1), Papel (2) Tesoura (3)");
            Console.Write("Jogador 1: ");
            opcao1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Escolha entre pedra (1), Papel (2) Tesoura (3)");
            Console.Write("Jogador 2: ");
            opcao2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(opcao1);
            Console.WriteLine(opcao2);
        }

    }
}