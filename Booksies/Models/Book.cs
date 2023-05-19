namespace Booksies.Models;

public class Book
{
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public string Description { get; set; } = "";
    public int Pages { get; set; }

    public Book() { }

    public Book(string title, string author, string description, int pages)
    {
        Title = title;
        Author = author;
        Description = description;
        Pages = pages;
    }
}
