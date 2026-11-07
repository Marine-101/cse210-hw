using System;
using System.Xml.Serialization;
// Stretch: Reflection questions do not repeat until all questions have been used.
class Program
{
    static void Main(string[] args)
    {
    string choice = "";
    while(choice != "4")
        {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");
        choice = Console.ReadLine();

        if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }

        else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
            }
        
        else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
        else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
            }

        else
            {
                Console.WriteLine("Sorry that is an invalid option :()");
            }
        }
    }
}