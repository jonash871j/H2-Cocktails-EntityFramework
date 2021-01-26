using Cocktails.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Cocktails.Models.Entities;

namespace Cocktails.Controllers
{
    public class CocktailController : IController<Cocktail, string>
    {
        private IngredientDescriptionController inDeCon = new IngredientDescriptionController();

        public void Create(Cocktail cocktail)
        {
            using (CocktailDBContext context = new CocktailDBContext())
            {
                context.Cocktails.Add(cocktail);
                context.IngredientDescriptions.AddRange(cocktail.IngredientDescription);
                context.SaveChanges();
            }
        }
        public void Delete(string key)
        {
            using (CocktailDBContext context = new CocktailDBContext())
            {
                Cocktail cocktail = Get(key);
                context.IngredientDescriptions.RemoveRange(cocktail.IngredientDescription);
                context.Cocktails.Remove(cocktail);
                context.SaveChanges();
            }
        }

        public void DeleteAll()
        {
            using (CocktailDBContext context = new CocktailDBContext())
            {
                context.IngredientDescriptions.RemoveRange(context.IngredientDescriptions);
                context.Cocktails.RemoveRange(context.Cocktails);
                context.SaveChanges();
            }
        }
        public Cocktail Get(string key)
        {
            using (CocktailDBContext context = new CocktailDBContext())
            {
                IEnumerable<Cocktail> cocktails = context.Cocktails;
               Cocktail cocktail = context.Cocktails.Where(c => c.Name == key).FirstOrDefault();
                cocktail = GetIngredientDescription(cocktail);

                return cocktail;
            }
        }
        public List<Cocktail> GetAll()
        {
            List<Cocktail> cocktails;

            using (CocktailDBContext context = new CocktailDBContext())
            {
                cocktails = context.Cocktails.ToList();
            }
            for (int i = 0; i < cocktails.Count; i++)
            {
                cocktails[i] = GetIngredientDescription(cocktails[i]);
            }

            return cocktails;
        }
        /// <summary>
        /// Used to get cocktails by a contain search
        /// </summary>
        /// <param name="search">Name of cocktail</param>
        public List<Cocktail> GetBySearch(string search)
        {
            List<Cocktail> cocktails;

            using (CocktailDBContext context = new CocktailDBContext())
            {
                cocktails = context.Cocktails.Where(c => c.Name.Contains(search)).ToList();
            }
            for (int i = 0; i < cocktails.Count; i++)
            {
                cocktails[i] = GetIngredientDescription(cocktails[i]);
            }

            return cocktails;
        }

        private Cocktail GetIngredientDescription(Cocktail cocktail)
        {
            cocktail.IngredientDescription.AddRange(inDeCon.GetByCocktailName(cocktail.Name));
            return cocktail;
        }
    }
}
