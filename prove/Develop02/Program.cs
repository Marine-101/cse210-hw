using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Search");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                journal.Add_Entry();
            }

            else if (choice == "2")
            {
                journal.DisplayALL();
            }

            else if (choice == "3")
            {
                journal.LoadFromFile();
            }

            else if (choice == "4")
            {
                journal.SaveToFile();
            }
            // Extra feature: Search journal entries by word or phrase,
            // ignoring capitalization and searching prompts and responses.
            else if (choice == "5")
            {
                journal.SearchEntries();
            }

            else if (choice == "6")
            {
                Console.WriteLine("Have a good day. ");
            }
            else 
            {
                Console.WriteLine("Invalid choice. please try again. ");
            }

        }
    }
}

