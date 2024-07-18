using System.Collections.ObjectModel;
using Domain.Entities.Base;
using Domain.Exceptions;

namespace Domain.Entities;

public class ReadingPlan : Entity
{
    //navigators
    public int BookId { get; private set; }
    public Book Book { get; private set; } 
    
    public IReadOnlyCollection<Reminder> Reminders => _reminders.AsReadOnly();
    private readonly Collection<Reminder> _reminders = [];

    protected ReadingPlan()
    {
        
    }

    public ReadingPlan(Book book)
    {
        Book = book;
        BookId = book.Id;
    }
}