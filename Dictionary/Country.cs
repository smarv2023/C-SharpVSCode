namespace Dictionary;

public class Country
{
    public string CountryName { get; set;}
    public string CountryCapital { get; set;}

    public Country(string countryName, string countryCapital)
    {
        CountryName = countryName;
        CountryCapital = countryCapital;
    }

    public override string ToString()
    {
        return $"Country: {CountryName} Capital: {CountryCapital}";
    }
}
