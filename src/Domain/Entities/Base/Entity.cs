namespace Domain.Entities.Base;

public abstract class Entity
{
    public int Id { get; protected set; }
    public Guid GuidId { get; protected set; } = Guid.NewGuid();
}