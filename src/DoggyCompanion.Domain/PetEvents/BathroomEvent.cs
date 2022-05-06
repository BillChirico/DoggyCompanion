using DoggyCompanion.Domain.Entities;

namespace DoggyCompanion.Domain.PetEvents;

public class BathroomEvent : PetEventEntity
{
    public BathroomEventType Type { get; set; }
}

public enum BathroomEventType
{
    Pee,
    Doody,
    Other
}