namespace Application.Dtos;

public record ResponseDto<T>
{
    public bool IsSuccessfully { get; private set; }
    public bool IsFailed => !IsSuccessfully;
    public string? ErrorMessage { get; private set; } = null;
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