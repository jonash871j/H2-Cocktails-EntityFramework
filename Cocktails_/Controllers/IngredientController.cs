using Cocktails.Models;
using System.Collections.Generic;
using System.Linq;
using Cocktails.Models.Entities;

namespace Cocktails.Controllers
{
    public class IngredientController : IController<Ingredient, string>
    {
        private CocktailDBContext context = new CocktailDBContext();

        public void Create(Ingredient ingredient)
        {
            context.Add(ingredient);
            context.SaveChanges();
        }
        public void Delete(string key)
        {
            Ingredient ingredient = Get(key);
            context.Ingredients.Remove(ingredient);
        }
        public void DeleteAll()
        {
            context.Ingredients.RemoveRange(context.Ingredients);
            context.SaveChanges();
        }
        public Ingredient Get(string key)
        {
            return context.Ingredients.Where(c => c.Name == key).FirstOrDefault();
        }
        public IEnumerable<Ingredient> GetAll()
        {
            return context.Ingredients;
        }
    }
}