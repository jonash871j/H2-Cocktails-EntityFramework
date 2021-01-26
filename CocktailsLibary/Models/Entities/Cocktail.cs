using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailsLib.Models
{
    public class Cocktail
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public GlassType Glass { get; set; }
    }
}
