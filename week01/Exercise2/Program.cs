using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string gradeInput = Console.ReadLine();
        double gradeValue = double.Parse(gradeInput);
        string gradeLetter = "";
        string pass = "";
        if (gradeValue >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradeValue >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradeValue >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradeValue >= 60)
        {
            gradeLetter = "D";
        }
        else if (gradeValue < 60)
        {
            gradeLetter = "F";
        }
        else
        {
            gradeLetter = "Invalid Score";
        }
        if (gradeValue >= 70)
        {
            pass = "Congrats! You passed the class!";
        }
        else if (gradeValue < 70)
        {
            pass = "Sorry, you did not pass the class, try again.";
        }
        else
        {
            pass = "Invalid Score";
        }
        Console.WriteLine($"Your grade is a {gradeLetter}.");
        Console.WriteLine($"{pass}");

    }
}