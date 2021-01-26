﻿using Cocktails.Models;
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
        private IngredientDescriptionController inDeCon = new IngredientDescriptionController();

        public void Create(Cocktail cocktail)
        {
            context.Cocktails.Add(cocktail);
            context.IngredientDescriptions.AddRange(cocktail.IngredientDescription);
            context.SaveChanges();
        }
        public void Delete(string key)
        {
            Cocktail cocktail = Get(key);
            context.Cocktails.Remove(cocktail);
            context.IngredientDescriptions.RemoveRange(cocktail.IngredientDescription);
        }
        public void DeleteAll()
        {
            context.Cocktails.RemoveRange(context.Cocktails);
            context.IngredientDescriptions.RemoveRange(context.IngredientDescriptions);
            context.SaveChanges();
        }
        public Cocktail Get(string key)
        {
            return context.Cocktails.Where(c => c.Name == key).FirstOrDefault();
        }
        public IEnumerable<Cocktail> GetAll()
        {
            IEnumerable<Cocktail> cocktails = context.Cocktails;

            foreach(Cocktail cocktail in cocktails)
            {
                cocktail.IngredientDescription.AddRange(inDeCon.GetByCocktailName(cocktail.Name));
            }
            return context.Cocktails;
        }
        /// <summary>
        /// Used to get cocktails by a contain search
        /// </summary>
        /// <param name="search">Name of cocktail</param>
        public IEnumerable<Cocktail> GetBySearch(string search)
        {
            return context.Cocktails.Where(c => c.Name.Contains(search));
        }
    }
}
