using System.Collections.ObjectModel;
using Domain.Entities.Base;

namespace Domain.Entities;

public class Book : Entity
{
    public string Title { get; private set; }
    public string? Author { get; private set; }
    public int Pages { get; private set; }
    
    // navigators
    public int GroupId { get; private set; }
    public Group Group { get; private set; }
    
    public IReadOnlyCollection<ReadingPlan> ReadingPlans => _readingPlans.AsReadOnly();
    private readonly Collection<ReadingPlan> _readingPlans = [];
}