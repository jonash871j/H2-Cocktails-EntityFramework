using Cocktails.Models;
using System.Collections.Generic;
using System.Linq;
using Cocktails.Models.Entities;
using System;

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
                Ingredient ingredients = Get(key);
                context.Ingredients.Remove(ingredients);
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
            throw new NotImplementedException();
        }
        public List<Ingredient> GetByCocktailName(string cocktailName)
        {
            using (CocktailDBContext context = new CocktailDBContext())
            {
                return context.Ingredients.Where(c => c.CocktailName == cocktailName).ToList();
            }
        }
        public List<Ingredient> GetAll()
        {
            using (CocktailDBContext context = new CocktailDBContext())
            {
                return context.Ingredients.ToList();
            }
        }
        public void Update(Ingredient @object)
        {
            throw new NotImplementedException();
        }
    }
}