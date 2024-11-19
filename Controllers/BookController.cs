using BookManagementAPI.Communication.Requests;
using BookManagementAPI.Communication.Responses;
using BookManagementAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookManagementAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookController : BookManagementAPIBaseController
{
    // Criar um livro
    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreatedBookJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] CreateBookRequestJson request)
    {
        var response = new ResponseCreatedBookJson()
        {
            Id = 1,
            Title = request.Title
        };

        return Created(string.Empty, response);
    }

    // Visualizar todos os livros criados
    [HttpGet]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<Book>()
        {
            new Book { Id = 1, Title = "O Senhor dos Anéis - A sociedade do anel", Author = "J.R.R. Tolkien", Genre = Genres.GenresOptions.Fiction, Price = 77.8f, Stock = 10 },
            new Book { Id = 2, Title = "O Senhor dos Anéis - As duas torres", Author = "J.R.R. Tolkien", Genre = Genres.GenresOptions.Fiction, Price = 77.8f, Stock = 10 },
            new Book { Id = 3, Title = "O Senhor dos Anéis - O retorno do Rei", Author = "J.R.R. Tolkien", Genre = Genres.GenresOptions.Fiction, Price = 77.8f, Stock = 10 },
            new Book { Id = 4, Title = "O Hobbit", Author = "J.R.R. Tolkien", Genre = Genres.GenresOptions.Fiction, Price = 67.8f, Stock = 10 }
        };

        return Ok(response);
    }

    // Visualizar um livro pelo ID
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    public IActionResult Get([FromRoute] int id) 
    {
        var response = new Book()
        {
            Id = 1,
            Title = "O Senhor dos Anéis - A sociedade do anel",
            Author = "J.R.R. Tolkien",
            Genre = Genres.GenresOptions.Fiction,
            Price = 77.8f,
            Stock = 10
        };
        return Ok(response);
    }

    // Editar informacoes de um livro
    [HttpPost]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestUpdateBookJson request) {
        // bloco de ações para fazer update do livro
        return NoContent();
    }

    // Excluir um livro
    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] int id)  {
        // bloco de ações para deletar o livro
        return NoContent(); 
    }
}
