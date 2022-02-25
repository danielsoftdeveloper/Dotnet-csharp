// Jogo Papel, Tesoura e Pedra

using System;

namespace jogoPapelTesouraPedra
{
    class Program
    {
        static string MyMethod(int gameOption){

            string objeto;

            if (gameOption == 1)
            {
                objeto = "pedra";
            }
            else if (gameOption == 2)
            {
                objeto = "papel";

            }
            else
            {
                //gameOption: 3
                objeto = "tesoura";
            }

            return objeto;
        }
        
        static void Main(string[] args)
        {
            int opcao1;
            int opcao2;
            string objeto1;
            string objeto2;

            Console.Clear();
            Console.WriteLine("Jogo o começou");

            Console.WriteLine("Escolha entre pedra (1), Papel (2) Tesoura (3)");
            Console.Write("Jogador 1: ");
            opcao1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Escolha entre pedra (1), Papel (2) Tesoura (3)");
            Console.Write("Jogador 2: ");
            opcao2 = Convert.ToInt32(Console.ReadLine());           

            objeto1 = MyMethod(Convert.ToInt32(opcao1));
            objeto2 = MyMethod(Convert.ToInt32(opcao2));

             //teste   
            Console.WriteLine(objeto1);
            Console.WriteLine(objeto2);
        }

    }
}