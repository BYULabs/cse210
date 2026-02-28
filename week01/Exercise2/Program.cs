using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();

        int grade = int.Parse(gradePercentage);

        string sign = "";

        if (grade % 10 >= 7 && grade < 90)
        {
            sign = "+";
        }
        else if (grade % 10 < 3)
        {
            sign = "-";
        }

        if (grade >= 90)
        {
            Console.WriteLine($"Your letter grade is an A{sign}.");
        }
        else if (grade >= 80)
        {
            Console.WriteLine($"Your letter grade is a B{sign}.");
        }
        else if (grade >= 70)
        {
            Console.WriteLine($"Your letter grade is a C{sign}.");
        }
        else if (grade >= 60)
        {
            Console.WriteLine($"Your letter grade is a D{sign}.");
        }
        else
        {
            Console.WriteLine($"Your letter grade is an F.");
        }
        
    }
}