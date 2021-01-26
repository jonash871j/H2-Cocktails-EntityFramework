using System.ComponentModel.DataAnnotations;

namespace Cocktails.Models.Entities
{
    public class Ingredient
    {
        [Key]
        public string Name { get; set; }
        public IngredientType IngredientType { get; set; }

        /// <summary>
        /// For some reason entity framework needs a default constructor
        /// </summary>
        public Ingredient() { }
        public Ingredient(string name, IngredientType ingredientType)
        {
            Name = name;
            IngredientType = ingredientType;
        }
    }
}
