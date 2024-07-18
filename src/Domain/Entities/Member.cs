using Domain.Entities.Base;

namespace Domain.Entities;

public class Member : Entity
{
    public string Name { get; private set; }
    public bool Enabled { get; private set; }
    
    //navigators
    public int GroupId { get; private set; }
    public Group Group { get; private set; }
}