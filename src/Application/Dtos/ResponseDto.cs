namespace Application.Dtos;


public record ResponseDto
{
    public bool IsSuccessfully { get; protected init; }
    public bool IsFailed => !IsSuccessfully;
    public string? ErrorMessage { get; protected set; } = null;

    protected ResponseDto()
    {
        
    }
    
    public ResponseDto(bool isSuccessfully, string? errorMessage = null)
    {
        IsSuccessfully = isSuccessfully;
        ErrorMessage = errorMessage;
    }
}

public record ResponseDto<T> : ResponseDto
{

    public T? Data { get; private set; }

    public ResponseDto(bool isSuccessfully, T? data, string? errorMessage = null)
    {
        IsSuccessfully = isSuccessfully;
        Data = data;
        ErrorMessage = errorMessage;
    }
    
    public ResponseDto(T? data)
    {
        IsSuccessfully = true;
        Data = data;
    }
}