using System.ComponentModel.DataAnnotations;

namespace Cocktails.Models.Entities
{
    public class Ingredient
    {
        [Key]
        public string Name { get; set; }
        public IngredientType IngredientType { get; set; }

        public Ingredient(string name, IngredientType ingredientType)
        {
            Name = name;
            IngredientType = ingredientType;
        }
    }
}
