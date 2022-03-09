// Jogo Papel, Tesoura e Pedra

using System;

namespace jogoPapelTesouraPedra
{
    class Program
    {
        static string MyMethod(int gameOption)
        {
            string result;

            switch (gameOption)
            {
                case 1:
                    result = "Pedra";
                    break;

                case 2:
                    result = "Papel";
                    break;

                case 3:
                    result = "Tesoura";
                    break;

                default:
                    result = "Erro";
                    break;
            }

            return result;
        }

        static void resultGame(int opcao1, int opcao2)
        {
            if (opcao1 == opcao2)
            {
                Console.WriteLine("\n");
                Console.WriteLine("As duas opções são iguais, então empatou");
            }

            else if (opcao1 == 1)
            {
                if (opcao2 == 3)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Jogador 1 ganhou!");
                    Console.WriteLine("A Pedra quebra a tesoura do Jogador 2");
                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Jogador 2 ganhou");
                    Console.WriteLine("O papel embrulha a pedra");
                }
            }
            else if (opcao1 == 2)
            {
                if (opcao2 == 1)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Jogador 1 ganhou!");
                    Console.WriteLine("O papel embrulha a pedra");
                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Jogador 2 ganhou");
                    Console.WriteLine("A tesoura corta o papel");
                }

            }

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
                    Console.WriteLine("A tesoura corta o papel");
                }

            }

        }

        static void Main(string[] args)
        {
            int opcao1;
            int opcao2;
            string objeto1;
            string objeto2;

            Console.Clear();
            Console.WriteLine("O jogo começou!");

            do
            {
                Console.WriteLine("Escolha uma opção entre (1) Pedra, (2) Papel ou (3)Tesoura.");
                Console.Write("Jogador 1: ");
                opcao1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

            } while (opcao1 < 1 || opcao1 > 3);

            do
            {
                Console.WriteLine("Escolha uma opção entre (1) Pedra, (2) Papel ou (3)Tesoura.");
                Console.Write("Jogador 2: ");
                opcao2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

            } while (opcao2 < 1 || opcao2 > 3);

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