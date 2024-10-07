using Evently.Modules.Events.Domain.Abstraction;

namespace Evently.Modules.Events.Domain.Events;

public sealed class EventCreateDomainEvent(Guid eventId) : DomainEvent
{
    public Guid EventId { get; init; } = eventId;
}
