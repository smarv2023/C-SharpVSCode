using Books;

Person marv = new Person("Marv", "Sor");

Book harry = new Book("Test", "Testor",10);

marv.Books.Add(harry);

Console.WriteLine(harry.CurrentPage);

harry.NextPage();
Console.WriteLine(harry.CurrentPage);

harry.SavePage();


