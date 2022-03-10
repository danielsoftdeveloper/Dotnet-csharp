// Jogo Papel, Tesoura e Pedra

using System;

namespace jogoPapelTesouraPedra
{
    class Program
    {
        static string returnsObjectName(int gameOption)
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

        static void showGameResult (int option1, int option2)
        {
            if (option1 == option2)
            {                
                Console.WriteLine("As duas opções são iguais, então empatou");
            }

            else if (option1 == 1)
            {
                if (option2 == 3)
                {                    
                    Console.WriteLine("Jogador 1 ganhou!");
                    Console.WriteLine("A Pedra quebra a tesoura do Jogador 2");
                }
                else
                {                    
                    Console.WriteLine("Jogador 2 ganhou");
                    Console.WriteLine("O papel embrulha a pedra");
                }
            }
            else if (option1 == 2)
            {
                if (option2 == 1)
                {
                    Console.WriteLine("Jogador 1 ganhou!");
                    Console.WriteLine("O papel embrulha a pedra");
                }
                else
                {                    
                    Console.WriteLine("Jogador 2 ganhou");
                    Console.WriteLine("A tesoura corta o papel");
                }
            }

            else if (option1 == 3)
            {
                if (option2 == 1)
                {
                    Console.WriteLine("Jogador 2 Ganhou!");
                    Console.WriteLine("A pedra quebra a tesoura");
                }
                else
                {                    
                    Console.WriteLine("Jogador 1 Ganhou");
                    Console.WriteLine("A tesoura corta o papel");
                }
            }

        }

        static void Main(string[] args)
        {
            int option1;
            int option2;
            string object1;
            string object2;

            Console.Clear();
            Console.WriteLine("O jogo começou!");

            do
            {
                Console.WriteLine("Escolha uma opção entre (1) Pedra, (2) Papel ou (3)Tesoura.");
                Console.Write("Jogador 1: ");
                option1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

            } while (option1 < 1 || option1 > 3);

            do
            {
                Console.WriteLine("Escolha uma opção entre (1) Pedra, (2) Papel ou (3)Tesoura.");
                Console.Write("Jogador 2: ");
                option2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

            } while (option2 < 1 || option2 > 3);

            object1 = returnsObjectName(Convert.ToInt32(option1));
            object2 = returnsObjectName(Convert.ToInt32(option2));

            Console.Clear();
            Console.WriteLine("Resultado: ");
            Console.WriteLine("\n");
            showGameResult(option1, option2);

            {
                Console.WriteLine("Jorgador 1: " + object1 + ", jogador 2: " + object2);
            }
        }
    }
}