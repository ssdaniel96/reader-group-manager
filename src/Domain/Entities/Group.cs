using System.Collections.ObjectModel;
using Domain.Entities.Base;
using Domain.Exceptions;

namespace Domain.Entities;

public class Group : Entity
{
    private readonly Collection<Book> _books = [];
    private readonly Collection<Member> _members = [];

    public Group(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }

    // navigators
    public IReadOnlyCollection<Book> Books => _books.AsReadOnly();

    public IReadOnlyCollection<Member> Members => _members.AsReadOnly();

    public void AddMembers(List<Member> members)
    {
        foreach (var member in members)
        {
            if (_members.Contains(member))
                throw new DomainException("This member is already in this group.");

            if (_members.Any(p => p.Name == member.Name))
                throw new DomainException("This group already has a member with this name.");

            _members.Add(member);
        }
    }

    public Member GetNextMember(Member member)
    {
        var members = _members.ToList();
        if (members.Count == 0)
            throw new DomainException(
                "This group is empty. It is necessary at least one member to generate next member.");

        var memberIndex = members.IndexOf(member);
        return memberIndex == members.Count - 1 ? members.First() : members[memberIndex + 1];
    }
}