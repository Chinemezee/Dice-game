using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable to dice points rolled
            int PlayerNumber;
            int CpuNumber;
            //variable to keep scores
            int PlayerScore = 0;
            int CpuScore = 0;


            //code to generate random numbers
            Random random = new Random();
            //number of loops(length of the game)
            for (int i = 0; i < 7; i++) {

                Console.WriteLine("Press any key to roll the dice");

                Console.ReadKey();
                //limits the dice scores for player to 1-6
                PlayerNumber = random.Next(1, 7);
                Console.WriteLine("Player rolled " + PlayerNumber);
                
                Console.WriteLine("...");
                //time gap for computer play
                System.Threading.Thread.Sleep(1000);

                //limits the dice scores for computer to 1-6
                CpuNumber = random.Next(1, 7);
                Console.WriteLine("Computer rolled " + CpuNumber);

                //to keep scores and win
                if(PlayerNumber > CpuNumber)
                {
                    PlayerScore++;
                    Console.WriteLine("Player wins this round");
                } 
                else if(CpuNumber > PlayerNumber)
                {
                    CpuScore++;
                    Console.WriteLine("Computer wins this round");
                } 
                else
                {
                    Console.WriteLine("Draw!!!");
                }
                Console.WriteLine("Player score: " + PlayerScore + " Computer score: " + CpuScore);
                Console.WriteLine();

            }
            //code to end the game and declare winner
            if (PlayerScore > CpuScore)
            {
                Console.WriteLine("YOU WIN :)");
            }
            else if (PlayerScore < CpuScore)
            {
                Console.WriteLine("YOU LOSE :(");
            }
            else
            {
                Console.WriteLine("DRAW :|");
            }

            Console.ReadKey();
        }
    }
}
