﻿using Dictionary;

// Basic adding array in Dictionary
int[] numbers = {9 ,8 ,10 , 1, 7, 5, 2, 3, 4, 5,};
int[] numbers2 = {9 ,8 ,10 , 1, 7, 5, 2, 3, 4, 5,};

Dictionary<string, int[]> dict = new Dictionary<string, int[]>();

dict.Add("Numbers", numbers);
dict["Numbers2"] = numbers2;

foreach (var refName in dict)
{
    Console.WriteLine(refName.Key);
    foreach (var number in refName.Value)
        Console.WriteLine(number);
}


List<Country> U = new List<Country>()
{
    new Country("Uganda", "Kampala"),
    new Country("Ukraine", "Kyiv"),
    new Country("United Arab Emirates", "Abu Dhabi"),
    new Country("United Kingdom", "London"),
    new Country("United States", "Washington, D.C."),
    new Country("Uruguay", "Montevideo"),
    new Country("Uzbekistan", "Tashkent")
};

List<Country> G = new List<Country>()
{
    new Country("Ghana", "Accra"),
    new Country("Greenland", "Nuuk"),
    new Country("Greece", "Athens")
};

List<Country> P = new List<Country>()
{
    new Country("Pakistan", "Islamabad"),
    new Country("Panama", "Panama City"),
    new Country("Paraguay", "Asunción"),
    new Country("Peru", "Lima"),
    new Country("Philippines", "Manila"),
    new Country("Poland", "Warsaw"),
    new Country("Portugal", "Lisbon")
};

Dictionary<string, List<Country>> countries = new();
countries.Add("P", P);
countries.Add("U", U);
countries.Add("G", G);

foreach (var country in countries)
{
    string countryLetter = country.Key;
    Console.WriteLine($"Group {countryLetter} country");
    foreach (var i in country.Value)
    {
        Console.WriteLine($"{i}");
    }
}

Console.WriteLine("Choose the first letter of the country");
string? input = Console.ReadLine();
if (input != null)
{
    input = input.Trim().ToUpper();
    char result = input.ToCharArray()[0];
    input = result.ToString();
    Console.WriteLine($"You choose [{input}]");
    if (countries.TryGetValue(input, out List<Country>? countryList))
    {
        foreach (var resultCountry in countryList)
        {
            Console.WriteLine($"{resultCountry.CountryName} ({resultCountry.CountryCapital})");
        }
    }
    else
    {
        Console.WriteLine("Cannot find");
    }
    
}
