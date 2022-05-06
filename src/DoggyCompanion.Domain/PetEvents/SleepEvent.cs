using DoggyCompanion.Domain.Entities;

namespace DoggyCompanion.Domain.PetEvents;

public class SleepEvent : PetEventEntity
{
    public DateTime EndTime { get; set; }
}