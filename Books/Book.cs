using System.IO;
namespace Books;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }

    public int CurrentPage = 0;
    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    public int NextPage()
    {
        if (CurrentPage <= Pages)
            return CurrentPage++;
        else
            throw new ArgumentException("That was the last page");
    }

    public int PreviousPage()
    {
        if (CurrentPage >= 0)
            return CurrentPage--;

        return 0;
    }

    public void SavePage()
    {
        string filePath = @"D:\Pages\";
        if (!Directory.Exists(filePath))
        {
            Directory.CreateDirectory(filePath);
        }
        File.WriteAllText(filePath + "page.txt", CurrentPage.ToString());
        Console.WriteLine("Text file created successfully.");
    }
}
