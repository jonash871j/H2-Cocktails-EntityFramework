using Cocktails.Models;
using System.Collections.Generic;
using System.Linq;
using Cocktails.Models.Entities;

namespace Cocktails.Controllers
{
    public class IngredientDescriptionController : IController<IngredientDescription, string>
    {
        private CocktailDBContext context = new CocktailDBContext();

        public void Create(IngredientDescription ingredientDescription)
        {
            context.IngredientDescriptions.Add(ingredientDescription);
            context.SaveChanges();
        }
        public void Delete(string key)
        {
            IngredientDescription ingredientDescriptions = Get(key);
            context.IngredientDescriptions.Remove(ingredientDescriptions);
        }
        public void DeleteAll()
        {
            context.IngredientDescriptions.RemoveRange(context.IngredientDescriptions);
            context.SaveChanges();
        }
        public IngredientDescription Get(string key)
        {
            return null;
        }
        public IEnumerable<IngredientDescription> GetByCocktailName(string cocktailName)
        {
            return context.IngredientDescriptions.Where(c => c.CocktailName == cocktailName);
        }
        public IEnumerable<IngredientDescription> GetAll()
        {
            return context.IngredientDescriptions;
        }
    }
}