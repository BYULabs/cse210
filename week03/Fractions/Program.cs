using System;

class Program
{
    static void Main(string[] args)
    {
        // Create three fraction instances
        Fractions fr1 = new Fractions();
        Fractions fr2 = new Fractions(6);
        Fractions fr3 = new Fractions(6, 7);

        // Display initial values
        Console.WriteLine("Initial values:");
        Console.WriteLine($"fr1: {fr1.GetTop()}/{fr1.GetBottom()}");
        Console.WriteLine($"fr2: {fr2.GetTop()}/{fr2.GetBottom()}");
        Console.WriteLine($"fr3: {fr3.GetTop()}/{fr3.GetBottom()}");

        // Use setters to change values
        Console.WriteLine("\nChanging values using setters...");
        fr1.SetTop(3);
        fr1.SetBottom(4);
        fr2.SetTop(5);
        fr2.SetBottom(2);
        fr3.SetTop(9);
        fr3.SetBottom(8);

        // Use getters to retrieve new values and display to console
        Console.WriteLine("\nUpdated values:");
        Console.WriteLine($"fr1: {fr1.GetTop()}/{fr1.GetBottom()}");
        Console.WriteLine($"fr2: {fr2.GetTop()}/{fr2.GetBottom()}");
        Console.WriteLine($"fr3: {fr3.GetTop()}/{fr3.GetBottom()}");

        // Test the default constructor (1/1)
        Fractions f1 = new Fractions();
        Console.WriteLine($"f1: {f1.GetFractionString()} = {f1.GetDecimalValue()}");

        // Test the whole number constructor (5/1)
        Fractions f2 = new Fractions(5);
        Console.WriteLine($"f2: {f2.GetFractionString()} = {f2.GetDecimalValue()}");

        // Test the top/bottom constructor (3/4)
        Fractions f3 = new Fractions(3, 4);
        Console.WriteLine($"f3: {f3.GetFractionString()} = {f3.GetDecimalValue()}");

        // Test with additional fractions
        Fractions f4 = new Fractions(1, 3);
        Console.WriteLine($"f4: {f4.GetFractionString()} = {f4.GetDecimalValue()}");

        Fractions f5 = new Fractions(8, 3);
        Console.WriteLine($"f5: {f5.GetFractionString()} = {f5.GetDecimalValue()}");
    }
}