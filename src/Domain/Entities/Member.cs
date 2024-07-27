using Domain.Entities.Base;

namespace Domain.Entities;

public class Member : Entity
{
    public Member(string name, Group group)
    {
        Name = name;
        Enabled = true;
        Group = group;
        GroupId = group.Id;
    }

    public string Name { get; private set; }
    public bool Enabled { get; private set; }

    //navigators
    public int GroupId { get; private set; }
    public Group Group { get; private set; }
}