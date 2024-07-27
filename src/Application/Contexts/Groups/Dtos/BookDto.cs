namespace Application.Contexts.Groups.Dtos;

public record BookDto(Guid Id, string Title, string Author, int Pages, string? SourceUrl);