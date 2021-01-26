using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cocktails.Models.Entities
{
    public class IngredientDescription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Ingredient Ingredient { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// For some reason entity framework needs a default constructor
        /// </summary>
        public IngredientDescription() { }
        public IngredientDescription(Ingredient ingredient, string description)
        {
            Ingredient = ingredient;
            Description = description;
        }
    }
}
