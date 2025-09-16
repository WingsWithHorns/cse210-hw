using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int input = 1;
        List<int> numbers = new List<int>();
        while (input != 0)
        {
            Console.WriteLine("Enter number: ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        }
        int total = 0;
        foreach (int i in numbers)
        {
            total += i;
        }
        Console.WriteLine($"The total of your numbers is {total}.");
        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average of your numbers is {average}.");
        int max = numbers[0];
        foreach (int i in numbers)
        {
            if (i > max)
            {
                max = i;
            }
        }
        Console.WriteLine($"The max number in your set is {max}.");


    }
}