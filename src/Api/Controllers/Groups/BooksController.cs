using Application.Contexts.Groups.Commands.AddBook;
using Application.Contexts.Groups.Commands.RemoveBook;
using Application.Contexts.Groups.Commands.UpdateBook;
using Application.Contexts.Groups.Dtos;
using Application.Contexts.Groups.Queries.GetBooks;
using Application.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Groups;

[ApiController]
[Route("groups/{groupId:guid}/[controller]")]
public class BooksController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<BookDto>>> GetBooks(GetBooksQuery getBooksQuery)
    {
        var result = await mediator.Send(getBooksQuery);

        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<ResponseDto<Guid>>> AddBook([FromBody] AddBookCommand addBookCommand)
    {
        var result = await mediator.Send(addBookCommand);

        return Ok(result);
    }

    [HttpDelete("{bookId:guid}")]
    public async Task<ActionResult<ResponseDto>> RemoveBook([FromRoute] RemoveBookCommand removeBookCommand)
    {
        var result = await mediator.Send(removeBookCommand);

        return Ok(result);
    }

    [HttpPut("{bookId:guid}")]
    public async Task<ActionResult<ResponseDto<BookDto>>> UpdateBook(UpdateBookCommand updateBookCommand)
    {
        var result = await mediator.Send(updateBookCommand);

        return Ok(result);
    }
}