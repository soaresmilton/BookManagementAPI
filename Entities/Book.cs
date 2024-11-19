using static BookManagementAPI.Genres;

namespace BookManagementAPI.Entities;

public class Book
{
  
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public GenresOptions Genre { get; set; }

    public float Price { get; set; }

    public int Stock { get; set; }

}
