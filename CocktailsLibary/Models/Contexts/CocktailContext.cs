using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailsLib.Models.Contexts
{
    public class CocktailContext : DbContext
    {
        public CocktailContext(DbContextOptions<CocktailContext> options)
        {

        }

        public DbSet<Cocktail> Cocktails { get; set; }
    }
}
