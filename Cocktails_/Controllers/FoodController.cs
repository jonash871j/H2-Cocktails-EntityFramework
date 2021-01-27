using Cocktails.Models;
using System.Collections.Generic;
using System.Linq;
using Cocktails.Models.Entities;
using System;

namespace Cocktails.Controllers
{
    public class FoodController : IController<Food, string>
    {
        public void Create(Food food)
        {
            using (CocktailDBContext context = new CocktailDBContext())
            {
                context.Foods.Add(food);
                context.SaveChanges();
            }
        }
        public void Delete(string key)
        {
            using (CocktailDBContext context = new CocktailDBContext())
            {
                Food food = Get(key);
                context.Foods.Remove(food);
            }
        }
        public void DeleteAll()
        {
            using (CocktailDBContext context = new CocktailDBContext())
            {
                context.Foods.RemoveRange(context.Foods);
                context.SaveChanges();
            }
        }
        public Food Get(string key)
        {
            using (CocktailDBContext context = new CocktailDBContext())
            {
                return context.Foods.Where(c => c.Name == key).FirstOrDefault();
            }
        }
        public List<Food> GetAll()
        {
            using (CocktailDBContext context = new CocktailDBContext())
            {
                return context.Foods.ToList();
            }
        }
        public void Update(Food @object)
        {
            throw new NotImplementedException();
        }
    }
}