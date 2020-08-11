using System;
using System.Collections.Generic;

namespace Puzzles_II
{
    class Program

    {
        public static string TossCoin()
        {
            Random rand = new Random();
            Console.WriteLine("Tossing a Coin!");
            int toss = rand.Next(1, 3);
            string outcome = (toss == 1) ? "Heads" : "Tails";
            Console.WriteLine(outcome);
            return outcome;
        }

        public static double TossMultipleCoins(int num)
        {
            double heads = 0;
            double tails = 0;
            for (int i = 0; i < num; i++)
            {
                string outcome = TossCoin();
                if (outcome == "Heads")
                {
                    heads += 1;
                }
                else
                {
                    tails += 1;
                }
            }

            double ratio = (heads / tails);
            Console.WriteLine($"Ratio of {heads} heads to {tails} tails in {num} coin tosses is {ratio}");
            return ratio;
        }
        static void Main(string[] args)
        {
            TossMultipleCoins(10);
        }
    }
}


/*
Coin Flip
Create a function called TossCoin() that returns a string

Have the function print "Tossing a Coin!"
Randomize a coin toss with a result signaling either side of the coin 
Have the function print either "Heads" or "Tails"
Finally, return the result
Create another function called TossMultipleCoins(int num) that returns a Double

Have the function call the tossCoin function multiple times based on num value
Have the function return a Double that reflects the ratio of head toss to total toss
*/
