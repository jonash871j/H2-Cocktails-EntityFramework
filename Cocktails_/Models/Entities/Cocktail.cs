using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cocktails.Models.Entities
{
    public class Cocktail
    {
        [Key]
        public string Name { get; set; }
        public List<IngredientDescription> Ingredients { get; set; }
        public GlassType GlassType { get; set; }

        /// <summary>
        /// For some reason entity framework needs a default constructor
        /// </summary>
        public Cocktail() { }
        public Cocktail(string name, List<IngredientDescription> ingredients, GlassType glassType)
        {
            Name = name;
            Ingredients = ingredients;
            GlassType = glassType;
        }
    }
}
