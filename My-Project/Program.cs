using System;

class Program
{
    static void Main(string[] args)
    {
        DatabaseHelper dbHelper = new DatabaseHelper();

        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    dbHelper.GetCountriesByPopulation();
                    break;
                case "2":
                    HandleTopCitiesRequest(dbHelper);
                    break;
                case "3":
                    dbHelper.GetLanguageSpeakers();
                    break;
                case "4":
                    Console.WriteLine("\nExiting... Goodbye!");
                    return;
                default:
                    Console.WriteLine("\nInvalid choice! Please try again.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Displays the main menu options.
    /// </summary>
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

    /// <summary>
    /// Handles user input for viewing top cities in a continent.
    /// </summary>
    static void HandleTopCitiesRequest(DatabaseHelper dbHelper)
    {
        Console.Write("\nEnter Continent Name: ");
        string continent = Console.ReadLine();

        int topN;
        while (true)
        {
            Console.Write("Enter Number of Top Cities to Display: ");
            if (int.TryParse(Console.ReadLine(), out topN) && topN > 0)
                break;
            Console.WriteLine("Invalid input! Please enter a valid positive number.");
        }

        dbHelper.GetTopCitiesInContinent(continent, topN);
    }
}
