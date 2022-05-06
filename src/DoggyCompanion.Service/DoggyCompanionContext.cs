using DoggyCompanion.Domain.PetEvents;
using DoggyCompanion.Domain.Pets;
using DoggyCompanion.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace DoggyCompanion.Service;

public class DoggyCompanionContext : DbContext
{
    public DbSet<Pet> Pets { get; set; }

    public DbSet<BathroomEvent> BathroomEvents { get; set; }

    public DbSet<EatEvent> EatEvents { get; set; }

    public DbSet<ExerciseEvent> ExerciseEvents { get; set; }

    public DbSet<SleepEvent> SleepEvents { get; set; }

    public DbSet<User> Users { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql();
    }
}