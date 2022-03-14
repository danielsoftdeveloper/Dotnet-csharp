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

                case 9:
                    result = "Saiu";
                    break;

                default:
                    result = "Erro";
                    break;
            }

            return result;
        }

        static void showGameResult(int option1, int option2)
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
                
                if(option2 == 2)
                {
                    Console.WriteLine("Jogador 2 ganhou");
                    Console.WriteLine("O papel embrulha a pedra");
                }
                else
                {
                    Console.WriteLine("Jogador 2 jogou errado!");
                    Console.WriteLine("Então ninguém ganhou!");
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
        static bool wantToPlayAgain()
        {
            int toWantToPlay;
            bool toPlay; 

            //Console.Clear();

            Console.WriteLine("Deseja jogar novamente? (1) Continua jogando ou (2) Para sair da Aplicação");

            try
            {
                toWantToPlay = Convert.ToInt32(Console.ReadLine());

                if (toWantToPlay == 1)
                {
                    toPlay = true;
                }
                else
                {
                    toPlay = false;
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Digitou errado.");
                toPlay = false;
            }

            return toPlay;

        }

        static void Main(string[] args)
        {
            bool ToContinue = true;

            while (ToContinue)
            {
                int option1 = 0;
                int option2 = 0;
                string object1 = "Vazio";
                string object2 = "Vazio"; ;
                bool cancelaJogo = false;
                

                Console.Clear();
                Console.WriteLine("O jogo começou!");

                try
                {
                    Console.WriteLine("Escolha uma opção entre (1) Pedra, (2) Papel ou (3)Tesoura ou (9) Para sair do jogo.");
                    Console.Write("Jogador 1: ");
                    option1 = Convert.ToInt32(Console.ReadLine());
                    object1 = returnsObjectName(Convert.ToInt32(option1));
                    if (object1 == "Saiu")
                    {
                        Console.WriteLine("Saiu Jogador 1");
                        cancelaJogo = true;
                        ToContinue = false;
                    }
                    //Console.Clear();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro Jogador 1");
                    cancelaJogo = true;
                    Console.WriteLine(e.Message);
                }

                if (!cancelaJogo)
                {
                    try
                    {
                        Console.WriteLine("Escolha uma opção entre (1) Pedra, (2) Papel ou (3)Tesoura (9) Para sair do jogo.");
                        Console.Write("Jogador 2: ");

                        option2 = Convert.ToInt32(Console.ReadLine());
                        object2 = returnsObjectName(Convert.ToInt32(option2));
                        if (object2 == "Saiu")
                        {
                            Console.WriteLine("Saiu Jogador 2");
                            cancelaJogo = true;
                            ToContinue = false;

                        }
                        Console.Clear();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro Jogador 2");
                        cancelaJogo = true;
                        Console.WriteLine(e.Message);
                    }

                }

                Console.WriteLine("Resultado: ");
                Console.WriteLine("\n");
                if (cancelaJogo)
                {
                    Console.WriteLine("Digitou errado ou Você saiu do jogo!");
                    Console.WriteLine("Jorgador 1: " + object1 + ", jogador 2: " + object2);
                }
                else
                {
                    showGameResult(option1, option2);
                    Console.WriteLine("Jorgador 1: " + object1 + ", jogador 2: " + object2);
                }
                Console.ReadKey();

                ToContinue = wantToPlayAgain();

            }
        }
    }
}