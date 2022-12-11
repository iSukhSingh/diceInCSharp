using System;

namespace Dice_Game
{
    class program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
						int enemyRandomNum;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("press any key to roll thje dice");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("you have rolled a " + playerRandomNum);
								System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("AI have rolled a " + enemyRandomNum);
            }




            Console.ReadKey();

        }
    }
}