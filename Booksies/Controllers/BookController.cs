using Booksies.Models;
using Booksies.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Booksies.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    private readonly BookDataService _bookDataService;

    public BookController(BookDataService bookDataService)
    {
        _bookDataService = bookDataService;
    }

    [HttpGet]
    public ActionResult<List<Book>> GetBooks()
    {
        var result = _bookDataService.FetchBooks();
        return Ok(result);
    }
}
