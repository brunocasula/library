using Library.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers;

public class BookController : BaseController
{
    

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] BookEntity request)
    {
        BookListEntity.Add(request);
        
        return Ok();
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(List<BookEntity>), StatusCodes.Status400BadRequest)]
    public IActionResult Index()
    {
        return Ok(BookListEntity.books.Values);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] int id, [FromBody] BookEntity request)
    {
        BookListEntity.Update(request);

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] int id)
    {
        BookListEntity.Delete(id);

        return NoContent();
    }
}
