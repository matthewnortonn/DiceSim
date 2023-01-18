using System;

namespace Mission02
{
    class Mission2Dice
    {
        static void Main()
        {
            //Welcome
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many dice tolls would you like to simulate?");

            //Take user input to count how many rolls
            int rolls = int.Parse(Console.ReadLine());

            //Creating an array to store the results
            int[] results = new int[13];

            //rolling two dice
            for (int i = 0; i < rolls; i++)
            {
                int dice1 = new Random().Next(1, 7);
                int dice2 = new Random().Next(1, 7);
                int total = dice1 + dice2;
                results[total]++;
            }


            //printing the results 
            Console.WriteLine($"DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine($"Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {rolls}");

            for (int i = 2; i <= 12; i++)
            {
                Console.Write($"{i}: ");
                int percentage = (int)((double)results[i] / rolls * 100);
                for (int j = 0; j < percentage; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Closing Message to user
            Console.WriteLine("Thankyou for using the dice throwing simulator. Goodbye!");
        }
    }
}

