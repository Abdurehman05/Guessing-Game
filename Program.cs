using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess the secret number?");
            Console.Write("Your Guess number is: ");
            string guess = Console.ReadLine();
            Console.WriteLine(guess);


        }
    }
}
