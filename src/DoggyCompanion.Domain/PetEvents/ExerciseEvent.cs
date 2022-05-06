using DoggyCompanion.Domain.Entities;

namespace DoggyCompanion.Domain.PetEvents;

public class ExerciseEvent : PetEventEntity
{
    public ExerciseType Type { get; set; }

    public DateTime EndTime { get; set; }
}

public enum ExerciseType
{
    Walk,
    Run,
    Play
}