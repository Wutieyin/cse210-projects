using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();

        int yourNumber = -1;
        while (yourNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string yourResponse = Console.ReadLine();
            yourNumber = int.Parse(yourResponse);
        

             if (yourNumber != 0)
            {
                numbers.Add(yourNumber);
            }
        }

        // Part 1: Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Part 2: Find the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3: Find the max
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (max < number)
            {
                // if the max is less than the number, the number becomes the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}