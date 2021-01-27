using System.ComponentModel.DataAnnotations;

namespace Cocktails.Models.Entities
{
    public class Food
    {
        [Key]
        public string Name { get; set; }
        public FoodType FoodType { get; set; }

        public Food(string name, FoodType foodType)
        {
            Name = name;
            FoodType = foodType;
        }
    }
}
