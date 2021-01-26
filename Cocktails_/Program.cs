using Cocktails.Controllers;
using Cocktails.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cocktails
{
    class Program
    {
        static CocktailController cocktailController = new CocktailController();
        static IngredientController ingredientController = new IngredientController();
        //IngredientController ingredientController = new IngredientController();

        // * Package Manager Console
        // EntityFrameworkCore\Add-Migration "InitialCreate"
        // EntityFrameworkCore\Update-Database

        static void Main(string[] args)
        {
            AddIngredients();
            //controller.CreateCocktail(new Cocktail { Name = "Dummy2", Glass = GlassType.Collins, Ingredients = new List<Ingredient>() { new LiquidIngredient { Name = "SomeLiquid2", MlAmount = 100 } } });


            //foreach (var c in controller.GetAllCocktails())
            //{
            //    Console.WriteLine(c.Name);
            //    Console.WriteLine(c.Glass);
            //}
        }

        static void AddIngredients()
        {
            ingredientController.Create(new Ingredient("Lime Juice", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Triple Sec", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Tequila", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Dark Rum", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Orange Curacao", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Almond Syrup", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Fresh Cream", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Kahlua", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Vodka", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Cachaca", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Orange Juice", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Tomato Juice", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Bourbon", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Water", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Italian Sweet Vermouth", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Fresh Dry Vermouth", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Gin", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("White Rum", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Pink Grapefruit", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Cranberry Juice", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Soda", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Cherry Brandy", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Lemon Juice", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Sloe Gin", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Pineapple Juice", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Coconut Cream", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Cola", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Peach Puree", IngredientType.Liquid));
            ingredientController.Create(new Ingredient("Prosecco", IngredientType.Liquid));
        }
        static void AddCocktails()
        {

        }

        //static IHostBuilder CreateHostBuilder(string[] args)
        //{
        //    return Host.CreateDefaultBuilder(args)
        //        .ConfigureServices((hostContext, services) =>
        //        {
        //            services.AddDbContext<CocktailDBContext>();
        //        });
        //}

    }

}
