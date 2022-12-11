using System;

namespace Dice_Game
{
    class program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoint = 0;
            int enemyPonit = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("press any key to roll thje dice");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("you have rolled a " + playerRandomNum);
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("AI have rolled a " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoint++;
                    Console.WriteLine("You won this round");
                }
                else if (enemyRandomNum > enemyPonit)
                {
                    enemyPonit++;
                    Console.WriteLine("AI wins this round");
                }
                else
                {
                    Console.WriteLine("Draw");
                }
                Console.WriteLine($"the score is now \nYou:{playerPoint} \nAI: {enemyPonit} .");
                Console.WriteLine();
            }




            Console.ReadKey();

        }
    }
}