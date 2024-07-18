using System.Security.AccessControl;

namespace Domain.ValueObject;

public class ReminderNote
{
    public int Page { get; set; }
    public string Chapter { get; set; }
    public int Paragraph { get; set; }

    public ReminderNote(int page, string chapter, int paragraph)
    {
        Page = page;
        Chapter = chapter;
        Paragraph = paragraph;
    }
}