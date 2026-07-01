using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number?");
        string input = Console.ReadLine();
        int magicNumber = int.Parse(input);

        Console.WriteLine("What is your guess?");
        string guessInput = Console.ReadLine();
        int guess = int.Parse(guessInput);

        while (guess != magicNumber)
        {
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }

            Console.WriteLine("What is your guess?");
            guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);
        }

        if (guess == magicNumber)
        {
            Console.WriteLine("You guessed it!");
        }
        else if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("Lower");
        }
    }
}