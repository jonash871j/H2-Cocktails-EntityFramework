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
        static CocktailController coCon = new CocktailController();
        static IngredientController inCon = new IngredientController();
        //IngredientController ingredientController = new IngredientController();

        // * Package Manager Console
        // EntityFrameworkCore\Add-Migration "InitialCreate"
        // EntityFrameworkCore\Update-Database

        static void Main(string[] args)
        {
            Data.SetDefaultIngredients();
            Data.SetDefaultCocktails();
            //controller.CreateCocktail(new Cocktail { Name = "Dummy2", Glass = GlassType.Collins, Ingredients = new List<Ingredient>() { new LiquidIngredient { Name = "SomeLiquid2", MlAmount = 100 } } });


            //foreach (var c in controller.GetAllCocktails())
            //{
            //    Console.WriteLine(c.Name);
            //    Console.WriteLine(c.Glass);
            //}
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine(" 1. List with drinks");
            Console.WriteLine(" 2. Create Drink");
            Console.WriteLine(" 3. Delete Drink");
            Console.WriteLine(" 4. Search for Drink");
            Console.Write("\r\nSelect an option: ");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    DrinkList();
                    return true;
                case ConsoleKey.D2:
                    CreateDrink();
                    return true;
                case ConsoleKey.D3:
                    DeleteDrink();
                    return true;
                case ConsoleKey.D4:
                    SearchDrink();
                    return true;
                default:
                    return false;
            }
        }
        private static void DrinkList()
        {
            Console.Clear();
            Console.WriteLine("List with drinks:");

            foreach (Cocktail item in coCon.GetAll())
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.GlassType);

                Console.WriteLine("\r\nIngredients:");
                foreach(IngredientDescription ingredientDescription in item.IngredientDescription)
                {
                    Ingredient ingredient = inCon.Get(ingredientDescription.Ingredient);
                    Console.WriteLine(ingredient.Name);
                    Console.WriteLine(ingredient.IngredientType);
                }

                Console.WriteLine("\r\n");
            }
            ExitCurrentMenu();
        }

        private static void CreateDrink()
        {
            Console.Write("Name of drink: ");
            string name = Console.ReadLine();
            Console.WriteLine("\r\nGlass type:");
            Console.WriteLine(" 1. Old Fashioned");
            Console.WriteLine(" 2. Collins");
            Console.WriteLine(" 3. Martini");
            Console.WriteLine(" 4. Highball");
            Console.WriteLine(" 5. Poco Grande");
            Console.WriteLine(" 6. Flute");
            GlassType type;
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    type =  GlassType.OldFashioned;
                    break;
                case ConsoleKey.D2:
                    type = GlassType.Collins;
                    break;
                case ConsoleKey.D3:
                    type = GlassType.Martini;
                    break;
                case ConsoleKey.D4:
                    type = GlassType.Highball;
                    break;
                case ConsoleKey.D5:
                    type = GlassType.PocoGrande;
                    break;
                case ConsoleKey.D6:
                    type = GlassType.Flute;
                    break;
                default:
                    break;
            }

            foreach(var item in inCon.GetAll())
            {
                Console.WriteLine(item.Name);
            }
            //coCon.Create(new Cocktail(name, type, ));
            ExitCurrentMenu();
        }

        private static void DeleteDrink()
        {
            Console.Clear();
            Console.Write("Drink name to delete: ");
            string toDelete = Console.ReadLine();
            if (coCon.Get(toDelete) != null)
            {
                coCon.Delete(toDelete);
                Console.WriteLine("Removed drink: " + toDelete);
            }
            ExitCurrentMenu();
        }

        private static void SearchDrink()
        {
            Console.Clear();
            Console.Write("Search for drink name: ");
            var searchFor = coCon.GetBySearch(Console.ReadLine());
            Console.WriteLine("Drinks founded:");
            foreach (Cocktail item in searchFor)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.GlassType);

                Console.WriteLine("\r\nIngredients:");
                foreach (IngredientDescription ingredientDescription in item.IngredientDescription)
                {
                    Ingredient ingredient = inCon.Get(ingredientDescription.Ingredient);
                    Console.WriteLine(ingredient.Name);
                    Console.WriteLine(ingredient.IngredientType);
                }

                Console.WriteLine("\r\n");
            }
                ExitCurrentMenu();
        }

        private static void ExitCurrentMenu()
        {
            Console.WriteLine("\r\nPress any key to go back");
            Console.ReadKey();
        }

     
    }
}
