using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RangoAgil.API.Entitites;

public class Ingredient
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public required string Name { get; set; }
    public Collection<Meal> Meals { get; set; } = [];

    public Ingredient()
    {
            
    }

    [SetsRequiredMembers]
    public Ingredient(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

