using Booksies.Models;

namespace Booksies.ExampleBooks;

public class FantasyBooks
{
    private readonly List<Book> books = new() {
        new Book("Name of the Wind", "Patrick Rothfuss", "Kvothe on the quest to learn the name of the wind", 376),
        new Book("A Little Hatred", "Joe Abercrombie", "he chimneys of industry rise over Adua and the world seethes with new opportunities. But old scores run deep as ever. On the blood-soaked borders of Angland, Leo dan Brock struggles to win fame on the battlefield, and defeat the marauding armies of Stour Nightfall.", 432)
    };

    public List<Book> Fetch()
    {
        return books;
    }
}
