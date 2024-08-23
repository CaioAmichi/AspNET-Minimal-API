using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RangoAgil.API.Entitites;

public class Meal
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public required string Name { get; set; }
    public Collection<Ingredient> Ingredients { get; set; } = [];
    public Meal()
    {

    }

    [SetsRequiredMembers]
    public Meal(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

