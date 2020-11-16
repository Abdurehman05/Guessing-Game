using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess the secret number?");
            Console.Write("Your Guess number is: ");
            int secretNumber = 42;
            int guess = int.Parse(Console.ReadLine());

            if (guess == secretNumber)
            {
                Console.WriteLine("You got It!!");
            }
            else
            {
                Console.WriteLine("Wrong");
            }



        }
    }
}
