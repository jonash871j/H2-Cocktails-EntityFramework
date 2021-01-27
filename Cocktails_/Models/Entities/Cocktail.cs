using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cocktails.Models.Entities
{
    public class Cocktail
    {
        [Key]
        public string Name { get; set; }

        [Required]
        public GlassType GlassType { get; set; }
        [Required]
        public List<Ingredient> IngredientDescription { get; set; } = new List<Ingredient>();

        // For some reason entity framework needs a default constructor
        public Cocktail() { }
        public Cocktail(string name, GlassType glassType, List<Ingredient> ingredientDescriptions)
        {
            Name = name;
            GlassType = glassType;
            IngredientDescription = ingredientDescriptions;
        }
    }
}