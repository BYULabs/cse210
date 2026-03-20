using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();
        
        var ref1 = new Reference("John", 3, 16);
        var scripture1 = new Scripture(ref1, "For God so loved the world that he gave his one and only Son");
        scriptures.Add(scripture1);
        
        var ref2 = new Reference("Proverbs", 3, 5, 6);
        var scripture2 = new Scripture(ref2, "Trust in the Lord with all your heart and lean not on your own understanding");
        scriptures.Add(scripture2);
        
        Random random = new Random();
        int randomIndex = random.Next(scriptures.Count);
        
        Console.Clear();
        Console.WriteLine(scriptures[randomIndex].GetDisplayText());
    }
}