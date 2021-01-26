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
        private CocktailDBContext context = new CocktailDBContext();

        public void Create(Cocktail cocktail)
        {
            context.Add(cocktail);
            context.SaveChanges();
        }

        public IEnumerable<Cocktail> Get(string key)
        {
            return GetAll().Where(c => c.Name == key);
        }

        public IEnumerable<Cocktail> GetAll()
        {
            return context.Cocktails;
        }
    }
}
