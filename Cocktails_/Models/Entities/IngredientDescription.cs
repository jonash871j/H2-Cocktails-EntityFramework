using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cocktails.Models.Entities
{
    public class IngredientDescription
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Ingredient { get; set; }

        [Required]
        public string Description { get; set; }

        // For some reason entity framework needs a default constructor
        public IngredientDescription() { }
        public IngredientDescription(string ingredient, string description)
        {
            Ingredient = ingredient;
            Description = description;
        }
    }
}