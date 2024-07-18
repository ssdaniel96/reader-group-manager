using System.Collections.ObjectModel;
using Domain.Entities.Base;
using Domain.Exceptions;

namespace Domain.Entities;

public class Group : Entity
{
    public string Name { get; private set; }
    
    // navigators
    public IReadOnlyCollection<Book> Books => _books.AsReadOnly();
    private readonly Collection<Book> _books = [];

    public IReadOnlyCollection<Member> Members => _members.AsReadOnly();
    private readonly Collection<Member> _members = [];
    
    public Member GetNextMember(Member member)
    {
        var members =_members.ToList();
        if (members.Count == 0)
            throw new DomainException("This group is empty. It is necessary at least one member to generate next member.");
                
        var memberIndex = members.IndexOf(member);
        return memberIndex == members.Count - 1 ? members.First() : members[memberIndex + 1];
    }

    public Group(string name)
    {
        Name = name;
    }
}