using Cocktails.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Cocktails.Models
{
    public class CocktailDBContext : DbContext
    {
        public DbSet<Cocktail> Cocktails { get; set; }
        public DbSet<IngredientDescription> IngredientDescriptions { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(local); Initial Catalog=CocktailDB; Integrated Security=SSPI");
            //if (!optionsBuilder.IsConfigured)
            //{
            //    IConfigurationRoot configuration = new ConfigurationBuilder()
            //       .SetBasePath(Directory.GetCurrentDirectory())
            //       .AddJsonFile("appsettings.json")
            //       .Build();
            //    var connectionString = configuration.GetConnectionString("DevConnection");
            //    optionsBuilder.UseSqlServer(connectionString);
            //}
        }
    }
}
