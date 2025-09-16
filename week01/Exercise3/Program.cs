using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        Console.WriteLine("Guess the magic number: ");
        int guessNumber = int.Parse(Console.ReadLine());
        while (guessNumber != magicNumber)
        {
            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Your guess was too high. try again. ");
                guessNumber = int.Parse(Console.ReadLine());
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Your guess was too low. try again. ");
                guessNumber = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("That is an invalid guess. try again. ");
                guessNumber = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine($"The magic number was {magicNumber}! You got it right!");
    }
}