using System;

namespace Dice_Game
{
    class program
    { 
        static void Main(string[] args)
        {
            int playerRandomNum;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("press any key to roll thje dice");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WiteLine("you have rolled a " + playerRandomNum);
            }
						Console.readKey();
           
        }
    }
}