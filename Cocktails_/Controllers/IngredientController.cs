using Cocktails.Models;
using System;
using System.Collections.Generic;
using System.Text;
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

        public IEnumerable<Ingredient> Get(string key)
        {
            return GetAll().Where(c => c.Name == key);
        }

        public IEnumerable<Ingredient> GetAll()
        {
            return context.Ingredients;
        }
    }
}
