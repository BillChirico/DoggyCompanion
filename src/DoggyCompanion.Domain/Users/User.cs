using DoggyCompanion.Domain.Entities;

namespace DoggyCompanion.Domain.Users;

public class User : Entity
{
    public string Name { get; set; }

    public string Email { get; set; }
}