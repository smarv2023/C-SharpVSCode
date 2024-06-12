namespace Books;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set;}

    public List<Book> Books { get; set; } = new List<Book>();
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}
