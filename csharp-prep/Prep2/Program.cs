using System;

class Program
{
    static void Main(string[] args)
    {
    
        Console.WriteLine();
        Console.Write("What was your grade percentage in CSE 210? ");
        string yourScore = Console.ReadLine();
        int x = int.Parse(yourScore);
        string letter = "";
        
        if (x >= 90)
        {
            letter = "A";  
        }

        else if (x >= 80)
        {
            letter = "B"; 
        }

        else if (x >= 70)
        {
            letter = "C";  
        }

        else if (x >= 60)
        {
            letter = "D";  
        }

        else if (x < 50)
        {
            letter = "F";  
        }
        Console.WriteLine($"{letter}");
    }
}