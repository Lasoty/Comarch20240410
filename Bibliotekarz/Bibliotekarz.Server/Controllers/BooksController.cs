using Bibliotekarz.Data.Context;
using Bibliotekarz.Data.Model;
using Bibliotekarz.Shared.ModelDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Bibliotekarz.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    private readonly ApplicationDbContext dbContext;

    public BooksController(ApplicationDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    [HttpGet("All")]
    public async Task<IActionResult> GetAllBooks()
    {
        List<Book> books = await dbContext.Books
            .Where(b => b.PageCount != null && b.PageCount > 0)
            .OrderBy(b => b.Author).ThenByDescending(b => b.Title)
            .ToListAsync();


        IEnumerable<BookDto> booksDto = books.Select(b => new BookDto
        {
            Id = b.Id,
            Author = b.Author,
            Title = b.Title,
            IsBorrowed = b.IsBorrowed,
            PageCount = b.PageCount.HasValue ? b.PageCount.Value : 0,
            BorrowerFirstName = b.Borrower?.FirstName,
            BorrowerLastName = b.Borrower?.LastName
        });
        return Ok(booksDto);
    }

    [HttpPost("Add")]
    public async Task<IActionResult> AddBook(AddBookDto request)
    {
        Book book = new Book()
        {
            Author = request.Author,
            Title = request.Title,
            PageCount = request.PageCount,
            IsBorrowed = request.IsBorrowed
        };

        if (request.IsBorrowed)
        {
            Customer customer = new Customer
            {
                FirstName = request.BorrowerFirstName,
                LastName = request.BorrowerLastName,
            };

            book.Borrower = customer;
        }

        dbContext.Books.Add(book);
        await dbContext.SaveChangesAsync();
        return Ok(book);
    }

    private List<BookDto> GenerateFakeData()
    {
        //var fakeData = new List<BookDto>();
        //fakeData.Add(new BookDto());
        //BookDto book = fakeData[0];
        //fakeData.RemoveAt(0);
        //fakeData.Remove(book);

        //var fakeData = new Dictionary<string, BookDto>();
        //fakeData.Add("ISBN_374629873469287364", new BookDto());
        //BookDto book = fakeData["ISBN_374629873469287364"];
        //fakeData.Remove("ISBN_374629873469287364");

        //var fakeData = new Queue<BookDto>(); //FIFO
        //fakeData.Enqueue(new BookDto());
        //var book = fakeData.Dequeue();
        //book = fakeData.Peek();

        //var fakeData = new Stack<BookDto>(); //FILO
        //fakeData.Push(new BookDto());
        //BookDto book = fakeData.Pop();

        List<BookDto> books =
            [
                new BookDto
                {
                    Id = 1,
                    Author = "Leszek Lewandowski",
                    Title = "Programowa",
                    PageCount = 1,
                    IsBorrowed = true,
                    BorrowerFirstName = "Adam",
                    BorrowerLastName = "Nowak"
                },
                new BookDto
                {
                    Id = 2,
                    Author = "John Sharp",
                    Title = "ASP.NET Core 2.0",
                    PageCount = 1,
                    IsBorrowed = false
                }
            ];

        return books;
    }
}
