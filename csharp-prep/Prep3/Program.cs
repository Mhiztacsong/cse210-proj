using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";

        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int userGuess = 0;
            
            // stretch chalenge 1
            int guessNumber = 0;

            do
            {
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine()); 
                guessNumber += 1;

                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            } while (userGuess != magicNumber);

            Console.WriteLine($"It took you {guessNumber} guesses.");

            Console.WriteLine();

            // stretch challenge 2
            Console.Write("Would you like to play again [yes/no]? ");
            response = Console.ReadLine();
        }
        if (response == "no")
        {
            Console.WriteLine("Thank you for playing");
        }
    }
}