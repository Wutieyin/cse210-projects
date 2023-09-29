using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else if (y < number)
            {
                Console.WriteLine("Higer");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }   
        Console.WriteLine();
    }

    
}