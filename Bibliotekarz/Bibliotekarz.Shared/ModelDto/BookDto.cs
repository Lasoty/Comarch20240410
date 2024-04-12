namespace Bibliotekarz.Shared.ModelDto;

public class BookDto
{
    public int Id { get; set; }

    public required string Title { get; set; }

    public string Author { get; set; }

    public int PageCount { get; set; }

    public bool IsBorrowed { get; set; }

    public string BorrowerFirstName { get; set; }

    public string BorrowerLastName { get; set; }

}
