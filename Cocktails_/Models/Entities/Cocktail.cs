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

        [ForeignKey("IngredientDescription")]
        public List<IngredientDescription> IngredientDescription { get; set; }

        // For some reason entity framework needs a default constructor
        public Cocktail() { }
        public Cocktail(string name, GlassType glassType, List<IngredientDescription> ingredientDescriptions)
        {
            Name = name;
            GlassType = glassType;
            IngredientDescription = ingredientDescriptions;
        }
    }
}