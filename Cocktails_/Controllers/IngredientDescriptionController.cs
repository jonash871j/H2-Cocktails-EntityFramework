using Cocktails.Models;
using System.Collections.Generic;
using System.Linq;
using Cocktails.Models.Entities;

namespace Cocktails.Controllers
{
    public class IngredientDescriptionController : IController<IngredientDescription, string>
    {
        public void Create(IngredientDescription ingredientDescription)
        {
            using (CocktailDBContext context = new CocktailDBContext())
            {
                context.IngredientDescriptions.Add(ingredientDescription);
                context.SaveChanges();
            }
        }
        public void Delete(string key)
        {
            using (CocktailDBContext context = new CocktailDBContext())
            {
                IngredientDescription ingredientDescriptions = Get(key);
                context.IngredientDescriptions.Remove(ingredientDescriptions);
            }
        }
        public void DeleteAll()
        {
            using (CocktailDBContext context = new CocktailDBContext())
            {
                context.IngredientDescriptions.RemoveRange(context.IngredientDescriptions);
                context.SaveChanges();
            }
        }
        public IngredientDescription Get(string key)
        {
            return null;
        }
        public List<IngredientDescription> GetByCocktailName(string cocktailName)
        {
            using (CocktailDBContext context = new CocktailDBContext())
            {
                return context.IngredientDescriptions.Where(c => c.CocktailName == cocktailName).ToList();
            }
        }
        public List<IngredientDescription> GetAll()
        {
            using (CocktailDBContext context = new CocktailDBContext())
            {
                return context.IngredientDescriptions.ToList();
            }
        }
        public void Update(IngredientDescription @object)
        {
            using (CocktailDBContext context = new CocktailDBContext())
            {
                //cocktails = context.Cocktails.Where(c => c.Name.Contains(search)).ToList();
            }
        }
    }
}