using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int userNumber = -1;

            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            // 1. COLLECT NUMBERS
            while (userNumber != 0)
            {
                Console.Write("Enter number: ");
                string response = Console.ReadLine();
                userNumber = int.Parse(response);

                // Only add to the list if it's NOT the sentry value (0)
                if (userNumber != 0)
                {
                    numbers.Add(userNumber);
                }
            }

            // 2. CORE REQUIREMENTS
            // Compute Sum
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum is: {sum}");

            // Compute Average
            // Note: We cast sum to double to ensure we get decimal precision
            double average = ((double)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            // Find Maximum
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The largest number is: {max}");

            // 3. STRETCH CHALLENGES
            // Find smallest positive number (closest to zero)
            int minPositive = int.MaxValue; // Start with the highest possible integer
            foreach (int number in numbers)
            {
                if (number > 0 && number < minPositive)
                {
                    minPositive = number;
                }
            }
            Console.WriteLine($"The smallest positive number is: {minPositive}");

            // Sort and Display
            numbers.Sort();
            Console.WriteLine("The sorted list is:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}