using System;
using System.Collections.Generic;

public class Database
{
    // Simulated database (Replace with actual database calls in a real application)
    private List<Country> countries = new List<Country>
    {
        new Country("USA", 331002651, "North America", "English"),
        new Country("China", 1393409038, "Asia", "Mandarin"),
        new Country("India", 1366417754, "Asia", "Hindi"),
        new Country("Brazil", 212559417, "South America", "Portuguese"),
        new Country("Nigeria", 206139589, "Africa", "English")
    };

    private List<City> cities = new List<City>
    {
        new City("New York", "USA", 8419600),
        new City("Tokyo", "Japan", 13929286),
        new City("London", "UK", 8982000),
        new City("Paris", "France", 2140526),
        new City("Shanghai", "China", 24150000)
    };

    private List<Language> languages = new List<Language>
    {
        new Language("English", 1500000000),
        new Language("Mandarin", 1100000000),
        new Language("Hindi", 600000000),
        new Language("Spanish", 560000000),
        new Language("French", 275000000)
    };

    /// <summary>
    /// Get the list of countries by population, ordered from largest to smallest.
    /// </summary>
    public void GetCountriesByPopulation()
    {
        Console.WriteLine("Countries by Population:");
        var sortedCountries = new List<Country>(countries);
        sortedCountries.Sort((x, y) => y.Population.CompareTo(x.Population)); // Sorting by population (descending)

        foreach (var country in sortedCountries)
        {
            Console.WriteLine($"{country.Name} - Population: {country.Population}");
        }
    }

    /// <summary>
    /// Get the top N cities in a specific continent.
    /// </summary>
    public void GetTopCitiesInContinent(string continent, int topN)
    {
        Console.WriteLine($"\nTop {topN} Cities in {continent}:");

        // Filter cities by continent and sort by population
        var continentCities = cities.FindAll(city => city.Country == continent); // Replace with actual continent filtering logic

        continentCities.Sort((x, y) => y.Population.CompareTo(x.Population)); // Sorting cities by population

        int count = 0;
        foreach (var city in continentCities)
        {
            if (count >= topN) break;
            Console.WriteLine($"{city.Name} - Population: {city.Population}");
            count++;
        }
    }

    /// <summary>
    /// Get language speakers statistics.
    /// </summary>
    public void GetLanguageSpeakers()
    {
        Console.WriteLine("\nLanguage Speaker Statistics:");

        foreach (var language in languages)
        {
            Console.WriteLine($"{language.Name} - {language.Speakers} speakers");
        }
    }
}

/// <summary>
/// Represents a Country.
/// </summary>
public class Country
{
    public string Name { get; set; }
    public long Population { get; set; }
    public string Continent { get; set; }
    public string OfficialLanguage { get; set; }

    public Country(string name, long population, string continent, string language)
    {
        Name = name;
        Population = population;
        Continent = continent;
        OfficialLanguage = language;
    }
}

/// <summary>
/// Represents a City.
/// </summary>
public class City
{
    public string Name { get; set; }
    public string Country { get; set; }
    public long Population { get; set; }

    public City(string name, string country, long population)
    {
        Name = name;
        Country = country;
        Population = population;
    }
}

/// <summary>
/// Represents a Language and its number of speakers.
/// </summary>
public class Language
{
    public string Name { get; set; }
    public long Speakers { get; set; }

    public Language(string name, long speakers)
    {
        Name = name;
        Speakers = speakers;
    }
}
