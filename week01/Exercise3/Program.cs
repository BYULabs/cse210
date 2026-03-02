using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            // Generate a random magic number from 1 to 100
            int magicNumber = random.Next(1, 101);
            int guess = -1;
            int guessCount = 0;

            // Loop until the user guesses the magic number
            while (guess != magicNumber)
            {
                // Ask for a guess
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                // Determine if the guess is higher, lower, or correct
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // Inform the user of how many guesses they made
            Console.WriteLine($"It took you {guessCount} guesses.");

            // Ask if they want to play again
            Console.Write("Do you want to play again? (yes/no) ");
            string response = Console.ReadLine().ToLower();

            if (response != "yes")
            {
                playAgain = false;
            }
        }
    }
}