using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailsLib.Models.Contexts
{
    public class LiquidIngredientContext : DbContext
    {
        public LiquidIngredientContext(DbContextOptions<LiquidIngredientContext> options)
        {

        }

        public DbSet<LiquidIngredient> LiquidIngredients { get; set; }
    }
}
