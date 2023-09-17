using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine();
        Console.Write("What was your grade percentage in CSE 210? ");
        string yourScore = Console.ReadLine();
        int x = int.Parse(yourScore);

        if (x >= 90)
        {
            Console.WriteLine("Wow! You got an A");
        }

        else if (x < 90 && x >= 80)
        {
            Console.WriteLine("You got a B.");
        }

        else if (x < 80 && x >= 70)
        {
            Console.WriteLine("You got a C.");
        }

        else if (x < 70 && x >= 60)
        {
            Console.WriteLine("You got a D.");
        }
        
        else
        {
            Console.WriteLine("You got a F.");

        }

        if (x >= 70)
        {
            Console.WriteLine("Congratulation! You passed the course.");
        }

        else
        {
            Console.WriteLine("Not yet. Work harder and you will pass it next semester.");
        }
        Console.WriteLine();

    }
}