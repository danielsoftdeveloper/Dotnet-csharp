// Jogo Papel, Tesoura e Pedra

using System;

namespace jogoPapelTesouraPedra
{
    class Program
    {
        static string MyMethod(int gameOption)
        {

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

        static void resultGame(int opcao1, int opcao2)
        {

            if (opcao1 == opcao2)
            {
                Console.WriteLine("\n");
                Console.WriteLine("As duas opções são iguais então empate");

            }
            else if (opcao1 == 1)
            {
                if (opcao2 == 3)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Jogador 1 Ganhou!");
                    Console.WriteLine("Pedra quebra tesoura do Jogador 2");

                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Jogador 2 ganhou");
                    Console.WriteLine("Papel embrulha pedra");

                }
            }
            else if (opcao1 == 2)
            {
                if (opcao2 == 1)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Jogador 1 Ganhou!");
                    Console.WriteLine("O papel embrulha a pedra");

                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Jogador 2 Ganhou");
                    Console.WriteLine("Tesoura corta papel");

                }

            }

            //
            else if (opcao1 == 3)
            {
                if (opcao2 == 1)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Jogador 2 Ganhou!");
                    Console.WriteLine("A pedra quebra a tesoura");

                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Jogador 1 Ganhou");
                    Console.WriteLine("A Tesoura corta papel");

                }

            }
            //

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

            Console.Clear();
            Console.WriteLine("Resultado: ");
            resultGame(opcao1, opcao2);

            {
                Console.WriteLine("Jorgador 1: " + objeto1 + ", jogador 2: " + objeto2);
            }




        }

    }
}