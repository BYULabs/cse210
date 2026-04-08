using System;

class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                return;
            }
            else if (choice == "2")
            {
                return;
            }
            else if (choice == "3")
            {
                return;
            }
            else if (choice == "4")
            {
                return;
            }
            else if (choice == "5")
            {
                return;
            }
            else if (choice =="6")
            {
                break;
            }
            else
            {
                Console.WriteLine("That is not a valid choice.");
            }
        }

    }
}