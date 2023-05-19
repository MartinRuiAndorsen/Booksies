using Booksies.ExampleBooks;
using Booksies.Models;

namespace Booksies.Services;

public class BookDataService
{
    private readonly FantasyBooks _fantasyBooks = new();
    public List<Book> FetchBooks()
    {
        return _fantasyBooks.Fetch();
    }
}
