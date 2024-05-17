using XMLSerialization;
using System.Text.Json;

    StreetAddress add1 = new StreetAddress { StreetNumber = 324, StreetName = "Fieldstone Bay", City = "Winnipeg" };
    StreetAddress add2 = new StreetAddress { StreetNumber = 562, StreetName = "Kenaston Blvd", City = "Winnipeg" };
    StreetAddress add3 = new StreetAddress { StreetNumber = 547, StreetName = "Gunn Rd", City = "Winnipeg" };

    Person person1 = new Person { FirstName = "Bill", LastName = "Watson", Addresses = new List<StreetAddress>() { add1, add2, add3 } };

    Person person2 = new Person { FirstName = "Naresh", LastName = "Nagandla", Addresses = new List<StreetAddress>() { add2 } };

    Person person3 = new Person { FirstName = "John", LastName = "Doe", Addresses = new List<StreetAddress>() { add3 } };

    Person person4 = new Person { FirstName = "Marvin", LastName = "Cholo", Addresses = new List<StreetAddress>() { add3 } };

    List<Person> people = new List<Person> { person1, person2, person3, person4 };
    var js = JsonSerializer.Serialize(people);
    // create a file to write to
    string path = @"D:\temp\person.json";
    // Delete the file if it exists.
    if (File.Exists(path))
    {
        File.Delete(path);
    }

    using (StreamWriter stream = new StreamWriter(path))
    {
        // serialize the object to the stream 
        stream.Write(js);
    }
    // Display the serialized object
    Console.WriteLine(File.ReadAllText(path));
