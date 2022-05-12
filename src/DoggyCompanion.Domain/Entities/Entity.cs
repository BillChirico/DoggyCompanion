using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoggyCompanion.Domain.Entities;

public class Entity
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public ulong Id { get; set; }
}