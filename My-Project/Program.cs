using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Database class to interact with the database
        Database db = new Database();

        while (true)
        {
            // Display the menu for the user
            DisplayMenu();
            string choice = Console.ReadLine();
            
            // Handle the user's menu choice
            switch (choice)
            {
                case "1":
                    // Fetch and display countries by population
                    db.GetCountriesByPopulation();
                    break;
                case "2":
                    // Handle the request for the top cities in a continent
                    HandleTopCitiesRequest(db);
                    break;
                case "3":
                    // Display the language speaker statistics
                    db.GetLanguageSpeakers();
                    break;
                case "4":
                    // Exit the program with a farewell message
                    Console.WriteLine("\nExiting... Goodbye!");
                    return;
                default:
                    // Handle invalid menu choices
                    Console.WriteLine("\nInvalid choice! Please try again.");
                    break;
            }

            // Prompt the user to continue or exit
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }

    // Displays the main menu options for the user to choose from
    static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine(" Population Reporting System");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("1. View Countries by Population");
        Console.WriteLine("2. View Top Cities in a Continent");
        Console.WriteLine("3. View Language Speaker Statistics");
        Console.WriteLine("4. Exit");
        Console.Write("\nEnter your choice: ");
    }

    // Prompts the user for input to view top cities in a specific continent
    static void HandleTopCitiesRequest(Database db)
    {
        // Request continent name from the user
        Console.Write("\nEnter Continent Name: ");
        string continent = Console.ReadLine();

        int topN;
        while (true)
        {
            // Prompt the user for the number of top cities to display
            Console.Write("Enter Number of Top Cities to Display: ");
            if (int.TryParse(Console.ReadLine(), out topN) && topN > 0)
                break;  // Valid input; proceed
            // Handle invalid input and prompt again
            Console.WriteLine("Invalid input! Please enter a valid positive number.");
        }

        // Fetch and display the top cities in the specified continent
        db.GetTopCitiesInContinent(continent, topN);
    }
}
