using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            int secretNumber = 42;
            int count = 1;
            while (count < 5)
            {
                Console.WriteLine("Can you guess the secret number?");
                Console.Write("Your Guess number is: ");
                Console.Write($"Your Guess ({count}) ");

                int guess = int.Parse(Console.ReadLine());

                if (guess == secretNumber)
                {
                    Console.WriteLine("You got It!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong");
                }

                count++;

            }
        }
    }
}
