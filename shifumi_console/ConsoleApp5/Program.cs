using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static int countVictory = 0;
        static int countGame = 0;
        static void Main(string[] args)
        {
            int PlayGame;
            bool game = true;
            Console.WriteLine("appuyé sur 1 pour jouer");
            while (game == true)
            {
                if (int.TryParse(Console.ReadLine(), out PlayGame))
                {
                    if (PlayGame == 1)
                    {
                        Console.Clear();
                        play();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("rentrez un nombre valide \n \n appuyé sur 1  pour jouer");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("rentrez un nombre valide \n \n appuyé sur 1  pour jouer");
                }
            }
          
        }

        public static void play()
        {
            {
                Console.WriteLine("rentrez un nombre entre 1 et 3 compris");
                int numberPlayer;
                int.TryParse(Console.ReadLine(), out numberPlayer);
                Random random = new Random();
                int numberRandom = random.Next(0, 4);
                numberRandom = random.Next(0, 4);
                try
                {
                    if (numberPlayer == 1 || numberPlayer == 2 || numberPlayer == 3)
                    {
                        if (numberPlayer == 1 && numberRandom == 1 || numberPlayer == 2 && numberRandom == 2 || numberPlayer == 3 && numberRandom == 3)
                        {
                            countGame += 1;
                            Console.WriteLine("egalité  \n nombre de partie: " + countGame + "\n nombre de victoire: " + countVictory + "\n\n appuyer sur 1 pour jouer");
                        }
                        else if (numberPlayer < numberRandom)
                        {
                            countGame += 1;
                            Console.WriteLine("perdu!  \n nombre de partie: " + countGame + "\n nombre de victoire: " + countVictory + "\n\n appuyer sur 1 pour jouer");
                        }
                        else
                        {
                            countGame += 1;
                            countVictory++;
                            Console.WriteLine("victoire \n nombre de partie: " + countGame + "\n nombre de victoire: " + countVictory + "\n\n appuyer sur 1 pour jouer");
                        }

                    }
                    else
                    {
                        Console.WriteLine("rentrez un nombre valide");
                    };
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine("rentrez un nombre valide");
                }
            }

        }
    }
}
