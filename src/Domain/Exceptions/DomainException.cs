namespace Domain.Exceptions;

public class DomainException(string details, Exception? innerException = null) 
    : Exception(details, innerException)
{
    
}