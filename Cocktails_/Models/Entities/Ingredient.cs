using System.ComponentModel.DataAnnotations;

namespace Cocktails.Models.Entities
{
    public class Ingredient
    {
        [Key]
        public string Name { get; set; }

        [Required]
        public IngredientType IngredientType { get; set; }

        // For some reason entity framework needs a default constructor
        public Ingredient() { }
        public Ingredient(string name, IngredientType ingredientType)
        {
            Name = name;
            IngredientType = ingredientType;
        }
    }
}