using DoggyCompanion.Domain.Pets;

namespace DoggyCompanion.Domain.Entities;

public class PetEventEntity : Entity
{
    public DateTime DateTime { get; set; }

    public ulong PetId { get; set; }

    public Pet Pet { get; set; }
}