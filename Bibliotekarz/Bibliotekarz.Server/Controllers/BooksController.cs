using Bibliotekarz.Shared.ModelDto;
using Microsoft.AspNetCore.Mvc;

namespace Bibliotekarz.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    public BooksController()
    {

    }

    [HttpGet("All")]
    public async Task<IActionResult> GetAllBooks()
    {
        List<BookDto> fakeData = GenerateFakeData();
        return Ok(fakeData);
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
