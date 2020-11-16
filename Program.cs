using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Random random = new System.Random();
            int secretNumber = random.Next(1, 100);
            int count = 1;
            while (count < 5)
            {
                Console.WriteLine("Can you guess the secret number?");
                Console.WriteLine($"{5 - count} guesses has left.");
                Console.WriteLine($"Your Guess number ({count}):");
                Console.Write("Your Guess number is: ");



                int guess = int.Parse(Console.ReadLine());

                if (guess == secretNumber)
                {
                    Console.WriteLine("You got It!!");
                    break;
                }
                else
                {
                    if (guess > secretNumber)
                    {
                        Console.WriteLine("Wrong! Guess too high");
                    }
                    else
                    {
                        Console.WriteLine("Wrong! Guess too low");
                    }
                }

                count++;

            }
        }
    }
}
