using static BookManagementAPI.Genres;

namespace BookManagementAPI.Communication.Responses;

public class ResponseCreatedBookJson
{

    public int Id { get; set; } 
    public string Title { get; set; } = string.Empty;
    public GenresOptions Genre { get; set; }
}
