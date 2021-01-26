using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailsLib.Models.Contexts
{
    public class SolidIngredientContext : DbContext
    {
        public SolidIngredientContext(DbContextOptions<SolidIngredientContext> options)
        {

        }

        public DbSet<SolidIngredient> SolidIngredients { get; set; }
    }
}
