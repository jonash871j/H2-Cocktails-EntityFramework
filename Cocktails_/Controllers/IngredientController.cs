using Cocktails.Models;
using System.Collections.Generic;
using System.Linq;
using Cocktails.Models.Entities;

namespace Cocktails.Controllers
{
    public class IngredientController : IController<Ingredient, string>
    {
        public void Create(Ingredient ingredient)
        {
            using (CocktailDBContext context = new CocktailDBContext())
            {
                context.Ingredients.Add(ingredient);
                context.SaveChanges();
            }
        }
        public void Delete(string key)
        {
            using (CocktailDBContext context = new CocktailDBContext())
            {
                Ingredient ingredient = Get(key);
                context.Ingredients.Remove(ingredient);
            }
        }
        public void DeleteAll()
        {
            using (CocktailDBContext context = new CocktailDBContext())
            {
                context.Ingredients.RemoveRange(context.Ingredients);
                context.SaveChanges();
            }
        }
        public Ingredient Get(string key)
        {
            using (CocktailDBContext context = new CocktailDBContext())
            {
                return context.Ingredients.Where(c => c.Name == key).FirstOrDefault();
            }
        }
        public List<Ingredient> GetAll()
        {
            using (CocktailDBContext context = new CocktailDBContext())
            {
                return context.Ingredients.ToList();
            }
        }
    }
}