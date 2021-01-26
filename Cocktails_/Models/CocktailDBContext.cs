using Cocktails.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Cocktails.Models
{
    public class CocktailDBContext : DbContext
    {
        public DbSet<Cocktail> Cocktails { get; set; }
        public DbSet<IngredientDescription> IngredientDescriptions { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Sets up json configuration
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .SetBasePath(Directory.GetCurrentDirectory())
                .Build();

            // Reads connection string from config file
            string connectionString = configuration.GetConnectionString("DevConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}