using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailsLib.Models.Contexts
{
    public class IngredientContext : DbContext
    {
        public IngredientContext(DbContextOptions<IngredientContext> options)
        {

        }

        public DbSet<Ingredient> Ingredients { get; set; }
    }
}
