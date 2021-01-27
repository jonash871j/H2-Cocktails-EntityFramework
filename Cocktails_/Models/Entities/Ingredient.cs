using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cocktails.Models.Entities
{
    public class Ingredient
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Food { get; set; }

        [Required]
        public string Description { get; set; }

        [ForeignKey("Cocktail")]
        public string CocktailName { get; set; }

        /// <summary>
        /// For some reason entity framework needs a default constructor
        /// </summary>
        public Ingredient() { }
        public Ingredient(string food, string description)
        {
            Food = food;
            Description = description;
        }
    }
}
