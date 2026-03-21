using System;
using System.Collections.Generic;

/// <summary>
/// Scripture Memorizer Program - Advanced Features Implementation
/// 
/// CORE REQUIREMENTS MET:
/// - Store scriptures with both reference (book, chapter, verse) and text
/// - Clear console and display complete scripture with reference
/// - Prompt user to press Enter or type quit
/// - Keep the program running in a loop
/// 
/// REQUIREMENTS EXCEEDED WITH ADDITIONAL FEATURES:
/// 
/// 1. SCRIPTURE LIBRARY (Not just a single scripture):
///    - Program includes 6 different Book of Mormon scriptures in a list
///    - Displays a random scripture each time the program runs
///    - Provides variety to practice multiple passages
/// 
/// 2. STUDY TOPICS FOR CONTEXT:
///    - Each scripture includes a topic/theme displayed above the text
///    - Helps users understand the meaning and purpose of each passage
///    - Improves comprehension while memorizing (not just rote memorization)
///    - Example: "Topic: How Christ's Grace Turns Weaknesses into Strengths"
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        // Initialize a list to store all available scriptures
        List<Scripture> scriptures = new List<Scripture>();
        
        // Add scriptures to the list with their references, text, and topics for study
        var ref1 = new Reference("Ether", 12, 27);
        var scripture1 = new Scripture(ref1, "I will make weak things become strong unto them that have faith in me", "Topic: How Christ's Grace Turns Weaknesses into Strengths");
        scriptures.Add(scripture1);
        
        var ref2 = new Reference("Mosiah", 3, 19);
        var scripture2 = new Scripture(ref2, "The natural man is an enemy to God and has been since the fall of Adam", "Topic: Overcoming the Natural Man Through the Atonement");
        scriptures.Add(scripture2);
        
        var ref3 = new Reference("1 Nephi", 3, 7);
        var scripture3 = new Scripture(ref3, "I will go and do the things which the Lord hath commanded for I know that the Lord giveth no commandments unto the children of men save he shall prepare a way for them", "Topic: Faith and Obedience in Following God's Commandments");
        scriptures.Add(scripture3);
        
        var ref4 = new Reference("Alma", 32, 21);
        var scripture4 = new Scripture(ref4, "Faith is not to have a perfect knowledge of things therefore if ye have faith ye hope for things which are not seen which are true", "Topic: The True Definition of Faith");
        scriptures.Add(scripture4);
        
        var ref5 = new Reference("Mosiah", 2, 17);
        var scripture5 = new Scripture(ref5, "When ye are in the service of your fellow beings ye are only in the service of your God", "Topic: Service to Others as Service to God");
        scriptures.Add(scripture5);
        
        var ref6 = new Reference("2 Nephi", 2, 25);
        var scripture6 = new Scripture(ref6, "Adam fell that men might be and men are that they might have joy", "Topic: The Purpose of Mortality and Joy");
        scriptures.Add(scripture6);
        
        // Select a random scripture from the list to practice
        Random random = new Random();
        int randomIndex = random.Next(scriptures.Count);
        Scripture scripture = scriptures[randomIndex];
        
        // Game loop - continue hiding words until all are hidden or user quits
        while (!scripture.IsCompletelyHidden())
        {
            // Clear the screen and display the scripture with its topic
            Console.Clear();
            Console.WriteLine(scripture.GetTopic());
            Console.WriteLine();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            // Display progress to motivate user and show memorization advancement
            Console.WriteLine(scripture.GetProgress());
            Console.WriteLine();
            Console.Write("Press Enter to hide a word, or type 'quit' to exit: ");
            
            // Get user input
            string input = Console.ReadLine();
            
            // Check if user wants to quit
            if (input.ToLower() == "quit")
            {
                break;
            }
            
            // Hide 1-3 consecutive unhidden words
            scripture.HideRandomWord();
        }
        
        // Display the completed scripture and congratulations message
        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetTopic());
            Console.WriteLine();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            // Show final progress (100% memorized)
            Console.WriteLine(scripture.GetProgress());
            Console.WriteLine();
            Console.WriteLine("🎉 Congratulations! You've memorized the entire scripture! 🎉");
        }
    }
}