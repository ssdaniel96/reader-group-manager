using System.Collections.ObjectModel;
using Domain.Entities.Base;

namespace Domain.Entities;

public class Book : Entity
{
    private readonly Collection<ReadingPlan> _readingPlans = [];

    public Book(Group group, string title, string? author, int pages, string? sourceUrl)
    {
        Title = title;
        Author = author;
        Pages = pages;

        if (sourceUrl is not null)
            SourceUrl = new(sourceUrl);

        Group = group;
        GroupId = group.Id;
    }

    public string Title { get; private set; }
    public string? Author { get; private set; }
    public int Pages { get; private set; }
    public Uri? SourceUrl { get; private set; }

    // navigators
    public int GroupId { get; private set; }
    public Group Group { get; private set; }

    public IReadOnlyCollection<ReadingPlan> ReadingPlans => _readingPlans.AsReadOnly();

    public void UpdateData(string title, string? author, int pages, string? sourceUrl)
    {
        Title = title;
        Author = author;
        Pages = pages;

        if (sourceUrl is not null)
            SourceUrl = new(sourceUrl);
    }
}