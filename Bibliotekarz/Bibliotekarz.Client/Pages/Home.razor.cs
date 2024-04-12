using Bibliotekarz.Shared.ModelDto;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace Bibliotekarz.Client.Pages;

public partial class Home : ComponentBase
{
    [Inject]
    public HttpClient HttpClient { get; set; }

    public List<BookDto> Books { get; set; } = new();

    public AddBookDto Model { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var response = await HttpClient.GetFromJsonAsync<List<BookDto>>("Books/All");
        //await HttpClient.PostAsJsonAsync("Books/Add", Books[0]);
        Books.AddRange(response);

        await base.OnInitializedAsync();
    }
}
