namespace Evently.Modules.Events.Domain.Abstraction;

public abstract class DomainEvent : IDomainEvent
{

    protected DomainEvent()
    {
        Id = Guid.NewGuid();
        OccurredOn = DateTime.UtcNow;
    }

    protected DomainEvent(Guid id, DateTime occurredOn)
    {
        OccurredOn = occurredOn;
        Id = id;
    }
    public Guid Id { get; init; }
    public DateTime OccurredOn { get; init; }
}
