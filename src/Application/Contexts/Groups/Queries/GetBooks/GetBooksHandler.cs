using Application.Contexts.Groups.Dtos;
using Application.Contexts.Groups.Repositories;
using Application.Dtos;
using MapsterMapper;
using MediatR;

namespace Application.Contexts.Groups.Queries.GetBooks;

public class GetBooksHandler(IBooksRepository booksRepository, IMapper mapper)
    : IRequestHandler<GetBooksQuery, ResponseDto<List<BookDto>>>
{
    public async Task<ResponseDto<List<BookDto>>> Handle(GetBooksQuery request, CancellationToken cancellationToken)
    {
        var entities = await booksRepository.GetAll(request.GroupId, cancellationToken);

        var result = mapper.Map<List<BookDto>>(entities);

        return new(result);
    }
}