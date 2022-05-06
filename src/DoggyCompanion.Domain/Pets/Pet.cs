using DoggyCompanion.Domain.Entities;
using DoggyCompanion.Domain.PetEvents;

namespace DoggyCompanion.Domain.Pets;

public class Pet : Entity
{
    public string Name { get; set; }
    public PetType PetType { get; set; }

    public IEnumerable<BathroomEvent> BathroomEvents { get; set; }
    public IEnumerable<EatEvent> EatEvents { get; set; }
    public IEnumerable<SleepEvent> SleepEvents { get; set; }
}