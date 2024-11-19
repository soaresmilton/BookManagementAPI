using static BookManagementAPI.Genres;

namespace BookManagementAPI.Communication.Requests;

public class RequestUpdateBookJson
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;

    public GenresOptions Genre { get; set; }

    public float Price { get; set; }

    public int Stock { get; set; }
}
